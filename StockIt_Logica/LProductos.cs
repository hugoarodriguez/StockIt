using StockIt_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Logica
{
    public class LProductos
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();


        //Solamente cuando sea una nueva compra
        public int insertarProductos(List<EProducto> eProductoList)
        {
            try
            {
                int r = 1;

                foreach (EProducto item in eProductoList)
                {
                    r = WS.insertarProductos(item.IdCategoria, item.IdUsuario, item.NombreProducto,
                    item.Precio, item.Existencia, item.Img, item.Detalles);
                }

                return r;
            }
            catch (Exception)
            {
                return -2;
            }
        }

        //Solo cuando se vaya a actualizar
        public int verificarExistenciaCantidadesNuevas(EProducto eProducto)
        {
            try
            {
                return WS.verificarExistenciaCantidadesNuevas(eProducto.IdProducto);
            }
            catch (Exception)
            {
                return -2;
            }
        }

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

        public int insertarDetalleCompra(List<EDetalleCompraProductos> eDetalleCompraProductosList, EEncabezadoCompraProductos eEncabezadoCompraProductos)
        {
            try
            {
                int idEncabezado = insertarEncabezadoCompra(eEncabezadoCompraProductos);

                int r = 1;

                foreach (EDetalleCompraProductos eDetalleCompraProductos in eDetalleCompraProductosList)
                {
                    eDetalleCompraProductos.IdEncCompraProductos = idEncabezado;
                    r = WS.insertarDetalleCompra(eDetalleCompraProductos.IdEncCompraProductos, eDetalleCompraProductos.IdProducto,
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

        //Método para generar Reporte de Productos
        public List<EReporteProductos> ReporteProductos(int idUsuario, int idCategoria, string estadoProducto)
        {
            List<EReporteProductos> lista = new List<EReporteProductos>();
            try
            {
                DataSet ds = WS.reporteProductos(idUsuario, idCategoria, estadoProducto);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    EReporteProductos eReporteProductos = new EReporteProductos();
                    eReporteProductos.NombreProducto = row["NOMBRE_PRODUCTO"].ToString();
                    eReporteProductos.NombreProveedor = row["NOMBRE_PROVEEDOR"].ToString();
                    eReporteProductos.Existencia = int.Parse(row["EXISTENCIA"].ToString());
                    eReporteProductos.PrecioUnitario = double.Parse(row["PRECIO_UNITARIO"].ToString());
                    eReporteProductos.PrecioVenta = double.Parse(row["PRECIO_REAL"].ToString());
                    lista.Add(eReporteProductos);
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
