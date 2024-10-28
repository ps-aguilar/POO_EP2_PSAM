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
    public partial class AgregarAuto : Form
    {
        private MenuPrincipal menuPrincipal;
        private CatalogoVehiculos catalogo;  // Instancia de CatalogoVehiculos para almacenar los autos

        // Variables para almacenar los valores ingresados en los TextBoxes
        private int tbIDAuto;
        private string modelo;
        private string marca;
        private int anio;
        private string combustible;

        public AgregarAuto(MenuPrincipal menuPrincipal, CatalogoVehiculos catalogo)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            this.catalogo = catalogo;
        }

        // Métodos para capturar los cambios en los TextBoxes y guardarlos en variables
        private void TbIDAuto_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TbIDAuto.Text, out tbIDAuto) || tbIDAuto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                tbIDAuto = 0; // Restablecer a un valor predeterminado
            }
        }

        private void TbModelo_TextChanged(object sender, EventArgs e)
        {
            modelo = TbModelo.Text.Trim();
        }

        private void TbMarca_TextChanged(object sender, EventArgs e)
        {
            marca = TbMarca.Text.Trim();
        }

        private void TbAño_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TbAño.Text, out anio) || anio <= 0)
            {
                MessageBox.Show("Por favor, ingrese un año válido.");
                anio = 0; // Restablecer a un valor predeterminado
            }
        }

        private void TbCombustible_TextChanged(object sender, EventArgs e)
        {
            combustible = TbCombustible.Text.Trim();
        }

        // Evento del botón para crear el vehículo
        private void CrearVehículo_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos están llenos
            if (tbIDAuto > 0 && !string.IsNullOrEmpty(modelo) && !string.IsNullOrEmpty(marca) && anio > 0 && !string.IsNullOrEmpty(combustible))
            {
                // Verificar si el ID ya existe en el catálogo
                if (catalogo.BuscarVehiculoPorId(tbIDAuto) == null)
                {
                    // Crear un nuevo Auto y agregarlo al catálogo
                    Auto nuevoAuto = new Auto(tbIDAuto, modelo, marca, anio, combustible);
                    catalogo.AgregarVehiculo(nuevoAuto);

                    MessageBox.Show($"Auto {modelo} agregado al catálogo exitosamente.");

                    // Limpiar los campos después de agregar el auto
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ya existe un vehículo con este ID. Por favor, use un ID único.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar el vehículo.");
            }
        }

        private void LimpiarCampos()
        {
            TbIDAuto.Clear();
            TbModelo.Clear();
            TbMarca.Clear();
            TbAño.Clear();
            TbCombustible.Clear();
            tbIDAuto = 0; // Restablecer el ID
            anio = 0; // Restablecer el año
        }

        // Evento para regresar al menú principal
        private void RegresarPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.Show();
        }

        // Eventos de labels (puedes eliminarlos si no son necesarios)
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void AgregarVehiculo_Load(object sender, EventArgs e) { }
    }
}
