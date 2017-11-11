namespace Comisariato.Formularios.Mantenimiento
{
    partial class FrmCajasTalonario
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
            this.tcCajaTalonario = new System.Windows.Forms.TabControl();
            this.tpNuevaCajaTalonario = new System.Windows.Forms.TabPage();
            this.btnLimpiarProveedor = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.gbDatosGeneralesCaja = new System.Windows.Forms.GroupBox();
            this.txtEstacionCaja = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ckbActivoCaja = new System.Windows.Forms.CheckBox();
            this.dtpFechaCaducidadCaja = new System.Windows.Forms.DateTimePicker();
            this.txtAutorizacionCaja = new System.Windows.Forms.TextBox();
            this.txtDocumentoActualCaja = new System.Windows.Forms.TextBox();
            this.txtDocumentoFinalCaja = new System.Windows.Forms.TextBox();
            this.txtDocumentoInicialCaja = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSerie2Caja = new System.Windows.Forms.TextBox();
            this.txtSerie1Caja = new System.Windows.Forms.TextBox();
            this.cbTipoDocumentoCaja = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbUbicacionCaja = new System.Windows.Forms.GroupBox();
            this.cbBodegaCaja = new System.Windows.Forms.ComboBox();
            this.cbSucursalCaja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpConsultarModificarDeshabilitarCaja = new System.Windows.Forms.TabPage();
            this.dgvDatosCaja = new System.Windows.Forms.DataGridView();
            this.txtConsultarCaja = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tcCajaTalonario.SuspendLayout();
            this.tpNuevaCajaTalonario.SuspendLayout();
            this.gbDatosGeneralesCaja.SuspendLayout();
            this.gbUbicacionCaja.SuspendLayout();
            this.tpConsultarModificarDeshabilitarCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCajaTalonario
            // 
            this.tcCajaTalonario.Controls.Add(this.tpNuevaCajaTalonario);
            this.tcCajaTalonario.Controls.Add(this.tpConsultarModificarDeshabilitarCaja);
            this.tcCajaTalonario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcCajaTalonario.Location = new System.Drawing.Point(17, 11);
            this.tcCajaTalonario.Name = "tcCajaTalonario";
            this.tcCajaTalonario.SelectedIndex = 0;
            this.tcCajaTalonario.Size = new System.Drawing.Size(745, 395);
            this.tcCajaTalonario.TabIndex = 0;
            // 
            // tpNuevaCajaTalonario
            // 
            this.tpNuevaCajaTalonario.BackColor = System.Drawing.Color.Bisque;
            this.tpNuevaCajaTalonario.Controls.Add(this.btnLimpiarProveedor);
            this.tpNuevaCajaTalonario.Controls.Add(this.btnGuardarUsuario);
            this.tpNuevaCajaTalonario.Controls.Add(this.gbDatosGeneralesCaja);
            this.tpNuevaCajaTalonario.Controls.Add(this.gbUbicacionCaja);
            this.tpNuevaCajaTalonario.ForeColor = System.Drawing.Color.Teal;
            this.tpNuevaCajaTalonario.Location = new System.Drawing.Point(4, 25);
            this.tpNuevaCajaTalonario.Name = "tpNuevaCajaTalonario";
            this.tpNuevaCajaTalonario.Padding = new System.Windows.Forms.Padding(3);
            this.tpNuevaCajaTalonario.Size = new System.Drawing.Size(737, 366);
            this.tpNuevaCajaTalonario.TabIndex = 0;
            this.tpNuevaCajaTalonario.Text = "Nueva Caja";
            // 
            // btnLimpiarProveedor
            // 
            this.btnLimpiarProveedor.Image = global::Comisariato.Properties.Resources.limpiar;
            this.btnLimpiarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarProveedor.Location = new System.Drawing.Point(363, 272);
            this.btnLimpiarProveedor.Name = "btnLimpiarProveedor";
            this.btnLimpiarProveedor.Size = new System.Drawing.Size(128, 72);
            this.btnLimpiarProveedor.TabIndex = 31;
            this.btnLimpiarProveedor.Text = "&Limpiar";
            this.btnLimpiarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Image = global::Comisariato.Properties.Resources.guardar11;
            this.btnGuardarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(214, 272);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(131, 72);
            this.btnGuardarUsuario.TabIndex = 30;
            this.btnGuardarUsuario.Text = "&Guardar";
            this.btnGuardarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            // 
            // gbDatosGeneralesCaja
            // 
            this.gbDatosGeneralesCaja.Controls.Add(this.txtEstacionCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.label11);
            this.gbDatosGeneralesCaja.Controls.Add(this.ckbActivoCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.dtpFechaCaducidadCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtAutorizacionCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtDocumentoActualCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtDocumentoFinalCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtDocumentoInicialCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.label10);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtSerie2Caja);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtSerie1Caja);
            this.gbDatosGeneralesCaja.Controls.Add(this.cbTipoDocumentoCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.label9);
            this.gbDatosGeneralesCaja.Controls.Add(this.label8);
            this.gbDatosGeneralesCaja.Controls.Add(this.label7);
            this.gbDatosGeneralesCaja.Controls.Add(this.label6);
            this.gbDatosGeneralesCaja.Controls.Add(this.label5);
            this.gbDatosGeneralesCaja.Controls.Add(this.label4);
            this.gbDatosGeneralesCaja.Controls.Add(this.label3);
            this.gbDatosGeneralesCaja.ForeColor = System.Drawing.Color.Teal;
            this.gbDatosGeneralesCaja.Location = new System.Drawing.Point(6, 100);
            this.gbDatosGeneralesCaja.Name = "gbDatosGeneralesCaja";
            this.gbDatosGeneralesCaja.Size = new System.Drawing.Size(706, 166);
            this.gbDatosGeneralesCaja.TabIndex = 1;
            this.gbDatosGeneralesCaja.TabStop = false;
            this.gbDatosGeneralesCaja.Text = "Datos Generales";
            // 
            // txtEstacionCaja
            // 
            this.txtEstacionCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEstacionCaja.Location = new System.Drawing.Point(179, 132);
            this.txtEstacionCaja.Name = "txtEstacionCaja";
            this.txtEstacionCaja.Size = new System.Drawing.Size(190, 22);
            this.txtEstacionCaja.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label11.Location = new System.Drawing.Point(21, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Estación:";
            // 
            // ckbActivoCaja
            // 
            this.ckbActivoCaja.AutoSize = true;
            this.ckbActivoCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ckbActivoCaja.Location = new System.Drawing.Point(633, 105);
            this.ckbActivoCaja.Name = "ckbActivoCaja";
            this.ckbActivoCaja.Size = new System.Drawing.Size(62, 20);
            this.ckbActivoCaja.TabIndex = 16;
            this.ckbActivoCaja.Text = "Activo";
            this.ckbActivoCaja.UseVisualStyleBackColor = true;
            // 
            // dtpFechaCaducidadCaja
            // 
            this.dtpFechaCaducidadCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dtpFechaCaducidadCaja.Location = new System.Drawing.Point(179, 104);
            this.dtpFechaCaducidadCaja.Name = "dtpFechaCaducidadCaja";
            this.dtpFechaCaducidadCaja.Size = new System.Drawing.Size(306, 22);
            this.dtpFechaCaducidadCaja.TabIndex = 15;
            // 
            // txtAutorizacionCaja
            // 
            this.txtAutorizacionCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtAutorizacionCaja.Location = new System.Drawing.Point(491, 77);
            this.txtAutorizacionCaja.Name = "txtAutorizacionCaja";
            this.txtAutorizacionCaja.Size = new System.Drawing.Size(204, 22);
            this.txtAutorizacionCaja.TabIndex = 14;
            // 
            // txtDocumentoActualCaja
            // 
            this.txtDocumentoActualCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtDocumentoActualCaja.Location = new System.Drawing.Point(179, 77);
            this.txtDocumentoActualCaja.Name = "txtDocumentoActualCaja";
            this.txtDocumentoActualCaja.Size = new System.Drawing.Size(190, 22);
            this.txtDocumentoActualCaja.TabIndex = 13;
            // 
            // txtDocumentoFinalCaja
            // 
            this.txtDocumentoFinalCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtDocumentoFinalCaja.Location = new System.Drawing.Point(491, 50);
            this.txtDocumentoFinalCaja.Name = "txtDocumentoFinalCaja";
            this.txtDocumentoFinalCaja.Size = new System.Drawing.Size(204, 22);
            this.txtDocumentoFinalCaja.TabIndex = 12;
            // 
            // txtDocumentoInicialCaja
            // 
            this.txtDocumentoInicialCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtDocumentoInicialCaja.Location = new System.Drawing.Point(179, 50);
            this.txtDocumentoInicialCaja.Name = "txtDocumentoInicialCaja";
            this.txtDocumentoInicialCaja.Size = new System.Drawing.Size(190, 22);
            this.txtDocumentoInicialCaja.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label10.Location = new System.Drawing.Point(577, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "-";
            // 
            // txtSerie2Caja
            // 
            this.txtSerie2Caja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtSerie2Caja.Location = new System.Drawing.Point(595, 24);
            this.txtSerie2Caja.Name = "txtSerie2Caja";
            this.txtSerie2Caja.Size = new System.Drawing.Size(100, 22);
            this.txtSerie2Caja.TabIndex = 9;
            // 
            // txtSerie1Caja
            // 
            this.txtSerie1Caja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtSerie1Caja.Location = new System.Drawing.Point(491, 24);
            this.txtSerie1Caja.Name = "txtSerie1Caja";
            this.txtSerie1Caja.Size = new System.Drawing.Size(82, 22);
            this.txtSerie1Caja.TabIndex = 8;
            // 
            // cbTipoDocumentoCaja
            // 
            this.cbTipoDocumentoCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbTipoDocumentoCaja.FormattingEnabled = true;
            this.cbTipoDocumentoCaja.Location = new System.Drawing.Point(179, 23);
            this.cbTipoDocumentoCaja.Name = "cbTipoDocumentoCaja";
            this.cbTipoDocumentoCaja.Size = new System.Drawing.Size(190, 24);
            this.cbTipoDocumentoCaja.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label9.Location = new System.Drawing.Point(375, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Autorización:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.Location = new System.Drawing.Point(375, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Documento Final:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.Location = new System.Drawing.Point(21, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha de Caducidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(21, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Documento Inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(21, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Documento Actual:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(375, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Serie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(21, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de Documento:";
            // 
            // gbUbicacionCaja
            // 
            this.gbUbicacionCaja.Controls.Add(this.cbBodegaCaja);
            this.gbUbicacionCaja.Controls.Add(this.cbSucursalCaja);
            this.gbUbicacionCaja.Controls.Add(this.label2);
            this.gbUbicacionCaja.Controls.Add(this.label1);
            this.gbUbicacionCaja.ForeColor = System.Drawing.Color.Teal;
            this.gbUbicacionCaja.Location = new System.Drawing.Point(153, 6);
            this.gbUbicacionCaja.Name = "gbUbicacionCaja";
            this.gbUbicacionCaja.Size = new System.Drawing.Size(431, 88);
            this.gbUbicacionCaja.TabIndex = 0;
            this.gbUbicacionCaja.TabStop = false;
            this.gbUbicacionCaja.Text = "Ubicación de la Caja";
            // 
            // cbBodegaCaja
            // 
            this.cbBodegaCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbBodegaCaja.FormattingEnabled = true;
            this.cbBodegaCaja.Location = new System.Drawing.Point(83, 53);
            this.cbBodegaCaja.Name = "cbBodegaCaja";
            this.cbBodegaCaja.Size = new System.Drawing.Size(333, 24);
            this.cbBodegaCaja.TabIndex = 3;
            // 
            // cbSucursalCaja
            // 
            this.cbSucursalCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbSucursalCaja.FormattingEnabled = true;
            this.cbSucursalCaja.Location = new System.Drawing.Point(83, 21);
            this.cbSucursalCaja.Name = "cbSucursalCaja";
            this.cbSucursalCaja.Size = new System.Drawing.Size(333, 24);
            this.cbSucursalCaja.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bodega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal:";
            // 
            // tpConsultarModificarDeshabilitarCaja
            // 
            this.tpConsultarModificarDeshabilitarCaja.BackColor = System.Drawing.Color.Bisque;
            this.tpConsultarModificarDeshabilitarCaja.Controls.Add(this.dgvDatosCaja);
            this.tpConsultarModificarDeshabilitarCaja.Controls.Add(this.txtConsultarCaja);
            this.tpConsultarModificarDeshabilitarCaja.Controls.Add(this.label12);
            this.tpConsultarModificarDeshabilitarCaja.Location = new System.Drawing.Point(4, 25);
            this.tpConsultarModificarDeshabilitarCaja.Name = "tpConsultarModificarDeshabilitarCaja";
            this.tpConsultarModificarDeshabilitarCaja.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsultarModificarDeshabilitarCaja.Size = new System.Drawing.Size(737, 366);
            this.tpConsultarModificarDeshabilitarCaja.TabIndex = 1;
            this.tpConsultarModificarDeshabilitarCaja.Text = "Consultar - Modificar Caja";
            // 
            // dgvDatosCaja
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCaja.Location = new System.Drawing.Point(19, 74);
            this.dgvDatosCaja.Name = "dgvDatosCaja";
            this.dgvDatosCaja.Size = new System.Drawing.Size(699, 244);
            this.dgvDatosCaja.TabIndex = 2;
            // 
            // txtConsultarCaja
            // 
            this.txtConsultarCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtConsultarCaja.Location = new System.Drawing.Point(180, 27);
            this.txtConsultarCaja.Name = "txtConsultarCaja";
            this.txtConsultarCaja.Size = new System.Drawing.Size(444, 22);
            this.txtConsultarCaja.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(93, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Consultar:";
            // 
            // FrmCajasTalonario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(779, 423);
            this.Controls.Add(this.tcCajaTalonario);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(795, 561);
            this.Name = "FrmCajasTalonario";
            this.Text = "Administrar Cajas/Talonarios";
            this.tcCajaTalonario.ResumeLayout(false);
            this.tpNuevaCajaTalonario.ResumeLayout(false);
            this.gbDatosGeneralesCaja.ResumeLayout(false);
            this.gbDatosGeneralesCaja.PerformLayout();
            this.gbUbicacionCaja.ResumeLayout(false);
            this.gbUbicacionCaja.PerformLayout();
            this.tpConsultarModificarDeshabilitarCaja.ResumeLayout(false);
            this.tpConsultarModificarDeshabilitarCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCajaTalonario;
        private System.Windows.Forms.TabPage tpNuevaCajaTalonario;
        private System.Windows.Forms.GroupBox gbDatosGeneralesCaja;
        private System.Windows.Forms.TextBox txtDocumentoFinalCaja;
        private System.Windows.Forms.TextBox txtDocumentoInicialCaja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSerie2Caja;
        private System.Windows.Forms.TextBox txtSerie1Caja;
        private System.Windows.Forms.ComboBox cbTipoDocumentoCaja;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbUbicacionCaja;
        private System.Windows.Forms.ComboBox cbBodegaCaja;
        private System.Windows.Forms.ComboBox cbSucursalCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpConsultarModificarDeshabilitarCaja;
        private System.Windows.Forms.TextBox txtEstacionCaja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ckbActivoCaja;
        private System.Windows.Forms.DateTimePicker dtpFechaCaducidadCaja;
        private System.Windows.Forms.TextBox txtAutorizacionCaja;
        private System.Windows.Forms.TextBox txtDocumentoActualCaja;
        private System.Windows.Forms.Button btnLimpiarProveedor;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.DataGridView dgvDatosCaja;
        private System.Windows.Forms.TextBox txtConsultarCaja;
        private System.Windows.Forms.Label label12;
    }
}