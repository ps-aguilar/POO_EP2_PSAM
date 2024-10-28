using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POO_EP2_PSAM
{
    internal class Auto : Vehiculo
    {
        private string combustible; //diesel, gasolina, electrico

        public string Combustible
        {
            get { return combustible; }
            set { combustible = value; }
        }

        // Constructor
        public Auto(int id, string modelo, string marca, int anio, string combustible)
            : base(id, modelo, marca, anio)
        {
            this.combustible = combustible;
        }
    }
}
