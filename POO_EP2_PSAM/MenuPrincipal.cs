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
    public partial class MenuPrincipal : Form
    {
        private MenuAgregarVehiculo menuAgregarVehiculo;
        private ActualizarVehiculo actualizarVehiculo;
        private EliminarVehiculo eliminarVehiculo;
        private MostrarVehiculos mostrarVehiculos;

        private CatalogoVehiculos catalogo;

        public MenuPrincipal(CatalogoVehiculos catalogo)
        {
            InitializeComponent();

            this.catalogo = catalogo;
            
            menuAgregarVehiculo = new MenuAgregarVehiculo(this, catalogo);
            actualizarVehiculo = new ActualizarVehiculo(this, catalogo);
            eliminarVehiculo = new EliminarVehiculo(this, catalogo);
            mostrarVehiculos = new MostrarVehiculos(this, catalogo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuAgregarVehiculo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizarVehiculo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eliminarVehiculo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarVehiculos.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
