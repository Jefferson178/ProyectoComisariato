namespace Comisariato.Formularios
{
    partial class FrmPrincipal
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Administrar Clientes");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Administrar Proveedores");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Administrar Usuarios");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cajas/Talonarios");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Impresion de Factura");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Empresa");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Sucursales");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Administrar Empresas", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Administrar Promociones");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Plan de Cuentas");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Administrar Descuentos");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Administrar Empleados");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Administrar Menu");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Mantenimiento", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Productos");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Categoria Producto");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Creacion de Bodega");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Combo de Productos");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Asignacion de Producto por Bodega");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Inventario", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Ventas");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Compras");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Devolución en Compras");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Devolución en Venta");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Orden de Giro");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Transacciones", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Kardex");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Informes", new System.Windows.Forms.TreeNode[] {
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("ATS");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("SRI", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Enviados");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Recibidos");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Eliminados");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Correo Electrónico", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33});
            this.tvPrincipal = new System.Windows.Forms.TreeView();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.msPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvPrincipal
            // 
            this.tvPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvPrincipal.BackColor = System.Drawing.Color.Bisque;
            this.tvPrincipal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvPrincipal.FullRowSelect = true;
            this.tvPrincipal.Location = new System.Drawing.Point(0, 46);
            this.tvPrincipal.Margin = new System.Windows.Forms.Padding(5);
            this.tvPrincipal.Name = "tvPrincipal";
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Administrar Clientes";
            treeNode2.Name = "Nodo2";
            treeNode2.Text = "Administrar Proveedores";
            treeNode3.Name = "Nodo15";
            treeNode3.Text = "Administrar Usuarios";
            treeNode4.Name = "Nodo1";
            treeNode4.Text = "Cajas/Talonarios";
            treeNode5.Name = "Nodo2";
            treeNode5.Text = "Impresion de Factura";
            treeNode6.Name = "Nodo3";
            treeNode6.Text = "Empresa";
            treeNode7.Name = "Nodo4";
            treeNode7.Text = "Sucursales";
            treeNode8.Name = "Nodo16";
            treeNode8.Text = "Administrar Empresas";
            treeNode9.Name = "Nodo9";
            treeNode9.Text = "Administrar Promociones";
            treeNode10.Name = "Nodo14";
            treeNode10.Text = "Plan de Cuentas";
            treeNode11.Name = "Nodo5";
            treeNode11.Text = "Administrar Descuentos";
            treeNode12.Name = "Nodo0";
            treeNode12.Text = "Administrar Empleados";
            treeNode13.Name = "nodoMenu";
            treeNode13.Text = "Administrar Menu";
            treeNode14.Name = "nodoMantenimiento";
            treeNode14.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode14.Text = "Mantenimiento";
            treeNode15.Name = "Nodo7";
            treeNode15.Text = "Productos";
            treeNode16.Name = "Nodo8";
            treeNode16.Text = "Categoria Producto";
            treeNode17.Name = "Nodo9";
            treeNode17.Text = "Creacion de Bodega";
            treeNode18.Name = "Nodo10";
            treeNode18.Text = "Combo de Productos";
            treeNode19.Name = "Nodo11";
            treeNode19.Text = "Asignacion de Producto por Bodega";
            treeNode20.Name = "nodoInventario";
            treeNode20.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode20.Text = "Inventario";
            treeNode21.Name = "Nodo3";
            treeNode21.Text = "Ventas";
            treeNode22.Name = "Nodo5";
            treeNode22.Text = "Compras";
            treeNode23.Name = "Nodo6";
            treeNode23.Text = "Devolución en Compras";
            treeNode24.Name = "Nodo1";
            treeNode24.Text = "Devolución en Venta";
            treeNode25.Name = "Nodo0";
            treeNode25.Text = "Orden de Giro";
            treeNode26.Name = "nodoTransaccion";
            treeNode26.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode26.Text = "Transacciones";
            treeNode27.Name = "Nodo14";
            treeNode27.Text = "Kardex";
            treeNode28.Name = "nodoInforme";
            treeNode28.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode28.Text = "Informes";
            treeNode29.Name = "Nodo8";
            treeNode29.Text = "ATS";
            treeNode30.Name = "nodoSRI";
            treeNode30.Text = "SRI";
            treeNode31.Name = "Nodo11";
            treeNode31.Text = "Enviados";
            treeNode32.Name = "Nodo12";
            treeNode32.Text = "Recibidos";
            treeNode33.Name = "Nodo13";
            treeNode33.Text = "Eliminados";
            treeNode34.Name = "nodoCorreoElectronico";
            treeNode34.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode34.Text = "Correo Electrónico";
            this.tvPrincipal.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode20,
            treeNode26,
            treeNode28,
            treeNode30,
            treeNode34});
            this.tvPrincipal.Size = new System.Drawing.Size(243, 600);
            this.tvPrincipal.TabIndex = 0;
            this.tvPrincipal.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvPrincipal_NodeMouseClick);
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackColor = System.Drawing.Color.SteelBlue;
            this.msPrincipal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.inicioToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.contactosToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 24);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.msPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msPrincipal.Size = new System.Drawing.Size(1342, 24);
            this.msPrincipal.TabIndex = 1;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = global::Comisariato.Properties.Resources.icono_libro;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 20);
            this.toolStripMenuItem1.Text = "Panel de Contenido";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inicioToolStripMenuItem.Image = global::Comisariato.Properties.Resources.inicio;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Image = global::Comisariato.Properties.Resources.calendario;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.ayudaToolStripMenuItem.Text = "Calendario";
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.contactosToolStripMenuItem.Image = global::Comisariato.Properties.Resources.contactos;
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.contactosToolStripMenuItem.Text = "Contactos";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.emailToolStripMenuItem.Image = global::Comisariato.Properties.Resources.email;
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.emailToolStripMenuItem.Text = "E-mail";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1342, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 17);
            this.lblFecha.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaToolStripMenuItem,
            this.ayudaToolStripMenuItem1,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ventanaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1342, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.tsmCerrarSesion});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // tsmCerrarSesion
            // 
            this.tsmCerrarSesion.Name = "tsmCerrarSesion";
            this.tsmCerrarSesion.Size = new System.Drawing.Size(182, 22);
            this.tsmCerrarSesion.Text = "Cerrar Sesion";
            this.tsmCerrarSesion.Click += new System.EventHandler(this.tsmCerrarSesion_Click_1);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.AutoScroll = true;
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPrincipal.Location = new System.Drawing.Point(243, 46);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(5);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1099, 600);
            this.panelPrincipal.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 662);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tvPrincipal);
            this.Controls.Add(this.msPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "AirControl System ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvPrincipal;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCerrarSesion;
    }
}