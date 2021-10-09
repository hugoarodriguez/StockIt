﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt
{
    public partial class frmAggProductos : Form
    {

        public frmAggProductos()
        {
            InitializeComponent();
            
        }

        private void frmAggProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Preguntar si desea cancelar
            limpiarControles();
        }

        private void btnSImagen_Click(object sender, EventArgs e)
        {
            //Abrimos un FileDialog
            OpenFileDialog open = new OpenFileDialog();
            //Establecemos los filtros de tupos de imágenes
            open.Filter = "Archivos de Imagen(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Mostramos la imagen en el PictureBox
                pbxImgProd.Image = new Bitmap(open.FileName);
                // image file path  
                //txtNomProd.Text = open.FileName;

                //Convertir Imagen a byte[] en la Capa Lógica
            }
        }

        //Limpia los controles del formulario
        private void limpiarControles()
        {
            pbxImgProd.Image = StockIt.Properties.Resources.noImage;
            txtNomProd.Text = null;
            nudCanProd.Value = 0;
            //cbxCatProd.SelectedIndex = 0;
            mskPreProd.Text = null;
            txtDetProd.Text = null;
        }
    }
}
