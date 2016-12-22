using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOrmCOtizaciones
{
    public partial class Form1 : Form
    {
        private List<Item> mis_items;
        /*public string GetCSV(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();

            return results;
        }*/
        private int cotizaciones;
        public Form1()
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es");
            InitializeComponent();
            //string fileList = GetCSV("https://drive.google.com/open?id=0B6g7Rl6GNqj3MU1ReXBkOXAyX0k&output=csv");

            mis_items = new List<Item>();
            InicializarDatos("Datos.csv");
            CargarGrilla();
            SumarTodo();
            dataGridViewDatos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void InicializarDatos(string path)
        {
            string[] allLines = File.ReadAllLines(path, System.Text.Encoding.Default);
            foreach (string line in allLines)
            {
                mis_items.Add(new Item(line));
            }
        }
        private void CargarGrilla()
        {
            for (int i = 0; i < mis_items.Count; i++)
            {
                Item it = mis_items[i];
                int x = dataGridViewDatos.Rows.Add();
                using (DataGridViewRow NewRow = dataGridViewDatos.Rows[x])
                {
                    NewRow.Cells[0].Value = it.Id;
                    NewRow.Cells[1].Value = it.Descripcion;
                    NewRow.Cells[2].Value = it.Precio.ToString("F2");
                    NewRow.Cells[3].Value = it.Escogido;

                    if (it.Escogido)
                    {
                        Tickear(i);
                    }
                }
            }
        }
        private void SumarTodo()
        {
            double t = 0;
            double a = 0;
            for (int i = 0; i < mis_items.Count; i++)
            {
                if ((bool)dataGridViewDatos.Rows[i].Cells[3].Value == true)
                {
                    t += mis_items[i].Precio;
                    a += mis_items[i].Anual;
                }
            }
            labelTotal.Text = t.ToString("C2", CultureInfo.GetCultureInfo("en"));
            labelReducido.Text = (t*0.60).ToString("C2", CultureInfo.GetCultureInfo("en"));

            labelAnual.Text = a.ToString("C2", CultureInfo.GetCultureInfo("en"));
        }

        private void Despintar(DataGridViewCell Cell)
        {
            DataGridViewCheckBoxCell chkCell = Cell as DataGridViewCheckBoxCell;
            chkCell.Value = true;
            chkCell.FlatStyle = FlatStyle.Flat;
            chkCell.Style.ForeColor = Color.DarkGray;
            Cell.ReadOnly = true;
        }
        private void Pintar(DataGridViewCell Cell)
        {
            DataGridViewCheckBoxCell chkCell = Cell as DataGridViewCheckBoxCell;
            chkCell.Value = false;
            chkCell.FlatStyle = FlatStyle.Standard;
            chkCell.Style.ForeColor = Color.White;
            Cell.ReadOnly = false;
        }
        private void Tickear(int x)
        {
            mis_items[x].Escogido = true;
            dataGridViewDatos[0, x].Style.Font = new Font(dataGridViewDatos.DefaultCellStyle.Font, FontStyle.Bold);
            dataGridViewDatos.Rows[x].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewDatos[3, x].Value = true;
            if (mis_items[x].Requerido)
            {
                Despintar(dataGridViewDatos[3, x]);
            }
        }
        private void DesTickear(int x)
        {
            mis_items[x].Escogido = false;
            dataGridViewDatos[0, x].Style.Font = new Font(dataGridViewDatos.DefaultCellStyle.Font, FontStyle.Regular);
            dataGridViewDatos.Rows[x].DefaultCellStyle.BackColor = Color.White;
            dataGridViewDatos[3, x].Value = false;
            if (mis_items[x].Requerido)
            {
                Pintar(dataGridViewDatos[3, x]);
            }
        }

        private void SetTrue(int x)
        {
            Tickear(x);
            if (mis_items[x].Grupo.Length > 0)
            {
                for (int i = 0; i < mis_items.Count; i++)
                {
                    if (mis_items[i].Grupo == mis_items[x].Grupo && i != x)
                    {
                        DesTickear(i);
                    }
                }
            }
        }

        private void SetFalse(int x)
        {
            if (!mis_items[x].Requerido)
            {
                DesTickear(x);
            }
        }
        private void dataGridViewDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && !dataGridViewDatos[e.ColumnIndex, e.RowIndex].ReadOnly)
            {
                bool isChecked = (bool)dataGridViewDatos[e.ColumnIndex, e.RowIndex].EditedFormattedValue;
                if (!isChecked)
                {
                    SetTrue(e.RowIndex);
                }
                else
                {
                    SetFalse(e.RowIndex);
                }
                dataGridViewDatos.EndEdit();
                SumarTodo();
            }
        }

        private void buttonMinimo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mis_items.Count; i++)
            {
                if (mis_items[i].Grupo.Length == 0 || !mis_items[i].Requerido)
                {
                    if (mis_items[i].Requerido)
                    {
                        SetTrue(i);
                    }
                    else
                    {
                        SetFalse(i);
                    }
                }
                else
                {
                    int mayor = (mis_items[i].Precio > mis_items[i + 1].Precio ? i : i + 1);
                    int menor = (mis_items[i].Precio < mis_items[i + 1].Precio ? i : i + 1);
                    SetTrue(menor);
                    SetFalse(mayor);

                    i++;
                }
            }
            SumarTodo();
        }

        private void buttonMaximo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mis_items.Count; i++)
            {
                if (mis_items[i].Grupo.Length == 0)
                {
                    SetTrue(i);
                }
                else
                {
                    int mayor = (mis_items[i].Precio > mis_items[i + 1].Precio ? i : i + 1);
                    int menor = (mis_items[i].Precio < mis_items[i + 1].Precio ? i : i + 1);
                    SetTrue(mayor);
                    SetFalse(menor);
                    i++;
                }
            }
            SumarTodo();
        }

        private void buttonRecomendado_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mis_items.Count; i++)
            {
                //if (mis_items[i].Grupo.Length == 0 || !mis_items[i].Recomendado)
                {
                    if (mis_items[i].Recomendado)
                    {
                        SetTrue(i);
                    }
                    else
                    {
                        SetFalse(i);
                    }
                }
            }
            SumarTodo();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            List<string> guardados = new List<string>();
            foreach(Item it in mis_items)
            {
                if (it.Escogido)
                {
                    guardados.Add(it.Id + ";" + it.Descripcion + ";" + it.Precio.ToString());
                }
            }
            System.IO.File.WriteAllLines(@"Cotizacion.csv", guardados);
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            string path = @"Cotizacion.csv";
            string[] allLines = File.ReadAllLines(path, System.Text.Encoding.Default);
            buttonMinimo_Click(sender, e);
            foreach (string line in allLines)
            {
                SetTrue(mis_items.FindIndex(
                delegate (Item it)
                {
                    return it.Id.Equals(line.Split(';')[0], StringComparison.Ordinal);
                }));

                //SetTrue(mis_items.IndexOf(line.Split(';')[0]));
            }
            SumarTodo();
        }
    }
}
