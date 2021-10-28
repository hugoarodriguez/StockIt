
namespace StockIt
{
    partial class frmAggReserva
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnSelCliente = new System.Windows.Forms.Button();
            this.flpListadoProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTotalReserva = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecEntrega = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.lklCambiarVista = new System.Windows.Forms.LinkLabel();
            this.ttCambiarVista = new System.Windows.Forms.ToolTip(this.components);
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
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar Reserva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(70, 180);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(710, 30);
            this.txtCliente.TabIndex = 6;
            // 
            // btnSelCliente
            // 
            this.btnSelCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(169)))));
            this.btnSelCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelCliente.ForeColor = System.Drawing.Color.White;
            this.btnSelCliente.Location = new System.Drawing.Point(800, 176);
            this.btnSelCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelCliente.Name = "btnSelCliente";
            this.btnSelCliente.Size = new System.Drawing.Size(50, 39);
            this.btnSelCliente.TabIndex = 8;
            this.btnSelCliente.Text = "...";
            this.btnSelCliente.UseVisualStyleBackColor = false;
            this.btnSelCliente.Click += new System.EventHandler(this.btnSelCliente_Click);
            // 
            // flpListadoProductos
            // 
            this.flpListadoProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpListadoProductos.AutoScroll = true;
            this.flpListadoProductos.Location = new System.Drawing.Point(70, 290);
            this.flpListadoProductos.Name = "flpListadoProductos";
            this.flpListadoProductos.Size = new System.Drawing.Size(810, 520);
            this.flpListadoProductos.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(184)))), ((int)(((byte)(81)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(935, 687);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 39);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(935, 737);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 39);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTotalReserva
            // 
            this.lblTotalReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalReserva.AutoEllipsis = true;
            this.lblTotalReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReserva.Location = new System.Drawing.Point(959, 290);
            this.lblTotalReserva.Name = "lblTotalReserva";
            this.lblTotalReserva.Size = new System.Drawing.Size(229, 23);
            this.lblTotalReserva.TabIndex = 32;
            this.lblTotalReserva.Text = "$0.00";
            this.lblTotalReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(900, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(900, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Fecha Entrega:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFecEntrega
            // 
            this.dtpFecEntrega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecEntrega.CustomFormat = "yyyy-MM-dd";
            this.dtpFecEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecEntrega.Location = new System.Drawing.Point(900, 367);
            this.dtpFecEntrega.Name = "dtpFecEntrega";
            this.dtpFecEntrega.Size = new System.Drawing.Size(200, 30);
            this.dtpFecEntrega.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(900, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Comentarios:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarios.Location = new System.Drawing.Point(900, 451);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComentarios.MaximumSize = new System.Drawing.Size(200, 200);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(200, 200);
            this.txtComentarios.TabIndex = 36;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(137, 150);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(74, 20);
            this.lblIdCliente.TabIndex = 37;
            this.lblIdCliente.Text = "IdCliente";
            this.lblIdCliente.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Búscar producto por nombre";
            // 
            // txtNomProd
            // 
            this.txtNomProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtNomProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProd.Location = new System.Drawing.Point(70, 255);
            this.txtNomProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(780, 30);
            this.txtNomProd.TabIndex = 38;
            this.txtNomProd.TextChanged += new System.EventHandler(this.txtNomProd_TextChanged);
            // 
            // lklCambiarVista
            // 
            this.lklCambiarVista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lklCambiarVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCambiarVista.ForeColor = System.Drawing.Color.White;
            this.lklCambiarVista.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lklCambiarVista.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(120)))), ((int)(((byte)(217)))));
            this.lklCambiarVista.Location = new System.Drawing.Point(900, 255);
            this.lklCambiarVista.Name = "lklCambiarVista";
            this.lklCambiarVista.Size = new System.Drawing.Size(196, 23);
            this.lklCambiarVista.TabIndex = 40;
            this.lklCambiarVista.TabStop = true;
            this.lklCambiarVista.Text = "Cambiar Vista";
            this.lklCambiarVista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lklCambiarVista.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCambiarVista_LinkClicked);
            // 
            // frmAggReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 1102);
            this.Controls.Add(this.lklCambiarVista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomProd);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecEntrega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalReserva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.flpListadoProductos);
            this.Controls.Add(this.btnSelCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAggReserva";
            this.Text = "frmAgregarReserva";
            this.Load += new System.EventHandler(this.frmAggReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnSelCliente;
        private System.Windows.Forms.FlowLayoutPanel flpListadoProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTotalReserva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecEntrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomProd;
        private System.Windows.Forms.LinkLabel lklCambiarVista;
        private System.Windows.Forms.ToolTip ttCambiarVista;
    }
}