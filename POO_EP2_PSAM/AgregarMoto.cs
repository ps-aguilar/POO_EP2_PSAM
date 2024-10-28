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
    public partial class AgregarMoto : Form
    {
        private MenuPrincipal menuPrincipal;
        private CatalogoVehiculos catalogo;  // Instancia de CatalogoVehiculos para almacenar las motos

        // Variables para almacenar los valores ingresados en los TextBoxes
        private int tbIDMoto;
        private string modelo;
        private string marca;
        private int anio;
        private string motor;

        public AgregarMoto(MenuPrincipal menuPrincipal, CatalogoVehiculos catalogo)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            this.catalogo = catalogo;
        }

        // Métodos para capturar los cambios en los TextBoxes y guardarlos en variables
        private void TbIDMoto_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TbIDMoto.Text, out tbIDMoto) || tbIDMoto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                tbIDMoto = 0; // Restablecer a un valor predeterminado
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

        private void TbMotor_TextChanged(object sender, EventArgs e)
        {
            motor = TbMotor.Text.Trim();
        }

        // Evento del botón para crear la motocicleta
        private void CrearVehículo_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos están llenos
            if (tbIDMoto > 0 && !string.IsNullOrEmpty(modelo) && !string.IsNullOrEmpty(marca) && anio > 0 && !string.IsNullOrEmpty(motor))
            {
                // Verificar si el ID ya existe en el catálogo
                if (catalogo.BuscarVehiculoPorId(tbIDMoto) == null)
                {
                    // Crear una nueva Moto y agregarla al catálogo
                    Moto nuevaMoto = new Moto(tbIDMoto, modelo, marca, anio, motor);
                    catalogo.AgregarVehiculo(nuevaMoto);

                    MessageBox.Show($"Motocicleta {modelo} agregada al catálogo exitosamente.");

                    // Limpiar los campos después de agregar la moto
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
            TbIDMoto.Clear();
            TbModelo.Clear();
            TbMarca.Clear();
            TbAño.Clear();
            TbMotor.Clear();
            tbIDMoto = 0; // Restablecer el ID
            anio = 0; // Restablecer el año
        }

        // Evento para regresar al menú principal
        private void RegresarPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.Show();
        }

        private void label6_Click(object sender, EventArgs e) { }
        private void AgregarMoto_Load(object sender, EventArgs e) { }
    }
}
