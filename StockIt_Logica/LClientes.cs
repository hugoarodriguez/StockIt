using StockIt_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Logica
{
    public class LClientes
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public int InsertarCliente(int idUsuario, ECliente eCliente)
        {
            try
            {
                return WS.insertarCliente(idUsuario, eCliente.NombreCliente, eCliente.ApellidoCliente, 
                    eCliente.SexoCliente, eCliente.TelefonoCliente, eCliente.CorreoCliente);
            }
            catch (Exception)
            {
                return -4;
            }
        }

        public int ActualizarCliente(int idUsuario, ECliente eCliente)
        {
            try
            {
                return WS.actualizarCliente(idUsuario, eCliente.IdCliente, eCliente.NombreCliente,
                    eCliente.ApellidoCliente, eCliente.SexoCliente, eCliente.TelefonoCliente, eCliente.CorreoCliente);
            }
            catch (Exception)
            {
                return -4;
            }
        }

        public int EliminarCliente(ECliente eCliente)
        {
            try
            {
                return WS.eliminarCliente(eCliente.IdCliente);
            }
            catch (Exception)
            {
                return -3;
            }
        }

        public List<ECliente> SeleccionarClientesByIdUsuario(int idUsuario)
        {
            List<ECliente> lista = new List<ECliente>();
            try
            {
                DataSet ds = WS.seleccionarClientesByIdUsuario(idUsuario);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ECliente eCliente = new ECliente();
                    eCliente.IdCliente = int.Parse(row["ID_CLIENTE"].ToString());
                    eCliente.IdUsuario = int.Parse(row["ID_USUARIO"].ToString());
                    eCliente.NombreCliente = row["NOMBRE_CLIENTE"].ToString();
                    eCliente.ApellidoCliente = row["APELLIDO_CLIENTE"].ToString();
                    eCliente.SexoCliente = row["SEXO_CLIENTE"].ToString();
                    eCliente.TelefonoCliente = row["TELEFONO_CLIENTE"].ToString();
                    eCliente.CorreoCliente = row["CORREO_CLIENTE"].ToString();
                    eCliente.EstadoCliente = row["ESTADO_CLIENTE"].ToString() == "A" ? "ACTIVO" : "INACTIVO";
                    lista.Add(eCliente);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public List<ECliente> SeleccionarClientesActivosByIdUsuario(int idUsuario)
        {
            List<ECliente> lista = new List<ECliente>();
            try
            {
                DataSet ds = WS.seleccionarClientesActivosByIdUsuario(idUsuario);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ECliente eCliente = new ECliente();
                    eCliente.IdCliente = int.Parse(row["ID_CLIENTE"].ToString());
                    eCliente.IdUsuario = int.Parse(row["ID_USUARIO"].ToString());
                    eCliente.NombreCliente = row["NOMBRE_CLIENTE"].ToString();
                    eCliente.ApellidoCliente = row["APELLIDO_CLIENTE"].ToString();
                    eCliente.SexoCliente = row["SEXO_CLIENTE"].ToString();
                    eCliente.TelefonoCliente = row["TELEFONO_CLIENTE"].ToString();
                    eCliente.CorreoCliente = row["CORREO_CLIENTE"].ToString();
                    eCliente.EstadoCliente = "ACTIVO";
                    lista.Add(eCliente);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public DataTable SeleccionarClientesActivosByIdUsuarioForReporteDT(int idUsuario)
        {
            try
            {
                DataSet ds = WS.seleccionarClientesActivosByIdUsuarioForReporte(idUsuario);

                return ds.Tables[0];
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        public ECliente SeleccionarClienteById(int idCliente)
        {
            ECliente eCliente = new ECliente();
            try
            {
                DataSet ds = WS.seleccionarClienteById(idCliente);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    eCliente.IdCliente = int.Parse(row["ID_CLIENTE"].ToString());
                    eCliente.IdUsuario = int.Parse(row["ID_USUARIO"].ToString());
                    eCliente.NombreCliente = row["NOMBRE_CLIENTE"].ToString();
                    eCliente.ApellidoCliente = row["APELLIDO_CLIENTE"].ToString();
                    eCliente.SexoCliente = row["SEXO_CLIENTE"].ToString();
                    eCliente.TelefonoCliente = row["TELEFONO_CLIENTE"].ToString();
                    eCliente.CorreoCliente = row["CORREO_CLIENTE"].ToString();
                    eCliente.EstadoCliente = "ACTIVO";
                }

                return eCliente;
            }
            catch (Exception)
            {
                return eCliente;
            }
        }
    }
}
