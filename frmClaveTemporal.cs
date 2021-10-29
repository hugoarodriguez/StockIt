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
    public partial class frmClaveTemporal : Form
    {
        public frmClaveTemporal()
        {
            InitializeComponent();
        }

        private void frmClaveTemporal_Load(object sender, EventArgs e)
        {
        }

        private void btnEntendido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtConTemp.Text);
                MessageBox.Show("Contraseña copiada al portapapales.", "Copiado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al copiar el texto al portapapales.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
