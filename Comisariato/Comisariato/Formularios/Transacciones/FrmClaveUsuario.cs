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
                        
                        string numcaja = "111", sucursal = "2";

                        string condicion = " where CAJA = '" + numcaja + "' and SUCURSAL= '" + sucursal + "' and IDEMPRESA= '"+  Program.IDEMPRESA + "';";
                        if (c.ObtenerID("IDFACTURA", "TbEncabezadoFactura", condicion) == 0)
                        {
                            f.numfact = 1;
                        }
                        else
                        {
                            f.numfact = c.ObtenerID("IDFACTURA", "TbEncabezadoFactura", condicion) + 1;
                        }

                        f.numcaja = numcaja;
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
                        //if (b)
                        //{
                        FrmAvanse s = new FrmAvanse();
                        s.cajero = Program.NOMBRES + " " + Program.APELLIDOS;
                        s.fecha = Program.FecaInicio;
                        s.caja = "" + Program.numfact;
                        s.ShowDialog();
                        this.Close();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Clave incorrecta. O quizas no tenga permiso para ingresar a esta opcion.");
                        //}

                    }



                }
            }
            catch (Exception ex)
            {

                // MessageBox.Show(""+ex.Message);
            }






        }
    }
}
