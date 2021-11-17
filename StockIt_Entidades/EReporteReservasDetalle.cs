using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Entidades
{
    public class EReporteReservasDetalle : EDetalleReservas
    {
        private string nombreProducto;

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
    }
}
