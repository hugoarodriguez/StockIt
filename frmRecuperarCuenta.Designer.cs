
namespace StockIt
{
    partial class frmRecuperarCuenta
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.picturVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Correo Electrónico";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(491, 452);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(500, 30);
            this.txtUsuario.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 150, 0, 0);
            this.label1.Size = new System.Drawing.Size(1482, 213);
            this.label1.TabIndex = 8;
            this.label1.Text = "Recuperar Tu Cuenta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSolicitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(169)))));
            this.btnSolicitar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitar.ForeColor = System.Drawing.Color.White;
            this.btnSolicitar.Location = new System.Drawing.Point(676, 507);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(130, 40);
            this.btnSolicitar.TabIndex = 11;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = false;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Favor, indicar tu email. ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(486, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 102);
            this.label4.TabIndex = 13;
            this.label4.Text = "Se te asignará una contraseña temporal, deberás cambiarla al iniciar sesión nueva" +
    "mente";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Image = global::StockIt.Properties.Resources.backButton1;
            this.btnVolver.Location = new System.Drawing.Point(57, 45);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(64, 64);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 14;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            this.btnVolver.MouseLeave += new System.EventHandler(this.btnVolver_MouseLeave);
            this.btnVolver.MouseHover += new System.EventHandler(this.btnVolver_MouseHover);
            // 
            // picturVolver
            // 
            this.picturVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picturVolver.Location = new System.Drawing.Point(66, 71);
            this.picturVolver.Name = "picturVolver";
            this.picturVolver.Size = new System.Drawing.Size(64, 64);
            this.picturVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturVolver.TabIndex = 14;
            this.picturVolver.TabStop = false;
            // 
            // frmRecuperarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuperarCuenta";
            this.Text = "frmRecuperarCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picturVolver;
        private System.Windows.Forms.PictureBox btnVolver;
    }
}