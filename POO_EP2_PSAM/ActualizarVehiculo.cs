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
    public partial class ActualizarVehiculo : Form
    {
        private MenuPrincipal menuPrincipal;
        private CatalogoVehiculos catalogo;

        private int idOriginal;
        private int idNuevo;
        private string nuevoModelo;
        private string nuevaMarca;
        private int nuevoAnio;
        private string nuevoDatoEspecifico;

        public ActualizarVehiculo(MenuPrincipal menuPrincipal, CatalogoVehiculos catalogo)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            this.catalogo = catalogo;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Validar el ID original
            if (!int.TryParse(TbIDOriginal.Text, out idOriginal) || idOriginal <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                return;
            }

            // Buscar el vehículo
            var vehiculo = catalogo.BuscarVehiculoPorId(idOriginal);
            if (vehiculo == null)
            {
                MessageBox.Show("No se encontró el vehículo que desea modificar.");
                return;
            }

            // Actualizar datos del vehículo
            // Asignar los nuevos valores desde los TextBox
            nuevoModelo = TbModelo.Text;
            nuevaMarca = TbMarca.Text;

            // Validar el año
            if (!int.TryParse(TbAnio.Text, out nuevoAnio) || nuevoAnio <= 0)
            {
                MessageBox.Show("Por favor, ingrese un año válido.");
                return;
            }

            nuevoDatoEspecifico = TbTipo.Text;

            // Intentar actualizar el vehículo
            bool actualizado = catalogo.ActualizarVehiculo(idOriginal, nuevoModelo, nuevaMarca, nuevoAnio, nuevoDatoEspecifico);

            // Proporcionar feedback al usuario
            if (actualizado)
            {
                MessageBox.Show("Vehículo actualizado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al actualizar el vehículo.");
            }
        }

        private void TbIDOriginal_TextChanged(object sender, EventArgs e)
        {
            // Validar el ID original al cambiar el texto
            if (!int.TryParse(TbIDOriginal.Text, out idOriginal))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                idOriginal = 0; // Restablecer a un valor predeterminado
            }
        }

        private void TbIDNuevo_TextChanged(object sender, EventArgs e)
        {
            // Validar el ID nuevo al cambiar el texto
            if (!int.TryParse(TbIDNuevo.Text, out idNuevo))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                idNuevo = 0; // Restablecer a un valor predeterminado
            }
        }

        private void TbModelo_TextChanged(object sender, EventArgs e)
        {
            nuevoModelo = TbModelo.Text;
        }

        private void TbAnio_TextChanged(object sender, EventArgs e)
        {
            // Validar el año al cambiar el texto
            if (!int.TryParse(TbAnio.Text, out nuevoAnio))
            {
                MessageBox.Show("Por favor, ingrese un año válido.");
                nuevoAnio = 0; // Restablecer a un valor predeterminado
            }
        }

        private void TbMarca_TextChanged(object sender, EventArgs e)
        {
            nuevaMarca = TbMarca.Text;
        }

        private void TbTipo_TextChanged(object sender, EventArgs e)
        {
            nuevoDatoEspecifico = TbTipo.Text;
        }

        private void RegresarPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.Show();
        }
    }
}
