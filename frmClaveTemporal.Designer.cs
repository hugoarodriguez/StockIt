
namespace StockIt
{
    partial class frmClaveTemporal
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
            this.btnEntendido = new System.Windows.Forms.Button();
            this.txtConTemp = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.label1.Size = new System.Drawing.Size(782, 127);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tu contraseña temporal es:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEntendido
            // 
            this.btnEntendido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(169)))));
            this.btnEntendido.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEntendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntendido.ForeColor = System.Drawing.Color.White;
            this.btnEntendido.Location = new System.Drawing.Point(326, 234);
            this.btnEntendido.Name = "btnEntendido";
            this.btnEntendido.Size = new System.Drawing.Size(130, 40);
            this.btnEntendido.TabIndex = 13;
            this.btnEntendido.Text = "Entendido";
            this.btnEntendido.UseVisualStyleBackColor = false;
            this.btnEntendido.Click += new System.EventHandler(this.btnEntendido_Click);
            // 
            // txtConTemp
            // 
            this.txtConTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtConTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConTemp.Location = new System.Drawing.Point(86, 179);
            this.txtConTemp.Name = "txtConTemp";
            this.txtConTemp.ReadOnly = true;
            this.txtConTemp.Size = new System.Drawing.Size(500, 30);
            this.txtConTemp.TabIndex = 12;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.btnCopiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.ForeColor = System.Drawing.Color.White;
            this.btnCopiar.Location = new System.Drawing.Point(592, 174);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(130, 40);
            this.btnCopiar.TabIndex = 14;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // frmClaveTemporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnEntendido);
            this.Controls.Add(this.txtConTemp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClaveTemporal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockIt";
            this.Load += new System.EventHandler(this.frmClaveTemporal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEntendido;
        private System.Windows.Forms.Button btnCopiar;
        public System.Windows.Forms.TextBox txtConTemp;
    }
}