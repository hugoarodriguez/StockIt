using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Entidades
{
    public class EReporteProductosEncabezado : EEncabezadoCompraProductos
    {
        private string nombreProveedor;

        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
    }
}
