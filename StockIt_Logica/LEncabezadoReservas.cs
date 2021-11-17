using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockIt_Entidades;

namespace StockIt_Logica
{
    public class LEncabezadoReservas
    {
        private string ESTADO_EN_ESPERA = "E";
        private string ESTADO_FINALIZADA = "F";
        private string ESTADO_CANCELADA_CLIENTE = "C";
        private string ESTADO_CANCELADA_TIEMPO = "T";

        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public int obtenerNumeroReserva(int idUsuario)
        {
            try
            {
                return WS.obtenerNumeroReserva(idUsuario);
            }
            catch (Exception)
            {
                return -2;
            }
        }

        //Ejecutar en inserción
        public int InsertarEncabezadoReserva(EEncabezadoReservas eEncabezadoReservas)
        {
            try
            {
                return WS.insertarEncabezadoReserva(eEncabezadoReservas.IdCliente, eEncabezadoReservas.MontoEncabezadoReserva, 
                    eEncabezadoReservas.Comentarios);
            }
            catch (Exception)
            {
                return -2;
            }
        }

        //Método para listar las reservas activas y asignar datos en CardReserva (ReservaCard)
        public List<ECardReserva> SeleccionarReservasActivas(int idUsuario)
        {
            List<ECardReserva> lista = new List<ECardReserva>();
            try
            {
                DataSet ds = WS.seleccionarReservasByIdUsuarioAndEstadoReserva(idUsuario, ESTADO_EN_ESPERA);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ECardReserva eCardReserva = new ECardReserva();
                    eCardReserva.IdEncabezadoReserva = int.Parse(row["ID_ENCABEZADO_RESERVAS"].ToString());
                    eCardReserva.NombreCliente = row["NOMBRE_CLIENTE"].ToString();
                    eCardReserva.ApellidoCliente = row["APELLIDO_CLIENTE"].ToString();
                    eCardReserva.TelefonoCliente = row["TELEFONO_CLIENTE"].ToString();
                    eCardReserva.FechaReserva = DateTime.Parse(row["FECHA_RESERVA"].ToString());
                    eCardReserva.FechaPromesaEntrega = DateTime.Parse(row["FECHA_PROMESA_RESERVA"].ToString());
                    eCardReserva.MontoEncabezadoReserva = double.Parse(row["MONTO_ENCABEZADO_RESERVA"].ToString());
                    eCardReserva.Comentarios = row["COMENTARIOS"].ToString();
                    lista.Add(eCardReserva);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public List<EReporteReservasEncabezado> EncabezadosReporteReservas(DateTime fechaInicio, DateTime fechaFinal, int idUsuario, string estadoReserva, 
            int idCliente)
        {
            List<EReporteReservasEncabezado> lista = new List<EReporteReservasEncabezado>();
            try
            {
                DataSet ds = WS.encabezadosReporteReservas(fechaInicio, fechaFinal, idUsuario, estadoReserva, idCliente);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    EReporteReservasEncabezado eReporteReservasEncabezado = new EReporteReservasEncabezado();
                    eReporteReservasEncabezado.IdEncabezadoReserva = int.Parse(row["ID_ENCABEZADO_RESERVAS"].ToString());
                    eReporteReservasEncabezado.NombreCliente = row["NOMBRE_CLIENTE"].ToString();
                    eReporteReservasEncabezado.ApellidoCliente = row["APELLIDO_CLIENTE"].ToString();
                    eReporteReservasEncabezado.FechaReserva = DateTime.Parse(row["FECHA_RESERVA"].ToString());
                    eReporteReservasEncabezado.FechaPromesaEntrega = DateTime.Parse(row["FECHA_PROMESA_RESERVA"].ToString());
                    eReporteReservasEncabezado.MontoEncabezadoReserva = double.Parse(row["MONTO_ENCABEZADO_RESERVA"].ToString());
                    eReporteReservasEncabezado.EstadoReserva = row["ESTADO_RESERVA"].ToString() == ESTADO_CANCELADA_CLIENTE 
                        ? "CANCELADA POR EL CLIENTE"
                        : "RESERVA EXPIRADA";
                    eReporteReservasEncabezado.Comentarios = row["COMENTARIOS"].ToString();
                    lista.Add(eReporteReservasEncabezado);
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
