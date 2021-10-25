using StockIt.CustomControls;
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
    public partial class frmCategorias : Form
    {
        Utils utils = new Utils();
        string nombreActualCategoria;

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            btnCancelar.Hide();//Ocultamos el btnCancelar
        }

        private void cargarCategorias()
        {
            if (flpListadoCategorias.Controls.Count > 0)
            {
                flpListadoCategorias.Controls.Clear();
            }

            CategoriaCard[] categorias = new CategoriaCard[10];
            for (int i = 0; i < categorias.Length; i++)
            {
                categorias[i] = new CategoriaCard();
                categorias[i].Name = "CategoriaCard" + i.ToString();//Colocar el id de la BD como nombre de la Card
                categorias[i].Categ = "Categoría" + " " + i.ToString();

                //Creación de btnEditar
                categorias[i].BtnEditarProp = new Button();
                categorias[i].ButtonClickEditar += new EventHandler(btnEditar_ButtonClick);

                void btnEditar_ButtonClick(object sender, EventArgs e)
                {
                    //Manejar evento
                    CategoriaCard categoriaCardItem = ((CategoriaCard)sender);
                    this.txtCategoria.Text = categoriaCardItem.Name + "Editar";

                    //Posteriormente se puede hacer consultando el nombre a la BD con el ID de la categoría
                    nombreActualCategoria = this.txtCategoria.Text = categoriaCardItem.Name;//Obtenemos el nombre actual de la categoría
                    btnAgregar.Text = "Editar";//Cambiamos el texto del btnAgregar
                    btnCancelar.Show();//Mostramos el btnCancelar, que permitirá cancelar la edición de la categoría
                    flpListadoCategorias.Hide();//Ocultamos el FlowLayoutPanel de Categorías
                }

                //Creación de btnEliminar
                categorias[i].BtnEliminarProp = new Button();
                categorias[i].ButtonClickEliminar += new EventHandler(btnEliminar_ButtonClick);

                void btnEliminar_ButtonClick(object sender, EventArgs e)
                {
                    //Manejar evento
                    CategoriaCard categoriaCardItem = ((CategoriaCard)sender);
                    this.txtCategoria.Text = categoriaCardItem.Name + "Eliminar";

                    /*
                     * Validar si la categoría seleccionada para eliminar tiene productos (con stock o reserva activa)
                     * relacionados en la BD.
                     * Si NO tienen ninguno relacionado SI se debe permitir eliminar
                     */
                    categoriaCardItem.Dispose();
                }

                //Agregamos el ProductoCard al FlowLAyoutPanel
                flpListadoCategorias.Controls.Add(categorias[i]);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (btnAgregar.Text == "Agregar")
            {
                if (txtCategoria.Text.Trim() != "")
                {
                    string nuevoNombreCategoria = txtCategoria.Text.Trim();

                    //Agregar categoría
                    utils.messageBoxOperacionExitosa("Se agregó la categoría \""+ nuevoNombreCategoria +"\"");

                    //Cargamos las categorías nuevamente
                    cargarCategorias();

                    //Limpiamos los controles
                    limpiarControles();
                }
                else
                {
                    utils.messageBoxCampoRequerido("Debes ingresar el nombre de la nueva categoría.");
                    txtCategoria.Focus();
                }
            }
            else
            {
                if (txtCategoria.Text.Trim() != "")
                {
                    string nuevoNombreCategoria = txtCategoria.Text.Trim();

                    //Modificar categoría
                    utils.messageBoxOperacionExitosa("La categoría \"" + nombreActualCategoria + "\"" +
                        " paso a llamarse \""+ nuevoNombreCategoria + "\"");

                    //Cargamos las categorías nuevamente
                    cargarCategorias();

                    //Limpiamos los controles
                    limpiarControles();
                }
                else
                {
                    utils.messageBoxCampoRequerido("Debes ingresar el nuevo nombre de la categoría \""+ nombreActualCategoria +"\".");
                    txtCategoria.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        //Permite reestablecer el estado inicial de los controles antes de presionar la opción "Editar" en la Categoría
        private void limpiarControles()
        {
            if (btnAgregar.Text == "Agregar")
            {
                txtCategoria.Text = null;
                txtCategoria.Focus();
            }
            else
            {
                txtCategoria.Text = null;
                txtCategoria.Focus();
                btnAgregar.Text = "Agregar";//Cambiamos el texto del btnAgregar
                btnCancelar.Hide();//Ocultamos el btnCancelar
                flpListadoCategorias.Show();//Mostramos el FlowLayoutPanel de Categorías
            }
        }
    }

    
}
