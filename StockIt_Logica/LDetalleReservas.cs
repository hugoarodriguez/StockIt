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
                        eDetalleReservas.Monto);
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
    }
}
