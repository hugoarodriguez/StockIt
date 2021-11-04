using System;
using System.Collections.Generic;
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
    }
}
