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
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void cargarCategorias()
        {
            CategoriaCard[] categorias = new CategoriaCard[10];
            for (int i = 0; i < categorias.Length; i++)
            {
                categorias[i] = new CategoriaCard();
                categorias[i].Name = "CategoriaCard" + i.ToString();
                categorias[i].CatProd = "Categoría" + " " + i.ToString();

                //Creación de btnEditar
                categorias[i].BtnEditarProp = new Button();
                categorias[i].ButtonClickEditar += new EventHandler(btnEditar_ButtonClick);

                void btnEditar_ButtonClick(object sender, EventArgs e)
                {
                    //Manejar evento
                    CategoriaCard categoriaCardItem = ((CategoriaCard)sender);
                    this.txtCategoria.Text = categoriaCardItem.Name + "Editar";
                }

                //Creación de btnEliminar
                categorias[i].BtnEliminarProp = new Button();
                categorias[i].ButtonClickEliminar += new EventHandler(btnEliminar_ButtonClick);

                void btnEliminar_ButtonClick(object sender, EventArgs e)
                {
                    //Manejar evento
                    CategoriaCard categoriaCardItem = ((CategoriaCard)sender);
                    this.txtCategoria.Text = categoriaCardItem.Name + "Eliminar";
                    categoriaCardItem.Dispose();
                }

                //Agregamos el ProductoCard al FlowLAyoutPanel
                flpListadoCategorias.Controls.Add(categorias[i]);
            }
        }
    }

    
}
