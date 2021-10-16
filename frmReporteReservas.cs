using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt
{
    public partial class frmReporteReservas : Form
    {
        public frmReporteReservas()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void dateFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_MouseHover(object sender, EventArgs e)
        {
            btnImprimir.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            btnImprimir.BorderStyle = BorderStyle.None;
        }
    }
}
