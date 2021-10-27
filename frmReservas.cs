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
    public partial class frmReservas : Form
    {
        Utils utils = new Utils();
        ReservaCard[] reservas;
        public frmReservas()
        {
            InitializeComponent();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            cargarReservas();
        }

        private void cargarReservas()
        {
            reservas = new ReservaCard[10];
            for (int i = 0; i < reservas.Length; i++)
            {
                reservas[i] = new ReservaCard();
                reservas[i].Name = "ReservaCard" + i.ToString();
                reservas[i].NomProd = "Producto " + i.ToString();
                reservas[i].NomClie = "Cliente " + i.ToString();
                reservas[i].PreProd = 8.50;

                //Creación de btnEditar
                reservas[i].BtnEditarProp = new Button();
                reservas[i].ButtonClickEditar += new EventHandler(btnEditar_ButtonClick);

                void btnEditar_ButtonClick(object sender, EventArgs e)
                {
                    //Manejar evento
                    ReservaCard reservaCardItem = ((ReservaCard)sender);

                    Utils utils = new Utils();
                    utils.setFormToPanelFormularioHijo(new frmModReservas());
                }

                //Creación de btnEliminar
                reservas[i].BtnEliminarProp = new Button();
                reservas[i].ButtonClickEliminar += new EventHandler(btnEliminar_ButtonClick);

                void btnEliminar_ButtonClick(object sender, EventArgs e)
                {
                    //Manejar evento
                    ReservaCard reservaCardItem = ((ReservaCard)sender);

                    DialogResult dialogResult = utils.getMessageBoxAlerta("¿Estás seguro que deseas finalizar la reserva del cliente" +
                        " \"" + reservaCardItem.NomClie + "\"?");
                    if (dialogResult == DialogResult.Yes)
                    {
                        reservaCardItem.Dispose();
                    }
                }

                //Agregamos el ProductoCard al FlowLAyoutPanel
                flpListadoReservas.Controls.Add(reservas[i]);
            }
        }

        private void txtNomCliente_TextChanged(object sender, EventArgs e)
        {
            utils.filtrarCardsReservas(reservas, txtNomCliente);
        }
    }
}
