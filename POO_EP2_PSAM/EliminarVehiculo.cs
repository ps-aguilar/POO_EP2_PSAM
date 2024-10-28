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
    public partial class EliminarVehiculo : Form
    {
        private MenuPrincipal menuPrincipal;
        private CatalogoVehiculos catalogo; // Instancia de CatalogoVehiculos

        private int tbIDVehiculo;

        public EliminarVehiculo(MenuPrincipal menuPrincipal, CatalogoVehiculos catalogo)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            this.catalogo = catalogo;
        }

        private void EliminarVehiculo_Load(object sender, EventArgs e) { }

        // Evento para validar el ID del vehículo
        private void TbIDVehiculo_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TbIDVehiculo.Text, out tbIDVehiculo) || tbIDVehiculo <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                tbIDVehiculo = 0; // Restablecer a un valor predeterminado
            }
        }

        // Evento del botón para eliminar el vehículo
        private void BtnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            if (tbIDVehiculo <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID válido para eliminar el vehículo.");
                return; // Salir del método si la validación falla
            }

            // Intentar eliminar el vehículo
            bool eliminado = catalogo.EliminarVehiculo(tbIDVehiculo);

            // Proporcionar feedback al usuario basado en el resultado
            if (eliminado)
            {
                MessageBox.Show("Vehículo eliminado exitosamente.");
                LimpiarCampos(); // Limpiar el campo después de la eliminación
            }
            else
            {
                MessageBox.Show("No se encontró el vehículo con ese ID.");
            }
        }

        private void LimpiarCampos()
        {
            TbIDVehiculo.Clear();
            tbIDVehiculo = 0; // Restablecer el ID
        }

        // Evento para regresar al menú principal
        private void RegresarPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.Show();
        }
    }
}
