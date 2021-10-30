using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Entidades
{
    public class EProveedor
    {
        private int idProveedor;
        private int idUsuario;
        private string nombreProveedor;
        private string telefonoProveedor;
        private string direccionProveedor;
        private string correoProveedor;
        private string estadoProveedor;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public string TelefonoProveedor { get => telefonoProveedor; set => telefonoProveedor = value; }
        public string DireccionProveedor { get => direccionProveedor; set => direccionProveedor = value; }
        public string CorreoProveedor { get => correoProveedor; set => correoProveedor = value; }
        public string EstadoProveedor { get => estadoProveedor; set => estadoProveedor = value; }
    }
}
