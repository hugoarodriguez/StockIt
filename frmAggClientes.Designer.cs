
namespace StockIt
{
    partial class frmAggClientes
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
            this.btnCImagen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomClie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApeClie = new System.Windows.Forms.TextBox();
            this.cbxSexoClie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumClie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreoClie = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pbxImgClie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgClie)).BeginInit();
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
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCImagen
            // 
            this.btnCImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(169)))));
            this.btnCImagen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCImagen.ForeColor = System.Drawing.Color.White;
            this.btnCImagen.Location = new System.Drawing.Point(317, 149);
            this.btnCImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnCImagen.Name = "btnCImagen";
            this.btnCImagen.Size = new System.Drawing.Size(98, 32);
            this.btnCImagen.TabIndex = 2;
            this.btnCImagen.Text = "Seleccionar";
            this.btnCImagen.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombres";
            // 
            // txtNomClie
            // 
            this.txtNomClie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtNomClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomClie.Location = new System.Drawing.Point(135, 269);
            this.txtNomClie.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomClie.Name = "txtNomClie";
            this.txtNomClie.Size = new System.Drawing.Size(601, 26);
            this.txtNomClie.TabIndex = 6;
            this.txtNomClie.TextChanged += new System.EventHandler(this.txtNomProd_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellidos";
            // 
            // txtApeClie
            // 
            this.txtApeClie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApeClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtApeClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeClie.Location = new System.Drawing.Point(135, 328);
            this.txtApeClie.Margin = new System.Windows.Forms.Padding(2);
            this.txtApeClie.Name = "txtApeClie";
            this.txtApeClie.Size = new System.Drawing.Size(601, 26);
            this.txtApeClie.TabIndex = 8;
            this.txtApeClie.TextChanged += new System.EventHandler(this.txtNomProd_TextChanged_1);
            // 
            // cbxSexoClie
            // 
            this.cbxSexoClie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSexoClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.cbxSexoClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexoClie.FormattingEnabled = true;
            this.cbxSexoClie.Location = new System.Drawing.Point(135, 388);
            this.cbxSexoClie.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSexoClie.Name = "cbxSexoClie";
            this.cbxSexoClie.Size = new System.Drawing.Size(151, 28);
            this.cbxSexoClie.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 428);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Número de teléfono";
            // 
            // txtNumClie
            // 
            this.txtNumClie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtNumClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumClie.Location = new System.Drawing.Point(135, 450);
            this.txtNumClie.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumClie.Name = "txtNumClie";
            this.txtNumClie.Size = new System.Drawing.Size(601, 26);
            this.txtNumClie.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 487);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Correo electrónico";
            // 
            // txtCorreoClie
            // 
            this.txtCorreoClie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreoClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtCorreoClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoClie.Location = new System.Drawing.Point(135, 509);
            this.txtCorreoClie.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoClie.Name = "txtCorreoClie";
            this.txtCorreoClie.Size = new System.Drawing.Size(601, 26);
            this.txtCorreoClie.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(494, 592);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 32);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(184)))), ((int)(((byte)(81)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(358, 592);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 32);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // pbxImgClie
            // 
            this.pbxImgClie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxImgClie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImgClie.Image = global::StockIt.Properties.Resources.noImage;
            this.pbxImgClie.Location = new System.Drawing.Point(135, 84);
            this.pbxImgClie.Margin = new System.Windows.Forms.Padding(2);
            this.pbxImgClie.MaximumSize = new System.Drawing.Size(136, 147);
            this.pbxImgClie.MinimumSize = new System.Drawing.Size(136, 147);
            this.pbxImgClie.Name = "pbxImgClie";
            this.pbxImgClie.Size = new System.Drawing.Size(136, 147);
            this.pbxImgClie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImgClie.TabIndex = 3;
            this.pbxImgClie.TabStop = false;
            // 
            // frmAggClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 788);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCorreoClie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumClie);
            this.Controls.Add(this.cbxSexoClie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApeClie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomClie);
            this.Controls.Add(this.btnCImagen);
            this.Controls.Add(this.pbxImgClie);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAggClientes";
            this.Text = "frmAggClientes";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgClie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCImagen;
        private System.Windows.Forms.PictureBox pbxImgClie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomClie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApeClie;
        private System.Windows.Forms.ComboBox cbxSexoClie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumClie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreoClie;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
    }
}