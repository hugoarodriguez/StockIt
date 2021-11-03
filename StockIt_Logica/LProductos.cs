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

        public int InsertarProductos(List<EProducto> eProductoList)
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

        //Solamente cuando sea una nueva compra
        public int CompraProductosInexistentes(List<EProducto> eProductoList, EEncabezadoCompraProductos eEncabezadoCompraProductos,
            List<EDetalleCompraProductos> eDetalleCompraProductosList)
        {
            try
            {
                int r = -1;
                int idProducto = 0;
                List<int> idProductos = new List<int>();

                foreach (EProducto item in eProductoList)
                {
                    idProducto = WS.insertarProductos(item.IdCategoria, item.IdUsuario, item.NombreProducto,
                    item.Precio, item.Existencia, item.Img, item.Detalles);
                    idProductos.Add(idProducto);
                }

                if (idProductos.Count > 0)
                {
                    int idEncabezadoCompraProductos = new LEncabezadoCompras().insertarEncabezadoCompra(eEncabezadoCompraProductos);

                    int contador = 0;
                    foreach (EDetalleCompraProductos eDetalleCompraProductos in eDetalleCompraProductosList)
                    {
                        r = WS.insertarDetalleCompra(idEncabezadoCompraProductos, idProductos[contador],
                            eDetalleCompraProductos.Cantidad, eDetalleCompraProductos.PrecioLote,
                            eDetalleCompraProductos.PrecioUnitario, eDetalleCompraProductos.PrecioVenta,
                            eDetalleCompraProductos.PorcentajeGanancia);
                        contador++;
                    }
                }

                return r;
            }
            catch (Exception)
            {
                return -2;
            }
        }

        //Solo cuando se vaya a actualizar
        public int VerificarExistenciaCantidadesNuevas(EProducto eProducto)
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

        //Obtener producto según su ID
        public ECardProducto SeleccionarProductoById(int idProducto)
        {
            ECardProducto eCardProducto = new ECardProducto();
            try
            {
                DataSet ds = WS.seleccionarProductoById(idProducto);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    eCardProducto.IdProducto = int.Parse(row["ID_PRODUCTO"].ToString());
                    eCardProducto.Img = (byte[])row["IMG"];
                    eCardProducto.NombreProducto = row["NOMBRE_PRODUCTO"].ToString();
                    eCardProducto.IdProveedor = int.Parse(row["ID_PROVEEDOR"].ToString());
                    eCardProducto.NombreProveedor = row["NOMBRE_PROVEEDOR"].ToString();
                    eCardProducto.Categoria = row["CATEGORIA"].ToString();
                    eCardProducto.Detalles = row["DETALLES"].ToString();
                }

                return eCardProducto;
            }
            catch (Exception)
            {
                return eCardProducto;
            }
        }

        //Método para listar los productos según usuario y estado
        public List<ECardProducto> SeleccionarProductosByIdUsuarioAndEstadoProducto(int idUsuario, string estadoProducto)
        {
            List<ECardProducto> lista = new List<ECardProducto>();
            try
            {
                DataSet ds = WS.seleccionarProductosByIdUsuarioAndEstadoProducto(idUsuario, estadoProducto);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ECardProducto eCardProducto = new ECardProducto();
                    eCardProducto.IdProducto = int.Parse(row["ID_PRODUCTO"].ToString());
                    eCardProducto.Img = (byte[])row["IMG"];
                    eCardProducto.NombreProducto = row["NOMBRE_PRODUCTO"].ToString();
                    eCardProducto.NombreProveedor = row["NOMBRE_PROVEEDOR"].ToString();
                    eCardProducto.Categoria = row["CATEGORIA"].ToString();
                    eCardProducto.Existencia = int.Parse(row["EXISTENCIA"].ToString());
                    eCardProducto.Precio = double.Parse(row["PRECIO"].ToString());
                    lista.Add(eCardProducto);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
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
