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
    public partial class frmAggReserva : Form
    {
        Utils utils = new Utils();
        ProductoVRCard[] productosVR;
        List<ECardProducto> eCardProductosList;
        private double totalReserva = 0.0; //Variable que almacena el total de la reserva (se asigna a lblTotalReserva)
        private bool tipoVista = true; //Variable que permite evaluar el modo de vista actual
        private string textoTTCambiarVista1 = "Haz clic para mostrar únicamente los productos agregados a la reserva";
        private string textoTTCambiarVista2 = "Haz clic para mostrar todos los productos disponibles";

        public frmAggReserva()
        {
            InitializeComponent();
        }

        private void frmAggReserva_Load(object sender, EventArgs e)
        {
            lblIDReserva.Text = "ID Reserva: " + new LEncabezadoReservas().obtenerNumeroReserva(utils.getIdUsuario()).ToString();
            lblFechaEntrega.Text = new LUtils().fechaEntregaDDMMAAAA();
            cargarProductos();
            ttCambiarVista.SetToolTip(lklCambiarVista, textoTTCambiarVista1);
        }

        private void btnSelCliente_Click(object sender, EventArgs e)
        {

            List<ECliente> eClientesList = new LClientes().SeleccionarClientesActivosByIdUsuario(utils.getIdUsuario());

            frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Teléfono");
            dt.Columns.Add("Correo");

            foreach (var cliente in eClientesList)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(cliente.IdCliente, cliente.NombreCliente, cliente.ApellidoCliente, cliente.TelefonoCliente, cliente.CorreoCliente);
            }
            frmSeleccionarCliente.lblFormularioLlamada.Text = this.Name;
            frmSeleccionarCliente.dgvClientes.DataSource = dt;
            frmSeleccionarCliente.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
            }
            else
            {
                //Guardar Reserva
                EEncabezadoReservas eEncabezadoReservas = new EEncabezadoReservas();
                eEncabezadoReservas.IdCliente = int.Parse(lblIdCliente.Text.Trim());
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

                List<EDetalleReservas> eDetallesReservasList = new List<EDetalleReservas>();
                int indexProducto = 0;
                for (int i = 0; i < productosVR.Length; i++)
                {
                    if (productosVR[i].SubTotal > 0.0)
                    {
                        EDetalleReservas eDetalleReservas = new EDetalleReservas();
                        eDetalleReservas.IdProducto = int.Parse(productosVR[i].Name);
                        NumericUpDown objNUDCanReserva = (NumericUpDown)productosVR[i].Controls.Find("nudCanReserva", true).SingleOrDefault();
                        eDetalleReservas.Cantidad = ((int)objNUDCanReserva.Value);
                        eDetalleReservas.PrecioProducto = productosVR[i].PreProd;
                        eDetalleReservas.Monto = productosVR[i].SubTotal;
                        indexProducto++;
                        eDetallesReservasList.Add(eDetalleReservas);
                    }
                }

                int r = new LDetalleReservas().InsertarDetalleReserva(eDetallesReservasList, eEncabezadoReservas);

                if (r > 0)
                {
                    utils.messageBoxOperacionExitosa("La reserva se agregó satisfactoriamente.");
                }
                else if (r == -1)
                {
                    utils.messageBoxAlerta("No se pudo agregar la reserva.");
                }
                else
                {
                    utils.messageBoxAlerta("Hubo un error. Intente más tarde");
                }

                //Obtenemos el nuevo valor de ID reserva
                lblIDReserva.Text = "ID Reserva: " + new LEncabezadoReservas().obtenerNumeroReserva(utils.getIdUsuario()).ToString();

                //Limpiamos el formulario
                limpiarDatosReserva();

                //Limpiamos el control FlowLayoutPanel
                flpListadoProductos.Controls.Clear();

                //Limpiamos el arreglo que contiene los Cards
                productosVR = null;

                //Cargamos los productos nuevamente
                cargarProductos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = utils.getMessageBoxCancelarOperacion(
                "¿Estás seguro que deseas cancelar la Reserva?" +
                "\nSe quitarán todos los productos que fueron" +
                "\nagragados con anterioridad.");
            if (dialogResult == DialogResult.Yes)
            {
                limpiarDatosReserva();
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
            eCardProductosList = new LProductos().SeleccionarProductosByIdUsuarioAndEstadoProducto(utils.getIdUsuario(), "A");

            if (eCardProductosList.Count > 0)
            {
                productosVR = new ProductoVRCard[eCardProductosList.Count];
                for (int i = 0; i < productosVR.Length; i++)
                {
                    productosVR[i] = new ProductoVRCard();
                    productosVR[i].Name = eCardProductosList[i].IdProducto.ToString();
                    productosVR[i].ImgProd = utils.byteArrayToImage(eCardProductosList[i].Img);
                    productosVR[i].NomProd = eCardProductosList[i].NombreProducto;
                    productosVR[i].CatProd = eCardProductosList[i].Categoria;
                    productosVR[i].CanProd = eCardProductosList[i].Existencia;
                    productosVR[i].PreProd = eCardProductosList[i].Precio;
                    productosVR[i].CanProdN = eCardProductosList[i].UnidadesNuevas;
                    productosVR[i].PreProdN = eCardProductosList[i].PrecioNuevo;
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
                        int existenciasActuales = productoVRCardItem.CanProd;
                        double precioActual = productoVRCardItem.PreProd;
                        int existenciasNuevas = productoVRCardItem.CanProdN;
                        double precioNuevo = productoVRCardItem.PreProdN;
                        int totalExistencias = (existenciasActuales + existenciasNuevas);
                        double precioPromedio = 0.0;
                        
                        if (canProdReservar <= totalExistencias)
                        {
                            int canProdReservarExtsNuevas = 1;
                            if (canProdReservar <= existenciasActuales)
                            {
                                subTotalNuevo = canProdReservar * precioActual;
                                precioPromedio = precioActual;
                            }
                            else
                            {
                                canProdReservarExtsNuevas = (canProdReservar - existenciasActuales);
                                //Obtenemos el nuevo precio
                                precioPromedio = ((existenciasActuales * precioActual) + (canProdReservarExtsNuevas * precioNuevo)) / canProdReservar;
                                subTotalNuevo = canProdReservar * precioPromedio;
                            }

                            //Detectamos la opción seleccionada del numericUpDown
                            if (subTotalAntiguo <= subTotalNuevo)
                            {
                                //Opción de Incremento
                                if (subTotalAntiguo < subTotalNuevo)
                                {
                                    if (canProdReservar > existenciasActuales)
                                    {
                                        int cantProdReservarAntigua = (canProdReservar - 1);
                                        double precioPromedioAntiguo = ((existenciasActuales * precioActual) + ((canProdReservarExtsNuevas - 1) * precioNuevo)) / cantProdReservarAntigua;

                                        totalReserva = totalReserva - (cantProdReservarAntigua * precioPromedioAntiguo);
                                        totalReserva = totalReserva + (canProdReservar * precioPromedio);
                                    }
                                    else
                                    {
                                        totalReserva += precioPromedio;
                                    }
                                }
                            }
                            else
                            {
                                /*
                                 * Si la cantidad a reservar es igual a las existencias actual, asignamos el precio promedio
                                 * haciendo un promedio tomando en cuenta 1 producto de las existencias nuevas
                                 */
                                
                                if (canProdReservar >= existenciasActuales)
                                {
                                    if (canProdReservar ==  existenciasActuales)
                                    {
                                        int cantProdReservarAntigua = (canProdReservar + 1);
                                        double precioPromedioAntiguo = ((existenciasActuales * precioActual) + ((canProdReservarExtsNuevas) * precioNuevo)) / cantProdReservarAntigua;

                                        totalReserva = totalReserva - (cantProdReservarAntigua * precioPromedioAntiguo);
                                        totalReserva = totalReserva + (canProdReservar * precioPromedio);
                                    }
                                    else
                                    {
                                        int cantProdReservarAntigua = (canProdReservar + 1);
                                        double precioPromedioAntiguo = ((existenciasActuales * precioActual) + ((canProdReservarExtsNuevas + 1) * precioNuevo)) / cantProdReservarAntigua;

                                        totalReserva = totalReserva - (cantProdReservarAntigua * precioPromedioAntiguo);
                                        totalReserva = totalReserva + (canProdReservar * precioPromedio);
                                    }
                                }
                                else
                                {
                                    //Opción de Decremento
                                    totalReserva -= precioPromedio;
                                }

                                
                            }

                            productoVRCardItem.SubTotal = subTotalNuevo;
                            lblTotalReserva.Text = "$" + totalReserva.ToString("0.00");
                        }
                        else
                        {
                            objNUDCanReserva.Value = totalExistencias;
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
            lblFechaEntrega.Text = new LUtils().fechaEntregaDDMMAAAA();
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
