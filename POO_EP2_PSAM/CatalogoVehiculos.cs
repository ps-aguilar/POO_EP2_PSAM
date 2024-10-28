using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EP2_PSAM
{
    public class CatalogoVehiculos
    {
        private List<Vehiculo> vehiculos = new List<Vehiculo>();

        public List<Vehiculo> Vehiculos
        {
            get { return vehiculos; }
            set { vehiculos = value; }
        }


        public void AgregarVehiculo(Vehiculo nuevoVehiculo)
        {
            vehiculos.Add(nuevoVehiculo);
        }

        // Método para buscar un vehículo por ID 
        public Vehiculo BuscarVehiculoPorId(int id)
        {
            for (int i = 0; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].Id == id)
                {
                    return vehiculos[i];
                }
            }
            return null; // Si no se encuentra el vehículo, devuelve null
        }

        // Método para eliminar un vehículo por ID
        public bool EliminarVehiculo(int id)
        {
            var vehiculo = BuscarVehiculoPorId(id);
            if (vehiculo != null)
            {
                vehiculos.Remove(vehiculo);
                return true;
            }
            return false; // Si no se encontró el vehículo, devuelve false
        }

        public bool ActualizarVehiculo(int id, string nuevoModelo, string nuevaMarca, int nuevoAnio, string nuevoDatoEspecifico)
        {
            var vehiculo = BuscarVehiculoPorId(id);
            if (vehiculo == null) return false;

            if (vehiculo is Auto auto)
            {
                auto.Modelo = nuevoModelo;
                auto.Marca = nuevaMarca;
                auto.Anio = nuevoAnio;
                auto.Combustible = nuevoDatoEspecifico; // Se usa para Auto
            }

            if (vehiculo is Moto moto)
            {
                moto.Modelo = nuevoModelo;
                moto.Marca = nuevaMarca;
                moto.Anio = nuevoAnio;
                moto.Motor = nuevoDatoEspecifico; // Se usa para Moto
            }

            if (vehiculo is Bici bici)
            {
                bici.Modelo = nuevoModelo;
                bici.Marca = nuevaMarca;
                bici.Anio = nuevoAnio;
                bici.Tipo = nuevoDatoEspecifico; // Se usa para Bici
            }

            return true; // Modificación exitosa
        }
    }
}
