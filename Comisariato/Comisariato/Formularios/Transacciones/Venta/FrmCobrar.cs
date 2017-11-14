using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmCobrar : Form
    {
        public float total;
        public int totalfilas,tipòpago=1;
        public string nombre, identificacion,descuentobd,ivabd;
        public DataGridView dg;
        Consultas c;
        public List<String> pedidos;
        public List<String> ivas;
        public string subtotal, subtotaconiva, descuento, ivasuma, totalapagar;
        //private bool chequear;
        public FrmCobrar()
        {
            InitializeComponent();
        }

        private void FrmCobrar_Load(object sender, EventArgs e)
        {
            txtEfectivo.Focus();
            txtTotalPagar.Text = total.ToString("#####0.00");
            dgvTarjeta.Enabled = false;
            dgvCheque.Enabled = false;
            txtRecibido.Text = "0.00";
           // MessageBox.Show("Filas: "+dg.RowCount+"  Columnas: "+dg.ColumnCount);
        }

        private void ckbCheque_CheckedChanged(object sender, EventArgs e)
        {
            tipòpago = 2;
            if (ckbCheque.Checked)
            {
                dgvCheque.Enabled = true;
                dgvCheque.CurrentCell = dgvCheque.Rows[0].Cells[0];
                dgvCheque.BeginEdit(true);
                Calcular();
            }
            else
            {
                dgvCheque.Enabled = false;
                Calcular();
            }
        }

       


        private void ckbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            tipòpago = 1;
            if (ckbEfectivo.Checked)
            {
                //txtCambio.Enabled = true;
                //txtRecibido.Enabled = true;
                //txtTotalPagar.Enabled = true;
                txtEfectivo.Focus();
                txtEfectivo.Enabled = true;
                Calcular();
            }
            else
            {
                txtEfectivo.Enabled = false;
                Calcular();
                //gbDinero.Enabled = false;
            }
        }

        private void ckbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            tipòpago = 3;
            if (ckbTarjeta.Checked)
            {
                dgvTarjeta.Enabled = true;
                dgvTarjeta.CurrentCell = dgvTarjeta.Rows[rowsdgvcredito].Cells[0];
                dgvTarjeta.BeginEdit(true);
                Calcular();
            }
            else
            {
                dgvTarjeta.Enabled = false;
                Calcular();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private int rowsdgvcheque = 0,rowsdgvcredito=0;
        private void dgvCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Return)
            //{
            //    if (dgvCheque.CurrentCell == dgvCheque.CurrentRow.Cells[0])
            //    {
            //        if (dato != null)
            //        {
            //            dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[1];
            //            dgvCheque.BeginEdit(true);
            //            //rowsdgvcheque++;
            //            dato = "";
            //        }
            //        else
            //        {
            //            dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[0];
            //            dgvCheque.BeginEdit(true);
            //        }
            //    }
            //    else
            //    {
            //        if (dgvCheque.CurrentCell == dgvCheque.CurrentRow.Cells[1])
            //        {
            //            if (dato != null)
            //            {
            //                dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[2];
            //                dgvCheque.BeginEdit(true);
            //                //rowsdgvcheque++;
            //                dato = "";
            //            }
            //            else
            //            {
            //                dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[1];
            //                dgvCheque.BeginEdit(true);
            //            }
            //        }
            //    }
            //}
                
        }
        string dato = "";
        private DateTimePicker oDateTimePicker;

        private void dgvCheque_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dato =Convert.ToString(dgvCheque.CurrentRow.Cells[e.ColumnIndex].Value);
            SendKeys.Send("{UP}");
            //SendKeys.Send("{TAB}");
        }

        private void dgvTarjeta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dato = Convert.ToString(dgvTarjeta.CurrentRow.Cells[e.ColumnIndex].Value);
            SendKeys.Send("{UP}");
            // MessageBox.Show("escibiendo...");
        }

        private void dgvCheque_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    if (dgvCheque.CurrentCell == this.dgvCheque.CurrentRow.Cells[0])
                    {
                        if (dato != "")
                        {
                            dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[1];
                            dgvCheque.BeginEdit(true);
                            dato = "";
                        }
                        else
                        {
                            dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[0];
                            dgvCheque.BeginEdit(true);
                        }
                    }
                    else
                    {
                        if (dgvCheque.CurrentCell == this.dgvCheque.CurrentRow.Cells[1])
                        {
                            if (dato != "")
                            {
                                dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[2];
                                dgvCheque.BeginEdit(true);
                                dato = "";
                            }
                            else
                            {
                                dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[1];
                                dgvCheque.BeginEdit(true);
                            }
                        }
                        else
                        {
                            if (dgvCheque.CurrentCell == this.dgvCheque.CurrentRow.Cells[2])
                            {
                                if (dato != "")
                                {
                                    SendKeys.Send("{right}");
                                    SendKeys.Send("{up}");
                                    //dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[2];
                                    //dgvCheque.BeginEdit(true);
                                    dato = "";
                                }
                                else
                                {
                                    // Me
                                    dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[2];
                                    dgvCheque.BeginEdit(true);
                                }
                            }
                            else
                            {
                                if (dgvCheque.CurrentCell == this.dgvCheque.CurrentRow.Cells[3])
                                {
                                    if (dato != "")
                                    {
                                        dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[4];
                                        dgvCheque.BeginEdit(true);
                                        dato = "";
                                    }
                                    else
                                    {
                                        dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[3];
                                        dgvCheque.BeginEdit(true);
                                    }
                                }
                                else
                                {
                                    if (dgvCheque.CurrentCell == this.dgvCheque.CurrentRow.Cells[4])
                                    {
                                        if (dato != "")
                                        {
                                            dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[5];
                                            dgvCheque.BeginEdit(true);
                                            dato = "";
                                        }
                                        else
                                        {
                                            //MessageBox.Show("Todos los datos son requeridos.");
                                            dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[4];
                                            dgvCheque.BeginEdit(true);
                                        }
                                    }
                                    else
                                    {
                                        if (dgvCheque.CurrentCell == this.dgvCheque.CurrentRow.Cells[5])
                                        {
                                            if (dato != "")
                                            {
                                                rowsdgvcheque++;
                                                dato = "";
                                                txtEfectivo.Focus();
                                                Calcular();
                                            }
                                            else
                                            {
                                                //MessageBox.Show("Todos los datos son requeridos.");
                                                dgvCheque.CurrentCell = dgvCheque.Rows[rowsdgvcheque].Cells[5];
                                                dgvCheque.BeginEdit(true);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    //throw;
                }
            }
              
        }

        private void dgvTarjeta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    if (dgvTarjeta.CurrentCell == this.dgvTarjeta.CurrentRow.Cells[0])
                    {
                        if (dato != "")
                        {
                            SendKeys.Send("{right}");
                            SendKeys.Send("{up}");
                            //dgvTarjeta.CurrentCell = dgvTarjeta.Rows[rowsdgvcredito].Cells[1];
                            //dgvTarjeta.BeginEdit(true);
                            dato = "";
                        }
                        else
                        {
                            dgvTarjeta.CurrentCell = dgvTarjeta.Rows[rowsdgvcredito].Cells[0];
                            dgvTarjeta.BeginEdit(true);
                        }
                    }
                    else
                    {
                        if (dgvTarjeta.CurrentCell == this.dgvTarjeta.CurrentRow.Cells[1])
                        {
                            if (dato != "")
                            {
                                dgvTarjeta.CurrentCell = dgvTarjeta.Rows[rowsdgvcredito].Cells[2];
                                dgvTarjeta.BeginEdit(true);
                                dato = "";
                            }
                            else
                            {
                                dgvTarjeta.CurrentCell = dgvTarjeta.Rows[rowsdgvcredito].Cells[1];
                                dgvTarjeta.BeginEdit(true);
                            }
                        }
                        else
                        {
                            if (dgvTarjeta.CurrentCell == this.dgvTarjeta.CurrentRow.Cells[2])
                            {
                                if (dato != "")
                                {
                                    
                                    dgvTarjeta.CurrentCell = dgvTarjeta.Rows[rowsdgvcredito].Cells[3];
                                    dgvTarjeta.BeginEdit(true);
                                    Calcular();
                                    dato = "";
                                }
                                else
                                {
                                    // Me
                                    dgvTarjeta.CurrentCell = dgvTarjeta.Rows[rowsdgvcredito].Cells[2];
                                    dgvTarjeta.BeginEdit(true);
                                }
                            }
                            else
                            {
                                if (dgvTarjeta.CurrentCell == this.dgvTarjeta.CurrentRow.Cells[3])
                                {
                                    if (dato != "")
                                    {
                                        rowsdgvcredito++;
                                        //Calcular();
                                        txtEfectivo.Focus();
                                        dato = "";
                                    }
                                    else
                                    {
                                        dgvTarjeta.CurrentCell = dgvTarjeta.Rows[rowsdgvcredito].Cells[3];
                                        dgvTarjeta.BeginEdit(true);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    // throw;
                }
            }
               

        }

        private void FrmCobrar_KeyUp(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Return)
            //{
            //    if (dgvCheque.Focus() && chequear)
            //    {
                   
                   
            //    }
            //    if (dgvTarjeta.Focus() && !chequear)
            //    {
                   
            //    }

            //}
        }

        private void dgvCheque_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox txt = e.Control as TextBox;

               
                    txt.KeyPress += OnlyNumbersdgvcheque_KeyPress;
                   // Funcion.SoloValores(e,txt);
             }
                   
               
            
        }

        private void OnlyNumbersdgvcheque_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (dgvCheque.CurrentCell == this.dgvCheque.CurrentRow.Cells[0] || dgvCheque.CurrentCell == this.dgvCheque.CurrentRow.Cells[1])
             {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // Si no es numerico y si no es espacio
                {
                    // Invalidar la accion
                    e.Handled = true;
                    // Enviar el sonido de beep de windows
                    System.Media.SystemSounds.Beep.Play();
                }

            }


        }

        private void OnlyNumbersdgvTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvTarjeta.CurrentCell == this.dgvTarjeta.CurrentRow.Cells[0])
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // Si no es numerico y si no es espacio
                {
                    // Invalidar la accion
                    e.Handled = true;
                    // Enviar el sonido de beep de windows
                    System.Media.SystemSounds.Beep.Play();
                }

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEfectivo.Text=="")
                {
                    txtCambio.Text = "0.00";
                }
                else
                {
                    Calcular();
                }
                

            }
            catch (Exception ex)
            {
            }
        }

        private void dgvTarjeta_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox txt = e.Control as TextBox;


                txt.KeyPress += OnlyNumbersdgvTarjeta_KeyPress;
                // Funcion.SoloValores(e,txt);
            }

        }

        private void dgvCheque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCheque.CurrentCell==this.dgvCheque.CurrentRow.Cells[3] && e.RowIndex ==rowsdgvcheque)
            {
                //Initialized a new DateTimePicker Control  
                oDateTimePicker = new DateTimePicker();

                //Adding DateTimePicker control into DataGridView   
                dgvCheque.Controls.Add(oDateTimePicker);

                // Setting the format (i.e. 2014-10-10)  
                oDateTimePicker.Format = DateTimePickerFormat.Short;

                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = dgvCheque.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                // An event attached to dateTimePicker Control which is fired when any date is selected  
                oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                // Now make it visible  
                oDateTimePicker.Visible = true;
            }
        }


        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            dgvCheque.CurrentRow.Cells[3].Value = oDateTimePicker.Text.ToString();
            dato= oDateTimePicker.Text.ToString();
            dgvCheque.Focus();
            dgvCheque.CurrentCell = dgvCheque.CurrentRow.Cells[4];
            dgvCheque.BeginEdit(true);

        }

        void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use   
            oDateTimePicker.Visible = false;
            dgvCheque.Focus();
            dgvCheque.CurrentCell = dgvCheque.CurrentRow.Cells[4];
            dgvCheque.BeginEdit(true);

        }

        private void dgvTarjeta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTarjeta.CurrentCell == this.dgvTarjeta.CurrentRow.Cells[1]  &&  e.RowIndex== rowsdgvcredito)
            {
                //Initialized a new DateTimePicker Control  
                oDateTimePicker = new DateTimePicker();

                //Adding DateTimePicker control into DataGridView   
                dgvTarjeta.Controls.Add(oDateTimePicker);

                // Setting the format (i.e. 2014-10-10)  
                oDateTimePicker.Format = DateTimePickerFormat.Short;

                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = dgvTarjeta.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                oDateTimePicker.CloseUp += new EventHandler(oDateTimePickerdgvtarjeta_CloseUp);

                // An event attached to dateTimePicker Control which is fired when any date is selected  
                oDateTimePicker.TextChanged += new EventHandler(dateTimePickerdgvtarjeta_OnTextChange);

                // Now make it visible  
                oDateTimePicker.Visible = true;
            }
        }

        void oDateTimePickerdgvtarjeta_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use   
            oDateTimePicker.Visible = false;
            dgvTarjeta.Focus();
            dgvTarjeta.CurrentCell = dgvTarjeta.CurrentRow.Cells[2];
            dgvTarjeta.BeginEdit(true);

        }

        private void dateTimePickerdgvtarjeta_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            dgvTarjeta.CurrentRow.Cells[1].Value = oDateTimePicker.Text.ToString();
            dato = oDateTimePicker.Text.ToString();
            dgvTarjeta.Focus();
            dgvTarjeta.CurrentCell = dgvTarjeta.CurrentRow.Cells[2];
            dgvTarjeta.BeginEdit(true);

        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ProceCambioBd();
            }
            else
            {
                Funcion.SoloValores(e, txtEfectivo.Text);
            }
        }

        private void dgvCheque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void dgvTarjeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRecibido_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtRecibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Return)
            //{
            //    ProceCambioBd();
            //}
            //else
            //{
            //    Funcion.SoloValores(e,txtRecibido);
            //}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProceCambioBd();


            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ ex.Message);
            }
          
        }

        private void ProceCambioBd()
        {
            c = new Consultas();
            try
            {
                int sucursal = Program.em.Sucursal;
                int caja = Program.em.Caja;
                int numfactbd = Program.em.Numfact;
                string fechabd = Program.em.Fecha;
                string horabd = Program.em.Hora;
                int idempleadobd = Program.em.Idempleado;
                int idclientebd = Program.em.Idcliente;
                //string ivastring = Funcion.reemplazarcaracter(ivabd.ToString());
                //string des = Funcion.reemplazarcaracter(descuentobd.ToString());
                if (Convert.ToSingle(txtRecibido.Text) >= total)
                {
                    List<string> encabezadofact = new List<string>();
                    List<string> detallepago = new List<string>();
                    encabezadofact.Add(""+sucursal);
                    encabezadofact.Add("" + caja);
                    encabezadofact.Add("" + numfactbd);
                    encabezadofact.Add("" + fechabd);
                    encabezadofact.Add("" + horabd);
                    encabezadofact.Add("" + idempleadobd);
                    encabezadofact.Add("" + idclientebd);

                    detallepago.Add(ivabd);
                    detallepago.Add(descuentobd);
                    if (txtEfectivo.Text=="")
                    {
                        txtEfectivo.Text = "0.00";
                    }
                    if (txtCredito.Text=="")
                    {
                        txtCredito.Text = "0.00";
                    }
                    if (txtCheque.Text=="")
                    {
                        txtCheque.Text = "0.00";
                    }

                    detallepago.Add(txtEfectivo.Text);
                    detallepago.Add(txtCheque.Text);
                    detallepago.Add(txtCredito.Text);
                    detallepago.Add(txtRecibido.Text);
                    detallepago.Add(txtCambio.Text);

                    bool b = c.GuardarFact(totalfilas, dg, encabezadofact, detallepago,ivas);
                    if (b)
                    {
                        
                        string condicion = " where CAJA = '" + caja + "' and SUCURSAL= '" + sucursal+"';";
                        if (ckbCheque.Checked)
                        {
                            int ult = c.ObtenerID("IDFACTURA", "TbEncabezadoFactura",condicion);
                            bool d = c.RegistrarCheque(dgvCheque, ult);
                        }
                        if (ckbTarjeta.Checked)
                        {
                            int ult = c.ObtenerID("IDFACTURA", "TbEncabezadoFactura",condicion);
                            bool e = c.RegistrarTarjeta(dgvTarjeta, ult);
                        }
                       
                        if (pedidos.Count > 0)
                        {
                            ImprimirenRed();
                        }

                        Imprimirfact();
                        FrmFactura.verificadorfrm = 3;
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error... No se pudo grabar la factura.");
                    }


                }
                else
                {
                    MessageBox.Show("El dinero recibido de ser mayor o igual al tota a pagar.");
                    txtRecibido.Focus();
                }
            }
            catch (Exception)
            {

                //throw;
            }
           
        }

       

        private void Imprimirfact()
        {
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo
            string fechaf = Program.FecaInicio;
            int sucursal= Program.em.Sucursal;
            int numcaja = Program.em.Caja;
            int numfac = Program.em.Numfact;
            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("EMPRESA: COMISARIATO SUPER DOS");
            ticket.TextoCentro("RUC: 1802114429001");
            ticket.TextoIzquierda("Direccion: AV LA GUAYAS 207 Y ABDON CALD");
            ticket.TextoIzquierda("Valido: "+ fechaf+" Hasta: " +fechaf);
            ticket.TextoIzquierda("Clave: 4530000");
            ticket.TextoIzquierda("        Factura: "+sucursal.ToString("D4") + "-"+numcaja.ToString("D4") + "-"+numfac.ToString("D8"));
            ticket.TextoIzquierda("         Informacion del Consumidor");//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("RUC: "+identificacion);
            ticket.TextoIzquierda("Cliente: "+nombre);
            ticket.TextoIzquierda("Facturado: "+Program.NOMBRES+" "+Program.APELLIDOS);
            string[] h = DateTime.Now.TimeOfDay.ToString().Split('.');
            ticket.TextoIzquierda("Fecha: "+Program.FecaInicio+"          "+ h[0]);
            if (ckbCheque.Checked && ckbEfectivo.Checked && ckbTarjeta.Checked)
            {
                ticket.TextoIzquierda("Tipo de pago: Efectivo - Cheque - T. Credito");
            }
            else
            {
                if (ckbCheque.Checked && ckbTarjeta.Checked)
                {
                    ticket.TextoIzquierda("Tipo de pago: Cheque - T. Credito");
                }
                else
                {
                    if (ckbTarjeta.Checked && ckbEfectivo.Checked)
                    {
                        ticket.TextoIzquierda("Tipo de pago: Efectivo - T. Credito");
                    }
                    else
                    {
                        if (ckbCheque.Checked && ckbEfectivo.Checked)
                        {
                            ticket.TextoIzquierda("Tipo de pago: Efectivo - Cheque");
                        }
                        else
                        {
                            if (ckbEfectivo.Checked)
                            {
                                ticket.TextoIzquierda("Tipo de pago: Efectivo");
                            }
                            else
                            {
                                if (ckbCheque.Checked)
                                {
                                    ticket.TextoIzquierda("Tipo de pago: Cheque");
                                }
                                else
                                {
                                    if (ckbTarjeta.Checked)
                                    {
                                        ticket.TextoIzquierda("Tipo de pago: T. Credito");
                                    }
                                }
                            }
                        }
                    }

                }
            }
            ticket.lineasAsteriscos();

            float imsubtotal=0, imivasuma=0,subtotaliva=0;
            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            for (int i = 0; i < totalfilas; i++)//dgvLista es el nombre del datagridview
            {
                float total = Convert.ToSingle(dg.Rows[i].Cells[4].Value.ToString()) * Convert.ToInt32(dg.Rows[i].Cells[2].Value.ToString());
                if (Convert.ToSingle( dg.Rows[i].Cells[5].Value.ToString())!=0)
                {
                    ticket.AgregaArticulo("*"+dg.Rows[i].Cells[1].Value.ToString(), int.Parse(dg.Rows[i].Cells[2].Value.ToString()),
                Convert.ToSingle(dg.Rows[i].Cells[4].Value).ToString("#####0.00"), total.ToString("#####0.00"));

                    imivasuma += Convert.ToSingle(dg.Rows[i].Cells[5].Value.ToString());
                    subtotaliva += Convert.ToSingle(dg.Rows[i].Cells[6].Value.ToString());
                }
                else {
                    ticket.AgregaArticulo(" "+dg.Rows[i].Cells[1].Value.ToString(), int.Parse(dg.Rows[i].Cells[2].Value.ToString()),
                Convert.ToSingle(dg.Rows[i].Cells[4].Value).ToString("#####0.00"), total.ToString("#####0.00"));
                }
                imsubtotal += total;
            }
           
            ticket.lineasAsteriscos();
            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("SUBTOTAL ",Convert.ToSingle(Funcion.reemplazarcaracter(Convert.ToString(imsubtotal))));
            ticket.AgregarTotales("SUBTOTAL 12% ", Convert.ToSingle(Funcion.reemplazarcaracter(Convert.ToString(subtotaliva))));
            ticket.AgregarTotales("Descuento", Convert.ToSingle(Funcion.reemplazarcaracter(descuento)));
            ticket.AgregarTotales("Iva 12%  ", Convert.ToSingle(Funcion.reemplazarcaracter(Convert.ToString(imivasuma))));
            ticket.AgregarTotales("Total a pagar", Convert.ToSingle(Funcion.reemplazarcaracter(totalapagar)));
            
            if (ckbCheque.Checked && ckbEfectivo.Checked && ckbTarjeta.Checked)
            {
                ticket.TextoIzquierda("Efectivo:  $" + txtEfectivo.Text);
                ticket.TextoIzquierda("Cheque:    $" + txtCheque.Text);
                ticket.TextoIzquierda("T. Credito $: " + txtCredito.Text);
                ticket.TextoIzquierda("Recibido: $" + txtRecibido.Text+ " Cambio: $" +txtCambio.Text);
            }
            else
            {
                if (ckbCheque.Checked && ckbTarjeta.Checked)
                {
                    //ticket.TextoIzquierda("Cheque:  $" + txtEfectivo.Text);
                    ticket.TextoIzquierda("Cheque:    $" + txtCheque.Text);
                    ticket.TextoIzquierda("T. Credito $: " + txtCredito.Text);
                    ticket.TextoIzquierda("Recibido: $" + txtRecibido.Text + " Cambio: $" + txtCambio.Text);
                }
                else
                {
                    if (ckbTarjeta.Checked && ckbEfectivo.Checked)
                    {
                        ticket.TextoIzquierda("Efectivo:  $" + txtEfectivo.Text);
                        //ticket.TextoIzquierda("Cheque:    $" + txtCheque.Text);
                        ticket.TextoIzquierda("T. Credito $: " + txtCredito.Text);
                        ticket.TextoIzquierda("Recibido: $" + txtRecibido.Text + " Cambio: $" + txtCambio.Text);
                    }
                    else
                    {
                        if (ckbCheque.Checked&& ckbEfectivo.Checked)
                        {
                            ticket.TextoIzquierda("Efectivo:  $" + txtEfectivo.Text);
                            ticket.TextoIzquierda("Cheque:    $" + txtCheque.Text);
                            // ticket.TextoIzquierda("T. Credito $: " + txtCredito.Text);
                            ticket.TextoIzquierda("Recibido: $" + txtRecibido.Text + " Cambio: $" + txtCambio.Text);
                        }
                        else
                        {
                            if (ckbEfectivo.Checked)
                            {
                                ticket.TextoIzquierda("Efectivo:  $" + txtEfectivo.Text);
                                ticket.TextoIzquierda("Recibido: $" + txtEfectivo.Text+" Cambio: $"+txtCambio.Text);
                                //ticket.TextoIzquierda("Recibido: $" + txtRecibido.Text + " Cambio: $" + txtCambio.Text);
                            }
                            else
                            {
                                if (ckbCheque.Checked)
                                {
                                    ticket.TextoIzquierda("Cheque:    $" + txtCheque.Text);
                                    ticket.TextoIzquierda("Recibido: $" + txtRecibido.Text + " Cambio: $" + txtCambio.Text);
                                }
                                else
                                {
                                    if (ckbTarjeta.Checked)
                                    {
                                        ticket.TextoIzquierda("T. Credito $: " + txtCredito.Text);
                                        ticket.TextoIzquierda("Recibido: $" + txtRecibido.Text + " Cambio: $" + txtCambio.Text);
                                    }
                                }
                            }
                        }
                    }
                   
                }
            }
            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTICULOS VENDIDOS: "+totalfilas);
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.CortaTicket();
            ticket.ImprimirTicket("Generic / Text Only");//Nombre de la impresora ticketera

        }

        private void ImprimirenRed()
        {
            CrearTicket ticket = new CrearTicket();
            int numcaja = Program.em.Caja;
            //PrintDialog pd = new PrintDialog();
            //pd.PrinterSettings = new PrinterSettings();
            //if (DialogResult.OK == pd.ShowDialog(this))
            //{
                ticket.TextoCentro("COMISARIATO SUPER2");
            ticket.TextoCentro("              ");
            ticket.TextoCentro("PEDIDO A BODEGA");
            ticket.TextoCentro("              ");
            ticket.TextoIzquierda("USUARIO: " + Program.NOMBRES + " " + Program.APELLIDOS);
                ticket.TextoIzquierda( "# CAJA: " + numcaja.ToString("D4"));
            ticket.TextoIzquierda("                 ");
            ticket.TextoIzquierda("");
            string[] h = DateTime.Now.TimeOfDay.ToString().Split('.');
                ticket.TextoIzquierda("Fecha: " + Program.FecaInicio + "          " + h[0]);
            ticket.TextoIzquierda("                 ");
            ticket.TextoIzquierda("                 ");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("                 ");
            for (int i = 0; i < pedidos.Count; i++)//dgvLista es el nombre del datagridview
                {
                    string[] vector = pedidos[i].Split(';');
                    ticket.AgregarDatosRed(vector[0],Convert.ToInt32(vector[1]));
                }
                
                ticket.lineasAsteriscos();
            //ticket.TextoIzquierda("Corporacion AirNet");
            //ticket.TextoIzquierda("Corporacion AirNet" );
                ticket.CortaTicket();
            //pd.PrinterSettings.PrinterName = "\\SCLIENTE-PC\\PedidoBodega";
            //MessageBox.Show(""+ pd.PrinterSettings.PrinterName);
            //string r = pd.PrinterSettings.PrinterName;
            // MessageBox.Show(@"\\SCLIENTE-PC\PedidoBodega");
           String ruta = @"\\SCLIENTE-PC\BodegaPedido";
            ticket.ImprimirTicket(ruta);
               // RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, "");
            //}
            pedidos.Clear();
        }

        private void Calcular()
        {
            float totalCheque=0, TotalCredito = 0;
            if (ckbCheque.Checked && ckbEfectivo.Checked && ckbTarjeta.Checked)
            {
                string valor = "";
                float suma = 0.0f;
                valor =Convert.ToString(dgvCheque.Rows[0].Cells[0].Value);
                if (valor!="")
                {
                    for (int i = 0; i < dgvCheque.RowCount; i++)
                    {
                        if (dgvCheque.Rows[i].Cells[0].Value!=null)
                        {
                            totalCheque += Convert.ToSingle(dgvCheque.Rows[i].Cells[5].Value.ToString());
                        }
                        else
                        {
                            break;
                        }
                    }
                    valor = "";
                    txtCheque.Text = ""+totalCheque.ToString("#####0.00");
                   // float t = totalCheque + Convert.ToSingle(txtRecibido.Text);
                    //txtRecibido.Text = "" + t.ToString("#####0.00");
                } 

                 valor =Convert.ToString(dgvTarjeta.Rows[0].Cells[0].Value);
                if (valor!="")
                {
                    for (int i = 0; i < dgvTarjeta.RowCount; i++)
                    {
                        if (dgvTarjeta.Rows[i].Cells[0].Value != null)
                        {
                            TotalCredito += Convert.ToSingle(dgvTarjeta.Rows[i].Cells[2].Value.ToString());
                        }
                        else
                        {
                            break;
                        }
                        
                    }
                    txtCredito.Text = "" + TotalCredito.ToString("#####0.00");
                    //float t = totalCheque + Convert.ToSingle(txtRecibido.Text);
                    //txtRecibido.Text = "" + t.ToString("#####0.00");
                }

                if (txtEfectivo.Text != "")
                {
                    suma = TotalCredito + Convert.ToSingle(txtEfectivo.Text)+totalCheque;
                }
                else
                {
                    suma = TotalCredito + 0+totalCheque;
                }

                txtRecibido.Text= suma.ToString("#####0.00");
                float cambio = Convert.ToSingle(txtRecibido.Text)- Convert.ToSingle(txtTotalPagar.Text);

                if (cambio<0)
                {
                    cambio *= -1;
                }
                txtCambio.Text = "" + cambio.ToString("#####0.00");

            }
            else
            {
                if (ckbTarjeta.Checked && ckbEfectivo.Checked)
                {
                    string valor = "";
                    float suma = 0.0f,cambio=0.0f;
                    valor = Convert.ToString(dgvTarjeta.Rows[0].Cells[0].Value);
                    if (valor != "")
                    {
                        for (int i = 0; i < dgvTarjeta.RowCount; i++)
                        {
                            if (dgvTarjeta.Rows[i].Cells[0].Value != null)
                            {
                                TotalCredito += Convert.ToSingle(dgvTarjeta.Rows[i].Cells[2].Value.ToString());
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                    if (txtEfectivo.Text!="")
                    {
                        suma = TotalCredito + Convert.ToSingle(txtEfectivo.Text);
                    }
                    else
                    {
                        suma = TotalCredito +0;
                    }
                    cambio = suma -Convert.ToSingle( txtTotalPagar.Text);
                    if (cambio<0)
                    {
                        cambio *= -1;
                    }
                    txtCredito.Text = "" + TotalCredito.ToString("#####0.00");
                    txtRecibido.Text=""+ suma.ToString("#####0.00");

                    txtCambio.Text=cambio.ToString("#####0.00");

                }
                else
                {
                    if (ckbCheque.Checked&& ckbEfectivo.Checked)
                    {
                        string valor = "";
                        float suma = 0.0f, cambio = 0.0f;
                        valor =Convert.ToString(dgvCheque.Rows[0].Cells[0].Value);
                        if (valor != "")
                        {
                            for (int i = 0; i < dgvCheque.RowCount; i++)
                            {
                                if (dgvCheque.Rows[i].Cells[0].Value != null)
                                {
                                    totalCheque += Convert.ToSingle(dgvCheque.Rows[i].Cells[5].Value.ToString());
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }

                        if (txtEfectivo.Text != "")
                        {
                            suma = totalCheque + Convert.ToSingle(txtEfectivo.Text);
                        }
                        else
                        {
                            suma = totalCheque + 0;
                        }
                        cambio = suma - Convert.ToSingle(txtTotalPagar.Text);
                        if (cambio<0)
                        {
                            cambio *= -1;
                        }
                        txtCheque.Text=totalCheque.ToString("#####0.00");
                        txtRecibido.Text=suma.ToString("#####0.00");
                        txtCambio.Text = cambio.ToString("#####0.00");

                    }
                    else
                    {
                        if (ckbCheque.Checked && ckbTarjeta.Checked)
                        {
                            string valor = "";
                            valor = Convert.ToString(dgvTarjeta.Rows[0].Cells[0].Value);
                            if (valor!="")
                            {
                                for (int i = 0; i < dgvTarjeta.RowCount; i++)
                                {
                                    if (dgvTarjeta.Rows[i].Cells[0].Value != null)
                                    {
                                        TotalCredito += Convert.ToSingle(dgvTarjeta.Rows[i].Cells[2].Value.ToString());
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                            }
                           
                            txtCredito.Text = "" + TotalCredito.ToString("#####0.00");
                            valor =Convert.ToString(dgvCheque.Rows[0].Cells[0].Value);
                            if (valor!="")
                            {
                                for (int i = 0; i < dgvCheque.RowCount; i++)
                                {
                                    if (dgvCheque.Rows[i].Cells[0].Value != null)
                                    {
                                        totalCheque += Convert.ToSingle(dgvCheque.Rows[i].Cells[5].Value.ToString());
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            
                            txtCheque.Text = "" + totalCheque.ToString("#####0.00");

                            float r = TotalCredito + totalCheque;
                            float cam = r - Convert.ToSingle(txtTotalPagar.Text);
                            if (cam<0)
                            {
                                cam *= -1;
                            }
                            txtCambio.Text=cam.ToString("#####0.00");
                           
                            txtRecibido.Text= r.ToString("#####0.00");
                        }
                        else
                        {
                            if (ckbCheque.Checked)
                            {
                                for (int i = 0; i < dgvCheque.RowCount; i++)
                                {
                                    if (dgvCheque.Rows[i].Cells[0].Value != null)
                                    {
                                        totalCheque += Convert.ToSingle(dgvCheque.Rows[i].Cells[5].Value.ToString());
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                
                                txtCheque.Text = "" + totalCheque.ToString("#####0.00");
                                //if (Convert.ToSingle(r) >= total)
                                //{

                                   // reci = Convert.ToSingle(txtCheque.Text);
                                    float cambio = totalCheque - Convert.ToSingle(txtTotalPagar.Text);
                                    if (cambio < 0)
                                    {
                                        cambio *= -1;
                                    }
                                    txtCambio.Text = cambio.ToString("#####0.00");
                                txtRecibido.Text = txtCheque.Text;
                               
                            }
                            else
                            {
                                if (ckbEfectivo.Checked)
                                {
                                    float reci = 0.0f;
                                    string r = "";
                                   
                                    //if (Convert.ToSingle(r) >= total)
                                    //{
                                    if (txtEfectivo.Text!="")
                                    {
                                        r = txtEfectivo.Text;
                                    }
                                    else
                                    {
                                        r = "0";
                                    }
                                        reci = Convert.ToSingle(r);
                                        float cambio = Convert.ToSingle(txtTotalPagar.Text) - reci;
                                        if (cambio < 0)
                                        {
                                            cambio *= -1;
                                        }
                                        txtCambio.Text = cambio.ToString("#####0.00");
                                    //}
                                    //else
                                    //{
                                    //    txtCambio.Text = "0.00";
                                    //}
                                    txtRecibido.Text = txtEfectivo.Text;
                                }
                                else
                                {
                                    if (ckbTarjeta.Checked)
                                    {
                                        for (int i = 0; i < dgvTarjeta.RowCount; i++)
                                        {
                                            if (dgvTarjeta.Rows[i].Cells[0].Value != null)
                                            {
                                                TotalCredito += Convert.ToSingle(dgvTarjeta.Rows[i].Cells[2].Value.ToString());
                                            }
                                            else
                                            {
                                                break;
                                            }

                                        }
                                       
                                        txtCredito.Text = "" + TotalCredito.ToString("#####0.00");
                                        float cambio = TotalCredito - Convert.ToSingle(txtTotalPagar.Text);
                                        if (cambio < 0)
                                        {
                                            cambio *= -1;
                                        }
                                        txtCambio.Text = cambio.ToString("#####0.00");
                                        txtRecibido.Text = txtCredito.Text;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }

}
