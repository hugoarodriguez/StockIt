using StockIt.CustomControls;
using StockIt_Entidades;
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
    public partial class frmModReservas : Form
    {
        Utils utils = new Utils();
        ProductoVRCard[] productosVR;
        ECliente[] eClientes;
        private double totalReserva = 0.0; //Variable que almacena el total de la reserva (se asigna a lblTotalReserva)
        private bool tipoVista = true; //Variable que permite evaluar el modo de vista actual
        private string textoTTCambiarVista1 = "Haz clic para mostrar únicamente los productos agregados a la reserva";
        private string textoTTCambiarVista2 = "Haz clic para mostrar todos los productos disponibles";

        public frmModReservas()
        {
            InitializeComponent();
        }

        private void frmModReserva_Load(object sender, EventArgs e)
        {
            cargarProductos();
            cargarClientes();
            ttCambiarVista.SetToolTip(lklCambiarVista, textoTTCambiarVista1);
            ttActualizar.SetToolTip(btnActualizar, "Haz click para establecer los cambios a la reserva");
            ttLimpiar.SetToolTip(btnLimpiar, "Haz click para reestablecer los datos de la reserva");
            ttCancelar.SetToolTip(btnCancelar, "Haz click para ignorar los cambios y volver a las Reservas");
        }

        private void btnSelCliente_Click(object sender, EventArgs e)
        {
            frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Teléfono");
            dt.Columns.Add("Correo");

            foreach (var cliente in eClientes)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(cliente.IdCliente, cliente.NombreCliente, cliente.ApellidoCliente, cliente.TelefonoCliente, cliente.CorreoCliente);
            }
            frmSeleccionarCliente.lblFormularioLlamada.Text = this.Name;
            frmSeleccionarCliente.dgvClientes.DataSource = dt;
            frmSeleccionarCliente.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Agregar validación de Fecha
            if (totalReserva <= 0 || lblIdCliente.Text == "" || txtCliente.Text == "")
            {
                if (totalReserva <= 0)
                {
                    utils.messageBoxCampoRequerido("Debes agregar productos a la reserva.");
                }
                else if (lblIdCliente.Text == "" || txtCliente.Text == "")
                {
                    utils.messageBoxCampoRequerido("Debes seleccionar el cliente a quien\n le pertenece la reserva.");
                    btnSelCliente.Focus();
                }
                /* //Validación de fecha con el WS
                else if ()
                {

                }
                */
            }
            else
            {
                //Guardar Reserva
                EEncabezadoReservas eEncabezadoReservas = new EEncabezadoReservas();
                eEncabezadoReservas.IdCliente = int.Parse(lblIdCliente.Text.Trim());
                eEncabezadoReservas.FechaPromesaEntrega = dtpFecEntrega.Value;
                eEncabezadoReservas.MontoEncabezadoReserva = totalReserva;
                eEncabezadoReservas.EstadoReserva = "A";//Verificar con los estados determinados
                eEncabezadoReservas.Comentarios = txtComentarios.Text.Trim();

                int conteoProductos = 0;
                for (int i = 0; i < productosVR.Length; i++)
                {
                    if (productosVR[i].SubTotal > 0.0)
                    {
                        conteoProductos++;
                    }
                }

                EDetalleReservas[] eDetallesReservas = new EDetalleReservas[conteoProductos];
                int indexProducto = 0;
                for (int i = 0; i < productosVR.Length; i++)
                {
                    if (productosVR[i].SubTotal > 0.0)
                    {
                        eDetallesReservas[indexProducto] = new EDetalleReservas();
                        eDetallesReservas[indexProducto].IdProducto = int.Parse(productosVR[i].Name);
                        NumericUpDown objNUDCanReserva = (NumericUpDown)productosVR[i].Controls.Find("nudCanReserva", true).SingleOrDefault();
                        eDetallesReservas[indexProducto].Cantidad = ((int)objNUDCanReserva.Value);
                        eDetallesReservas[indexProducto].Monto = productosVR[i].SubTotal;
                        indexProducto++;
                    }
                }

                try
                {
                    //Llamar método de capa lógica para guardar la reserva enviar como argumentos a eEncabezadoReservas y eDetallesReservas[]
                    utils.messageBoxOperacionExitosa("La reserva fue actualizada satisfactoriamente.");

                    //Volvemos al formulario Reservas
                    limpiarDatosReserva();
                    utils.setFormToPanelFormularioHijo(new frmReservas());

                }
                catch (Exception)
                {
                    utils.messageBoxOperacionSinExito("No se pudo actualizr la reserva. Intente más tarde.");
                    //Volvemos al formulario Reservas
                    limpiarDatosReserva();
                    utils.setFormToPanelFormularioHijo(new frmReservas());
                }
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Reestablecer los datos de la reserva
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = utils.getMessageBoxCancelarOperacion(
                "¿Estás seguro que deseas cancelar la modificación de la Reserva?" +
                "\nTodos los cambios realizados se descartarán.");
            if (dialogResult == DialogResult.Yes)
            {
                limpiarDatosReserva();
                utils.setFormToPanelFormularioHijo(new frmReservas());
            }
        }

        private void txtNomProd_TextChanged(object sender, EventArgs e)
        {
            tipoVista = false;
            cambiarVista();
            utils.filtrarCardsProductosReservas(productosVR, txtNomProd);
        }

        private void lklCambiarVista_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cambiarVista();
        }

        #region Métodos creados
        private void cargarProductos()
        {
            productosVR = new ProductoVRCard[10];
            for (int i = 0; i < productosVR.Length; i++)
            {
                productosVR[i] = new ProductoVRCard();
                productosVR[i].Name = i.ToString();
                productosVR[i].NomProd = "Camiseta Verde " + i.ToString();
                productosVR[i].CatProd = "Camisetas";
                productosVR[i].CanProd = 5;
                productosVR[i].PreProd = 8.50;
                productosVR[i].SubTotal = 0.0;

                //Creación de btnEditar
                productosVR[i].NudCanReservaProp = new NumericUpDown();
                productosVR[i].ValueChangedNUDCanReserva += new EventHandler(nudCanProd_ValueChanged);

                void nudCanProd_ValueChanged(object sender, EventArgs e)
                {
                    //Manejar evento
                    ProductoVRCard productoVRCardItem = ((ProductoVRCard)sender);
                    //Obtenemos el control nudCanReserva
                    NumericUpDown objNUDCanReserva = (NumericUpDown)productoVRCardItem.Controls.Find("nudCanReserva", true).SingleOrDefault();

                    //Realizamos las operaciones necesarias para obtener el SubTotal y se actualiza el Total
                    int canProdReservar = ((int)objNUDCanReserva.Value);
                    double subTotalAntiguo = productoVRCardItem.SubTotal;
                    double subTotalNuevo;
                    if (canProdReservar <= productoVRCardItem.CanProd)
                    {
                        subTotalNuevo = canProdReservar * productoVRCardItem.PreProd;

                        //Detectamos la opción seleccionada del numericUpDown
                        if (subTotalAntiguo <= subTotalNuevo)
                        {
                            //Opción de Incremento
                            if (subTotalAntiguo < subTotalNuevo)
                            {
                                totalReserva += productoVRCardItem.PreProd;
                            }
                        }
                        else
                        {
                            //Opción de Decremento
                            totalReserva -= productoVRCardItem.PreProd;
                        }

                        productoVRCardItem.SubTotal = subTotalNuevo;
                        lblTotalReserva.Text = "$" + totalReserva.ToString("0.00");
                    }
                    else
                    {
                        objNUDCanReserva.Value = productoVRCardItem.CanProd;
                        lblTotalReserva.Text = "$" + totalReserva.ToString("0.00");
                    }

                    //Evaluamos el subtotal para cambiar el color del Fondo y Letra del CustomControl
                    if (((int)productoVRCardItem.SubTotal) > 0)
                    {
                        productoVRCardItem.BackColor = Color.FromArgb(95, 189, 89);
                        productoVRCardItem.ForeColor = Color.White;
                    }
                    else
                    {
                        if (tipoVista == false)
                        {
                            productoVRCardItem.Hide();
                        }
                        productoVRCardItem.BackColor = Color.White;
                        productoVRCardItem.ForeColor = Color.Black;
                    }
                }

                //Agregamos el ProductoCard al FlowLAyoutPanel
                flpListadoProductos.Controls.Add(productosVR[i]);
            }
        }

        private void cargarClientes()
        {
            eClientes = new ECliente[10];
            for (int i = 0; i < eClientes.Length; i++)
            {
                eClientes[i] = new ECliente();
                eClientes[i].IdCliente = i + 1;
                eClientes[i].IdUsuario = 1;
                eClientes[i].NombreCliente = "Nombre " + (i + 1).ToString();
                eClientes[i].ApellidoCliente = "Apellido 1" + (i + 1).ToString();
                eClientes[i].SexoCliente = "A";
                eClientes[i].TelefonoCliente = "7022-8563";
                eClientes[i].CorreoCliente = "correo" + (i + 1).ToString() + "@gmail.com";
                eClientes[i].EstadoCliente = "A";
            }
        }

        //Permite quitar de la reserva todos los productos que han sido agregados como reservados
        private void limpiarDatosReserva()
        {
            for (int i = 0; i < productosVR.Length; i++)
            {
                if (productosVR[i].SubTotal > 0)
                {
                    NumericUpDown objNUDCanReserva = (NumericUpDown)productosVR[i].Controls.Find("nudCanReserva", true).SingleOrDefault();
                    objNUDCanReserva.Value = 0;
                    productosVR[i].SubTotal = 0.0;
                    productosVR[i].BackColor = Color.White;
                    productosVR[i].ForeColor = Color.Black;
                }

            }
            txtCliente.Text = null;
            lblIdCliente.Text = null;
            txtComentarios.Text = null;
            totalReserva = 0.0;
            lblTotalReserva.Text = "$" + totalReserva.ToString("0.00");
            txtNomProd.Text = null;
            dtpFecEntrega.Value = DateTime.Now;//Cambiar Datetime.Now por la fecha traída del WS

            tipoVista = false;
            cambiarVista();
        }

        //Método que permite mostrar los productos reservados o todos los productos
        private void cambiarVista()
        {
            if (tipoVista == true)
            {
                tipoVista = false;
                ttCambiarVista.SetToolTip(lklCambiarVista, textoTTCambiarVista2);
                //Mostrar solo productos con subtotal diferente de 0
                for (int i = 0; i < productosVR.Length; i++)
                {
                    if (productosVR[i].SubTotal > 0.0)
                    {
                        productosVR[i].Show();
                    }
                    else
                    {
                        productosVR[i].Hide();
                    }
                }
            }
            else if (tipoVista == false)
            {
                tipoVista = true;
                ttCambiarVista.SetToolTip(lklCambiarVista, textoTTCambiarVista1);
                //Mostrar todos los productos
                for (int i = 0; i < productosVR.Length; i++)
                {
                    productosVR[i].Show();
                }
            }
        }

        #endregion
    }
}
