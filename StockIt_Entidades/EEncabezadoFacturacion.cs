using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Entidades
{
    public class EEncabezadoFacturacion
    {
        private int idEncabezadoFacturacion;
        private int idCliente;
        private int idReserva;
        DateTime fechaFacturacion;
        double montoEncabezadoFacturacion;

        public int IdEncabezadoFacturacion { get => idEncabezadoFacturacion; set => idEncabezadoFacturacion = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdReserva { get => idReserva; set => idReserva = value; }
        public DateTime FechaFacturacion { get => fechaFacturacion; set => fechaFacturacion = value; }
        public double MontoEncabezadoFacturacion { get => montoEncabezadoFacturacion; set => montoEncabezadoFacturacion = value; }
    }
}
