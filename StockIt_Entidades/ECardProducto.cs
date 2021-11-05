using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Entidades
{
    public class ECardProducto : EProducto
    {
        private int idProveedor;
        private string nombreProveedor;
        private string categoria;
        private int unidadesNuevas;
        private double precioNuevo;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int UnidadesNuevas { get => unidadesNuevas; set => unidadesNuevas = value; }
        public double PrecioNuevo { get => precioNuevo; set => precioNuevo = value; }
    }
}
