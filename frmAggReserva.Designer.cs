﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnSelCliente = new System.Windows.Forms.Button();
            this.flpListadoProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecEntrega = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
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
            this.label2.Location = new System.Drawing.Point(213, 150);
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
            this.txtCliente.Location = new System.Drawing.Point(217, 180);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(720, 30);
            this.txtCliente.TabIndex = 6;
            // 
            // btnSelCliente
            // 
            this.btnSelCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(169)))));
            this.btnSelCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelCliente.ForeColor = System.Drawing.Color.White;
            this.btnSelCliente.Location = new System.Drawing.Point(967, 176);
            this.btnSelCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelCliente.Name = "btnSelCliente";
            this.btnSelCliente.Size = new System.Drawing.Size(50, 39);
            this.btnSelCliente.TabIndex = 8;
            this.btnSelCliente.Text = "...";
            this.btnSelCliente.UseVisualStyleBackColor = false;
            // 
            // flpListadoProductos
            // 
            this.flpListadoProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpListadoProductos.AutoScroll = true;
            this.flpListadoProductos.Location = new System.Drawing.Point(50, 233);
            this.flpListadoProductos.Name = "flpListadoProductos";
            this.flpListadoProductos.Size = new System.Drawing.Size(830, 580);
            this.flpListadoProductos.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(184)))), ((int)(((byte)(81)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(900, 630);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 39);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(900, 680);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 39);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubTotal.AutoEllipsis = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(1038, 233);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(150, 23);
            this.lblSubTotal.TabIndex = 32;
            this.lblSubTotal.Text = "$0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(900, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(900, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Fecha Entrega:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFecEntrega
            // 
            this.dtpFecEntrega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecEntrega.Location = new System.Drawing.Point(900, 310);
            this.dtpFecEntrega.Name = "dtpFecEntrega";
            this.dtpFecEntrega.Size = new System.Drawing.Size(200, 30);
            this.dtpFecEntrega.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(900, 369);
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
            this.txtComentarios.Location = new System.Drawing.Point(900, 394);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComentarios.MaximumSize = new System.Drawing.Size(200, 200);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(200, 200);
            this.txtComentarios.TabIndex = 36;
            // 
            // frmAggReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 1102);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecEntrega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSubTotal);
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
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecEntrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComentarios;
    }
}