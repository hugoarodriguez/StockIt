
namespace StockIt
{
    partial class frmPrincipal
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelSubMenuReportes = new System.Windows.Forms.Panel();
            this.btnReporteVentas = new System.Windows.Forms.Button();
            this.btnReporteReservas = new System.Windows.Forms.Button();
            this.btnReporteClientes = new System.Windows.Forms.Button();
            this.btnReporteProductos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnAggReservas = new System.Windows.Forms.Button();
            this.btnAggClientes = new System.Windows.Forms.Button();
            this.btnAggProductos = new System.Windows.Forms.Button();
            this.btnAggProveedores = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.lblFormOpen = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lklCorreo = new System.Windows.Forms.LinkLabel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelFormularioHijo = new System.Windows.Forms.Panel();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuReportes.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(169)))));
            this.panelSideMenu.Controls.Add(this.btnAcercaDe);
            this.panelSideMenu.Controls.Add(this.lblIdUsuario);
            this.panelSideMenu.Controls.Add(this.btnCerrarSesion);
            this.panelSideMenu.Controls.Add(this.panelSubMenuReportes);
            this.panelSideMenu.Controls.Add(this.btnReportes);
            this.panelSideMenu.Controls.Add(this.btnReservas);
            this.panelSideMenu.Controls.Add(this.btnClientes);
            this.panelSideMenu.Controls.Add(this.btnProductos);
            this.panelSideMenu.Controls.Add(this.btnProveedores);
            this.panelSideMenu.Controls.Add(this.btnAggReservas);
            this.panelSideMenu.Controls.Add(this.btnAggClientes);
            this.panelSideMenu.Controls.Add(this.btnAggProductos);
            this.panelSideMenu.Controls.Add(this.btnAggProveedores);
            this.panelSideMenu.Controls.Add(this.btnCategorias);
            this.panelSideMenu.Controls.Add(this.lblFormOpen);
            this.panelSideMenu.Controls.Add(this.btnInicio);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(251, 1102);
            this.panelSideMenu.TabIndex = 0;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(52, 973);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(82, 17);
            this.lblIdUsuario.TabIndex = 25;
            this.lblIdUsuario.Text = "lblIdUsuario";
            this.lblIdUsuario.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 771);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(251, 46);
            this.btnCerrarSesion.TabIndex = 24;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelSubMenuReportes
            // 
            this.panelSubMenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.panelSubMenuReportes.Controls.Add(this.btnReporteVentas);
            this.panelSubMenuReportes.Controls.Add(this.btnReporteReservas);
            this.panelSubMenuReportes.Controls.Add(this.btnReporteClientes);
            this.panelSubMenuReportes.Controls.Add(this.btnReporteProductos);
            this.panelSubMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuReportes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelSubMenuReportes.Location = new System.Drawing.Point(0, 606);
            this.panelSubMenuReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSubMenuReportes.Name = "panelSubMenuReportes";
            this.panelSubMenuReportes.Size = new System.Drawing.Size(251, 165);
            this.panelSubMenuReportes.TabIndex = 12;
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteVentas.FlatAppearance.BorderSize = 0;
            this.btnReporteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVentas.ForeColor = System.Drawing.Color.White;
            this.btnReporteVentas.Location = new System.Drawing.Point(0, 117);
            this.btnReporteVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReporteVentas.Size = new System.Drawing.Size(251, 39);
            this.btnReporteVentas.TabIndex = 3;
            this.btnReporteVentas.Text = "Ventas";
            this.btnReporteVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteVentas.UseVisualStyleBackColor = true;
            this.btnReporteVentas.Click += new System.EventHandler(this.btnReporteVentas_Click);
            // 
            // btnReporteReservas
            // 
            this.btnReporteReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteReservas.FlatAppearance.BorderSize = 0;
            this.btnReporteReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteReservas.ForeColor = System.Drawing.Color.White;
            this.btnReporteReservas.Location = new System.Drawing.Point(0, 78);
            this.btnReporteReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteReservas.Name = "btnReporteReservas";
            this.btnReporteReservas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReporteReservas.Size = new System.Drawing.Size(251, 39);
            this.btnReporteReservas.TabIndex = 2;
            this.btnReporteReservas.Text = "Reservas";
            this.btnReporteReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteReservas.UseVisualStyleBackColor = true;
            this.btnReporteReservas.Click += new System.EventHandler(this.btnReporteReservas_Click);
            // 
            // btnReporteClientes
            // 
            this.btnReporteClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteClientes.FlatAppearance.BorderSize = 0;
            this.btnReporteClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteClientes.ForeColor = System.Drawing.Color.White;
            this.btnReporteClientes.Location = new System.Drawing.Point(0, 39);
            this.btnReporteClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteClientes.Name = "btnReporteClientes";
            this.btnReporteClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReporteClientes.Size = new System.Drawing.Size(251, 39);
            this.btnReporteClientes.TabIndex = 1;
            this.btnReporteClientes.Text = "Clientes";
            this.btnReporteClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteClientes.UseVisualStyleBackColor = true;
            this.btnReporteClientes.Click += new System.EventHandler(this.btnReporteClientes_Click);
            // 
            // btnReporteProductos
            // 
            this.btnReporteProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteProductos.FlatAppearance.BorderSize = 0;
            this.btnReporteProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteProductos.ForeColor = System.Drawing.Color.White;
            this.btnReporteProductos.Location = new System.Drawing.Point(0, 0);
            this.btnReporteProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteProductos.Name = "btnReporteProductos";
            this.btnReporteProductos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReporteProductos.Size = new System.Drawing.Size(251, 39);
            this.btnReporteProductos.TabIndex = 0;
            this.btnReporteProductos.Text = "Productos";
            this.btnReporteProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteProductos.UseVisualStyleBackColor = true;
            this.btnReporteProductos.Click += new System.EventHandler(this.btnReporteProductos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(0, 560);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(251, 46);
            this.btnReportes.TabIndex = 23;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.Location = new System.Drawing.Point(0, 514);
            this.btnReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnReservas.Size = new System.Drawing.Size(251, 46);
            this.btnReservas.TabIndex = 22;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(0, 468);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(251, 46);
            this.btnClientes.TabIndex = 21;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(0, 422);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(251, 46);
            this.btnProductos.TabIndex = 20;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Location = new System.Drawing.Point(0, 376);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(251, 46);
            this.btnProveedores.TabIndex = 19;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnAggReservas
            // 
            this.btnAggReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAggReservas.FlatAppearance.BorderSize = 0;
            this.btnAggReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggReservas.ForeColor = System.Drawing.Color.White;
            this.btnAggReservas.Location = new System.Drawing.Point(0, 330);
            this.btnAggReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggReservas.Name = "btnAggReservas";
            this.btnAggReservas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnAggReservas.Size = new System.Drawing.Size(251, 46);
            this.btnAggReservas.TabIndex = 18;
            this.btnAggReservas.Text = "Agregar Reservas";
            this.btnAggReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAggReservas.UseVisualStyleBackColor = true;
            this.btnAggReservas.Click += new System.EventHandler(this.btnAggReservas_Click);
            // 
            // btnAggClientes
            // 
            this.btnAggClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAggClientes.FlatAppearance.BorderSize = 0;
            this.btnAggClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggClientes.ForeColor = System.Drawing.Color.White;
            this.btnAggClientes.Location = new System.Drawing.Point(0, 284);
            this.btnAggClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggClientes.Name = "btnAggClientes";
            this.btnAggClientes.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnAggClientes.Size = new System.Drawing.Size(251, 46);
            this.btnAggClientes.TabIndex = 17;
            this.btnAggClientes.Text = "Agregar Clientes";
            this.btnAggClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAggClientes.UseVisualStyleBackColor = true;
            this.btnAggClientes.Click += new System.EventHandler(this.btnAggClientes_Click);
            // 
            // btnAggProductos
            // 
            this.btnAggProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAggProductos.FlatAppearance.BorderSize = 0;
            this.btnAggProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggProductos.ForeColor = System.Drawing.Color.White;
            this.btnAggProductos.Location = new System.Drawing.Point(0, 238);
            this.btnAggProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggProductos.Name = "btnAggProductos";
            this.btnAggProductos.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnAggProductos.Size = new System.Drawing.Size(251, 46);
            this.btnAggProductos.TabIndex = 16;
            this.btnAggProductos.Text = "Agregar Productos";
            this.btnAggProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAggProductos.UseVisualStyleBackColor = true;
            this.btnAggProductos.Click += new System.EventHandler(this.btnAggProductos_Click);
            // 
            // btnAggProveedores
            // 
            this.btnAggProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAggProveedores.FlatAppearance.BorderSize = 0;
            this.btnAggProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggProveedores.ForeColor = System.Drawing.Color.White;
            this.btnAggProveedores.Location = new System.Drawing.Point(0, 192);
            this.btnAggProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggProveedores.Name = "btnAggProveedores";
            this.btnAggProveedores.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnAggProveedores.Size = new System.Drawing.Size(251, 46);
            this.btnAggProveedores.TabIndex = 15;
            this.btnAggProveedores.Text = "Agregar Proveedores";
            this.btnAggProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAggProveedores.UseVisualStyleBackColor = true;
            this.btnAggProveedores.Click += new System.EventHandler(this.btnAggProveedores_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Location = new System.Drawing.Point(0, 146);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(251, 46);
            this.btnCategorias.TabIndex = 14;
            this.btnCategorias.Text = "Administrar Categorías";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnAdmCategorias_Click);
            // 
            // lblFormOpen
            // 
            this.lblFormOpen.AutoSize = true;
            this.lblFormOpen.Location = new System.Drawing.Point(52, 1014);
            this.lblFormOpen.Name = "lblFormOpen";
            this.lblFormOpen.Size = new System.Drawing.Size(89, 17);
            this.lblFormOpen.TabIndex = 13;
            this.lblFormOpen.Text = "lblFormOpen";
            this.lblFormOpen.Visible = false;
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(0, 100);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(251, 46);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(95)))), ((int)(((byte)(134)))));
            this.panelLogo.Controls.Add(this.lklCorreo);
            this.panelLogo.Controls.Add(this.lblNombre);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(251, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // lklCorreo
            // 
            this.lklCorreo.AutoEllipsis = true;
            this.lklCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCorreo.ForeColor = System.Drawing.Color.White;
            this.lklCorreo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklCorreo.LinkColor = System.Drawing.Color.White;
            this.lklCorreo.Location = new System.Drawing.Point(9, 56);
            this.lklCorreo.Name = "lklCorreo";
            this.lklCorreo.Size = new System.Drawing.Size(239, 23);
            this.lklCorreo.TabIndex = 1;
            this.lklCorreo.TabStop = true;
            this.lklCorreo.Text = "correo@gmail.com";
            this.lklCorreo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCorreo_LinkClicked);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(9, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(236, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Apellido";
            // 
            // panelFormularioHijo
            // 
            this.panelFormularioHijo.BackColor = System.Drawing.Color.White;
            this.panelFormularioHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularioHijo.Location = new System.Drawing.Point(251, 0);
            this.panelFormularioHijo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFormularioHijo.Name = "panelFormularioHijo";
            this.panelFormularioHijo.Size = new System.Drawing.Size(1231, 1102);
            this.panelFormularioHijo.TabIndex = 1;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.Color.White;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 817);
            this.btnAcercaDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnAcercaDe.Size = new System.Drawing.Size(251, 46);
            this.btnAcercaDe.TabIndex = 26;
            this.btnAcercaDe.Text = "Acerca De";
            this.btnAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1102);
            this.Controls.Add(this.panelFormularioHijo);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Stock It";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelSubMenuReportes.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelFormularioHijo;
        private System.Windows.Forms.Label lblFormOpen;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnAggReservas;
        private System.Windows.Forms.Button btnAggClientes;
        private System.Windows.Forms.Button btnAggProductos;
        private System.Windows.Forms.Button btnAggProveedores;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelSubMenuReportes;
        private System.Windows.Forms.Button btnReporteVentas;
        private System.Windows.Forms.Button btnReporteReservas;
        private System.Windows.Forms.Button btnReporteClientes;
        private System.Windows.Forms.Button btnReporteProductos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnClientes;
        public System.Windows.Forms.Label lblIdUsuario;
        public System.Windows.Forms.LinkLabel lklCorreo;
        private System.Windows.Forms.Button btnAcercaDe;
    }
}

