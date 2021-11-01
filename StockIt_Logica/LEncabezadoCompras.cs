using StockIt_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Logica
{
    public class LEncabezadoCompras
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        //Ejecutar en acutalización o inserción
        public int insertarEncabezadoCompra(EEncabezadoCompraProductos eEncabezadoCompraProductos)
        {
            try
            {
                return WS.insertarEncabezadoCompra(eEncabezadoCompraProductos.IdProveedor, eEncabezadoCompraProductos.Monto);
            }
            catch (Exception)
            {
                return -2;
            }
        }

        public int obtenerIdCompra(int idUsuario)
        {
            try
            {
                //Agregar SP en la BD y método en el WS
                return 1;
            }
            catch (Exception)
            {
                return -2;
            }
        }
    }
}
