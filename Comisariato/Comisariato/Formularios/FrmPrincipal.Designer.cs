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
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Administrar Clientes");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Administrar Proveedores");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Administrar Usuarios");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Cajas/Talonarios");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Impresion de Factura");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Empresa");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Sucursales");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Administrar Empresas", new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode71,
            treeNode72,
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Administrar Promociones");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Plan de Cuentas");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Administrar Descuentos");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Administrar Empleados");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Mantenimiento", new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode68,
            treeNode69,
            treeNode74,
            treeNode75,
            treeNode76,
            treeNode77,
            treeNode78});
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Productos");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Categoria Producto");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Creacion de Bodega");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Combo de Productos");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Asignacion de Producto por Bodega");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Inventario", new System.Windows.Forms.TreeNode[] {
            treeNode80,
            treeNode81,
            treeNode82,
            treeNode83,
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Ventas");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Compras");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Devolución en Compras");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Devolución en Venta");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Orden de Giro");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Transacciones", new System.Windows.Forms.TreeNode[] {
            treeNode86,
            treeNode87,
            treeNode88,
            treeNode89,
            treeNode90});
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Kardex");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Informes", new System.Windows.Forms.TreeNode[] {
            treeNode92});
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("ATS");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("SRI", new System.Windows.Forms.TreeNode[] {
            treeNode94});
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Enviados");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Recibidos");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Eliminados");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Correo Electrónico", new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode97,
            treeNode98});
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
            treeNode67.Name = "Nodo1";
            treeNode67.Text = "Administrar Clientes";
            treeNode68.Name = "Nodo2";
            treeNode68.Text = "Administrar Proveedores";
            treeNode69.Name = "Nodo15";
            treeNode69.Text = "Administrar Usuarios";
            treeNode70.Name = "Nodo1";
            treeNode70.Text = "Cajas/Talonarios";
            treeNode71.Name = "Nodo2";
            treeNode71.Text = "Impresion de Factura";
            treeNode72.Name = "Nodo3";
            treeNode72.Text = "Empresa";
            treeNode73.Name = "Nodo4";
            treeNode73.Text = "Sucursales";
            treeNode74.Name = "Nodo16";
            treeNode74.Text = "Administrar Empresas";
            treeNode75.Name = "Nodo9";
            treeNode75.Text = "Administrar Promociones";
            treeNode76.Name = "Nodo14";
            treeNode76.Text = "Plan de Cuentas";
            treeNode77.Name = "Nodo5";
            treeNode77.Text = "Administrar Descuentos";
            treeNode78.Name = "Nodo0";
            treeNode78.Text = "Administrar Empleados";
            treeNode79.Name = "nodoMantenimiento";
            treeNode79.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode79.Text = "Mantenimiento";
            treeNode80.Name = "Nodo7";
            treeNode80.Text = "Productos";
            treeNode81.Name = "Nodo8";
            treeNode81.Text = "Categoria Producto";
            treeNode82.Name = "Nodo9";
            treeNode82.Text = "Creacion de Bodega";
            treeNode83.Name = "Nodo10";
            treeNode83.Text = "Combo de Productos";
            treeNode84.Name = "Nodo11";
            treeNode84.Text = "Asignacion de Producto por Bodega";
            treeNode85.Name = "nodinventario";
            treeNode85.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode85.Text = "Inventario";
            treeNode86.Name = "Nodo3";
            treeNode86.Text = "Ventas";
            treeNode87.Name = "Nodo5";
            treeNode87.Text = "Compras";
            treeNode88.Name = "Nodo6";
            treeNode88.Text = "Devolución en Compras";
            treeNode89.Name = "Nodo1";
            treeNode89.Text = "Devolución en Venta";
            treeNode90.Name = "Nodo0";
            treeNode90.Text = "Orden de Giro";
            treeNode91.Name = "nodoTransaccion";
            treeNode91.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode91.Text = "Transacciones";
            treeNode92.Name = "Nodo14";
            treeNode92.Text = "Kardex";
            treeNode93.Name = "nodoInforme";
            treeNode93.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode93.Text = "Informes";
            treeNode94.Name = "Nodo8";
            treeNode94.Text = "ATS";
            treeNode95.Name = "Nodo7";
            treeNode95.Text = "SRI";
            treeNode96.Name = "Nodo11";
            treeNode96.Text = "Enviados";
            treeNode97.Name = "Nodo12";
            treeNode97.Text = "Recibidos";
            treeNode98.Name = "Nodo13";
            treeNode98.Text = "Eliminados";
            treeNode99.Name = "Nodo10";
            treeNode99.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode99.Text = "Correo Electrónico";
            this.tvPrincipal.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode79,
            treeNode85,
            treeNode91,
            treeNode93,
            treeNode95,
            treeNode99});
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
            this.panelPrincipal.AutoSize = true;
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPrincipal.BackgroundImage = global::Comisariato.Properties.Resources.logo1098x585;
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