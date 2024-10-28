using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_EP2_PSAM
{
    public partial class MostrarVehiculos : Form
    {
        private MenuPrincipal menuPrincipal;
        private CatalogoVehiculos catalogo;

        public MostrarVehiculos(MenuPrincipal menuPrincipal, CatalogoVehiculos catalogo)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            this.catalogo = catalogo;
        }

        private void MostrarVehiculos_Load(object sender, EventArgs e)
        {
            CargarVehiculos(); // Llama a cargar vehículos solo al cargar el formulario
        }

        private void CargarVehiculos()
        {
            var vehiculos = catalogo.Vehiculos; // Accede a la lista de vehículos correctamente
            dataGridView1.Rows.Clear(); // Limpiar filas antes de cargar nuevos datos

            if (vehiculos.Count == 0)
            {
                MessageBox.Show("No hay vehículos disponibles en el catálogo.");
                return; // Salir del método si no hay vehículos
            }

            // Cargar los vehículos en el DataGridView
            foreach (var vehiculo in vehiculos)
            {
                dataGridView1.Rows.Add(vehiculo.Id, vehiculo.Marca, vehiculo.Modelo, vehiculo.Anio,
                    vehiculo is Auto auto ? auto.Combustible :
                    vehiculo is Moto moto ? moto.Motor :
                    vehiculo is Bici bici ? bici.Tipo : ""); // Mostrar tipo específico
            }
        }

        private void RegresarPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.Show();
        }
    }
}
