using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Entidades
{
    public class EReporteProductosDetalle : EDetalleCompraProductos
    {
        private string nombreProducto;
        private string categoria;

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
