using StockIt_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Logica
{
    public class LDetalleCompras
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public int insertarDetalleCompra(List<EDetalleCompraProductos> eDetalleCompraProductosList, EEncabezadoCompraProductos eEncabezadoCompraProductos)
        {
            try
            {
                int idEncabezado = new LEncabezadoCompras().insertarEncabezadoCompra(eEncabezadoCompraProductos);

                int r = 1;

                foreach (EDetalleCompraProductos eDetalleCompraProductos in eDetalleCompraProductosList)
                {
                    r = WS.insertarDetalleCompra(idEncabezado, eDetalleCompraProductos.IdProducto,
                        eDetalleCompraProductos.Cantidad, eDetalleCompraProductos.PrecioLote,
                        eDetalleCompraProductos.PrecioUnitario, eDetalleCompraProductos.PrecioVenta,
                        eDetalleCompraProductos.PorcentajeGanancia);
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
