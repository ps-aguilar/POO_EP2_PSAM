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
    public partial class MenuAgregarVehiculo : Form
    {
        private AgregarAuto agregarAuto;
        private AgregarMoto agregarMoto;
        private AgregarBici agregarBici;
        private MenuPrincipal menuPrincipal;

        private CatalogoVehiculos catalogo; 

        public MenuAgregarVehiculo(MenuPrincipal menuPrincipal, CatalogoVehiculos catalogo)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            this.catalogo = catalogo; 
            agregarAuto = new AgregarAuto(menuPrincipal, catalogo);
            agregarMoto = new AgregarMoto(menuPrincipal, catalogo);
            agregarBici = new AgregarBici(menuPrincipal, catalogo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            agregarAuto.Show(this);
            this.Hide();
        }

        private void btnAgregarMoto_Click(object sender, EventArgs e)
        {
            agregarMoto.Show(this);
            this.Hide();
        }

        private void btnAgregarBici_Click(object sender, EventArgs e)
        {
            agregarBici.Show(this);
            this.Hide();
        }

        private void RegresarPrincipal_Click(object sender, EventArgs e)
        {
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
