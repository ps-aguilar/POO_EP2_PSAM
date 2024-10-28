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
    public partial class AgregarBici : Form
    {
        private MenuPrincipal menuPrincipal;
        private CatalogoVehiculos catalogo; // Instancia de CatalogoVehiculos para almacenar las bicicletas

        // Variables para almacenar los valores ingresados en los TextBoxes
        private int tbIDBicicleta;
        private string modelo;
        private string marca;
        private int anio;
        private string tipo; // Nuevo campo para el tipo de bicicleta

        public AgregarBici(MenuPrincipal menuPrincipal, CatalogoVehiculos catalogo)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            this.catalogo = catalogo;
        }

        // Métodos para capturar los cambios en los TextBoxes y guardarlos en variables
        private void TbIDBicicleta_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TbIDBicicleta.Text, out tbIDBicicleta) || tbIDBicicleta <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                tbIDBicicleta = 0; // Restablecer a un valor predeterminado
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

        private void TbTipo_TextChanged(object sender, EventArgs e) // Evento para el tipo de bicicleta
        {
            tipo = TbTipo.Text.Trim(); // Capturar el tipo de bicicleta
        }

        // Evento del botón para crear la bicicleta
        private void CrearVehículo_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos están llenos
            if (tbIDBicicleta > 0 && !string.IsNullOrEmpty(modelo) && !string.IsNullOrEmpty(marca) &&
                anio > 0 && !string.IsNullOrEmpty(tipo))
            {
                // Verificar si el ID ya existe en el catálogo
                if (catalogo.BuscarVehiculoPorId(tbIDBicicleta) == null)
                {
                    // Crear una nueva Bicicleta y agregarla al catálogo
                    Bici nuevaBici = new Bici(tbIDBicicleta, modelo, marca, anio, tipo); // Asegúrate de que el constructor de Bicicleta acepte el tipo
                    catalogo.AgregarVehiculo(nuevaBici);

                    MessageBox.Show($"Bicicleta {modelo} agregada al catálogo exitosamente.");

                    // Limpiar los campos después de agregar la bicicleta
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ya existe un vehículo con este ID. Por favor, use un ID único.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar la bicicleta.");
            }
        }

        private void LimpiarCampos()
        {
            TbIDBicicleta.Clear();
            TbModelo.Clear();
            TbMarca.Clear();
            TbAño.Clear();
            TbTipo.Clear(); // Limpiar el campo de tipo
            tbIDBicicleta = 0; // Restablecer el ID
            anio = 0; // Restablecer el año
        }

        // Evento para regresar al menú principal
        private void RegresarPrincipal_Click(object sender, EventArgs e)
        {
            menuPrincipal.Show();
            this.Hide();
        }

        // Eventos de labels (puedes eliminarlos si no son necesarios)
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void AgregarBici_Load(object sender, EventArgs e) { }
    }
}
