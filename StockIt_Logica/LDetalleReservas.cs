using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockIt_Entidades;

namespace StockIt_Logica
{
    public class LDetalleReservas
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public int InsertarDetalleReserva(List<EDetalleReservas> eDetalleReservasList, EEncabezadoReservas eEncabezadoReservas)
        {
            try
            {
                int idEncabezado = new LEncabezadoReservas().InsertarEncabezadoReserva(eEncabezadoReservas);

                int r = idEncabezado;

                foreach (EDetalleReservas eDetalleReservas in eDetalleReservasList)
                {
                    r = WS.insertarDetalleReserva(idEncabezado, eDetalleReservas.IdProducto,
                        eDetalleReservas.Cantidad, eDetalleReservas.PrecioProducto,
                        eDetalleReservas.Monto, 0);
                }

                return r;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -2;
            }
        }

        //Método para agregar un producto a una reserva existente
        public int InsertarDetalleReservaExistente(int idEncabezadoReserva, EDetalleReservas eDetalleReservas)
        {
            try
            {
                
                int r = 0;

                r = WS.insertarDetalleReserva(idEncabezadoReserva, eDetalleReservas.IdProducto,
                        eDetalleReservas.Cantidad, eDetalleReservas.PrecioProducto,
                        eDetalleReservas.Monto, 1);

                return r;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -2;
            }
        }

        public int ActualizarDetalleReserva(List<EDetalleReservas> eDetalleReservasListActual, List<EDetalleReservas> eDetalleReservasListNuevo, 
            EEncabezadoReservas eEncabezadoReservas)
        {
            try
            {
                int r = 0;

                //Actualizamos los productos existentes en la reserva
                foreach (EDetalleReservas eDetalleReservasActual in eDetalleReservasListActual)
                {
                    foreach (EDetalleReservas eDetalleReservasNuevo in eDetalleReservasListNuevo)
                    {
                        if (eDetalleReservasActual.IdProducto == eDetalleReservasNuevo.IdProducto && 
                            eDetalleReservasActual.Cantidad > eDetalleReservasNuevo.Cantidad)
                        {
                            //Si vamos a quitar unidades
                            r = WS.actualizarDetalleReserva(eEncabezadoReservas.IdEncabezadoReserva, eDetalleReservasActual.IdProducto,
                            eDetalleReservasActual.Cantidad, (eDetalleReservasActual.Cantidad - eDetalleReservasNuevo.Cantidad), 
                            eDetalleReservasActual.Monto, 0);
                        }
                        else if (eDetalleReservasActual.IdProducto == eDetalleReservasNuevo.IdProducto &&
                            eDetalleReservasNuevo.Cantidad > eDetalleReservasActual.Cantidad)
                        {
                            //Si vamos a agregar unidades
                            r = WS.actualizarDetalleReserva(eEncabezadoReservas.IdEncabezadoReserva, eDetalleReservasActual.IdProducto,
                            eDetalleReservasActual.Cantidad, (eDetalleReservasNuevo.Cantidad - eDetalleReservasActual.Cantidad),
                            eDetalleReservasActual.Monto, 1);
                        }
                    }
                }

                //Insertamos los productos inexistentes en la reserva
                foreach (EDetalleReservas eDetalleReservasNuevo in eDetalleReservasListNuevo)
                {
                    //Verificamos si el producto existe o no en la reserva
                    int verificarExistenciaEnReserva = new LReservas().VerificarProductoEnReserva(eEncabezadoReservas.IdEncabezadoReserva, eDetalleReservasNuevo.IdProducto);

                    if (verificarExistenciaEnReserva == -1)
                    {
                        //Si no existe (-1), lo insertamos
                        r = new LDetalleReservas().InsertarDetalleReservaExistente(eEncabezadoReservas.IdEncabezadoReserva, eDetalleReservasNuevo);
                    }
                }

                return r;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -2;
            }
        }

        //Método para listar las reservas activas y asignar datos en CardReserva (ReservaCard)
        public List<EDetalleReservas> SeleccionarDetalleReserva(int idEncabezadoReserva)
        {
            List<EDetalleReservas> lista = new List<EDetalleReservas>();
            try
            {
                DataSet ds = WS.seleccionarDetalleReservasByIdEncabezadoReserva(idEncabezadoReserva);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    EDetalleReservas eDetalleReserva = new EDetalleReservas();
                    eDetalleReserva.IdProducto = int.Parse(row["ID_PRODUCTO"].ToString());
                    eDetalleReserva.Cantidad = int.Parse(row["CANTIDAD"].ToString());
                    eDetalleReserva.PrecioProducto = double.Parse(row["PRECIO"].ToString());
                    eDetalleReserva.Monto = double.Parse(row["MONTO_DETALLE_RESERVA"].ToString());
                    lista.Add(eDetalleReserva);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public List<EReporteReservasDetalle> DetalleReporteReservas(int idEncabezadoReserva)
        {
            List<EReporteReservasDetalle> lista = new List<EReporteReservasDetalle>();
            try
            {
                DataSet ds = WS.detalleReporteReservas(idEncabezadoReserva);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    EReporteReservasDetalle eReporteReservasDetalle = new EReporteReservasDetalle();
                    eReporteReservasDetalle.IdEncabezadoReserva = int.Parse(row["ID_ENCABEZADO_RESERVAS"].ToString());
                    eReporteReservasDetalle.IdProducto = int.Parse(row["ID_PRODUCTO"].ToString());
                    eReporteReservasDetalle.NombreProducto = row["NOMBRE_PRODUCTO"].ToString();
                    eReporteReservasDetalle.Cantidad = int.Parse(row["CANTIDAD"].ToString());
                    eReporteReservasDetalle.PrecioProducto = double.Parse(row["PRECIO"].ToString());
                    eReporteReservasDetalle.Monto = double.Parse(row["MONTO_DETALLE_RESERVA"].ToString());
                    lista.Add(eReporteReservasDetalle);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public DataTable SeleccionarEstadosReservaByIdUsuarioAndFechasForReporteDT(int idUsuario, DateTime fechaInicio, DateTime fechaFinal)
        {
            try
            {
                DataSet ds = WS.seleccionarEstadosReservaByIdUsuarioAndFechasForReporte(idUsuario, fechaInicio, fechaFinal);

                return ds.Tables[0];
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }
    }
}
