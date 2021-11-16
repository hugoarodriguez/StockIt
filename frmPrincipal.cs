using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockIt_Entidades;
using StockIt_Logica;

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
            if (lklCorreo.Text.Trim() != "")
            {
                EUsuario eUsuario = new EUsuario();
                eUsuario.Correo = lklCorreo.Text.Trim();
                bool r = new LUsuarios().GetEstadoPasswordTemporal(eUsuario);
                if (r)
                {
                    //Abrimos el formulario para actualizar la contraseña
                    frmCambiarClave formularioHijo = new frmCambiarClave();
                    utils.setFormToPanelFormularioHijo(formularioHijo);
                    lblFormOpen.Text = formularioHijo.Name;

                    //Deshabilitar todos los botones excepto acerca de y cerrar sesión
                    btnInicio.Enabled = false;
                    btnCategorias.Enabled = false;
                    btnAggProveedores.Enabled = false;
                    btnAggProductos.Enabled = false;
                    btnAggClientes.Enabled = false;
                    btnAggReservas.Enabled = false;
                    btnProveedores.Enabled = false;
                    btnProductos.Enabled = false;
                    btnClientes.Enabled = false;
                    btnReservas.Enabled = false;
                    btnReportes.Enabled = false;
                }
                else
                {
                    //Abrimos el formulario principal
                    frmInicio formularioHijo = new frmInicio();
                    utils.setFormToPanelFormularioHijo(formularioHijo);
                    lblFormOpen.Text = formularioHijo.Name;

                    //Habilitar todos los botones excepto acerca de y cerrar sesión
                    btnInicio.Enabled = true;
                    btnCategorias.Enabled = true;
                    btnAggProveedores.Enabled = true;
                    btnAggProductos.Enabled = true;
                    btnAggClientes.Enabled = true;
                    btnAggReservas.Enabled = true;
                    btnProveedores.Enabled = true;
                    btnProductos.Enabled = true;
                    btnClientes.Enabled = true;
                    btnReservas.Enabled = true;
                    btnReportes.Enabled = true;
                }
            }
        }

        private void lklCorreo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCambiarClave formularioHijo = new frmCambiarClave();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmInicio formularioHijo = new frmInicio();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnAdmCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias formularioHijo = new frmCategorias();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnAggProveedores_Click(object sender, EventArgs e)
        {
            frmAggProveedores formularioHijo = new frmAggProveedores();
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

        private void btnAggClientes_Click(object sender, EventArgs e)
        {
            frmAggClientes formularioHijo = new frmAggClientes();
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

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores formularioHijo = new frmProveedores();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos formularioHijo = new frmProductos();
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

        private void btnReservas_Click(object sender, EventArgs e)
        {
            frmReservas formularioHijo = new frmReservas();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        #region Reportes
        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuReportes);
        }

        private void btnReporteCompraProductos_Click(object sender, EventArgs e)
        {
            frmReporteCompraProductos formularioHijo = new frmReporteCompraProductos();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
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

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            frmReporteVentas formularioHijo = new frmReporteVentas();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            frmReporteVentasEsp formularioHijo = new frmReporteVentasEsp();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }
        #endregion

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercaDe formularioHijo = new frmAcercaDe();
            utils.setFormToPanelFormularioHijo(formularioHijo);
            lblFormOpen.Text = formularioHijo.Name;
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
            this.Close();
        }
    }
}
