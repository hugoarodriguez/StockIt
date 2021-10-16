
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReservas = new System.Windows.Forms.TextBox();
            this.flpListadoReservas = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.label1.Size = new System.Drawing.Size(923, 57);
            this.label1.TabIndex = 21;
            this.label1.Text = "Reservas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Buscar reservas";
            // 
            // txtReservas
            // 
            this.txtReservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReservas.BackColor = System.Drawing.SystemColors.Window;
            this.txtReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservas.Location = new System.Drawing.Point(161, 85);
            this.txtReservas.Margin = new System.Windows.Forms.Padding(2);
            this.txtReservas.Name = "txtReservas";
            this.txtReservas.Size = new System.Drawing.Size(601, 26);
            this.txtReservas.TabIndex = 25;
            // 
            // flpListadoReservas
            // 
            this.flpListadoReservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpListadoReservas.AutoScroll = true;
            this.flpListadoReservas.Location = new System.Drawing.Point(86, 136);
            this.flpListadoReservas.Margin = new System.Windows.Forms.Padding(2);
            this.flpListadoReservas.Name = "flpListadoReservas";
            this.flpListadoReservas.Size = new System.Drawing.Size(750, 471);
            this.flpListadoReservas.TabIndex = 27;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 788);
            this.Controls.Add(this.flpListadoReservas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReservas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservas";
            this.Text = "frmReservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReservas;
        private System.Windows.Forms.FlowLayoutPanel flpListadoReservas;
    }
}