namespace Comisariato.Formularios.Transacciones.Devolucion_Venta
{
    partial class FrmDevolucionVenta
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
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.txtNumFact = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvDetalleFact = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.txtTotalDevolucion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleFact)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSucursal
            // 
            this.txtSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucursal.Location = new System.Drawing.Point(104, 34);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(100, 22);
            this.txtSucursal.TabIndex = 0;
            this.txtSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSucursal_KeyPress);
            // 
            // txtCaja
            // 
            this.txtCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.Location = new System.Drawing.Point(227, 34);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(100, 22);
            this.txtCaja.TabIndex = 1;
            this.txtCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaja_KeyPress);
            // 
            // txtNumFact
            // 
            this.txtNumFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFact.Location = new System.Drawing.Point(350, 34);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.Size = new System.Drawing.Size(168, 22);
            this.txtNumFact.TabIndex = 2;
            this.txtNumFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumFact);
            this.groupBox1.Controls.Add(this.txtSucursal);
            this.groupBox1.Controls.Add(this.txtCaja);
            this.groupBox1.Location = new System.Drawing.Point(53, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serie Factura";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(22, 71);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(384, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Devolver toda la Venta";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nº. FACT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "DEVOLUCIONES";
            // 
            // DgvDetalleFact
            // 
            this.DgvDetalleFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleFact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DETALLE,
            this.CANTIDAD,
            this.PRECIO,
            this.IVA,
            this.TOTAL,
            this.Anular});
            this.DgvDetalleFact.Location = new System.Drawing.Point(53, 171);
            this.DgvDetalleFact.Name = "DgvDetalleFact";
            this.DgvDetalleFact.Size = new System.Drawing.Size(744, 363);
            this.DgvDetalleFact.TabIndex = 5;
            this.DgvDetalleFact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalleFact_CellClick);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Width = 150;
            // 
            // DETALLE
            // 
            this.DETALLE.HeaderText = "Detalle";
            this.DETALLE.Name = "DETALLE";
            this.DETALLE.Width = 175;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "Cantidad";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Width = 80;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "Precio";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Width = 80;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "Iva";
            this.IVA.Name = "IVA";
            this.IVA.Width = 80;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Width = 80;
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.Name = "Anular";
            this.Anular.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Anular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Anular.Width = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Enabled = false;
            this.txtTotalFactura.Location = new System.Drawing.Point(466, 552);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFactura.TabIndex = 8;
            // 
            // txtTotalDevolucion
            // 
            this.txtTotalDevolucion.Enabled = false;
            this.txtTotalDevolucion.Location = new System.Drawing.Point(697, 552);
            this.txtTotalDevolucion.Name = "txtTotalDevolucion";
            this.txtTotalDevolucion.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDevolucion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Devolucion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Factura:";
            // 
            // FrmDevolucionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 665);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalDevolucion);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgvDetalleFact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDevolucionVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleFact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.TextBox txtNumFact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvDetalleFact;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.TextBox txtTotalDevolucion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DETALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
    }
}