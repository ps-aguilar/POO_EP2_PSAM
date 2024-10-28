using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EP2_PSAM
{
    internal class Bici : Vehiculo
    {
        private string tipo; //montaña, carretera, electrica

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        // Constructor
        public Bici(int id, string modelo, string marca, int anio, string tipo)
            : base(id, modelo, marca, anio)
        {
            this.tipo = tipo;
        }
    }
}
