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
                    int idEncabezadoCompraProductos = new LEncabezadoCompras().InsertarEncabezadoCompra(eEncabezadoCompraProductos);

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

        //Solo cuando se vaya a agregar un nuevo lote
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

        public int eliminarProducto(EProducto eProducto)
        {
            int r;
            try
            {
                return WS.eliminarProducto(eProducto.IdProducto);
            }
            catch (Exception)
            {
                r = -2;
                return r;
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
                    eCardProducto.Existencia = int.Parse(row["UNIDADES_ACTUALES"].ToString());
                    eCardProducto.Precio = double.Parse(row["PRECIO_ACTUAL"].ToString());
                    eCardProducto.UnidadesNuevas = int.Parse(row["UNIDADES_NUEVAS"].ToString());
                    eCardProducto.PrecioNuevo = double.Parse(row["PRECIO_NUEVO"].ToString());
                    lista.Add(eCardProducto);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        //Método para generar Encabezados Compra de Productos
        public List<EReporteProductosEncabezado> EncabezadosReporteCompraProductos(DateTime fechaInicio, DateTime fechaFinal, int idUsuario)
        {
            List<EReporteProductosEncabezado> lista = new List<EReporteProductosEncabezado>();
            try
            {
                DataSet ds = WS.encabezadosReporteCompraProductos(fechaInicio, fechaFinal, idUsuario);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    EReporteProductosEncabezado eReportePRoductosEncabezado = new EReporteProductosEncabezado();
                    eReportePRoductosEncabezado.IdEncCompraProductos = int.Parse(row["ID_ENC_COMPRA_PRODUCTOS"].ToString());
                    eReportePRoductosEncabezado.NombreProveedor = row["NOMBRE_PROVEEDOR"].ToString();
                    eReportePRoductosEncabezado.FechaIngreso = DateTime.Parse(row["FECHA_INGRESO"].ToString());
                    eReportePRoductosEncabezado.Monto = double.Parse(row["MONTO"].ToString());
                    lista.Add(eReportePRoductosEncabezado);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        //Método para generar Detalle Compra de Productos de una compra en específico
        public List<EReporteProductosDetalle> DetalleReporteCompraProductos(int idEncabezadoCompra)
        {
            List<EReporteProductosDetalle> lista = new List<EReporteProductosDetalle>();
            try
            {
                DataSet ds = WS.detalleReporteCompraProductos(idEncabezadoCompra);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    EReporteProductosDetalle eReporteProductosDetalle = new EReporteProductosDetalle();
                    eReporteProductosDetalle.IdEncCompraProductos = int.Parse(row["ID_ENC_COMPRA_PRODUCTOS"].ToString());
                    eReporteProductosDetalle.IdProducto = int.Parse(row["ID_PRODUCTO"].ToString());
                    eReporteProductosDetalle.NombreProducto = row["NOMBRE_PRODUCTO"].ToString();
                    eReporteProductosDetalle.Cantidad = int.Parse(row["CANTIDAD"].ToString());
                    eReporteProductosDetalle.PrecioLote = double.Parse(row["PRECIO_LOTE"].ToString());
                    eReporteProductosDetalle.PrecioUnitario = double.Parse(row["PRECIO_UNITARIO"].ToString());
                    eReporteProductosDetalle.PrecioVenta = double.Parse(row["PRECIO_REAL"].ToString());
                    eReporteProductosDetalle.Categoria = row["CATEGORIA"].ToString();
                    lista.Add(eReporteProductosDetalle);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        //Método para generar Reporte de Productos Específicado
        public List<EReporteProductosDetalle> DetalleReporteCompraProductosFiltros(int idProducto, DateTime fechaInicio, DateTime fechaFinal, int idCategoria, int idUsuario)
        {
            List<EReporteProductosDetalle> lista = new List<EReporteProductosDetalle>();
            try
            {
                DataSet ds = WS.detalleReporteCompraProductosFiltros(idProducto, fechaInicio, fechaFinal, idCategoria, idUsuario);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    EReporteProductosDetalle eReporteProductosDetalle = new EReporteProductosDetalle();
                    eReporteProductosDetalle.IdProducto = int.Parse(row["ID_PRODUCTO"].ToString());
                    eReporteProductosDetalle.NombreProducto = row["NOMBRE_PRODUCTO"].ToString();
                    eReporteProductosDetalle.Cantidad = int.Parse(row["CANTIDAD"].ToString());
                    eReporteProductosDetalle.PrecioLote = double.Parse(row["PRECIO_LOTE"].ToString());
                    eReporteProductosDetalle.PrecioUnitario = double.Parse(row["PRECIO_UNITARIO"].ToString());
                    eReporteProductosDetalle.PrecioVenta = double.Parse(row["PRECIO_REAL"].ToString());
                    eReporteProductosDetalle.NombreProveedor = row["NOMBRE_PROVEEDOR"].ToString();
                    eReporteProductosDetalle.FechaIngreso = DateTime.Parse(row["FECHA_INGRESO"].ToString());
                    lista.Add(eReporteProductosDetalle);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        //Método para llenar DropDownList de Productos en frmReporteProductos
        /* Modificar cuando se agrege el método necesario en el WebService */
        public DataTable seleccionarProductosByIdCategoria(int idCategoria)
        {
            try
            {
                DataSet ds = WS.seleccionarProductosByIdCategoria(idCategoria);

                return ds.Tables[0];
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        public DataTable SeleccionarProductosByIdUsuarioFechasAndIdCategoriaForReporte(int idUsuario, DateTime fechaInicio, DateTime fechaFinal, int idCategoria)
        {
            try
            {
                DataSet ds = WS.seleccionarProductosByIdUsuarioFechasAndIdCategoriaForReporte(idUsuario, fechaInicio, fechaFinal, idCategoria);

                return ds.Tables[0];
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }
    }
}
