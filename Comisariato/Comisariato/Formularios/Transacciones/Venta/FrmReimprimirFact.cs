using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmReimprimirFact : Form
    {
        List<Producto> p;
        List<string> detapago;
        Consultas c;
        EmcabezadoFactura em;
        public FrmReimprimirFact()
        {
            InitializeComponent();
            p = new List<Producto>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                c = new Consultas();
                if (txtSucursal.Text != "" && txtCaja.Text != "" && txtNumFact.Text != "")
                {
                    em = c.ConsutarFactura(int.Parse(txtSucursal.Text), int.Parse(txtCaja.Text), int.Parse(txtNumFact.Text),1);
                    if (em != null)
                    {
                        p = c.detalleFact;
                        detapago = c.detallepagoreim;
                        if (p.Count>0)
                        {
                            Imprimirfact();
                            FrmFactura.verificadorfrm = 4;
                            this.Close();
                        }
                        //MessageBox.Show("Cantidad Productos: "+p.Count);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar una factura con esa serie.");
                    }

                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void Imprimirfact()
        {
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo
           
            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("EMPRESA: COMISARIATO SUPER DOS");
            ticket.TextoCentro("RUC: 1802114429001");
            ticket.TextoIzquierda("Direccion: AV LA GUAYAS 207 Y ABDON CALD");
            ticket.TextoIzquierda("Valido: " + em.Fecha + " Hasta: " + em.Fecha);
            ticket.TextoIzquierda("Clave: 4530000");
            ticket.TextoIzquierda("        Factura: " + int.Parse(txtSucursal.Text).ToString("D4") + "-" + int.Parse(txtCaja.Text).ToString("D4") + "-" + int.Parse(txtNumFact.Text).ToString("D8"));
            ticket.TextoIzquierda("         Informacion del Consumidor");//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("RUC: " + em.Identificacion);
            ticket.TextoIzquierda("Cliente: " + em.NombresCliente);
            ticket.TextoIzquierda("Facturado: " + em.NombreUsuario);
            ticket.TextoIzquierda("Fecha: " + em.Fecha + "          " + em.Hora);

            if (detapago[0]!="0"&&detapago[1]!="0"&& detapago[2]!="0")
            {
                ticket.TextoIzquierda("Tipo de pago: Efectivo - Cheque - T. Credito");
            }
            else
            {
                if (detapago[1] != "0" && detapago[2] != "0")
                {
                    ticket.TextoIzquierda("Tipo de pago: Cheque - T. Credito");
                }
                else
                {
                    if (detapago[2]!="0"&&detapago[0]!="0")
                    {
                        ticket.TextoIzquierda("Tipo de pago: Efectivo - T. Credito");
                    }
                    else
                    {
                        if (detapago[0]!="0" && detapago[1]!="0")
                        {
                            ticket.TextoIzquierda("Tipo de pago: Efectivo - Cheque");
                        }
                        else
                        {
                            if (detapago[0]!="0")
                            {
                                ticket.TextoIzquierda("Tipo de pago: Efectivo");
                            }
                            else
                            {
                                if (detapago[1]!="0")
                                {
                                    ticket.TextoIzquierda("Tipo de pago: Cheque");
                                }
                                else
                                {
                                    if (detapago[2]!="0")
                                    {
                                        ticket.TextoIzquierda("Tipo de pago: T. Credito");
                                    }
                                }
                            }
                        }
                    }
                }

            }

            //ticket.TextoIzquierda("Forma de pago: " + pago);
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            float ivasuma = 0.0f, subtotal = 0.0f, subtotaconiva = 0.0f,  totaapagar = 0.0f;
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            for (int i = 0; i < p.Count; i++)//dgvLista es el nombre del datagridview
            {
                float total = 0.0f,iva=0.0f;
                total = p[i].Preciopublico_sin_iva * p[i].Cantidad;
                if (p[i].Iva == 12)
                {
                    iva = ((p[i].Preciopublico_sin_iva * p[i].Cantidad) * p[i].Iva)/100;
                    ivasuma += iva;
                    ticket.AgregaArticulo("*" + p[i].Nombreproducto, p[i].Cantidad,
                    Convert.ToSingle(p[i].Preciopublico_sin_iva).ToString("#####0.00"), total.ToString("#####0.00"));
                    subtotaconiva += total + ivasuma;
                }
                else
                {
                    ticket.AgregaArticulo(" "+p[i].Nombreproducto, p[i].Cantidad,
                    Convert.ToSingle(p[i].Preciopublico_sin_iva).ToString("#####0.00"), Convert.ToSingle(total).ToString("#####0.00"));
                }
                subtotal += total;
                totaapagar += total + ivasuma;
               
            }
            
            ticket.lineasAsteriscos();
            //Resumen de la venta. Sólo son ejemplos
            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("SUBTOTAL ", Convert.ToSingle(Funcion.reemplazarcaracter(Convert.ToString(subtotal))));
            ticket.AgregarTotales("SUBTOTAL 12% ", Convert.ToSingle(Funcion.reemplazarcaracter(Convert.ToString(subtotaconiva))));
            ticket.AgregarTotales("Descuento", Convert.ToSingle(Funcion.reemplazarcaracter(detapago[3])));
            ticket.AgregarTotales("Iva 12%  ", Convert.ToSingle(Funcion.reemplazarcaracter(detapago[4])));
            ticket.AgregarTotales("Total a pagar", Convert.ToSingle(Funcion.reemplazarcaracter(Convert.ToString(totaapagar))));

            if (detapago[0] != "0" && detapago[1] != "0" && detapago[2] != "0")
            {
                ticket.TextoIzquierda("Efectivo:  $" + detapago[0]);
                ticket.TextoIzquierda("Cheque:    $" + detapago[1]);
                ticket.TextoIzquierda("T. Credito $: " + detapago[2]);
                ticket.TextoIzquierda("Recibido: $" + Convert.ToSingle(detapago[5]).ToString("#####0.00") + " Cambio: $" + Convert.ToSingle(detapago[6]).ToString("#####0.00"));
            }
            else
            {
                if (detapago[1] != "0" && detapago[2] != "0")
                {
                    //ticket.TextoIzquierda("Cheque:  $" + txtEfectivo.Text);
                    ticket.TextoIzquierda("Cheque:    $" + detapago[1]);
                    ticket.TextoIzquierda("T. Credito $: " + detapago[2]);
                    ticket.TextoIzquierda("Recibido: $" + Convert.ToSingle(detapago[5]).ToString("#####0.00") + " Cambio: $" + Convert.ToSingle(detapago[6]).ToString("#####0.00"));
                }
                else
                {
                    if (detapago[2] != "0" && detapago[0] != "0")
                    {
                        ticket.TextoIzquierda("Efectivo:  $" + detapago[0]);
                        //ticket.TextoIzquierda("Cheque:    $" + txtCheque.Text);
                        ticket.TextoIzquierda("T. Credito $: " + detapago[2]);
                        ticket.TextoIzquierda("Recibido: $" + Convert.ToSingle(detapago[5]).ToString("#####0.00") + " Cambio: $" + Convert.ToSingle(detapago[6]).ToString("#####0.00"));
                    }
                    else
                    {
                        if (detapago[0] != "0" && detapago[1] != "0")
                        {
                            ticket.TextoIzquierda("Efectivo:  $" + detapago[0]);
                            ticket.TextoIzquierda("Cheque:    $" + detapago[1]);
                            // ticket.TextoIzquierda("T. Credito $: " + txtCredito.Text);
                            ticket.TextoIzquierda("Recibido: $" + Convert.ToSingle(detapago[5]).ToString("#####0.00") + " Cambio: $" + Convert.ToSingle(detapago[6]).ToString("#####0.00"));
                        }
                        else
                        {
                            if (detapago[0]!="0")
                            {
                                ticket.TextoIzquierda("Efectivo:  $" +detapago[0]);
                                ticket.TextoIzquierda("Recibido: $" + Convert.ToSingle(detapago[5]).ToString("#####0.00") + " Cambio: $" + Convert.ToSingle(detapago[6]).ToString("#####0.00"));
                            }
                            else
                            {
                                if (detapago[1]!="0")
                                {
                                    ticket.TextoIzquierda("Cheque:    $" + detapago[1]);
                                    ticket.TextoIzquierda("Recibido: $" + Convert.ToSingle(detapago[5]).ToString("#####0.00") + " Cambio: $" + Convert.ToSingle(detapago[6]).ToString("#####0.00"));
                                }
                                else
                                {
                                    if (detapago[2]!="0")
                                    {
                                        ticket.TextoIzquierda("T. Credito $: " + detapago[2]);
                                        ticket.TextoIzquierda("Recibido: $" +Convert.ToSingle( detapago[5]).ToString("#####0.00") + " Cambio: $" +Convert.ToSingle(detapago[6]).ToString("#####0.00"));
                                    }
                                }
                            }
                        }
                    }

                }
            }



            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTICULOS VENDIDOS: " + p.Count);
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.CortaTicket();
            ticket.ImprimirTicket("Generic / Text Only");//Nombre de la impresora ticketera




        }

        private void txtSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtSucursal.Text!="")
                {
                    txtCaja.Focus();
                }
                
            }
            else
            {
                Funcion.Validar_Numeros(e);
            }

           
        }

        private void txtCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtCaja.Text != "")
                {
                    txtNumFact.Focus();
                }

            }
            else
            {
                Funcion.Validar_Numeros(e);
            }
        }

        private void txtNumFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                c = new Consultas();
                if (e.KeyChar == (char)Keys.Return)
                {
                    if (txtNumFact.Text != "")
                    {
                        em = c.ConsutarFactura(int.Parse(txtSucursal.Text), int.Parse(txtCaja.Text), int.Parse(txtNumFact.Text),1);
                        if (em != null)
                        {
                            p = c.detalleFact;
                            detapago = c.detallepagoreim;
                            if (p.Count > 0)
                            {
                                Imprimirfact();
                                FrmFactura.verificadorfrm = 4;
                                this.Close();
                            }
                        }
                        else
                        {
                            //MessageBox.Show("No se pudo encontrar una factura con esa serie.");
                        }
                    }

                }
                else
                {
                    Funcion.Validar_Numeros(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

    }
}
