
namespace StockIt.CustomControls
{
    partial class ClienteCard
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblSexClie = new System.Windows.Forms.Label();
            this.lblCorrClie = new System.Windows.Forms.Label();
            this.lblTelClie = new System.Windows.Forms.Label();
            this.lblNomClie = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxImgClie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgClie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(613, 80);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 32);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(169)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(613, 32);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 32);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblSexClie
            // 
            this.lblSexClie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSexClie.AutoEllipsis = true;
            this.lblSexClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexClie.Location = new System.Drawing.Point(219, 115);
            this.lblSexClie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexClie.Name = "lblSexClie";
            this.lblSexClie.Size = new System.Drawing.Size(375, 19);
            this.lblSexClie.TabIndex = 24;
            this.lblSexClie.Text = "Sexo";
            this.lblSexClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorrClie
            // 
            this.lblCorrClie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorrClie.AutoEllipsis = true;
            this.lblCorrClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrClie.Location = new System.Drawing.Point(219, 80);
            this.lblCorrClie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorrClie.Name = "lblCorrClie";
            this.lblCorrClie.Size = new System.Drawing.Size(375, 19);
            this.lblCorrClie.TabIndex = 23;
            this.lblCorrClie.Text = "Correo";
            this.lblCorrClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelClie
            // 
            this.lblTelClie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelClie.AutoEllipsis = true;
            this.lblTelClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelClie.Location = new System.Drawing.Point(219, 46);
            this.lblTelClie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelClie.Name = "lblTelClie";
            this.lblTelClie.Size = new System.Drawing.Size(375, 19);
            this.lblTelClie.TabIndex = 22;
            this.lblTelClie.Text = "Teléfono";
            this.lblTelClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNomClie
            // 
            this.lblNomClie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomClie.AutoEllipsis = true;
            this.lblNomClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClie.Location = new System.Drawing.Point(219, 12);
            this.lblNomClie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomClie.Name = "lblNomClie";
            this.lblNomClie.Size = new System.Drawing.Size(375, 19);
            this.lblNomClie.TabIndex = 21;
            this.lblNomClie.Text = "Nombre";
            this.lblNomClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sexo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Correo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Teléfono:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxImgClie
            // 
            this.pbxImgClie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImgClie.Location = new System.Drawing.Point(16, 12);
            this.pbxImgClie.Margin = new System.Windows.Forms.Padding(2);
            this.pbxImgClie.Name = "pbxImgClie";
            this.pbxImgClie.Size = new System.Drawing.Size(113, 122);
            this.pbxImgClie.TabIndex = 16;
            this.pbxImgClie.TabStop = false;
            // 
            // ClienteCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblSexClie);
            this.Controls.Add(this.lblCorrClie);
            this.Controls.Add(this.lblTelClie);
            this.Controls.Add(this.lblNomClie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxImgClie);
            this.Name = "ClienteCard";
            this.Size = new System.Drawing.Size(726, 146);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgClie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblSexClie;
        private System.Windows.Forms.Label lblCorrClie;
        private System.Windows.Forms.Label lblTelClie;
        private System.Windows.Forms.Label lblNomClie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxImgClie;
    }
}
