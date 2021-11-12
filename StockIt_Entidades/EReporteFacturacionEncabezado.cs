using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Entidades
{
    public class EReporteFacturacionEncabezado : EEncabezadoFacturacion
    {
        private string telefonoCliente;

        public string TelefonoCliente { get => telefonoCliente; set => telefonoCliente = value; }
    }
}
