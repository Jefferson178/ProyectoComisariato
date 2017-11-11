namespace Comisariato.Formularios.Mantenimiento.Inventario
{
    partial class FrmAsignacionProductoBodega
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAsignarProducto = new System.Windows.Forms.Button();
            this.btnNoAsiganrProducto = new System.Windows.Forms.Button();
            this.btnLimpiarAsignacionProducto = new System.Windows.Forms.Button();
            this.btnGuardarAsignacionProducto = new System.Windows.Forms.Button();
            this.tcAsignarProductoBodega = new System.Windows.Forms.TabControl();
            this.tpNuevaAsignacionProducto = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEscogerBodega = new System.Windows.Forms.ComboBox();
            this.txtUbicacionBodegaAsignacionProducto = new System.Windows.Forms.TextBox();
            this.dgvDatosProductosAsignadosABodega = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.dgvDatosProductoParaAsignacionBodega = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarProductosAbodega = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtConsultarAsginacionProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDatosAsignacionProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tcAsignarProductoBodega.SuspendLayout();
            this.tpNuevaAsignacionProducto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProductosAsignadosABodega)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProductoParaAsignacionBodega)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAsignacionProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // btnAsignarProducto
            // 
            this.btnAsignarProducto.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAsignarProducto.Location = new System.Drawing.Point(501, 217);
            this.btnAsignarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAsignarProducto.Name = "btnAsignarProducto";
            this.btnAsignarProducto.Size = new System.Drawing.Size(47, 38);
            this.btnAsignarProducto.TabIndex = 3;
            this.btnAsignarProducto.Text = ">";
            this.btnAsignarProducto.UseVisualStyleBackColor = true;
            // 
            // btnNoAsiganrProducto
            // 
            this.btnNoAsiganrProducto.Font = new System.Drawing.Font("Arial", 10F);
            this.btnNoAsiganrProducto.Location = new System.Drawing.Point(501, 284);
            this.btnNoAsiganrProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNoAsiganrProducto.Name = "btnNoAsiganrProducto";
            this.btnNoAsiganrProducto.Size = new System.Drawing.Size(47, 38);
            this.btnNoAsiganrProducto.TabIndex = 6;
            this.btnNoAsiganrProducto.Text = "<";
            this.btnNoAsiganrProducto.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarAsignacionProducto
            // 
            this.btnLimpiarAsignacionProducto.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLimpiarAsignacionProducto.Image = global::Comisariato.Properties.Resources.limpiar;
            this.btnLimpiarAsignacionProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarAsignacionProducto.Location = new System.Drawing.Point(525, 451);
            this.btnLimpiarAsignacionProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiarAsignacionProducto.Name = "btnLimpiarAsignacionProducto";
            this.btnLimpiarAsignacionProducto.Size = new System.Drawing.Size(136, 79);
            this.btnLimpiarAsignacionProducto.TabIndex = 33;
            this.btnLimpiarAsignacionProducto.Text = "&Limpiar";
            this.btnLimpiarAsignacionProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarAsignacionProducto.UseVisualStyleBackColor = true;
            // 
            // btnGuardarAsignacionProducto
            // 
            this.btnGuardarAsignacionProducto.Font = new System.Drawing.Font("Arial", 10F);
            this.btnGuardarAsignacionProducto.Image = global::Comisariato.Properties.Resources.guardar11;
            this.btnGuardarAsignacionProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarAsignacionProducto.Location = new System.Drawing.Point(381, 451);
            this.btnGuardarAsignacionProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarAsignacionProducto.Name = "btnGuardarAsignacionProducto";
            this.btnGuardarAsignacionProducto.Size = new System.Drawing.Size(138, 79);
            this.btnGuardarAsignacionProducto.TabIndex = 32;
            this.btnGuardarAsignacionProducto.Text = "&Guardar";
            this.btnGuardarAsignacionProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarAsignacionProducto.UseVisualStyleBackColor = true;
            // 
            // tcAsignarProductoBodega
            // 
            this.tcAsignarProductoBodega.Controls.Add(this.tpNuevaAsignacionProducto);
            this.tcAsignarProductoBodega.Controls.Add(this.tabPage2);
            this.tcAsignarProductoBodega.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAsignarProductoBodega.Location = new System.Drawing.Point(10, 6);
            this.tcAsignarProductoBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcAsignarProductoBodega.Name = "tcAsignarProductoBodega";
            this.tcAsignarProductoBodega.SelectedIndex = 0;
            this.tcAsignarProductoBodega.Size = new System.Drawing.Size(1056, 568);
            this.tcAsignarProductoBodega.TabIndex = 34;
            // 
            // tpNuevaAsignacionProducto
            // 
            this.tpNuevaAsignacionProducto.BackColor = System.Drawing.Color.Bisque;
            this.tpNuevaAsignacionProducto.Controls.Add(this.groupBox2);
            this.tpNuevaAsignacionProducto.Controls.Add(this.groupBox1);
            this.tpNuevaAsignacionProducto.Controls.Add(this.btnLimpiarAsignacionProducto);
            this.tpNuevaAsignacionProducto.Controls.Add(this.btnGuardarAsignacionProducto);
            this.tpNuevaAsignacionProducto.Controls.Add(this.btnAsignarProducto);
            this.tpNuevaAsignacionProducto.Controls.Add(this.btnNoAsiganrProducto);
            this.tpNuevaAsignacionProducto.Location = new System.Drawing.Point(4, 25);
            this.tpNuevaAsignacionProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpNuevaAsignacionProducto.Name = "tpNuevaAsignacionProducto";
            this.tpNuevaAsignacionProducto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpNuevaAsignacionProducto.Size = new System.Drawing.Size(1048, 539);
            this.tpNuevaAsignacionProducto.TabIndex = 0;
            this.tpNuevaAsignacionProducto.Text = "Nueva Asginacion de Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbEscogerBodega);
            this.groupBox2.Controls.Add(this.txtUbicacionBodegaAsignacionProducto);
            this.groupBox2.Controls.Add(this.dgvDatosProductosAsignadosABodega);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(553, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 437);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Bodega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escoger Bodega:";
            // 
            // cbEscogerBodega
            // 
            this.cbEscogerBodega.Font = new System.Drawing.Font("Arial", 10F);
            this.cbEscogerBodega.FormattingEnabled = true;
            this.cbEscogerBodega.Location = new System.Drawing.Point(139, 23);
            this.cbEscogerBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEscogerBodega.Name = "cbEscogerBodega";
            this.cbEscogerBodega.Size = new System.Drawing.Size(330, 24);
            this.cbEscogerBodega.TabIndex = 3;
            // 
            // txtUbicacionBodegaAsignacionProducto
            // 
            this.txtUbicacionBodegaAsignacionProducto.Enabled = false;
            this.txtUbicacionBodegaAsignacionProducto.Font = new System.Drawing.Font("Arial", 10F);
            this.txtUbicacionBodegaAsignacionProducto.Location = new System.Drawing.Point(139, 55);
            this.txtUbicacionBodegaAsignacionProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUbicacionBodegaAsignacionProducto.Name = "txtUbicacionBodegaAsignacionProducto";
            this.txtUbicacionBodegaAsignacionProducto.Size = new System.Drawing.Size(330, 23);
            this.txtUbicacionBodegaAsignacionProducto.TabIndex = 6;
            // 
            // dgvDatosProductosAsignadosABodega
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosProductosAsignadosABodega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosProductosAsignadosABodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosProductosAsignadosABodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvDatosProductosAsignadosABodega.Location = new System.Drawing.Point(0, 95);
            this.dgvDatosProductosAsignadosABodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDatosProductosAsignadosABodega.Name = "dgvDatosProductosAsignadosABodega";
            this.dgvDatosProductosAsignadosABodega.Size = new System.Drawing.Size(484, 342);
            this.dgvDatosProductosAsignadosABodega.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ubicación:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBuscarProducto);
            this.groupBox1.Controls.Add(this.dgvDatosProductoParaAsignacionBodega);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 437);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Productos";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBuscarProducto.Location = new System.Drawing.Point(111, 23);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(340, 23);
            this.txtBuscarProducto.TabIndex = 2;
            // 
            // dgvDatosProductoParaAsignacionBodega
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosProductoParaAsignacionBodega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosProductoParaAsignacionBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosProductoParaAsignacionBodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.agregarProductosAbodega});
            this.dgvDatosProductoParaAsignacionBodega.Location = new System.Drawing.Point(0, 95);
            this.dgvDatosProductoParaAsignacionBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDatosProductoParaAsignacionBodega.Name = "dgvDatosProductoParaAsignacionBodega";
            this.dgvDatosProductoParaAsignacionBodega.Size = new System.Drawing.Size(482, 342);
            this.dgvDatosProductoParaAsignacionBodega.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Código";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // agregarProductosAbodega
            // 
            this.agregarProductosAbodega.HeaderText = "";
            this.agregarProductosAbodega.Name = "agregarProductosAbodega";
            this.agregarProductosAbodega.Width = 25;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.txtConsultarAsginacionProducto);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dgvDatosAsignacionProducto);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1048, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar - Modificar Asignaciones de Productos";
            // 
            // txtConsultarAsginacionProducto
            // 
            this.txtConsultarAsginacionProducto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtConsultarAsginacionProducto.Location = new System.Drawing.Point(255, 28);
            this.txtConsultarAsginacionProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsultarAsginacionProducto.Name = "txtConsultarAsginacionProducto";
            this.txtConsultarAsginacionProducto.Size = new System.Drawing.Size(611, 22);
            this.txtConsultarAsginacionProducto.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(182, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Consultar:";
            // 
            // dgvDatosAsignacionProducto
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosAsignacionProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosAsignacionProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAsignacionProducto.Location = new System.Drawing.Point(46, 69);
            this.dgvDatosAsignacionProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDatosAsignacionProducto.Name = "dgvDatosAsignacionProducto";
            this.dgvDatosAsignacionProducto.Size = new System.Drawing.Size(957, 440);
            this.dgvDatosAsignacionProducto.TabIndex = 3;
            // 
            // FrmAsignacionProductoBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1076, 581);
            this.Controls.Add(this.tcAsignarProductoBodega);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1092, 620);
            this.MinimumSize = new System.Drawing.Size(1092, 620);
            this.Name = "FrmAsignacionProductoBodega";
            this.Text = "Administrar Asignación de Producto por Bodega";
            this.Load += new System.EventHandler(this.FrmAsignacionProductoBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tcAsignarProductoBodega.ResumeLayout(false);
            this.tpNuevaAsignacionProducto.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProductosAsignadosABodega)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProductoParaAsignacionBodega)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAsignacionProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnAsignarProducto;
        private System.Windows.Forms.Button btnNoAsiganrProducto;
        private System.Windows.Forms.Button btnLimpiarAsignacionProducto;
        private System.Windows.Forms.Button btnGuardarAsignacionProducto;
        private System.Windows.Forms.TabControl tcAsignarProductoBodega;
        private System.Windows.Forms.TabPage tpNuevaAsignacionProducto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtConsultarAsginacionProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDatosAsignacionProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEscogerBodega;
        private System.Windows.Forms.TextBox txtUbicacionBodegaAsignacionProducto;
        private System.Windows.Forms.DataGridView dgvDatosProductosAsignadosABodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.DataGridView dgvDatosProductoParaAsignacionBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn agregarProductosAbodega;
    }
}