using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Entidades
{
    public class ECardProducto : EProducto
    {
        private string nombreProveedor;
        private string categoria;

        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
