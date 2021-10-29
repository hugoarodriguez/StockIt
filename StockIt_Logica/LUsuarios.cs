using System;
using System.Collections.Generic;
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

    }
}
