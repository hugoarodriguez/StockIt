using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockIt_Entidades;


namespace StockIt_Logica
{
    public class LUsuarios
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();
        public int Login(EUsuario eUsuario)
        {
            try
            {
                return WS.login(eUsuario.Correo, eUsuario.Password);
            }
            catch (Exception)
            {
                return -3;
            }
        }

        public int CrearCuenta(EUsuario eUsuario)
        {
            try
            {
                return WS.insertarUsuario(eUsuario.Usuario, eUsuario.Nombres, eUsuario.Apellidos, eUsuario.NombreEmpresa,
                eUsuario.Correo, eUsuario.Password);
            }
            catch (Exception)
            {
                return -3;
            }
        }

        public int ActualizarPassword(EUsuario eUsuario, string passwordNueva)
        {
            try
            {
                return WS.actualizarPassword(eUsuario.Correo, eUsuario.Password, passwordNueva);
            }
            catch (Exception)
            {
                return -3;
            }
        }

        public string AsignarPasswordTemporal(EUsuario eUsuario)
        {
            try
            {
                return WS.asignarPasswordTemporal(eUsuario.Correo);
            }
            catch (Exception)
            {
                return "-3";
            }
        }

        public bool GetEstadoPasswordTemporal(EUsuario eUsuario)
        {
            try
            {
                return WS.getEstadoPasswordTemporalUsuario(eUsuario.Correo);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string getNombreUsuario(string correo)
        {
            try
            {
                EUsuario eUsuario = seleccionarUsuarioByCorreo(correo);

                return eUsuario.Nombres + " " + eUsuario.Apellidos;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public EUsuario seleccionarUsuarioByCorreo(string correo)
        {
            EUsuario eUsuario = new EUsuario();

            try
            {
                DataSet ds = WS.seleccionarUsuarioByCorreo(correo);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    eUsuario.IdUsuario = int.Parse(row["ID_USUARIO"].ToString());
                    eUsuario.Usuario = row["USUARIO"].ToString();
                    eUsuario.Nombres = row["NOMBRE_USUARIO"].ToString();
                    eUsuario.Apellidos = row["APELLIDO_USUARIO"].ToString();
                    eUsuario.NombreEmpresa = row["NOMBRE_EMPRESA"].ToString();
                    eUsuario.Correo = row["CORREO_USUARIO"].ToString();
                    eUsuario.EstadoUsuario = row["ESTADO_USUARIO"].ToString();
                }

                return eUsuario;
            }
            catch (Exception)
            {
                return eUsuario;
            }
        }

    }
}
