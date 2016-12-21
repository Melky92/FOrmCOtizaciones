using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOrmCOtizaciones
{
    class Item
    {
        public Item(string line)
        {
            string[] values = line.Split(';');
            int i = 0;
            Requerido = values[i++] == "x";
            Id = System.Convert.ToInt32(values[i++]);
            Descripcion = values[i++];
            Grupo = values[i++];
            Dificultad = System.Convert.ToInt32(values[i++]);
            Escogido = Requerido;i++;//(values[i++] == "1");
            Precio = System.Convert.ToDouble(values[i++]);
            Anual = System.Convert.ToDouble(values[i++]);

        }
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Escogido { get; set; }
        public double Precio { get; set; }
        public string Grupo { get; set; }
        public bool Requerido { get; set; }
        public int Dificultad { get; set; }
        public double Anual { get; set; }
    }
}
