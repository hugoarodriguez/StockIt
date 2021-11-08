using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockIt_Entidades;

namespace StockIt_Logica
{
    public class LReservas
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public int CancelarReservaPorIndicacionCliente(EEncabezadoReservas eEncabezadoReservas)
        {
            try
            {
                return WS.cancelarReservaPorIndicacionCliente(eEncabezadoReservas.IdEncabezadoReserva);
            }
            catch (Exception)
            {
                return -2;
            }
        }
    }
}
