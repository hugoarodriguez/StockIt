
namespace StockIt.CustomControls
{
    partial class ProductoCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxImgProd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomProd = new System.Windows.Forms.Label();
            this.lblCatProd = new System.Windows.Forms.Label();
            this.lblCanProd = new System.Windows.Forms.Label();
            this.lblPreProd = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImgProd
            // 
            this.pbxImgProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImgProd.Location = new System.Drawing.Point(17, 15);
            this.pbxImgProd.Name = "pbxImgProd";
            this.pbxImgProd.Size = new System.Drawing.Size(150, 150);
            this.pbxImgProd.TabIndex = 0;
            this.pbxImgProd.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNomProd
            // 
            this.lblNomProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomProd.AutoEllipsis = true;
            this.lblNomProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProd.Location = new System.Drawing.Point(288, 15);
            this.lblNomProd.Name = "lblNomProd";
            this.lblNomProd.Size = new System.Drawing.Size(500, 23);
            this.lblNomProd.TabIndex = 5;
            this.lblNomProd.Text = "Producto";
            this.lblNomProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCatProd
            // 
            this.lblCatProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCatProd.AutoEllipsis = true;
            this.lblCatProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatProd.Location = new System.Drawing.Point(288, 57);
            this.lblCatProd.Name = "lblCatProd";
            this.lblCatProd.Size = new System.Drawing.Size(500, 23);
            this.lblCatProd.TabIndex = 6;
            this.lblCatProd.Text = "Categoría";
            this.lblCatProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCanProd
            // 
            this.lblCanProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCanProd.AutoEllipsis = true;
            this.lblCanProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanProd.Location = new System.Drawing.Point(288, 99);
            this.lblCanProd.Name = "lblCanProd";
            this.lblCanProd.Size = new System.Drawing.Size(500, 23);
            this.lblCanProd.TabIndex = 7;
            this.lblCanProd.Text = "Cantidad";
            this.lblCanProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPreProd
            // 
            this.lblPreProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreProd.AutoEllipsis = true;
            this.lblPreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreProd.Location = new System.Drawing.Point(288, 141);
            this.lblPreProd.Name = "lblPreProd";
            this.lblPreProd.Size = new System.Drawing.Size(500, 23);
            this.lblPreProd.TabIndex = 8;
            this.lblPreProd.Text = "Precio";
            this.lblPreProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(120)))), ((int)(((byte)(217)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(813, 40);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 40);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(813, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 40);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ProductoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblPreProd);
            this.Controls.Add(this.lblCanProd);
            this.Controls.Add(this.lblCatProd);
            this.Controls.Add(this.lblNomProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxImgProd);
            this.Name = "ProductoCard";
            this.Size = new System.Drawing.Size(968, 180);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImgProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomProd;
        private System.Windows.Forms.Label lblCatProd;
        private System.Windows.Forms.Label lblCanProd;
        private System.Windows.Forms.Label lblPreProd;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
