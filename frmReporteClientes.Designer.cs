
namespace StockIt
{
    partial class frmReporteClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClientes
            // 
            this.gridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(76, 150);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(700, 433);
            this.gridClientes.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.label1.Size = new System.Drawing.Size(852, 81);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reporte de Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::StockIt.Properties.Resources.printingButton1;
            this.btnImprimir.Location = new System.Drawing.Point(726, 84);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);
            this.btnImprimir.MouseHover += new System.EventHandler(this.btnImprimir_MouseHover);
            // 
            // frmReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 640);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteClientes";
            this.Text = "frmReporteClientes";
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnImprimir;
    }
}