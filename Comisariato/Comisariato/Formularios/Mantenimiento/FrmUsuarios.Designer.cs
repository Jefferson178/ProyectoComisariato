namespace Comisariato.Formularios
{
    partial class FrmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcUsuario = new System.Windows.Forms.TabControl();
            this.tpNuevoUsuario = new System.Windows.Forms.TabPage();
            this.btnLimpiarProveedor = new System.Windows.Forms.Button();
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.ckMostrarContra = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbFacturaUsuario = new System.Windows.Forms.CheckBox();
            this.gbEmpresaConectarseProveedor = new System.Windows.Forms.GroupBox();
            this.CheckListBEmpresasProveedor = new System.Windows.Forms.CheckedListBox();
            this.TxtConfirmarContraUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cbPersonaUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.tpConsultarModificarUsuario = new System.Windows.Forms.TabPage();
            this.dgvDatosUsuario = new System.Windows.Forms.DataGridView();
            this.modificarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.usuarioUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaUsuario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.empresaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtConsultarUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tcUsuario.SuspendLayout();
            this.tpNuevoUsuario.SuspendLayout();
            this.gbDatosUsuario.SuspendLayout();
            this.gbEmpresaConectarseProveedor.SuspendLayout();
            this.tpConsultarModificarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tcUsuario
            // 
            this.tcUsuario.Controls.Add(this.tpNuevoUsuario);
            this.tcUsuario.Controls.Add(this.tpConsultarModificarUsuario);
            this.tcUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcUsuario.Location = new System.Drawing.Point(10, 17);
            this.tcUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tcUsuario.Name = "tcUsuario";
            this.tcUsuario.SelectedIndex = 0;
            this.tcUsuario.Size = new System.Drawing.Size(626, 416);
            this.tcUsuario.TabIndex = 1;
            // 
            // tpNuevoUsuario
            // 
            this.tpNuevoUsuario.BackColor = System.Drawing.Color.Bisque;
            this.tpNuevoUsuario.Controls.Add(this.btnLimpiarProveedor);
            this.tpNuevoUsuario.Controls.Add(this.gbDatosUsuario);
            this.tpNuevoUsuario.Controls.Add(this.btnGuardarUsuario);
            this.tpNuevoUsuario.Location = new System.Drawing.Point(4, 25);
            this.tpNuevoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tpNuevoUsuario.Name = "tpNuevoUsuario";
            this.tpNuevoUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.tpNuevoUsuario.Size = new System.Drawing.Size(618, 387);
            this.tpNuevoUsuario.TabIndex = 0;
            this.tpNuevoUsuario.Text = "Nuevo Usuario";
            // 
            // btnLimpiarProveedor
            // 
            this.btnLimpiarProveedor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnLimpiarProveedor.Image = global::Comisariato.Properties.Resources.limpiar;
            this.btnLimpiarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarProveedor.Location = new System.Drawing.Point(362, 303);
            this.btnLimpiarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarProveedor.Name = "btnLimpiarProveedor";
            this.btnLimpiarProveedor.Size = new System.Drawing.Size(122, 69);
            this.btnLimpiarProveedor.TabIndex = 29;
            this.btnLimpiarProveedor.Text = "&Limpiar";
            this.btnLimpiarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarProveedor.UseVisualStyleBackColor = true;
            this.btnLimpiarProveedor.Click += new System.EventHandler(this.btnLimpiarProveedor_Click);
            // 
            // gbDatosUsuario
            // 
            this.gbDatosUsuario.Controls.Add(this.ckMostrarContra);
            this.gbDatosUsuario.Controls.Add(this.label5);
            this.gbDatosUsuario.Controls.Add(this.ckbFacturaUsuario);
            this.gbDatosUsuario.Controls.Add(this.gbEmpresaConectarseProveedor);
            this.gbDatosUsuario.Controls.Add(this.TxtConfirmarContraUsuario);
            this.gbDatosUsuario.Controls.Add(this.txtContraseñaUsuario);
            this.gbDatosUsuario.Controls.Add(this.txtUsuario);
            this.gbDatosUsuario.Controls.Add(this.cbPersonaUsuario);
            this.gbDatosUsuario.Controls.Add(this.label3);
            this.gbDatosUsuario.Controls.Add(this.label2);
            this.gbDatosUsuario.Controls.Add(this.label1);
            this.gbDatosUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosUsuario.ForeColor = System.Drawing.Color.Teal;
            this.gbDatosUsuario.Location = new System.Drawing.Point(42, 6);
            this.gbDatosUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatosUsuario.Size = new System.Drawing.Size(560, 295);
            this.gbDatosUsuario.TabIndex = 0;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "Datos Usuario";
            // 
            // ckMostrarContra
            // 
            this.ckMostrarContra.AutoSize = true;
            this.ckMostrarContra.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ckMostrarContra.Location = new System.Drawing.Point(541, 95);
            this.ckMostrarContra.Margin = new System.Windows.Forms.Padding(2);
            this.ckMostrarContra.Name = "ckMostrarContra";
            this.ckMostrarContra.Size = new System.Drawing.Size(15, 14);
            this.ckMostrarContra.TabIndex = 11;
            this.ckMostrarContra.UseVisualStyleBackColor = true;
            this.ckMostrarContra.CheckedChanged += new System.EventHandler(this.ckMostrarContra_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(265, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmar Contraseña:";
            // 
            // ckbFacturaUsuario
            // 
            this.ckbFacturaUsuario.AutoSize = true;
            this.ckbFacturaUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ckbFacturaUsuario.Location = new System.Drawing.Point(43, 124);
            this.ckbFacturaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.ckbFacturaUsuario.Name = "ckbFacturaUsuario";
            this.ckbFacturaUsuario.Size = new System.Drawing.Size(119, 20);
            this.ckbFacturaUsuario.TabIndex = 9;
            this.ckbFacturaUsuario.Text = "Usuario Factura";
            this.ckbFacturaUsuario.UseVisualStyleBackColor = true;
            // 
            // gbEmpresaConectarseProveedor
            // 
            this.gbEmpresaConectarseProveedor.Controls.Add(this.CheckListBEmpresasProveedor);
            this.gbEmpresaConectarseProveedor.ForeColor = System.Drawing.Color.Teal;
            this.gbEmpresaConectarseProveedor.Location = new System.Drawing.Point(43, 156);
            this.gbEmpresaConectarseProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.gbEmpresaConectarseProveedor.Name = "gbEmpresaConectarseProveedor";
            this.gbEmpresaConectarseProveedor.Padding = new System.Windows.Forms.Padding(2);
            this.gbEmpresaConectarseProveedor.Size = new System.Drawing.Size(497, 128);
            this.gbEmpresaConectarseProveedor.TabIndex = 8;
            this.gbEmpresaConectarseProveedor.TabStop = false;
            this.gbEmpresaConectarseProveedor.Text = "Empresa a conectarse";
            // 
            // CheckListBEmpresasProveedor
            // 
            this.CheckListBEmpresasProveedor.CheckOnClick = true;
            this.CheckListBEmpresasProveedor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.CheckListBEmpresasProveedor.FormattingEnabled = true;
            this.CheckListBEmpresasProveedor.Items.AddRange(new object[] {
            "Empresa 1"});
            this.CheckListBEmpresasProveedor.Location = new System.Drawing.Point(97, 27);
            this.CheckListBEmpresasProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.CheckListBEmpresasProveedor.Name = "CheckListBEmpresasProveedor";
            this.CheckListBEmpresasProveedor.Size = new System.Drawing.Size(302, 89);
            this.CheckListBEmpresasProveedor.TabIndex = 7;
            // 
            // TxtConfirmarContraUsuario
            // 
            this.TxtConfirmarContraUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtConfirmarContraUsuario.Location = new System.Drawing.Point(407, 123);
            this.TxtConfirmarContraUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtConfirmarContraUsuario.Name = "TxtConfirmarContraUsuario";
            this.TxtConfirmarContraUsuario.Size = new System.Drawing.Size(133, 22);
            this.TxtConfirmarContraUsuario.TabIndex = 6;
            // 
            // txtContraseñaUsuario
            // 
            this.txtContraseñaUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtContraseñaUsuario.Location = new System.Drawing.Point(407, 90);
            this.txtContraseñaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            this.txtContraseñaUsuario.Size = new System.Drawing.Size(133, 22);
            this.txtContraseñaUsuario.TabIndex = 6;
            this.txtContraseñaUsuario.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtUsuario.Location = new System.Drawing.Point(114, 90);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(133, 22);
            this.txtUsuario.TabIndex = 5;
            // 
            // cbPersonaUsuario
            // 
            this.cbPersonaUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonaUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbPersonaUsuario.FormattingEnabled = true;
            this.cbPersonaUsuario.Location = new System.Drawing.Point(114, 23);
            this.cbPersonaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbPersonaUsuario.Name = "cbPersonaUsuario";
            this.cbPersonaUsuario.Size = new System.Drawing.Size(426, 24);
            this.cbPersonaUsuario.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(265, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(40, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presona:";
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnGuardarUsuario.Image = global::Comisariato.Properties.Resources.guardar11;
            this.btnGuardarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(196, 303);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(133, 69);
            this.btnGuardarUsuario.TabIndex = 28;
            this.btnGuardarUsuario.Text = "&Guardar";
            this.btnGuardarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // tpConsultarModificarUsuario
            // 
            this.tpConsultarModificarUsuario.BackColor = System.Drawing.Color.Bisque;
            this.tpConsultarModificarUsuario.Controls.Add(this.dgvDatosUsuario);
            this.tpConsultarModificarUsuario.Controls.Add(this.txtConsultarUsuario);
            this.tpConsultarModificarUsuario.Controls.Add(this.label4);
            this.tpConsultarModificarUsuario.Location = new System.Drawing.Point(4, 25);
            this.tpConsultarModificarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tpConsultarModificarUsuario.Name = "tpConsultarModificarUsuario";
            this.tpConsultarModificarUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.tpConsultarModificarUsuario.Size = new System.Drawing.Size(618, 379);
            this.tpConsultarModificarUsuario.TabIndex = 1;
            this.tpConsultarModificarUsuario.Text = "Consultar - Modificar Usuario";
            // 
            // dgvDatosUsuario
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modificarUsuario,
            this.eliminarUsuario,
            this.usuarioUsuario,
            this.contraseñaUsuario,
            this.facturaUsuario,
            this.empresaUsuario});
            this.dgvDatosUsuario.Location = new System.Drawing.Point(18, 60);
            this.dgvDatosUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosUsuario.Name = "dgvDatosUsuario";
            this.dgvDatosUsuario.Size = new System.Drawing.Size(586, 289);
            this.dgvDatosUsuario.TabIndex = 2;
            // 
            // modificarUsuario
            // 
            this.modificarUsuario.HeaderText = "";
            this.modificarUsuario.Name = "modificarUsuario";
            this.modificarUsuario.Width = 25;
            // 
            // eliminarUsuario
            // 
            this.eliminarUsuario.HeaderText = "";
            this.eliminarUsuario.Name = "eliminarUsuario";
            this.eliminarUsuario.Width = 25;
            // 
            // usuarioUsuario
            // 
            this.usuarioUsuario.HeaderText = "Usuario";
            this.usuarioUsuario.Name = "usuarioUsuario";
            this.usuarioUsuario.Width = 125;
            // 
            // contraseñaUsuario
            // 
            this.contraseñaUsuario.HeaderText = "Contraseña";
            this.contraseñaUsuario.Name = "contraseñaUsuario";
            this.contraseñaUsuario.Width = 125;
            // 
            // facturaUsuario
            // 
            this.facturaUsuario.HeaderText = "Factura";
            this.facturaUsuario.Name = "facturaUsuario";
            this.facturaUsuario.Width = 75;
            // 
            // empresaUsuario
            // 
            this.empresaUsuario.HeaderText = "Empresas";
            this.empresaUsuario.Name = "empresaUsuario";
            this.empresaUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.empresaUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.empresaUsuario.Width = 150;
            // 
            // txtConsultarUsuario
            // 
            this.txtConsultarUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtConsultarUsuario.Location = new System.Drawing.Point(184, 21);
            this.txtConsultarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarUsuario.Name = "txtConsultarUsuario";
            this.txtConsultarUsuario.Size = new System.Drawing.Size(325, 22);
            this.txtConsultarUsuario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(109, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Consultar:";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(647, 444);
            this.Controls.Add(this.tcUsuario);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(663, 482);
            this.MinimumSize = new System.Drawing.Size(663, 482);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.tcUsuario.ResumeLayout(false);
            this.tpNuevoUsuario.ResumeLayout(false);
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            this.gbEmpresaConectarseProveedor.ResumeLayout(false);
            this.tpConsultarModificarUsuario.ResumeLayout(false);
            this.tpConsultarModificarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcUsuario;
        private System.Windows.Forms.TabPage tpNuevoUsuario;
        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.CheckBox ckbFacturaUsuario;
        private System.Windows.Forms.GroupBox gbEmpresaConectarseProveedor;
        private System.Windows.Forms.CheckedListBox CheckListBEmpresasProveedor;
        private System.Windows.Forms.TextBox txtContraseñaUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cbPersonaUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpConsultarModificarUsuario;
        private System.Windows.Forms.DataGridView dgvDatosUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn modificarUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaUsuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn facturaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaUsuario;
        private System.Windows.Forms.TextBox txtConsultarUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiarProveedor;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtConfirmarContraUsuario;
        private System.Windows.Forms.CheckBox ckMostrarContra;
    }
}