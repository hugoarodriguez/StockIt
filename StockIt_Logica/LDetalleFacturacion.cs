using StockIt_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Logica
{
    public class LDetalleFacturacion
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public int InsertarDetalleFacturacion(EEncabezadoReservas eEncabezadoReservas)
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

        public List<EDetalleFacturacion> SeleccionarDetalleFacturacionByIdEncabezadoFacturacion(int idEncabezadoFacturacion)
        {
            List<EDetalleFacturacion> eDetalleFacturacionList = new List<EDetalleFacturacion>();
            try
            {
                DataSet ds = WS.seleccionarDetalleFacturacionByIdEncabezadoFacturacion(idEncabezadoFacturacion);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    EDetalleFacturacion eDetalleFacturacion = new EDetalleFacturacion();
                    eDetalleFacturacion.NombreProducto = row["NOMBRE_PRODUCTO"].ToString();
                    eDetalleFacturacion.Cantidad = int.Parse(row["CANTIDAD"].ToString());
                    eDetalleFacturacion.Precio = double.Parse(row["PRECIO"].ToString());
                    eDetalleFacturacion.MontoDetalleFacturacion = double.Parse(row["MONTO_DETALLE_FACTURACION"].ToString());
                    eDetalleFacturacionList.Add(eDetalleFacturacion);
                }

                return eDetalleFacturacionList;
            }
            catch (Exception)
            {
                return eDetalleFacturacionList;
            }
        }
    }
}
