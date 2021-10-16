using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt
{
    public partial class frmPrincipal : Form
    {
        Utils utils = new Utils();
        public frmPrincipal()
        {
            InitializeComponent();
            estiloInicial();
        }

        private void estiloInicial()
        {
            panelSubMenuReportes.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if(panelSubMenuReportes.Visible == true)
            {
                panelSubMenuReportes.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            } 
            else
            {
                subMenu.Visible = false;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Abrimos el formulario principal
            frmInicio formularioHijo = new frmInicio();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmInicio formularioHijo = new frmInicio();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnAggProductos_Click(object sender, EventArgs e)
        {
            frmAggProductos formularioHijo = new frmAggProductos();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnAggReservas_Click(object sender, EventArgs e)
        {
            frmAggReserva formularioHijo = new frmAggReserva();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnAggCategorias_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnAggClientes_Click(object sender, EventArgs e)
        {
            frmAggClientes formularioHijo = new frmAggClientes();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos formularioHijo = new frmProductos();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias formularioHijo = new frmCategorias();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes formularioHijo = new frmClientes();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        #region Reportes
        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuReportes);
        }

        private void btnReporteProductos_Click(object sender, EventArgs e)
        {
            frmReporteProductos formularioHijo = new frmReporteProductos();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnReporteReservas_Click(object sender, EventArgs e)
        {
            frmReporteReservas formularioHijo = new frmReporteReservas();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            frmReporteClientes formularioHijo = new frmReporteClientes();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            frmReporteVentas formularioHijo = new frmReporteVentas();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }
        #endregion

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
            this.Close();
        }

        private void lklCorreo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCambiarClave formularioHijo = new frmCambiarClave();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();
        }
    }
}
