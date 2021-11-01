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
    public partial class frmProductosAgregados : Form
    {
        public frmAggProductos frmAggProductos = new frmAggProductos();
        List<int> productosEliminados = new List<int>();

        public frmProductosAgregados()
        {
            InitializeComponent();
        }

        private void dgvProductosSeleccionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminarProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirmarEliminarProductos();
            this.Close();
        }

        private void eliminarProducto()
        {
            if (dgvProductosSeleccionados.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProductosSeleccionados.SelectedRows)
                {
                    try
                    {
                        productosEliminados.Add(int.Parse(row.Cells[0].Value.ToString()));
                        dgvProductosSeleccionados.Rows.Remove(dgvProductosSeleccionados.SelectedRows[0]);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void confirmarEliminarProductos()
        {
            int index = 0;
            foreach (int id in productosEliminados)
            {
                frmAggProductos.eProductosList.Remove(frmAggProductos.eProductosList[index]);
                frmAggProductos.eDetalleCompraProductosList.Remove(frmAggProductos.eDetalleCompraProductosList[index]);
                frmAggProductos.lklProductos.Text = "Productos de esta compra: " + frmAggProductos.eProductosList.Count;

                if (frmAggProductos.eProductosList.Count <= 0)
                {
                    frmAggProductos.btnSelProveedor.Enabled = true;
                }
            }
        }
    }
}
