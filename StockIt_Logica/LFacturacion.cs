using StockIt_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Logica
{
    public class LFacturacion
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public int InsertarDetalleReserva(EEncabezadoReservas eEncabezadoReservas)
        {
            try
            {
                return WS.insertarFactura(eEncabezadoReservas.IdEncabezadoReserva);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -2;
            }
        }
    }
}
