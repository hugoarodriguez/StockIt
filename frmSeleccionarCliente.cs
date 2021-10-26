using StockIt_Entidades;
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
    public partial class frmSeleccionarCliente : Form
    {
        
        public frmSeleccionarCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSeleccionarCliente_Load(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarCliente();
        }

        private void seleccionarCliente()
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvClientes.SelectedRows)
                {
                    try
                    {
                        Form frmAggReserva = Application.OpenForms["frmAggReserva"];
                        TextBox objTxtCliente = (TextBox)frmAggReserva.Controls.Find("txtCliente", true).SingleOrDefault();
                        objTxtCliente.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
                        //lblIdCliente
                        Label objLblIdCliente = (Label)frmAggReserva.Controls.Find("lblIdCliente", true).SingleOrDefault();
                        objLblIdCliente.Text = row.Cells[0].Value.ToString();
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
