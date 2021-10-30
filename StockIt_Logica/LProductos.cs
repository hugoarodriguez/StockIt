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
