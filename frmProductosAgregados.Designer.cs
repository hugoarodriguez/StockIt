
namespace StockIt
{
    partial class frmProductosAgregados
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductosSeleccionados = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(672, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Haz doble click en la columna vacía que aparece al principio del producto para el" +
    "iminarlo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1061, 104);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 39);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.label1.Size = new System.Drawing.Size(1482, 70);
            this.label1.TabIndex = 20;
            this.label1.Text = "Productos de esta Compra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvProductosSeleccionados
            // 
            this.dgvProductosSeleccionados.AllowUserToAddRows = false;
            this.dgvProductosSeleccionados.AllowUserToDeleteRows = false;
            this.dgvProductosSeleccionados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProductosSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosSeleccionados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.dgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosSeleccionados.Location = new System.Drawing.Point(241, 224);
            this.dgvProductosSeleccionados.Name = "dgvProductosSeleccionados";
            this.dgvProductosSeleccionados.ReadOnly = true;
            this.dgvProductosSeleccionados.RowHeadersWidth = 51;
            this.dgvProductosSeleccionados.RowTemplate.Height = 24;
            this.dgvProductosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosSeleccionados.Size = new System.Drawing.Size(1000, 580);
            this.dgvProductosSeleccionados.TabIndex = 19;
            this.dgvProductosSeleccionados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosSeleccionados_CellDoubleClick);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(169)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(894, 104);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(131, 39);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmProductosAgregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 1102);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductosSeleccionados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductosAgregados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductosAgregados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSeleccionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvProductosSeleccionados;
        private System.Windows.Forms.Button btnConfirmar;
    }
}