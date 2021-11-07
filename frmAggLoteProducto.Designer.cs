
namespace StockIt
{
    partial class frmAggLoteProducto
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxImgProd = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarLote = new System.Windows.Forms.Button();
            this.txtPrecVenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecUnitario = new System.Windows.Forms.TextBox();
            this.mskPrecLote = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.mskPorGanancia = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCanProd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.ttSelImagen = new System.Windows.Forms.ToolTip(this.components);
            this.ttActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.ttCancelar = new System.Windows.Forms.ToolTip(this.components);
            this.txtCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCanProd)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Text = "Agregar Nuevo Lote de Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxImgProd
            // 
            this.pbxImgProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxImgProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImgProd.Image = global::StockIt.Properties.Resources.noImage;
            this.pbxImgProd.Location = new System.Drawing.Point(215, 150);
            this.pbxImgProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxImgProd.Name = "pbxImgProd";
            this.pbxImgProd.Size = new System.Drawing.Size(160, 160);
            this.pbxImgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImgProd.TabIndex = 14;
            this.pbxImgProd.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(554, 760);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 39);
            this.btnLimpiar.TabIndex = 47;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(722, 760);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 39);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarLote
            // 
            this.btnAgregarLote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(120)))), ((int)(((byte)(217)))));
            this.btnAgregarLote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLote.ForeColor = System.Drawing.Color.White;
            this.btnAgregarLote.Location = new System.Drawing.Point(386, 760);
            this.btnAgregarLote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarLote.Name = "btnAgregarLote";
            this.btnAgregarLote.Size = new System.Drawing.Size(131, 39);
            this.btnAgregarLote.TabIndex = 45;
            this.btnAgregarLote.Text = "Agregar";
            this.btnAgregarLote.UseVisualStyleBackColor = false;
            this.btnAgregarLote.Click += new System.EventHandler(this.btnAgregarLote_Click);
            // 
            // txtPrecVenta
            // 
            this.txtPrecVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtPrecVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecVenta.Location = new System.Drawing.Point(815, 610);
            this.txtPrecVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecVenta.Name = "txtPrecVenta";
            this.txtPrecVenta.ReadOnly = true;
            this.txtPrecVenta.Size = new System.Drawing.Size(200, 30);
            this.txtPrecVenta.TabIndex = 60;
            this.txtPrecVenta.Text = "$0.00";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(815, 580);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 68;
            this.label11.Text = "Precio Venta";
            // 
            // txtPrecUnitario
            // 
            this.txtPrecUnitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtPrecUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecUnitario.Location = new System.Drawing.Point(815, 530);
            this.txtPrecUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecUnitario.Name = "txtPrecUnitario";
            this.txtPrecUnitario.ReadOnly = true;
            this.txtPrecUnitario.Size = new System.Drawing.Size(200, 30);
            this.txtPrecUnitario.TabIndex = 55;
            this.txtPrecUnitario.Text = "$0.00";
            // 
            // mskPrecLote
            // 
            this.mskPrecLote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskPrecLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.mskPrecLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPrecLote.Location = new System.Drawing.Point(515, 530);
            this.mskPrecLote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskPrecLote.Mask = "$000000.00";
            this.mskPrecLote.Name = "mskPrecLote";
            this.mskPrecLote.PromptChar = '0';
            this.mskPrecLote.Size = new System.Drawing.Size(200, 30);
            this.mskPrecLote.TabIndex = 54;
            this.mskPrecLote.TextChanged += new System.EventHandler(this.mskPrecLote_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(515, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 67;
            this.label10.Text = "Precio Lote";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(211, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(215, 370);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(350, 30);
            this.txtProveedor.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(515, 580);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Ganancia ($)";
            // 
            // txtGanancia
            // 
            this.txtGanancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanancia.Location = new System.Drawing.Point(515, 610);
            this.txtGanancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.ReadOnly = true;
            this.txtGanancia.Size = new System.Drawing.Size(200, 30);
            this.txtGanancia.TabIndex = 58;
            this.txtGanancia.Text = "$0.00";
            // 
            // mskPorGanancia
            // 
            this.mskPorGanancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskPorGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.mskPorGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPorGanancia.Location = new System.Drawing.Point(215, 610);
            this.mskPorGanancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskPorGanancia.Mask = "000";
            this.mskPorGanancia.Name = "mskPorGanancia";
            this.mskPorGanancia.Size = new System.Drawing.Size(200, 30);
            this.mskPorGanancia.TabIndex = 57;
            this.mskPorGanancia.ValidatingType = typeof(int);
            this.mskPorGanancia.TextChanged += new System.EventHandler(this.mskPorGanancia_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Porcentaje de Ganancia";
            // 
            // nudCanProd
            // 
            this.nudCanProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudCanProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.nudCanProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCanProd.Location = new System.Drawing.Point(215, 530);
            this.nudCanProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCanProd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCanProd.Name = "nudCanProd";
            this.nudCanProd.Size = new System.Drawing.Size(200, 30);
            this.nudCanProd.TabIndex = 51;
            this.nudCanProd.ValueChanged += new System.EventHandler(this.nudCanProd_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(665, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Categoría";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 660);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Detalles Adicionales";
            // 
            // txtDetProd
            // 
            this.txtDetProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDetProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtDetProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetProd.Location = new System.Drawing.Point(215, 690);
            this.txtDetProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetProd.Name = "txtDetProd";
            this.txtDetProd.ReadOnly = true;
            this.txtDetProd.Size = new System.Drawing.Size(800, 30);
            this.txtDetProd.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(815, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Precio Unitario";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nombre de Producto";
            // 
            // txtNomProd
            // 
            this.txtNomProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtNomProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProd.Location = new System.Drawing.Point(215, 450);
            this.txtNomProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.ReadOnly = true;
            this.txtNomProd.Size = new System.Drawing.Size(800, 30);
            this.txtNomProd.TabIndex = 50;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(665, 370);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(350, 30);
            this.txtCategoria.TabIndex = 69;
            // 
            // frmAggLoteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 1102);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtPrecVenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPrecUnitario);
            this.Controls.Add(this.mskPrecLote);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGanancia);
            this.Controls.Add(this.mskPorGanancia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudCanProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDetProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomProd);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarLote);
            this.Controls.Add(this.pbxImgProd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAggLoteProducto";
            this.Text = "frmModificarProductos";
            this.Load += new System.EventHandler(this.frmModificarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCanProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarLote;
        private System.Windows.Forms.TextBox txtPrecVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecUnitario;
        private System.Windows.Forms.MaskedTextBox mskPrecLote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.MaskedTextBox mskPorGanancia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCanProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomProd;
        private System.Windows.Forms.ToolTip ttSelImagen;
        private System.Windows.Forms.ToolTip ttActualizar;
        private System.Windows.Forms.ToolTip ttLimpiar;
        private System.Windows.Forms.ToolTip ttCancelar;
        private System.Windows.Forms.TextBox txtCategoria;
        public System.Windows.Forms.PictureBox pbxImgProd;
    }
}