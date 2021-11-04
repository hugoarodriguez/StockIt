using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockIt_Entidades;

namespace StockIt_Logica
{
    public class LEncabezadoReservas
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public int obtenerNumeroReserva(int idUsuario)
        {
            try
            {
                return WS.obtenerNumeroReserva(idUsuario);
            }
            catch (Exception)
            {
                return -2;
            }
        }

        //Ejecutar en inserción
        public int InsertarEncabezadoReserva(EEncabezadoReservas eEncabezadoReservas)
        {
            try
            {
                return WS.insertarEncabezadoReserva(eEncabezadoReservas.IdCliente, eEncabezadoReservas.MontoEncabezadoReserva, 
                    eEncabezadoReservas.Comentarios);
            }
            catch (Exception)
            {
                return -2;
            }
        }
    }
}
