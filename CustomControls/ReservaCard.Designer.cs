
namespace StockIt.CustomControls
{
    partial class ReservaCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblFReserva = new System.Windows.Forms.Label();
            this.lblTelClie = new System.Windows.Forms.Label();
            this.lblNomClie = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFPromesaEntrega = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMontoReserva = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(816, 124);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 39);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(120)))), ((int)(((byte)(217)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(816, 14);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(131, 39);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblFReserva
            // 
            this.lblFReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFReserva.AutoEllipsis = true;
            this.lblFReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFReserva.Location = new System.Drawing.Point(160, 97);
            this.lblFReserva.Name = "lblFReserva";
            this.lblFReserva.Size = new System.Drawing.Size(120, 23);
            this.lblFReserva.TabIndex = 22;
            this.lblFReserva.Text = "dd-MM-yyyy";
            this.lblFReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelClie
            // 
            this.lblTelClie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelClie.AutoEllipsis = true;
            this.lblTelClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelClie.Location = new System.Drawing.Point(160, 54);
            this.lblTelClie.Name = "lblTelClie";
            this.lblTelClie.Size = new System.Drawing.Size(500, 23);
            this.lblTelClie.TabIndex = 21;
            this.lblTelClie.Text = "7589-8968";
            this.lblTelClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNomClie
            // 
            this.lblNomClie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomClie.AutoEllipsis = true;
            this.lblNomClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClie.Location = new System.Drawing.Point(160, 14);
            this.lblNomClie.Name = "lblNomClie";
            this.lblNomClie.Size = new System.Drawing.Size(500, 23);
            this.lblNomClie.TabIndex = 20;
            this.lblNomClie.Text = "Producto";
            this.lblNomClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "F. Reserva:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Teléfono:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFPromesaEntrega
            // 
            this.lblFPromesaEntrega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFPromesaEntrega.AutoEllipsis = true;
            this.lblFPromesaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPromesaEntrega.Location = new System.Drawing.Point(570, 97);
            this.lblFPromesaEntrega.Name = "lblFPromesaEntrega";
            this.lblFPromesaEntrega.Size = new System.Drawing.Size(150, 23);
            this.lblFPromesaEntrega.TabIndex = 26;
            this.lblFPromesaEntrega.Text = "dd-MM-yyyy";
            this.lblFPromesaEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "F. Promesa Entrega:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Monto:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontoReserva
            // 
            this.lblMontoReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMontoReserva.AutoEllipsis = true;
            this.lblMontoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoReserva.Location = new System.Drawing.Point(160, 141);
            this.lblMontoReserva.Name = "lblMontoReserva";
            this.lblMontoReserva.Size = new System.Drawing.Size(500, 23);
            this.lblMontoReserva.TabIndex = 28;
            this.lblMontoReserva.Text = "$0.00";
            this.lblMontoReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(184)))), ((int)(((byte)(81)))));
            this.btnFacturar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Location = new System.Drawing.Point(816, 69);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(131, 39);
            this.btnFacturar.TabIndex = 29;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // ReservaCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.lblMontoReserva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFPromesaEntrega);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblFReserva);
            this.Controls.Add(this.lblTelClie);
            this.Controls.Add(this.lblNomClie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservaCard";
            this.Size = new System.Drawing.Size(965, 177);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblFReserva;
        private System.Windows.Forms.Label lblTelClie;
        private System.Windows.Forms.Label lblNomClie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFPromesaEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMontoReserva;
        private System.Windows.Forms.Button btnFacturar;
    }
}
