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
        public frmPrincipal()
        {
            InitializeComponent();
            estiloInicial();
            abrirFormularioHijo(new frmInicio());
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
                

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmInicio());
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnAggProductos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmAggProductos());
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnAggReservas_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnAggCategorias_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnAggClientes_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
            abrirFormularioHijo(new frmAggClientes());
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
            abrirFormularioHijo(new frmProductos());
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
            abrirFormularioHijo(new frmCategorias());
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
            abrirFormularioHijo(new frmClientes());
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        #region Reportes
        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuReportes);
        }

        private void btnReporteProductos_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
            abrirFormularioHijo(new frmReporteProductos());
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnReporteReservas_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
            ocultarSubMenu();//Ocultamos Sub Menu siempre que se seleccione una opción
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            //Funcionalidades (llamar formulario correspondiente)
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
            abrirFormularioHijo(new frmCambiarClave());
            ocultarSubMenu();
        }

        private Form formularioActivo = null;
        private void abrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(formularioHijo);
            panelFormularioHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
    }
}
