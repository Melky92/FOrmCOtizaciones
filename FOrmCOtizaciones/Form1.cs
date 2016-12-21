using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOrmCOtizaciones
{
    public partial class Form1 : Form
    {
        private List<Item> mis_items;
        public Form1()
        {
            InitializeComponent();
            mis_items = new List<Item>();
            InicializarDatos("Datos.csv");
            CargarGrilla();
            SumarTodo();
            dataGridViewDatos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void InicializarDatos(string path)
        {
            string[] allLines = File.ReadAllLines(path);
            foreach(string line in allLines)
            {
                mis_items.Add(new Item(line));
            }
        }
        private void CargarGrilla()
        {
            foreach(Item it in mis_items)
            {
                int x = dataGridViewDatos.Rows.Add();
                using (DataGridViewRow NewRow = dataGridViewDatos.Rows[x])
                {
                    NewRow.Cells[0].Value = it.Id.ToString();
                    NewRow.Cells[1].Value = it.Descripcion;
                    NewRow.Cells[2].Value = it.Precio.ToString("F2");
                    NewRow.Cells[3].Value = it.Escogido;
                    if(it.Requerido)
                    {
                        DataGridViewCell cell = NewRow.Cells[3];
                        DataGridViewCheckBoxCell chkCell = cell as DataGridViewCheckBoxCell;
                        chkCell.Value = true;
                        chkCell.FlatStyle = FlatStyle.Flat;
                        chkCell.Style.ForeColor = Color.DarkGray;
                        cell.ReadOnly = true;
                    }
                    //NewRow.Cells[3].ReadOnly = it.Requerido;
                    //dataGridViewDatos.Update();
                }
            }
        }
        private void SumarTodo()
        {
            double t = 0;
            double a = 0;
            for(int i = 0;i<mis_items.Count;i++)
            {
                if((bool)dataGridViewDatos.Rows[i].Cells[3].Value == true)
                {
                    t += mis_items[i].Precio;
                    a += mis_items[i].Anual;
                }
            }
            labelTotal.Text = t.ToString("F2");
            labelAnual.Text = a.ToString("F2");
        }

        private void dataGridViewDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.ColumnIndex == 3)
            {
                this.dataGridViewDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                SumarTodo();
            }*/
        }

        private void Mover(DataGridViewCell c1, DataGridViewCell c2)
        {
            DataGridViewCheckBoxCell cb1 = c1 as DataGridViewCheckBoxCell;
            DataGridViewCheckBoxCell cb2 = c2 as DataGridViewCheckBoxCell;
            cb1.Value = cb2.Value;
            cb1.FlatStyle = cb2.FlatStyle;
            cb1.Style.ForeColor = cb2.Style.ForeColor;
            c1.ReadOnly = c2.ReadOnly;
        }
        private void Intercambiar(int i,int j)
        {
            DataGridViewCell cell1 = dataGridViewDatos[3,i];
            DataGridViewCell cell2 = dataGridViewDatos[3,j];
            int x = dataGridViewDatos.Rows.Add();
            DataGridViewCell aux = dataGridViewDatos[3, x];

            Mover(aux, cell1);
            Mover(cell1, cell2);
            Mover(cell2, aux);
            dataGridViewDatos.Rows.RemoveAt(x);
        }

        private bool SetTrue(int x)
        {
            string gr = mis_items[x].Grupo;
            bool changed = false;
            for (int i = 0; i < mis_items.Count; i++)
            {
                if (mis_items[i].Grupo == gr && i != x)
                {
                    if ((bool)dataGridViewDatos[3, i].Value)
                    {
                        Intercambiar(i, x);
                        changed = true;
                    }
                }
            }
            return changed;
        }

        private void dataGridViewDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3 && !dataGridViewDatos[e.ColumnIndex,e.RowIndex].ReadOnly)
            {
                bool isChecked = (bool)dataGridViewDatos[e.ColumnIndex, e.RowIndex].EditedFormattedValue;
                bool changed = false;
                if(mis_items[e.RowIndex].Grupo != "" && !isChecked)
                {
                    changed = SetTrue(e.RowIndex);
                }
                if(!changed)
                {
                    dataGridViewDatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !isChecked;
                }
                dataGridViewDatos.EndEdit();
                SumarTodo();
            }
        }

        private void buttonMinimo_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<mis_items.Count;i++)
            {
                if (mis_items[i].Grupo.Length == 0)
                {
                    dataGridViewDatos[3, i].Value = mis_items[i].Requerido;
                }
                else
                {
                    int mayor = (mis_items[i].Precio > mis_items[i + 1].Precio ? i : i + 1);
                    int menor = (mis_items[i].Precio < mis_items[i + 1].Precio ? i : i + 1);
                    if (mis_items[i].Grupo.Length == 2)
                    {
                        dataGridViewDatos[3, mayor].Value = false;
                        dataGridViewDatos[3, menor].Value = false;
                    }
                    else
                    {
                        SetTrue(menor);
                    }

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
                        dataGridViewDatos[3,i].Value = true;
                }
                else
                {
                    int mayor = (mis_items[i].Precio > mis_items[i+1].Precio ? i : i+1);
                    int menor = (mis_items[i].Precio < mis_items[i+1].Precio ? i : i+1);
                    if(mis_items[i].Grupo.Length == 2)
                    {
                        dataGridViewDatos[3, menor].Value = false;
                        dataGridViewDatos[3, mayor].Value = true;
                    }
                    else
                    {
                        SetTrue(mayor);
                    }

                    i++;
                }
            }
            SumarTodo();
        }
    }
}
