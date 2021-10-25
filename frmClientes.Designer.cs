
namespace StockIt
{
    partial class frmClientes
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
            this.txtClientes = new System.Windows.Forms.TextBox();
            this.flpListadoClientes = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Buscar clientes (escriba el nombre)";
            // 
            // txtClientes
            // 
            this.txtClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes.Location = new System.Drawing.Point(215, 170);
            this.txtClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.Size = new System.Drawing.Size(800, 30);
            this.txtClientes.TabIndex = 28;
            this.txtClientes.TextChanged += new System.EventHandler(this.txtClientes_TextChanged);
            // 
            // flpListadoClientes
            // 
            this.flpListadoClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpListadoClientes.AutoScroll = true;
            this.flpListadoClientes.Location = new System.Drawing.Point(115, 233);
            this.flpListadoClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpListadoClientes.Name = "flpListadoClientes";
            this.flpListadoClientes.Size = new System.Drawing.Size(1000, 580);
            this.flpListadoClientes.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(1231, 70);
            this.label1.TabIndex = 37;
            this.label1.Text = "Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 1102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpListadoClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientes;
        private System.Windows.Forms.FlowLayoutPanel flpListadoClientes;
        private System.Windows.Forms.Label label1;
    }
}