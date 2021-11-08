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
using StockIt_Entidades;
using StockIt_Logica;

namespace StockIt
{
    public partial class frmCategorias : Form
    {
        Utils utils = new Utils();
        string nombreActualCategoria;
        int idCategoria;

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

            List<ECategoria> eCategoriasList = new LCategorias().SeleccionarCategoriasActivasByIdUsuario(utils.getIdUsuario());

            if (eCategoriasList.Count > 0)
            {
                CategoriaCard[] categorias = new CategoriaCard[eCategoriasList.Count];
                for (int i = 0; i < categorias.Length; i++)
                {
                    categorias[i] = new CategoriaCard();
                    categorias[i].Name = eCategoriasList[i].IdCategoria.ToString();
                    categorias[i].Categ = eCategoriasList[i].Categoria;

                    //Creación de btnEditar
                    categorias[i].BtnEditarProp = new Button();
                    categorias[i].ButtonClickEditar += new EventHandler(btnEditar_ButtonClick);

                    void btnEditar_ButtonClick(object sender, EventArgs e)
                    {
                        //Manejar evento
                        CategoriaCard categoriaCardItem = ((CategoriaCard)sender);
                        this.txtCategoria.Text = categoriaCardItem.Name + "Editar";

                        //Posteriormente se puede hacer consultando el nombre a la BD con el ID de la categoría
                        idCategoria = int.Parse(categoriaCardItem.Name);
                        nombreActualCategoria = this.txtCategoria.Text = categoriaCardItem.Categ.ToUpper();//Obtenemos el nombre actual de la categoría
                        btnAgregar.Text = "Editar";//Cambiamos el texto del btnAgregar
                        txtCategoria.Focus();
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
                        DialogResult dialogResult = utils.getMessageBoxAlerta("¿Estás seguro que deseas eliminar el cliente" +
                            " \"" + categoriaCardItem.Categ + "\"?");
                        if (dialogResult == DialogResult.Yes)
                        {
                            ECategoria eCategoria = new ECategoria();
                            eCategoria.IdCategoria = int.Parse(categoriaCardItem.Name);
                            int r = new LCategorias().EliminarCategoria(eCategoria);

                            if (r > 0)
                            {
                                categoriaCardItem.Dispose();
                                utils.messageBoxOperacionExitosa("Se eliminó la categoría \"" + categoriaCardItem.Categ + "\"");
                            }
                            else if (r == -1)
                            {
                                utils.messageBoxAlerta("No se puede eliminar esta categoría, " +
                                    "\nse encuentra relacionada con productos activos.");
                            }
                            else
                            {
                                utils.messageBoxOperacionSinExito("Hubo un error. Intente más tarde.");
                            }
                        }
                    }

                    //Agregamos el CategoriaCard al FlowLAyoutPanel
                    flpListadoCategorias.Controls.Add(categorias[i]);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (btnAgregar.Text == "Agregar")
            {
                if (txtCategoria.Text.Trim() != "")
                {
                    string nombreCategoria = txtCategoria.Text.Trim().ToUpper();

                    ECategoria eCategoria = new ECategoria();
                    eCategoria.Categoria = nombreCategoria;

                    int r = new LCategorias().InsertarCategoria(utils.getIdUsuario(), eCategoria);

                    if(r > 0)
                    {
                        utils.messageBoxOperacionExitosa("Se agregó la categoría \"" + nombreCategoria + "\"");

                        //Cargamos las categorías nuevamente
                        cargarCategorias();

                        //Limpiamos los controles
                        limpiarControles();
                    }
                    else if (r == -1)
                    {
                        utils.messageBoxAlerta("No se puede agregar la categoría \"" + nombreCategoria + "\"." +
                            "\nHay una existente con idéntico nombre.");
                    }
                    else
                    {
                        utils.messageBoxOperacionSinExito("Hubo un error. Intente más tarde.");
                    }
                    txtCategoria.Focus();
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
                    string nuevoNombreCategoria = txtCategoria.Text.Trim().ToUpper();

                    if (nombreActualCategoria != nuevoNombreCategoria)
                    {
                        ECategoria eCategoria = new ECategoria();
                        eCategoria.IdCategoria = idCategoria;
                        eCategoria.Categoria = nuevoNombreCategoria;

                        int r = new LCategorias().ActualizarCategoria(utils.getIdUsuario(), eCategoria);

                        if (r > 0)
                        {
                            utils.messageBoxOperacionExitosa("La categoría \"" + nombreActualCategoria + "\"" +
                                " pasó a llamarse \"" + nuevoNombreCategoria + "\"");

                            //Cargamos las categorías nuevamente
                            cargarCategorias();

                            //Limpiamos los controles
                            limpiarControles();

                            txtCategoria.Focus();
                        }
                        else if (r == -1)
                        {
                            utils.messageBoxAlerta("No se puede asignar el nombre \"" + nuevoNombreCategoria + "\" a la categoría." +
                                "\nHay una existente con idéntico nombre.");
                        }
                        else
                        {
                            utils.messageBoxOperacionSinExito("Hubo un error. Intente más tarde.");
                        }
                    }
                    else
                    {
                        utils.messageBoxAlerta("El nombre \"" + nuevoNombreCategoria + "\" es el actual de la categoría." +
                                "\nEscribe uno distinto.");
                    }
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
            idCategoria = 0;
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
