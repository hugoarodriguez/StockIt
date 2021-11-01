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
    public partial class frmSeleccionarProveedor : Form
    {
        public frmSeleccionarProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarProveedor();
        }

        private void seleccionarProveedor()
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProveedores.SelectedRows)
                {
                    try
                    {
                        Form frmAggProductos = Application.OpenForms["frmAggProductos"];
                        TextBox objTxtProveedor = (TextBox)frmAggProductos.Controls.Find("txtProveedor", true).SingleOrDefault();
                        objTxtProveedor.Text = row.Cells[1].Value.ToString();
                        //lblIdCliente
                        Label objLblIdProveedor = (Label)frmAggProductos.Controls.Find("lblIdProveedor", true).SingleOrDefault();
                        objLblIdProveedor.Text = row.Cells[0].Value.ToString();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            this.Close();
        }
    }
}
