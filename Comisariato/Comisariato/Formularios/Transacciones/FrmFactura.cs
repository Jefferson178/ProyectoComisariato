﻿using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmFactura : Form
    {
        internal static List<string> DatosCliente = new List<string>();
        internal static int  correcta;
        internal static int verificadorfrm;
        private int cantidadanterior = 0, posicion, ivaporcentaje, tipoprecio = 0, cantmayorita = 20, fila,contador=0,factenter, tipoprecio1 = 0, formapago = 0,idcliente,fr;
        private string codactual = "",cantactual="";
        public string numcaja;
        public int numfact=0;
        List<String> listatipo = new List<String>();
        List<String> pedidos = new List<String>();
        List<int> indezp = new List<int>();
        List<Producto> retencionfact;
        List<string> codigos;
        private bool estadoiva, pr, escribiendo = false;
        Producto Producto;
        FrmClaveSupervisor s;
        FrmCobrar frmcobrar;
        public bool comprobarmetodo;

        public FrmFactura()
        {
            InitializeComponent();
            codigos = new List<string>();
          
        }

        private void rdbFacturaDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFacturaDatos.Checked)
            {
                txtIdentidicacion.Text = "";
                btnGuardar.Enabled = true;
                txtIdentidicacion.Enabled = true;
                txtIdentidicacion.Focus();
            }
            else
            {
                rdbFacturaDatos.Checked = false;
                txtCodigo.Focus();
            }
            //txtCodigo.Focus();
        }
       /// private String cliente = "", identificacion;
        private void rdbConsumidorFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbConsumidorFinal.Checked)
            {
                idcliente =3;
                btnGuardar.Enabled = false;
                txtConsumidor.Enabled = false;
                txtIdentidicacion.Enabled = false;
                txtIdentidicacion.Text = "9999999999999";
                txtConsumidor.Text = "Consumidor Final";
                DatosCliente.Clear();
            }
            else
            {
                rdbConsumidorFinal.Checked = false;
            }
            txtCodigo.Focus();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            // this.dgvDetalleProductos.CellValidating += new DataGridViewCellValidatingEventHandler(dgv_validating);
            //propiedadesdgv();

            txtCodigo.Focus();
            txtNumFact.Text = numfact.ToString("D8");
            txtCaja.Text = "00" + numcaja;
            lblCajero.Text = "Cajero:  " + Program.NOMBRES + "  " + Program.APELLIDOS;
            dgvDetalleProductos.Columns[2].DefaultCellStyle.BackColor = Color.LightCyan;
            dgvDetalleProductos.Columns[3].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            dgvDetalleProductos.Columns[4].DefaultCellStyle.BackColor = Color.LightCyan;
            dgvDetalleProductos.Columns[6].DefaultCellStyle.BackColor = Color.LightGreen;
            rdbFacturaDatos.Checked = false;
            rdbConsumidorFinal.Checked = true;

            //dgvFormaPago.Enabled = false;
            //dgvFormaPago.DefaultCellStyle.BackColor = Color.Silver;
            btnActivarFact.Enabled = false;
            btnFactEspera.Enabled = false;
            btnEliminarFact.Enabled = false;




            //DataGridViewComboBoxColumn comboboxColumn = dgvFormaPago.Columns["Tipo"] as DataGridViewComboBoxColumn;

            // comboboxColumn.DataSource = listatipo;

            for (int i = 0; i < 21; i++)
            {
                dgvDetalleProductos.Rows.Add();
            }
           
        }

        private void FrmFactura_Activated(object sender, EventArgs e)
        {
            if (verificadorfrm==0)
            {
                if (DatosCliente.Count > 0)
                {
                    txtIdentidicacion.Text = DatosCliente[0];
                    txtConsumidor.Text = DatosCliente[1];
                    rdbFacturaDatos.Checked = true;
                    txtCodigo.Focus();
                }
                else
                {
                    rdbConsumidorFinal.Checked = true;
                    txtCodigo.Focus();
                }
               
            }
            else
            {
                if (verificadorfrm==1)
                {
                    if (correcta == 1)
                    {
                        dgvDetalleProductos.Rows.RemoveAt(fila);
                        codigos.RemoveAt(fila);
                        if (codigos.Count>0)
                        {
                            Calcular();
                            //dgvDetalleProductos.Rows[codigos.Count-1].Selected = true;
                        }
                        else
                        {
                            factEspe = 1;
                            nuevafact();
                            if (codigos.Count>0)
                            {
                                dgvDetalleProductos.Rows[codigos.Count - 1].Selected = true;
                            }
                            else
                            {
                                dgvDetalleProductos.Rows[0].Selected = true;
                            }
                            
                        }
                       
                        
                        //ClicFila = false;
                        LimpiarTexbox();
                        verificadorfrm = 0;
                    }
                    else
                    {
                        dgvDetalleProductos.Rows[codigos.Count - 1].Selected = true;
                    }
                    txtCodigo.Focus();
                }
                else
                {
                    if (DatosCliente.Count>0 && verificadorfrm==2)
                    {
                        
                        if (rdbPublico.Checked)
                        {
                            txtPrecio.Text = DatosCliente[3];
                        }
                        else
                        {
                            if (rdbMayorista.Checked)
                            {
                                txtPrecio.Text = DatosCliente[4];
                            }
                            else
                            {
                                txtPrecio.Text = DatosCliente[5];
                            }
                        }

                        int verificariva = Convert.ToInt32(DatosCliente[6]);
                        //estadoiva = verificariva;
                        if (verificariva==1)
                        {
                            estadoiva = true;
                            ivaporcentaje = Convert.ToInt32( DatosCliente[7]);

                        }
                        else
                        {
                            estadoiva = false;
                            float prueba = 0.0f;
                            txtIvaPrecio.Text = prueba.ToString("#####0.00");
                        }

                        txtCodigo.Text = DatosCliente[0];
                        txtDetalle.Text = DatosCliente[1];
                        txtBodega.Text = DatosCliente[2];
                        txtCantidad.Focus();
                    }
                    else
                    {
                        if (verificadorfrm==3)
                        {
                                factEspe = 0;
                                nuevafact();
                            
                        }
                        else
                        {
                            factEspe = 1;
                            nuevafact();
                            escribiendo = false;
                            factenter = 0;
                        }
                        txtCodigo.Focus();
                    }
                   
                }
                
                
            }
            

            
        }

        private void dgvDetalleProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void factproducto(float iva, int n)
        {

            float total = 0.0f;
          
            if (n == 1)
            {
                //if (ClicFila)
                //{
                //    total = (Convert.ToSingle(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text)) + iva;
                //    dgvDetalleProductos.Rows[fr].Cells[0].Value = txtCodigo.Text;
                //    dgvDetalleProductos.Rows[fr].Cells[1].Value = txtDetalle.Text;
                //    dgvDetalleProductos.Rows[fr].Cells[2].Value = txtCantidad.Text;
                //    dgvDetalleProductos.Rows[fr].Cells[3].Value = txtBodega.Text;
                //    dgvDetalleProductos.Rows[fr].Cells[4].Value = txtPrecio.Text;
                //    dgvDetalleProductos.Rows[fr].Cells[5].Value = txtIvaPrecio.Text;
                //    dgvDetalleProductos.Rows[fr].Cells[6].Value = total;
                //    ClicFila = false;
                //    Calcular();
                //}
                //else
                //{
                    if (verificarcodigos(txtCodigo.Text))
                    {
                        if (Convert.ToInt32(txtBodega.Text) >= (Convert.ToInt32(txtCantidad.Text) + cantidadanterior))
                        {
                            dgvDetalleProductos.Rows[posicion].Cells[2].Value = Convert.ToInt32(txtCantidad.Text) + cantidadanterior;

                            float ivant = Convert.ToSingle(dgvDetalleProductos.Rows[posicion].Cells[5].Value.ToString()) + iva;
                            dgvDetalleProductos.Rows[posicion].Cells[5].Value = ivant.ToString("#####0.00");

                            total = (Convert.ToSingle(dgvDetalleProductos.Rows[posicion].Cells[4].Value.ToString()) * Convert.ToInt32(dgvDetalleProductos.Rows[posicion].Cells[2].Value.ToString())) + ivant;
                            //dgvDetalleProductos.CurrentRow.Cells[2].Value = Convert.ToInt32(dgvDetalleProductos.CurrentRow.Cells[2].Value.ToString()) + cantidadanterior;
                            dgvDetalleProductos.Rows[posicion].Cells[6].Value = total.ToString("#####0.00");

                           // LimpiarTexbox();
                           
                            cantidadanterior = 0;
                            posicion = 0;
                            Calcular();
                            pr = true;

                        }
                        else
                        {
                            MessageBox.Show("El Stock del Producto\n\rExistente es de " + Convert.ToInt32(dgvDetalleProductos.CurrentRow.Cells[3].Value.ToString()) + " unidades");
                            //SendKeys.Send("{up}");
                            txtCantidad.Focus();
                            pr = false;
                        }

                    }
                    else
                    {
                     
                        total = (Convert.ToSingle(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text)) + iva;
                        codigos.Add(txtCodigo.Text + ";" + tipoprecio);
                        AgregarFila(codigos.Count - 1, total);
                        Calcular();
                        pr = true;
                    }
                //}

               
            }
            else
            {
                //if (ClicFila)
                //{
                //    total = (Convert.ToSingle(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text)) + iva;
                //    dgvDetalleProductos.Rows[fr].Cells[0].Value = txtCodigo.Text;
                //    dgvDetalleProductos.Rows[fr].Cells[1].Value = txtDetalle.Text;
                //    dgvDetalleProductos.Rows[fr].Cells[2].Value = txtCantidad.Text;
                //    dgvDetalleProductos.Rows[fr].Cells[3].Value = txtBodega.Text;
                //    dgvDetalleProductos.Rows[fr].Cells[4].Value = txtPrecio.Text;
                //    dgvDetalleProductos.Rows[fr].Cells[5].Value = txtIvaPrecio.Text;
                //    dgvDetalleProductos.Rows[fr].Cells[6].Value = total;
                //    ClicFila = false;
                //    Calcular();
                //}
                //else
                //{
                    if (verificarcodigos(txtCodigo.Text))
                    {
                        if (Convert.ToInt32(txtBodega.Text) >= (Convert.ToInt32(txtCantidad.Text) + cantidadanterior))
                        {
                            dgvDetalleProductos.Rows[posicion].Cells[2].Value = Convert.ToInt32(txtCantidad.Text) + cantidadanterior;
                            total = Convert.ToInt32(dgvDetalleProductos.Rows[posicion].Cells[2].Value.ToString()) * Convert.ToSingle(dgvDetalleProductos.Rows[posicion].Cells[4].Value.ToString());
                            //dgvDetalleProductos.CurrentRow.Cells[2].Value = Convert.ToInt32(dgvDetalleProductos.CurrentRow.Cells[2].Value.ToString()) + cantidadanterior;
                            dgvDetalleProductos.Rows[posicion].Cells[6].Value = total.ToString("#####0.00");
                            //LimpiarTexbox();
                            Calcular();
                            pr = true;
                        }
                        else
                        {
                            MessageBox.Show("El Stock del Producto\n\rExistente es de " + Convert.ToInt32(txtBodega.Text) + " unidades");
                            txtCantidad.Focus();
                            pr = false;
                        }

                    }
                    else
                    {
                        total = Convert.ToInt32(txtCantidad.Text) * Convert.ToSingle(txtPrecio.Text);
                        codigos.Add(txtCodigo.Text + ";" + tipoprecio);
                        AgregarFila(codigos.Count - 1, total);
                       
                        pr = true;
                        Calcular();
                    }

                //}


            }

            // }

            if (codigos.Count > 0 && contador == 0)
            {
                btnFactEspera.Enabled = true;
                btnEliminarFact.Enabled = true;
            }
           // Calcular();

        }

        private void AgregarFila(int fila, float total)
        {
            dgvDetalleProductos.Rows[fila].Cells[0].Value = txtCodigo.Text;
            dgvDetalleProductos.Rows[fila].Cells[1].Value = txtDetalle.Text;
            dgvDetalleProductos.Rows[fila].Cells[2].Value = txtCantidad.Text;
            dgvDetalleProductos.Rows[fila].Cells[3].Value = txtBodega.Text;
            dgvDetalleProductos.Rows[fila].Cells[4].Value = txtPrecio.Text;
            dgvDetalleProductos.Rows[fila].Cells[5].Value = txtIvaPrecio.Text;
            dgvDetalleProductos.Rows[fila].Cells[6].Value = total;

        }

        private void LimpiarTexbox()
        {
            txtCodigo.Text = "";
            txtDetalle.Text = "";
            txtCantidad.Text = "";
            txtBodega.Text = "";
            txtPrecio.Text = "";
            txtIvaPrecio.Text = "";
            txtCodigo.Focus();
        }

        private void Calcular()
        {
            float sumasubiva = 0.0f, sumasubcero = 0.0f, totalpagar = 0.0f, ivatotal = 0.0f;
            try
            {
                for (int i = 0; i < codigos.Count; i++)
                {
                    // sumasub += Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[4].Value.ToString())+ Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[5].Value.ToString());
                    // if (verificador == 1)
                    //{
                    if (Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[5].Value) != 0)
                    {
                        sumasubiva += Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[6].Value.ToString());
                        ivatotal += Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[5].Value.ToString());
                    }
                    // }
                    //else
                    //{
                    if (Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[5].Value) == 0)
                    {
                        sumasubcero += Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[6].Value.ToString());
                    }
                    totalpagar += Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[6].Value.ToString());


                }
                txtSubTotalcero.Text = sumasubcero.ToString("#####0.00");
                txtSubTotal.Text = totalpagar.ToString("#####0.00");
                txtSubTotalIva.Text = sumasubiva.ToString("#####0.00");
                //totalpagar = sumasub + ivatotal;
                txtIva.Text = ivatotal.ToString("#####0.00");
                lblTotalPagar.Text = "$ " + totalpagar.ToString("#####0.00");
                codactual = "";
                factenter = 0;
                LimpiarTexbox();
                if (codigos.Count>1)
                {
                    dgvDetalleProductos.Rows[codigos.Count - 2].Selected = false;
                }
               
                dgvDetalleProductos.Rows[codigos.Count-1].Selected = true;
                //float prueba = Convert.ToSingle(totalpagar.ToString("#####0.00"));
            }
            catch (Exception EX)
            {

                MessageBox.Show("" + EX.Message);
            }

        }

        private void btnEliminarFact_Click(object sender, EventArgs e)
        {
            if (codigos.Count>0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar la factura?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (codigos.Count > 0)
                    {
                        factEspe = 1;
                        nuevafact();
                    }
                }
                else
                {
                    if (txtDetalle.Text != "")
                    {
                        txtCantidad.Focus();
                    }
                    else
                    {
                        txtCodigo.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay Items para eliminar");
                txtCodigo.Focus();
            }
           
                
           
        }

        private void ckbCredito_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckbEfectivo.Checked)
            //{
            //    dgvFormaPago.Enabled = true;
            //    dgvFormaPago.DefaultCellStyle.BackColor = Color.White;
            //}
            //else
            //{
            //    //dgvFormaPago.DefaultCellStyle.BackColor = Color.Silver;
            //    dgvFormaPago.Enabled = false;

            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            FrmDatosClientes f = new FrmDatosClientes();
            f.comprobarvista = 1;
            f.ShowDialog();
            txtCodigo.Focus();
        }

        private void txtIdentidicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Consultas objCns = new Consultas();
            if (txtIdentidicacion.Focus())
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    bool cedu=Funcion.VerificarCedula(txtIdentidicacion.Text);
                    if (cedu)
                    {
                        string datoscliente = objCns.buscarcliente(txtIdentidicacion.Text);
                        if (datoscliente != null)
                        {
                            string[] vector = datoscliente.Split(';');
                            txtConsumidor.Text = "" + vector[0];
                            idcliente = Convert.ToInt32(vector[1]);
                            comprobarmetodo = true;
                            txtCodigo.Focus();
                            //btnBuscar.Text = "Buscar";
                        }
                        else
                        {
                            txtIdentidicacion.Focus();
                            comprobarmetodo = false;
                            idcliente = 6;
                            //btnBuscar.Text = "Registrar";
                            if (MessageBox.Show("No existe un cliente registrado con la identificacion: " + txtIdentidicacion.Text + "\n¿Quieres registrarlo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                               FrmClientes f = new FrmClientes();
                                f.ShowDialog();
                            }
                            else
                            {
                                rdbConsumidorFinal.Checked = true;
                                txtCodigo.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cedula incorrecta.");
                        txtIdentidicacion.Focus();
                        rdbFacturaDatos.Checked = true;
                        rdbConsumidorFinal.Checked = false;
                    }
                   
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmDatosClientes f = new FrmDatosClientes();
            f.comprobarvista = 2;
            f.ShowDialog();
            txtCodigo.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FrmClaveUsuario u = new FrmClaveUsuario();
            u.verificarMetodo = 2;
            u.ShowDialog();
            txtCodigo.Focus();

            //FrmAvanse f = new FrmAvanse();
            //f.cajero = Program.NOMBRES + " " + Program.APELLIDOS;
            //f.fecha = Program.FecaInicio;
            //f.caja = txtCaja.Text;
            //f.ShowDialog();
            //txtCodigo.Focus();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReimprimirFact_Click(object sender, EventArgs e)
        {
            FrmReimprimirFact r = new FrmReimprimirFact();
            r.ShowDialog();
            txtCodigo.Focus();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FrmConsultarProducto p = new FrmConsultarProducto();
            p.ShowDialog();
            
        }

        private void dgvDetalleProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (e.Control is TextBox)
            //{
            //    TextBox txt = e.Control as TextBox;
            //    if (dgvDetalleProductos.CurrentCell == dgvDetalleProductos.CurrentRow.Cells[2])
            //    {
            //        txt.KeyPress += OnlyNumbers_KeyPress;
            //    }
            //}
        }

        //private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (dgvDetalleProductos.CurrentCell == dgvDetalleProductos.CurrentRow.Cells[2])
        //    {
        //        if (Char.IsDigit(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else if (Char.IsControl(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else if (Char.IsSeparator(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else
        //        {
        //            e.Handled = true;
        //        }
        //    }
                
            
        //}

        private void dgvDetalleProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Focus();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (e.KeyChar == (char)Keys.Return && txtCodigo.Text!="")
                {
                    Consultas objCns = new Consultas();
                    //Producto = new Producto();
                    Producto = new Producto();
                    codactual = txtCodigo.Text;
                    if (codactual != null)
                    {
                        Producto = objCns.Consultarproducto(txtCodigo.Text);
                        if (Producto != null)
                        {

                            if (Producto.Cantidad == 0)
                            {
                                MessageBox.Show("No hay unidades suficientes para vender.");
                                txtCodigo.Text = "";
                                txtCodigo.Focus();
                                pr = false;
                            }
                            else
                            {
                                if (Producto.Cantidad == 10)
                                {
                                    MessageBox.Show("Unidades actuales al limite.");
                                }

                                txtDetalle.Text = Producto.Nombreproducto;
                                txtBodega.Text = Producto.Cantidad.ToString();
                                if (tipoprecio == 0)
                                {
                                    txtPrecio.Text = Producto.Preciopublico_sin_iva.ToString("#####0.00");
                                }
                                else
                                {
                                    if (tipoprecio == 1)
                                    {

                                        txtPrecio.Text = Producto.Precioalmayor_sin_iva.ToString("#####0.00");
                                    }
                                    else
                                    {
                                        if (tipoprecio == 2)
                                        {
                                            txtPrecio.Text = Producto.Precioporcaja_sin_iva.ToString("#####0.00");
                                        }

                                    }
                                }

                                bool verificariva = Convert.ToBoolean(Producto.Ivaestado);
                                estadoiva = verificariva;
                                if (verificariva)
                                {
                                    ivaporcentaje = Producto.Iva;

                                }
                                else
                                {
                                    float prueba = 0.0f;
                                    txtIvaPrecio.Text = prueba.ToString("#####0.00");
                                }

                                escribiendo = false;
                                pr = false;
                                txtCantidad.Focus();
                            }
                            

                        }
                        else
                        {
                            codactual = "";
                            txtCodigo.Text = "";
                            escribiendo = false;
                            //MessageBox.Show("No existe un producto registrado con ese codigo.");
                            Producto = null;
                            factenter = 0;

                        }
                    }
                }
                else
                {
                    factenter++;

                    if (codigos.Count > 0)
                    {
                        if (factenter==2 && !escribiendo)
                        {
                            if (MessageBox.Show("¿Deseas Grabar esta Factura?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                grabarfact();
                            }
                            else
                            {
                                factenter = 0;
                                escribiendo =false;
                            }
                        }
                       
                    }
                    else
                    {
                        factenter = 0;
                    }
                   

                }
            }
            catch (Exception)
            {


            }
        }
       
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text!="")
            {
                escribiendo = true;
                //ClicFila = false;
            }
            else
            {
                escribiendo = false;
                factenter = 0;
            }
            
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                        cantactual = txtCantidad.Text;
                        float iva = 0.0f;
                    if (Convert.ToInt32(txtCantidad.Text)!=0)
                    {
                        if (estadoiva)
                        {
                            if (Convert.ToInt32(txtBodega.Text) >= Convert.ToInt32(txtCantidad.Text))
                            {
                                iva = ((Convert.ToSingle(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text)) * ivaporcentaje) / 100;
                                txtIvaPrecio.Text = iva.ToString("#####0.00");
                                if (tipoprecio == 1)
                                {
                                    if (Convert.ToInt32(txtCantidad.Text) >= cantmayorita)
                                    {
                                        factproducto(iva, 1);
                                       // txtCodigo.Focus();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La cantidad minima para comprar al mayor debe ser  " + cantmayorita);
                                        //SendKeys.Send("{up}");
                                        txtCantidad.Focus();
                                        pr = false;
                                    }
                                }
                                else
                                {
                                    if (tipoprecio == 0)
                                    {
                                        factproducto(iva, 1);
                                        //txtCodigo.Focus();
                                    }
                                    else
                                    {
                                        if (tipoprecio == 2)
                                        {
                                            factproducto(iva, 1);
                                            //txtCodigo.Focus();
                                        }

                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("El Stock del Producto\n\rExistente es de " + Convert.ToInt32(txtBodega.Text) + " unidades");
                                txtCantidad.Focus();
                                pr = false;
                            }


                        }
                        else
                        {
                            if (Convert.ToInt32(txtBodega.Text) >= Convert.ToInt32(txtCantidad.Text))
                            {
                                if (tipoprecio == 1)
                                {
                                    //if (Convert.ToInt32(txtCantidad.Text) >= cantmayorita)
                                    //{
                                        factproducto(iva, 2);
                                    //}
                                    //else
                                    //{
                                    //    MessageBox.Show("La cantidad minima para comprar al por mayor debe ser  " + cantmayorita);
                                    //    // SendKeys.Send("{up}");
                                    //    txtCantidad.Focus();
                                    //    pr = false;
                                    //}

                                }
                                else
                                {
                                    if (tipoprecio == 0)
                                    {
                                        factproducto(iva, 2);
                                        //txtCodigo.Focus();
                                    }
                                    else
                                    {
                                        if (tipoprecio == 2)
                                        {
                                            factproducto(iva, 2);
                                          //  txtCodigo.Focus();
                                        }

                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("El Stock del Producto\n\rExistente es de " +txtBodega.Text + " unidades");
                                //SendKeys.Send("{up}");
                                txtCantidad.Focus();
                                pr = false;
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Ingresa una cantidad diferente de cero.");
                        txtCantidad.Text = "";
                        txtCantidad.Focus();
                    }
                    // }
                }
                else
                {
                    Funcion.Validar_Numeros(e);
                }

            }
            catch (Exception)
            {

                // throw;
            }

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (estadoiva)
                {
                    float iva = ((Convert.ToSingle(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text)) * ivaporcentaje) / 100;
                    txtIvaPrecio.Text = iva.ToString("#####0.00");
                }
                
            }
            catch (Exception)
            {

                //throw;
            }
            
        }

        private void dgvDetalleProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDetalleProductos.CurrentCell != this.dgvDetalleProductos.CurrentRow.Cells[7])
                {
                    dgvDetalleProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                    txtCodigo.Focus();
                }
                else
                {
                    if (dgvDetalleProductos.Rows[e.RowIndex].Cells[0].Value != null && dgvDetalleProductos.Rows[e.RowIndex].Cells[1].Value != null)
                    {
                        if (verificarindex(e.RowIndex))
                        {
                            indezp.RemoveAt(posindexp);
                        }
                        else
                        {
                            indezp.Add(e.RowIndex);
                        }
                    }
                }
            }
            catch (Exception)
            {

                txtCodigo.Focus();
            }
          
        }

        private int posindexp =0;

        private void dgvDetalleProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetalleProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
            txtCodigo.Focus();
        }

        private void dgvDetalleProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetalleProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
            txtCodigo.Focus();

        }

        private void dgvDetalleProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (dgvDetalleProductos.Focus())
                {
                    if (codigos.Count>0)
                    {
                        if (MessageBox.Show("¿Deseas Grabar esta Factura?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            grabarfact();
                        }
                        else
                        {
                            txtCodigo.Focus();
                        }
                    }
                    
                }
            }
        }
        private bool verificarindex(int inde)
        {
            bool b = false;
            for (int i = 0; i < indezp.Count; i++)
            {
                if (indezp[i]==inde)
                {
                    posindexp = i;
                    b = true;
                }
            }
            return b;
        }

        private void ObtenerPedidos()
        {
            try
            {
                for (int i = 0; i < indezp.Count; i++)
                {
                   
                    pedidos.Add("" + dgvDetalleProductos.Rows[indezp[i]].Cells[1].Value + ";" + dgvDetalleProductos.Rows[indezp[i]].Cells[2].Value);
                   
                }
            }
            catch (Exception)
            {

                //throw;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < retencionfact.Count; i++)
                {
                    codigos.Add(retencionfact[i].Codigobarra);
                    dgvDetalleProductos.Rows[i].Cells[0].Value = retencionfact[i].Codigobarra;
                    dgvDetalleProductos.Rows[i].Cells[1].Value = retencionfact[i].Nombreproducto;
                    dgvDetalleProductos.Rows[i].Cells[2].Value = retencionfact[i].Cantidad;
                    dgvDetalleProductos.Rows[i].Cells[3].Value = retencionfact[i].Cantidad1;
                    dgvDetalleProductos.Rows[i].Cells[4].Value = retencionfact[i].Precioporcaja_sin_iva;
                    dgvDetalleProductos.Rows[i].Cells[5].Value = retencionfact[i].Precioporcaja_sin_iva;
                    dgvDetalleProductos.Rows[i].Cells[6].Value = retencionfact[i].Precioalmayor_sin_iva;

                }
                if (tipoprecio1==0)
                {
                    rdbPublico.Checked = true;
                }
                else
                {
                    if (tipoprecio1==1)
                    {
                        rdbMayorista.Checked = true;
                    }
                    else
                    {
                        rdbCaja.Checked = true;
                    }
                }
              
                Calcular();
                btnActivarFact.Enabled = false;
                btnFactEspera.Enabled = true;
                contador = 0;
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ex.Message);
            }
            
        }

        private void dgvDetalleProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (codigos.Count > 0)
            {
                fila = e.RowIndex;
                //dgvDetalleProductos.Rows[fila].Selected = true;
                s = new FrmClaveSupervisor();
                s.ShowDialog();
                txtCodigo.Focus();
            }
            else
            {
                txtCodigo.Focus();
            }
        }

        private bool verificarcodigos(string codigo)
        {
            bool b = false;
            String[] vector;
            if (codigos.Count>0)
            {
                for (int i = 0; i <codigos.Count; i++)
                {
                    vector = codigos[i].Split(';');
                    if (vector[0].Equals(codigo) && vector[1].Equals(Convert.ToString(tipoprecio)))
                    {
                        cantidadanterior = Convert.ToInt32(dgvDetalleProductos.Rows[i].Cells[2].Value.ToString());
                        posicion = i;
                        b =true;
                        break;
                        
                    }
                }
            }
           
           return b;
        }

        int factEspe = 0;
             
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigos.Count > 0)
                {
                    if (retencionfact.Count>0)
                    {
                        retencionfact.Clear();
                    }
                    retencionfact = new List<Producto>();
                    for (int i = 0; i < codigos.Count; i++)
                    {
                        if (dgvDetalleProductos.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            Producto p = new Producto();
                            p.Codigobarra = dgvDetalleProductos.Rows[i].Cells[0].Value.ToString();
                            p.Nombreproducto = dgvDetalleProductos.Rows[i].Cells[1].Value.ToString();
                            p.Cantidad = Convert.ToInt32(dgvDetalleProductos.Rows[i].Cells[2].Value.ToString());
                            p.Cantidad1 = Convert.ToInt32(dgvDetalleProductos.Rows[i].Cells[3].Value.ToString());
                            p.Preciopublico_sin_iva = Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[4].Value.ToString());
                            p.Precioporcaja_sin_iva = Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[5].Value.ToString());
                            p.Precioalmayor_sin_iva = Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[6].Value.ToString());
                            //codigos.Add(dgvDetalleProductos.Rows[i].Cells[0].Value.ToString());
                            retencionfact.Add(p);
                        }

                    }
                    btnActivarFact.Enabled = true;
                    btnFactEspera.Enabled = false;
                    nuevafact();
                    tipoprecio1 = tipoprecio;
                    contador=1;
                }
                txtCodigo.Focus();
                factEspe = 1;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }
        }

        private void rdbPublico_CheckedChanged(object sender, EventArgs e)
        {
            tipoprecio = 0;
        }

        private void rdbMayorista_CheckedChanged(object sender, EventArgs e)
        {
            tipoprecio = 1;
        }

        private void dgvDetalleProductos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            Funcion.ValidarNumerosStock(e, dgvDetalleProductos);
        }

        private void FrmFactura_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (codigos.Count>0)
                    {
                        if (MessageBox.Show("¿Deseas Grabar esta Factura?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            grabarfact();
                        }
                        else
                        {
                            txtCodigo.Focus();
                        }
                    }
                    
                    break;
                case Keys.F3:
                    
                    if (rdbFacturaDatos.Checked)
                    {
                        rdbConsumidorFinal.Checked = true;
                        rdbFacturaDatos.Checked = false;
                    }
                    else 
                    {
                        rdbFacturaDatos.Checked = true;
                        rdbConsumidorFinal.Checked = false;
                    }
                   
                    break;
               
                case Keys.F5:
                    if (rdbMayorista.Checked)
                    {
                        rdbMayorista.Checked = false;
                        rdbPublico.Checked = false;
                        rdbCaja.Checked = true;
                    }
                    else
                    {
                        if (rdbPublico.Checked)
                        {
                            rdbMayorista.Checked = true;
                            rdbPublico.Checked = false;
                            rdbCaja.Checked = false;
                        }
                        else
                        {
                            rdbMayorista.Checked = false;
                            rdbPublico.Checked = true;
                            rdbCaja.Checked = false;
                        }
                        
                    }
                    break;
                case Keys.F6:
                    FrmConsultarProducto p = new FrmConsultarProducto();
                    p.ShowDialog();
                    if (DatosCliente.Count>0)
                    {
                        txtCantidad.Focus();
                        
                    }
                    else
                    {
                        txtCodigo.Focus();
                    }
                    
                    break;
                case Keys.F7:
                    break;
                case Keys.F8:
                    break;
                case Keys.F9:
                    nuevafact();
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                

            }
        }

        private void grabarfact()
        {
            Program.em = new EmcabezadoFactura();
            Program.em.Sucursal = int.Parse(txtSucursal.Text);
            //Program.em.Descuento = Convert.ToSingle(txtDescuento.Text);
            Program.em.Caja = int.Parse(txtCaja.Text);
            Program.em.Fecha = DateTime.Now.Date.ToShortDateString();
            Program.em.Hora = DateTime.Now.TimeOfDay.ToString();
            //Program.em.Iva = Convert.ToSingle(txtIva.Text);
            Program.em.Idempleado = int.Parse(Program.IDUsuario);
            Program.em.Idcliente = idcliente;
            Program.em.Numfact = numfact;

            //Consultas objCns = new Consultas();
            // objCns.Insertar("INSERT INTO TbEncabezadoFactura (SUCURSAL,CAJA,NFACTURA,FECHA,HORA,DESCUENTO,IVA,IDEMPLEADO,IDCLIENTE) VALUES ('" + txtSucursal.Text + "','" + txtCaja.Text + "','"+txtNumFact.Text+"','"+Program.FecaInicio+"','"+ DateTime.Now.Date.ToShortDateString()+"','"+ DateTime.Now.TimeOfDay.ToString()+"','0','"+txtIva.Text+"','"+Program.IDUsuario+"','"+idcliente+"'"+ ");");
            //List<>
            frmcobrar = new FrmCobrar();
            frmcobrar.nombre = txtConsumidor.Text;
            frmcobrar.identificacion = txtIdentidicacion.Text;
            frmcobrar.descuentobd = txtDescuento.Text;
            frmcobrar.ivabd = txtIva.Text;
            frmcobrar.subtotal = txtSubTotal.Text;
            frmcobrar.subtotaconiva = txtSubTotalIva.Text;
            frmcobrar.descuento = txtDescuento.Text;
            frmcobrar.totalapagar = txtSubTotal.Text;
            frmcobrar.ivasuma = txtIva.Text;

            frmcobrar.total = Convert.ToSingle(txtSubTotal.Text);
            frmcobrar.dg = dgvDetalleProductos;
            frmcobrar.totalfilas = codigos.Count;
            ObtenerPedidos();
            frmcobrar.pedidos = pedidos;
            frmcobrar.ShowDialog();
            //nuevafact();
        }

        private void nuevafact()
        {
            verificadorfrm = 0;
            //MessageBox.Show("" + codigos.Count);
            if (factEspe!=1)
            {
                numfact += 1;
                DatosCliente.Clear();
            }
            
            txtNumFact.Text = numfact.ToString("D8");
            rdbPublico.Checked = true;
            rdbConsumidorFinal.Checked = true;
            //ckbEfectivo.Checked = true;
            //ckbCredito.Checked = false;
            dgvDetalleProductos.Rows.Clear();
            lblTotalPagar.Text = "$ 0.00";
            txtSubTotalcero.Text = "0.00";
            txtSubTotalIva.Text = "0.00";
            txtSubTotal.Text = "0.00";
            txtIva.Text = "0.00";
            codigos.Clear();
            btnFactEspera.Enabled = false;
            //btnEliminarFact.Enabled = false;
            factenter = 0;
            //MessageBox.Show(""+codigos.Count);
            for (int i = 0; i < 21; i++)
            {
                dgvDetalleProductos.Rows.Add();
            }
            txtCodigo.Focus();
        }

        private void rdbCaja_CheckedChanged(object sender, EventArgs e)
        {
            tipoprecio = 2;
        }

    }
}
