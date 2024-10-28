using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EP2_PSAM
{
    public abstract class Vehiculo
    {
        private int id;
        private string modelo;
        private string marca;
        private int anio;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }


        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        protected Vehiculo(int id, string modelo, string marca, int anio)
        {
            Id = id;
            Modelo = modelo;
            Marca = marca;
            Anio = anio;
        }
    }
}
