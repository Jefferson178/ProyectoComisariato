namespace Comisariato.Formularios.Transacciones
{
    partial class FrmDatosClientes
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
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.dgvDatosUsuario = new System.Windows.Forms.DataGridView();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.cbParroquia = new System.Windows.Forms.ComboBox();
            this.cbCanton = new System.Windows.Forms.ComboBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuario)).BeginInit();
            this.gbDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Consultar:";
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(94, 28);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(277, 20);
            this.TxtConsulta.TabIndex = 0;
            this.TxtConsulta.TextChanged += new System.EventHandler(this.TxtConsulta_TextChanged);
            this.TxtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConsulta_KeyPress);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.dgvDatosUsuario);
            this.gbBuscar.Controls.Add(this.TxtConsulta);
            this.gbBuscar.Controls.Add(this.label1);
            this.gbBuscar.Location = new System.Drawing.Point(23, 66);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(722, 329);
            this.gbBuscar.TabIndex = 22;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Clientes";
            // 
            // dgvDatosUsuario
            // 
            this.dgvDatosUsuario.AllowUserToAddRows = false;
            this.dgvDatosUsuario.AllowUserToDeleteRows = false;
            this.dgvDatosUsuario.AllowUserToOrderColumns = true;
            this.dgvDatosUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDatosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosUsuario.Location = new System.Drawing.Point(33, 58);
            this.dgvDatosUsuario.Name = "dgvDatosUsuario";
            this.dgvDatosUsuario.ReadOnly = true;
            this.dgvDatosUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosUsuario.Size = new System.Drawing.Size(657, 258);
            this.dgvDatosUsuario.TabIndex = 1;
            this.dgvDatosUsuario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosUsuario_CellContentDoubleClick);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Teal;
            this.lbltitulo.Location = new System.Drawing.Point(240, 23);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(182, 24);
            this.lbltitulo.TabIndex = 21;
            this.lbltitulo.Text = "Ingreso de Datos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(308, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 46);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.label9);
            this.gbDatosCliente.Controls.Add(this.comboBox1);
            this.gbDatosCliente.Controls.Add(this.label7);
            this.gbDatosCliente.Controls.Add(this.txtCell);
            this.gbDatosCliente.Controls.Add(this.cbParroquia);
            this.gbDatosCliente.Controls.Add(this.cbCanton);
            this.gbDatosCliente.Controls.Add(this.cbProvincia);
            this.gbDatosCliente.Controls.Add(this.cbPais);
            this.gbDatosCliente.Controls.Add(this.btnGuardar);
            this.gbDatosCliente.Controls.Add(this.txtDireccion);
            this.gbDatosCliente.Controls.Add(this.label8);
            this.gbDatosCliente.Controls.Add(this.txtApellidos);
            this.gbDatosCliente.Controls.Add(this.label6);
            this.gbDatosCliente.Controls.Add(this.txtTelefono);
            this.gbDatosCliente.Controls.Add(this.label5);
            this.gbDatosCliente.Controls.Add(this.txtEmail);
            this.gbDatosCliente.Controls.Add(this.label4);
            this.gbDatosCliente.Controls.Add(this.txtNombres);
            this.gbDatosCliente.Controls.Add(this.label3);
            this.gbDatosCliente.Controls.Add(this.txtIdentificacion);
            this.gbDatosCliente.Controls.Add(this.label2);
            this.gbDatosCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.ForeColor = System.Drawing.Color.Teal;
            this.gbDatosCliente.Location = new System.Drawing.Point(774, 23);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(459, 488);
            this.gbDatosCliente.TabIndex = 27;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos Cliente";
            this.gbDatosCliente.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tipo Doc";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cedula",
            "RUC",
            "Pasaporte"});
            this.comboBox1.Location = new System.Drawing.Point(128, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "-";
            // 
            // txtCell
            // 
            this.txtCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell.Location = new System.Drawing.Point(290, 192);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(138, 22);
            this.txtCell.TabIndex = 12;
            // 
            // cbParroquia
            // 
            this.cbParroquia.FormattingEnabled = true;
            this.cbParroquia.Location = new System.Drawing.Point(290, 254);
            this.cbParroquia.Name = "cbParroquia";
            this.cbParroquia.Size = new System.Drawing.Size(138, 24);
            this.cbParroquia.TabIndex = 9;
            // 
            // cbCanton
            // 
            this.cbCanton.FormattingEnabled = true;
            this.cbCanton.Location = new System.Drawing.Point(128, 254);
            this.cbCanton.Name = "cbCanton";
            this.cbCanton.Size = new System.Drawing.Size(143, 24);
            this.cbCanton.TabIndex = 8;
            this.cbCanton.SelectedIndexChanged += new System.EventHandler(this.cbCanton_SelectedIndexChanged);
            // 
            // cbProvincia
            // 
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(290, 227);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(138, 24);
            this.cbProvincia.TabIndex = 7;
            this.cbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged);
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(128, 227);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(143, 24);
            this.cbPais.TabIndex = 6;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Comisariato.Properties.Resources.CLIENTE;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(179, 324);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(158, 152);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(128, 293);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(300, 22);
            this.txtDireccion.TabIndex = 10;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Dirección:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(128, 127);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(300, 22);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Apellidos:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(128, 192);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(143, 22);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fono - Cell:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(128, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(128, 92);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(300, 22);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(128, 59);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(196, 22);
            this.txtIdentificacion.TabIndex = 1;
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identificacion:";
            // 
            // FrmDatosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1260, 537);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDatosClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Cliente";
            this.Load += new System.EventHandler(this.FrmDatosClientes_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmDatosClientes_KeyUp);
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuario)).EndInit();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.DataGridView dgvDatosUsuario;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbParroquia;
        private System.Windows.Forms.ComboBox cbCanton;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}