
namespace StockIt
{
    partial class frmModificarProductos
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
            this.mskPreProd = new System.Windows.Forms.MaskedTextBox();
            this.nudCanProd = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxCatProd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.btnSImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxImgProd = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCanProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // mskPreProd
            // 
            this.mskPreProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskPreProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.mskPreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPreProd.Location = new System.Drawing.Point(180, 610);
            this.mskPreProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskPreProd.Mask = "$999999.99";
            this.mskPreProd.Name = "mskPreProd";
            this.mskPreProd.Size = new System.Drawing.Size(200, 30);
            this.mskPreProd.TabIndex = 18;
            // 
            // nudCanProd
            // 
            this.nudCanProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudCanProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.nudCanProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCanProd.Location = new System.Drawing.Point(180, 450);
            this.nudCanProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCanProd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCanProd.Name = "nudCanProd";
            this.nudCanProd.Size = new System.Drawing.Size(200, 30);
            this.nudCanProd.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(659, 760);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 39);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxCatProd
            // 
            this.cbxCatProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCatProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.cbxCatProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCatProd.FormattingEnabled = true;
            this.cbxCatProd.Location = new System.Drawing.Point(180, 530);
            this.cbxCatProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCatProd.Name = "cbxCatProd";
            this.cbxCatProd.Size = new System.Drawing.Size(200, 33);
            this.cbxCatProd.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Categoría";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 660);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Detalles Adicionales (Opcional)";
            // 
            // txtDetProd
            // 
            this.txtDetProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDetProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtDetProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetProd.Location = new System.Drawing.Point(180, 690);
            this.txtDetProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetProd.Name = "txtDetProd";
            this.txtDetProd.Size = new System.Drawing.Size(800, 30);
            this.txtDetProd.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Precio Producto";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre de Producto";
            // 
            // txtNomProd
            // 
            this.txtNomProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtNomProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProd.Location = new System.Drawing.Point(180, 370);
            this.txtNomProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(800, 30);
            this.txtNomProd.TabIndex = 15;
            // 
            // btnSImagen
            // 
            this.btnSImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(169)))));
            this.btnSImagen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSImagen.ForeColor = System.Drawing.Color.White;
            this.btnSImagen.Location = new System.Drawing.Point(423, 226);
            this.btnSImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSImagen.Name = "btnSImagen";
            this.btnSImagen.Size = new System.Drawing.Size(131, 39);
            this.btnSImagen.TabIndex = 13;
            this.btnSImagen.Text = "Seleccionar";
            this.btnSImagen.UseVisualStyleBackColor = false;
            this.btnSImagen.Click += new System.EventHandler(this.btnSImagen_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(1231, 70);
            this.label1.TabIndex = 12;
            this.label1.Text = "Modificar Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxImgProd
            // 
            this.pbxImgProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxImgProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImgProd.Image = global::StockIt.Properties.Resources.noImage;
            this.pbxImgProd.Location = new System.Drawing.Point(180, 150);
            this.pbxImgProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxImgProd.Name = "pbxImgProd";
            this.pbxImgProd.Size = new System.Drawing.Size(160, 160);
            this.pbxImgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImgProd.TabIndex = 14;
            this.pbxImgProd.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(120)))), ((int)(((byte)(217)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(477, 760);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(131, 39);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmModificarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 1102);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.mskPreProd);
            this.Controls.Add(this.nudCanProd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbxCatProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDetProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomProd);
            this.Controls.Add(this.btnSImagen);
            this.Controls.Add(this.pbxImgProd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarProductos";
            this.Text = "frmModificarProductos";
            this.Load += new System.EventHandler(this.frmModificarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCanProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskPreProd;
        private System.Windows.Forms.NumericUpDown nudCanProd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxCatProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomProd;
        private System.Windows.Forms.Button btnSImagen;
        private System.Windows.Forms.PictureBox pbxImgProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
    }
}