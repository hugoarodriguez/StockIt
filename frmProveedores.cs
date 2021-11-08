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
    public partial class frmProveedores : Form
    {
        Utils utils = new Utils();
        ProveedorCard[] proveedores;
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            List<EProveedor> eProveedoresList = new LProveedores().SeleccionarProveedoresActivosByIdUsuario(utils.getIdUsuario());

            if (eProveedoresList.Count > 0)
            {
                proveedores = new ProveedorCard[eProveedoresList.Count];
                for (int i = 0; i < proveedores.Length; i++)
                {
                    proveedores[i] = new ProveedorCard();
                    proveedores[i].Name = eProveedoresList[i].IdProveedor.ToString();
                    proveedores[i].NomProveedor = eProveedoresList[i].NombreProveedor;
                    proveedores[i].TelProveedor = eProveedoresList[i].TelefonoProveedor;
                    proveedores[i].CorrProveedor = eProveedoresList[i].CorreoProveedor;
                    proveedores[i].DirProveedor = eProveedoresList[i].DireccionProveedor;

                    //Creación de btnEditar
                    proveedores[i].BtnEditarProp = new Button();
                    proveedores[i].ButtonClickEditar += new EventHandler(btnEditar_ButtonClick);

                    void btnEditar_ButtonClick(object sender, EventArgs e)
                    {
                        //Manejar evento
                        ProveedorCard proveedorCardItem = ((ProveedorCard)sender);

                        //Abrimos el formulario para modificar el producto
                        Utils utils = new Utils();
                        frmModProveedores frmModProveedores = new frmModProveedores();
                        frmModProveedores.ID_PROVEEDOR = int.Parse(proveedorCardItem.Name);
                        utils.setFormToPanelFormularioHijo(frmModProveedores);

                    }

                    //Creación de btnEliminar
                    proveedores[i].BtnEliminarProp = new Button();
                    proveedores[i].ButtonClickEliminar += new EventHandler(btnEliminar_ButtonClick);

                    void btnEliminar_ButtonClick(object sender, EventArgs e)
                    {
                        //Manejar evento
                        ProveedorCard proveedorCardItem = ((ProveedorCard)sender);

                        DialogResult dialogResult = utils.getMessageBoxAlerta("¿Estás seguro que deseas eliminar el proveedor" +
                            " \"" + proveedorCardItem.NomProveedor + "\"?");
                        if (dialogResult == DialogResult.Yes)
                        {
                            EProveedor eProveedor = new EProveedor();
                            eProveedor.IdProveedor = int.Parse(proveedorCardItem.Name);

                            int r = new LProveedores().EliminarProveedor(eProveedor);

                            if (r > 0)
                            {
                                proveedorCardItem.Dispose();
                                utils.messageBoxOperacionExitosa("Se eliminó el proveedor \"" + proveedorCardItem.NomProveedor + "\"");
                            }
                            else if (r == -1)
                            {
                                utils.messageBoxAlerta("No se puede eliminar este proveedor, " +
                                    "\nse encuentra relacionado con productos activos.");
                            }
                            else
                            {
                                utils.messageBoxOperacionSinExito("Hubo un error. Intente más tarde.");
                            }
                        }
                    }

                    //Agregamos el ProveedorCard al FlowLAyoutPanel
                    flpListadoProveedores.Controls.Add(proveedores[i]);
                }
            }
        }

        private void txtNomProveedor_TextChanged(object sender, EventArgs e)
        {
            utils.filtrarCardsProveedores(proveedores, txtNomProveedor);
        }
    }
}
