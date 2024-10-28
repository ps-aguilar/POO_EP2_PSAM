using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EP2_PSAM
{
    internal class Moto : Vehiculo
    {

        private string motor; // 2 o 4 cilindros

        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }

        // Constructor
        public Moto(int id, string modelo, string marca, int anio, string motor)
            : base(id, modelo, marca, anio)
        {
            this.motor = motor;
        }
    }
}
