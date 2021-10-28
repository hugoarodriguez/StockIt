
namespace StockIt
{
    partial class frmReservas
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.flpListadoReservas = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Buscar reservas por nombre del Cliente";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCliente.Location = new System.Drawing.Point(215, 171);
            this.txtNomCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(800, 30);
            this.txtNomCliente.TabIndex = 25;
            this.txtNomCliente.TextChanged += new System.EventHandler(this.txtNomCliente_TextChanged);
            // 
            // flpListadoReservas
            // 
            this.flpListadoReservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpListadoReservas.AutoScroll = true;
            this.flpListadoReservas.Location = new System.Drawing.Point(115, 233);
            this.flpListadoReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpListadoReservas.Name = "flpListadoReservas";
            this.flpListadoReservas.Size = new System.Drawing.Size(1000, 580);
            this.flpListadoReservas.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(1231, 70);
            this.label1.TabIndex = 28;
            this.label1.Text = "Reservas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 1102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpListadoReservas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReservas";
            this.Text = "frmReservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.FlowLayoutPanel flpListadoReservas;
        private System.Windows.Forms.Label label1;
    }
}