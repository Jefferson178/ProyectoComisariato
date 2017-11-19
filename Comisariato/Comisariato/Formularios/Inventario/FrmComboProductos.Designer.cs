namespace Comisariato.Formularios.Mantenimiento.Inventario
{
    partial class FrmComboProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbproductosParaCombo = new System.Windows.Forms.GroupBox();
            this.dgvProductosParaCombo = new System.Windows.Forms.DataGridView();
            this.txtBuscarProductosParaCombo = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tcComboProducto = new System.Windows.Forms.TabControl();
            this.tpNuevoCombo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodigoCombo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiarCombo = new System.Windows.Forms.Button();
            this.btnGuardarCombo = new System.Windows.Forms.Button();
            this.txtNombreCombo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarProductoACombo = new System.Windows.Forms.Button();
            this.gbComboProductos = new System.Windows.Forms.GroupBox();
            this.dgvProductosEnCombo = new System.Windows.Forms.DataGridView();
            this.tpConsultarModificarCombo = new System.Windows.Forms.TabPage();
            this.txtConsultarCombo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDatosCombo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbproductosParaCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosParaCombo)).BeginInit();
            this.tcComboProducto.SuspendLayout();
            this.tpNuevoCombo.SuspendLayout();
            this.gbComboProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnCombo)).BeginInit();
            this.tpConsultarModificarCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbproductosParaCombo
            // 
            this.gbproductosParaCombo.Controls.Add(this.dgvProductosParaCombo);
            this.gbproductosParaCombo.Controls.Add(this.txtBuscarProductosParaCombo);
            this.gbproductosParaCombo.Controls.Add(this.label25);
            this.gbproductosParaCombo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbproductosParaCombo.ForeColor = System.Drawing.Color.Teal;
            this.gbproductosParaCombo.Location = new System.Drawing.Point(47, 37);
            this.gbproductosParaCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbproductosParaCombo.Name = "gbproductosParaCombo";
            this.gbproductosParaCombo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbproductosParaCombo.Size = new System.Drawing.Size(895, 178);
            this.gbproductosParaCombo.TabIndex = 3;
            this.gbproductosParaCombo.TabStop = false;
            this.gbproductosParaCombo.Text = "Productos para Combos";
            // 
            // dgvProductosParaCombo
            // 
            this.dgvProductosParaCombo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosParaCombo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosParaCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosParaCombo.Location = new System.Drawing.Point(94, 49);
            this.dgvProductosParaCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductosParaCombo.Name = "dgvProductosParaCombo";
            this.dgvProductosParaCombo.RowHeadersVisible = false;
            this.dgvProductosParaCombo.Size = new System.Drawing.Size(717, 119);
            this.dgvProductosParaCombo.TabIndex = 3;
            this.dgvProductosParaCombo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosParaCombo_CellClick);
            // 
            // txtBuscarProductosParaCombo
            // 
            this.txtBuscarProductosParaCombo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtBuscarProductosParaCombo.Location = new System.Drawing.Point(211, 22);
            this.txtBuscarProductosParaCombo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarProductosParaCombo.Name = "txtBuscarProductosParaCombo";
            this.txtBuscarProductosParaCombo.Size = new System.Drawing.Size(571, 22);
            this.txtBuscarProductosParaCombo.TabIndex = 7;
            this.txtBuscarProductosParaCombo.TextChanged += new System.EventHandler(this.txtBuscarProductosParaCombo_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label25.Location = new System.Drawing.Point(110, 26);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 16);
            this.label25.TabIndex = 6;
            this.label25.Text = "Buscar:";
            // 
            // tcComboProducto
            // 
            this.tcComboProducto.Controls.Add(this.tpNuevoCombo);
            this.tcComboProducto.Controls.Add(this.tpConsultarModificarCombo);
            this.tcComboProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcComboProducto.Location = new System.Drawing.Point(15, 8);
            this.tcComboProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcComboProducto.Name = "tcComboProducto";
            this.tcComboProducto.SelectedIndex = 0;
            this.tcComboProducto.Size = new System.Drawing.Size(1043, 573);
            this.tcComboProducto.TabIndex = 3;
            // 
            // tpNuevoCombo
            // 
            this.tpNuevoCombo.BackColor = System.Drawing.Color.Bisque;
            this.tpNuevoCombo.Controls.Add(this.button1);
            this.tpNuevoCombo.Controls.Add(this.txtCodigoCombo);
            this.tpNuevoCombo.Controls.Add(this.label3);
            this.tpNuevoCombo.Controls.Add(this.btnLimpiarCombo);
            this.tpNuevoCombo.Controls.Add(this.btnGuardarCombo);
            this.tpNuevoCombo.Controls.Add(this.txtNombreCombo);
            this.tpNuevoCombo.Controls.Add(this.label1);
            this.tpNuevoCombo.Controls.Add(this.btnAgregarProductoACombo);
            this.tpNuevoCombo.Controls.Add(this.gbComboProductos);
            this.tpNuevoCombo.Controls.Add(this.gbproductosParaCombo);
            this.tpNuevoCombo.ForeColor = System.Drawing.Color.Teal;
            this.tpNuevoCombo.Location = new System.Drawing.Point(4, 25);
            this.tpNuevoCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpNuevoCombo.Name = "tpNuevoCombo";
            this.tpNuevoCombo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpNuevoCombo.Size = new System.Drawing.Size(1035, 544);
            this.tpNuevoCombo.TabIndex = 0;
            this.tpNuevoCombo.Text = "Nuevo Combo";
            // 
            // button1
            // 
            this.button1.Image = global::Comisariato.Properties.Resources.salir2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(39, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 57);
            this.button1.TabIndex = 12;
            this.button1.Text = "Salir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCodigoCombo
            // 
            this.txtCodigoCombo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCodigoCombo.Location = new System.Drawing.Point(183, 10);
            this.txtCodigoCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoCombo.Name = "txtCodigoCombo";
            this.txtCodigoCombo.Size = new System.Drawing.Size(157, 22);
            this.txtCodigoCombo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(44, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Codigo del Combo: ";
            // 
            // btnLimpiarCombo
            // 
            this.btnLimpiarCombo.Image = global::Comisariato.Properties.Resources.limpiar;
            this.btnLimpiarCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarCombo.Location = new System.Drawing.Point(874, 455);
            this.btnLimpiarCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiarCombo.Name = "btnLimpiarCombo";
            this.btnLimpiarCombo.Size = new System.Drawing.Size(128, 81);
            this.btnLimpiarCombo.TabIndex = 9;
            this.btnLimpiarCombo.Text = "&Limpiar";
            this.btnLimpiarCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarCombo.UseVisualStyleBackColor = true;
            this.btnLimpiarCombo.Click += new System.EventHandler(this.btnLimpiarCombo_Click);
            // 
            // btnGuardarCombo
            // 
            this.btnGuardarCombo.Image = global::Comisariato.Properties.Resources.guardar11;
            this.btnGuardarCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCombo.Location = new System.Drawing.Point(721, 455);
            this.btnGuardarCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarCombo.Name = "btnGuardarCombo";
            this.btnGuardarCombo.Size = new System.Drawing.Size(128, 81);
            this.btnGuardarCombo.TabIndex = 8;
            this.btnGuardarCombo.Text = "&Guardar";
            this.btnGuardarCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCombo.UseVisualStyleBackColor = true;
            this.btnGuardarCombo.Click += new System.EventHandler(this.btnGuardarCombo_Click);
            // 
            // txtNombreCombo
            // 
            this.txtNombreCombo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNombreCombo.Location = new System.Drawing.Point(496, 10);
            this.txtNombreCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreCombo.Name = "txtNombreCombo";
            this.txtNombreCombo.Size = new System.Drawing.Size(475, 22);
            this.txtNombreCombo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(357, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del Combo:";
            // 
            // btnAgregarProductoACombo
            // 
            this.btnAgregarProductoACombo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnAgregarProductoACombo.Image = global::Comisariato.Properties.Resources.Modificar;
            this.btnAgregarProductoACombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProductoACombo.Location = new System.Drawing.Point(865, 223);
            this.btnAgregarProductoACombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarProductoACombo.Name = "btnAgregarProductoACombo";
            this.btnAgregarProductoACombo.Size = new System.Drawing.Size(106, 53);
            this.btnAgregarProductoACombo.TabIndex = 5;
            this.btnAgregarProductoACombo.Text = "&Agregar";
            this.btnAgregarProductoACombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductoACombo.UseVisualStyleBackColor = true;
            this.btnAgregarProductoACombo.Click += new System.EventHandler(this.btnAgregarProductoACombo_Click);
            // 
            // gbComboProductos
            // 
            this.gbComboProductos.Controls.Add(this.dgvProductosEnCombo);
            this.gbComboProductos.ForeColor = System.Drawing.Color.Teal;
            this.gbComboProductos.Location = new System.Drawing.Point(6, 274);
            this.gbComboProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbComboProductos.Name = "gbComboProductos";
            this.gbComboProductos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbComboProductos.Size = new System.Drawing.Size(994, 173);
            this.gbComboProductos.TabIndex = 4;
            this.gbComboProductos.TabStop = false;
            this.gbComboProductos.Text = "Combo de Productos";
            // 
            // dgvProductosEnCombo
            // 
            this.dgvProductosEnCombo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosEnCombo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosEnCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosEnCombo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.categoriaCombo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Cant,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvProductosEnCombo.Location = new System.Drawing.Point(30, 25);
            this.dgvProductosEnCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductosEnCombo.Name = "dgvProductosEnCombo";
            this.dgvProductosEnCombo.RowHeadersVisible = false;
            this.dgvProductosEnCombo.Size = new System.Drawing.Size(935, 137);
            this.dgvProductosEnCombo.TabIndex = 2;
            // 
            // tpConsultarModificarCombo
            // 
            this.tpConsultarModificarCombo.BackColor = System.Drawing.Color.Bisque;
            this.tpConsultarModificarCombo.Controls.Add(this.txtConsultarCombo);
            this.tpConsultarModificarCombo.Controls.Add(this.label2);
            this.tpConsultarModificarCombo.Controls.Add(this.dgvDatosCombo);
            this.tpConsultarModificarCombo.Location = new System.Drawing.Point(4, 25);
            this.tpConsultarModificarCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpConsultarModificarCombo.Name = "tpConsultarModificarCombo";
            this.tpConsultarModificarCombo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpConsultarModificarCombo.Size = new System.Drawing.Size(1015, 544);
            this.tpConsultarModificarCombo.TabIndex = 1;
            this.tpConsultarModificarCombo.Text = "Consultar - Modificar Combo";
            // 
            // txtConsultarCombo
            // 
            this.txtConsultarCombo.Location = new System.Drawing.Point(296, 25);
            this.txtConsultarCombo.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarCombo.Name = "txtConsultarCombo";
            this.txtConsultarCombo.Size = new System.Drawing.Size(571, 22);
            this.txtConsultarCombo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(182, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Consultar:";
            // 
            // dgvDatosCombo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosCombo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCombo.Location = new System.Drawing.Point(19, 63);
            this.dgvDatosCombo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosCombo.Name = "dgvDatosCombo";
            this.dgvDatosCombo.Size = new System.Drawing.Size(977, 458);
            this.dgvDatosCombo.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // categoriaCombo
            // 
            this.categoriaCombo.HeaderText = "Categoria";
            this.categoriaCombo.Name = "categoriaCombo";
            this.categoriaCombo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cant.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "EnBodega";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Bodega";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "V. Unit.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // FrmComboProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1083, 588);
            this.Controls.Add(this.tcComboProducto);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmComboProductos";
            this.Text = "Administrar Combo de Productos";
            this.Load += new System.EventHandler(this.FrmComboProductos_Load);
            this.gbproductosParaCombo.ResumeLayout(false);
            this.gbproductosParaCombo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosParaCombo)).EndInit();
            this.tcComboProducto.ResumeLayout(false);
            this.tpNuevoCombo.ResumeLayout(false);
            this.tpNuevoCombo.PerformLayout();
            this.gbComboProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnCombo)).EndInit();
            this.tpConsultarModificarCombo.ResumeLayout(false);
            this.tpConsultarModificarCombo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCombo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbproductosParaCombo;
        private System.Windows.Forms.TabControl tcComboProducto;
        private System.Windows.Forms.TabPage tpConsultarModificarCombo;
        private System.Windows.Forms.TabPage tpNuevoCombo;
        private System.Windows.Forms.GroupBox gbComboProductos;
        private System.Windows.Forms.TextBox txtBuscarProductosParaCombo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnAgregarProductoACombo;
        private System.Windows.Forms.TextBox txtNombreCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarCombo;
        private System.Windows.Forms.Button btnGuardarCombo;
        private System.Windows.Forms.TextBox txtConsultarCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatosCombo;
        private System.Windows.Forms.TextBox txtCodigoCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProductosEnCombo;
        private System.Windows.Forms.DataGridView dgvProductosParaCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}