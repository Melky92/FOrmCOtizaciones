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
                    NewRow.Cells[2].Value = it.Precio.ToString();
                    NewRow.Cells[3].Value = it.Escogido;
                }
            }
        }
        private void SumarTodo()
        {
            double t = 0;
            foreach(DataGridViewRow r in dataGridViewDatos.Rows)
            {
                if((bool)r.Cells[3].Value == true)
                t += System.Convert.ToDouble(r.Cells[2].Value);
            }
            labelTotal.Text = t.ToString();
        }

        private void dataGridViewDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                this.dataGridViewDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                SumarTodo();
            }
        }
        
    }
}
