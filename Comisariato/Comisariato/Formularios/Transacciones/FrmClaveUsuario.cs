using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmClaveUsuario : Form
    {

        Consultas c;
        public int verificarMetodo;
        public FrmClaveUsuario()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        Bitacora bitacora;

        private void button1_Click(object sender, EventArgs e)
        {


            Auntenticar();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Auntenticar();
            }
        }

        private void Auntenticar()
        {
            try
            {
                if (txtClave.Text != "")
                {
                    c = new Consultas();
                    //bool b = c.VerificarClave("SELECT TbUsuario.CONTRASEÑA, TbUsuario.USUARIO, TbTipousuario.TIPO, TbUsuario.IDTIPOUSUARIO from TbUsuario INNER JOIN TbTipousuario ON(TbUsuario.USUARIO = '" + Program.Usuario + "' and TbUsuario.CONTRASEÑA= '" + txtClave.Text + "')" + " AND (TbTipousuario.IDTIPOUSUARIO = '" + Program.IDTIPOUSUARIO + "' and TbTipousuario.TIPO='CAJERO')");
                    if (verificarMetodo == 1)
                    {
                        bool b = c.VerificarClave(txtClave.Text);
                        if (b)
                        {
                            Program.contraseñausuarioactual = txtClave.Text;
                            FrmFactura f = new FrmFactura();
                            bitacora = new Bitacora("00:00:00", "Venta");
                            bitacora.insertarBitacora();

                            Consultas objconsul = new Consultas();
                            string numcaja = "", sucursal = "", documentoActual ="";
                            string IpMaquina = bitacora.LocalIPAddress();
                            DataTable Dt = objconsul.BoolDataTable("Select SERIE1,SERIE2,DOCUMENTOACTUAL,DOCUMENTOINICIAL,DOCUMENTOFINAL,AUTORIZACION,ESTACION,IPESTACION from TbCajasTalonario where IPESTACION = '" + IpMaquina + "' and ESTADO=1;");
                            if (Dt.Rows.Count > 0)
                            {
                                DataRow myRows = Dt.Rows[0];
                                sucursal = myRows["SERIE1"].ToString();
                                numcaja = myRows["SERIE2"].ToString();
                                documentoActual= myRows["DOCUMENTOACTUAL"].ToString();
                            }
                            

                            
                           







                            string condicion = " where CAJA = '" + numcaja + "' and SUCURSAL= '" + sucursal + "' and IDEMPRESA= '" + Program.IDEMPRESA + "';";

                            int numero = c.ObtenerID("IDFACTURA", "TbEncabezadoFactura", condicion);
                            condicion= " where IDENTIFICACION= 9999999999999";
                            f.IDCLIENTEINICIO = c.ObtenerID("IDCLIENTE", "TbCliente", condicion);
                            if (numero == 0)
                            {
                                f.numfact = Convert.ToInt32(documentoActual);
                            }
                            else
                            {
                                f.numfact = numero + 1;
                            }
                            f.sucursal = sucursal;
                            f.numcaja = numcaja;
                            //f.numcaja = numcaja;
                            this.Close();
                            f.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Clave incorrecta. O quizas no tenga permiso para ingresar a esta opcion.");
                        }
                    }
                    else
                    {
                        if (txtClave.Text == Program.contraseñausuarioactual)
                        {
                            FrmAvanse s = new FrmAvanse();
                            s.cajero = Program.NOMBRES + " " + Program.APELLIDOS;
                            s.fecha = Program.FecaInicio;
                            s.caja = "" + Program.numfact;
                            s.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Clave incorrecta. O quizas no tenga permiso para ingresar a esta opcion.");
                        }

                    }



                }
            }
            catch (Exception ex)
            {

                // MessageBox.Show(""+ex.Message);
            }


        }

        private void FrmClaveUsuario_Load(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");

            txtClave.Focus();
        }
    }
}
