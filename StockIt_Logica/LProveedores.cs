using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockIt_Entidades;

namespace StockIt_Logica
{
    public class LProveedores
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public int InsertarProveedor(int idUsuario, EProveedor eProveedor)
        {
            try
            {
                return WS.insertarProveedor(idUsuario, eProveedor.NombreProveedor, eProveedor.TelefonoProveedor, 
                    eProveedor.DireccionProveedor, eProveedor.CorreoProveedor);
            }
            catch (Exception)
            {
                return -4;
            }
        }

        public int ActualizarProveedor(int idUsuario, EProveedor eProveedor)
        {
            try
            {
                return WS.actualizarProveedor(idUsuario, eProveedor.IdProveedor, eProveedor.NombreProveedor, 
                    eProveedor.TelefonoProveedor, eProveedor.DireccionProveedor, eProveedor.CorreoProveedor);
            }
            catch (Exception)
            {
                return -4;
            }
        }

        public int EliminarProveedor(EProveedor eProveedor)
        {
            try
            {
                return WS.eliminarProveedor(eProveedor.IdProveedor);
            }
            catch (Exception)
            {
                return -3;
            }
        }

        public List<EProveedor> SeleccionarProveedoresByIdUsuario(int idUsuario)
        {
            List<EProveedor> lista = new List<EProveedor>();
            try
            {
                DataSet ds = WS.seleccionarProveedoresByIdUsuario(idUsuario);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    EProveedor eProveedor = new EProveedor();
                    eProveedor.IdProveedor = int.Parse(row["ID_PROVEEDOR"].ToString());
                    eProveedor.IdUsuario = int.Parse(row["ID_USUARIO"].ToString());
                    eProveedor.NombreProveedor = row["NOMBRE_PROVEEDOR"].ToString();
                    eProveedor.TelefonoProveedor = row["TELEFONO_PROVEEDOR"].ToString();
                    eProveedor.DireccionProveedor = row["DIRECCION_PROVEEDOR"].ToString();
                    eProveedor.CorreoProveedor = row["CORREO_PROVEEDOR"].ToString();
                    eProveedor.EstadoProveedor = row["ESTADO_PROVEEDOR"].ToString() == "A" ? "ACTIVA" : "INACTIVA";
                    lista.Add(eProveedor);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public List<EProveedor> SeleccionarProveedoresActivosByIdUsuario(int idUsuario)
        {
            List<EProveedor> lista = new List<EProveedor>();
            try
            {
                DataSet ds = WS.seleccionarProveedoresActivosByIdUsuario(idUsuario);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    EProveedor eProveedor = new EProveedor();
                    eProveedor.IdProveedor = int.Parse(row["ID_PROVEEDOR"].ToString());
                    eProveedor.IdUsuario = int.Parse(row["ID_USUARIO"].ToString());
                    eProveedor.NombreProveedor = row["NOMBRE_PROVEEDOR"].ToString();
                    eProveedor.TelefonoProveedor = row["TELEFONO_PROVEEDOR"].ToString();
                    eProveedor.DireccionProveedor = row["DIRECCION_PROVEEDOR"].ToString();
                    eProveedor.CorreoProveedor = row["CORREO_PROVEEDOR"].ToString();
                    eProveedor.EstadoProveedor = "ACTIVO";
                    lista.Add(eProveedor);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public EProveedor SeleccionarProveedorById(int idProveedor)
        {
            EProveedor eProveedor = new EProveedor();
            try
            {
                DataSet ds = WS.seleccionarProveedorById(idProveedor);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    eProveedor.IdProveedor = int.Parse(row["ID_PROVEEDOR"].ToString());
                    eProveedor.IdUsuario = int.Parse(row["ID_USUARIO"].ToString());
                    eProveedor.NombreProveedor = row["NOMBRE_PROVEEDOR"].ToString();
                    eProveedor.TelefonoProveedor = row["TELEFONO_PROVEEDOR"].ToString();
                    eProveedor.DireccionProveedor = row["DIRECCION_PROVEEDOR"].ToString();
                    eProveedor.CorreoProveedor = row["CORREO_PROVEEDOR"].ToString();
                    eProveedor.EstadoProveedor = "ACTIVO";
                }

                return eProveedor;
            }
            catch (Exception)
            {
                return eProveedor;
            }
        }
    }
}
