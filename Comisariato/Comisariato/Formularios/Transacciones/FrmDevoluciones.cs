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

namespace Comisariato.Formularios.Transacciones.Devolucion_Venta
{
    public partial class FrmDevolucionVenta : Form
    {
        EmcabezadoFactura em;
        Consultas c;
        List<Producto> product;
        private int posindexp = 0;
        List<int> indezp = new List<int>();
        List<String> pedidos = new List<String>();
        public FrmDevolucionVenta()
        {
            InitializeComponent();
            for (int i = 0; i < 21; i++)
            {
                DgvDetalleFact.Rows.Add("");
            }
            lblUsuario.Text = "";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            c = new Consultas();
            try
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    em = c.ConsutarFactura(int.Parse(txtSucursal.Text), int.Parse(txtCaja.Text), int.Parse(txtNumFact.Text),2);
                    if (em != null)
                    {
                        product = c.detalleFact;
                        if (product.Count > 0)
                        {
                            llenarDgV();
                            lblUsuario.Text="Usuario: " +em.NombreUsuario;
                        }
                        else
                        {
                            MessageBox.Show("Todos los Items de esta factura ya Fueron dados de baja.");
                            LimpiarTodo();
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ex.Message);
            }
           
        }

        private void llenarDgV()
        {
            float total=0,iva=0,totalfactura=0;
            for (int i = 0; i < product.Count; i++)
            {
                DgvDetalleFact.Rows[i].Cells[0].Value=product[i].Codigobarra;
                DgvDetalleFact.Rows[i].Cells[1].Value = product[i].Nombreproducto;
                DgvDetalleFact.Rows[i].Cells[2].Value = product[i].Cantidad;
                DgvDetalleFact.Rows[i].Cells[3].Value = product[i].Preciopublico_sin_iva;
                // DgvDetalleFact.Rows[i].Cells[4].Value = product[i].Iva;
                iva = ((product[i].Cantidad * product[i].Preciopublico_sin_iva) * product[i].Iva) / 100;
                total = (product[i].Cantidad * product[i].Preciopublico_sin_iva) + iva;
                DgvDetalleFact.Rows[i].Cells[4].Value = iva;
                DgvDetalleFact.Rows[i].Cells[5].Value = total;
                totalfactura += total;
            }
            txtTotalFactura.Text = totalfactura.ToString("#####0.00");
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

        private void txtSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtSucursal.Text != "")
                {
                    txtCaja.Focus();
                }

            }
            else
            {
                Funcion.Validar_Numeros(e);
            }

        }
       
        private void DgvDetalleFact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvDetalleFact.CurrentCell != this.DgvDetalleFact.CurrentRow.Cells[6])
                {
                    DgvDetalleFact.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                    //txtCodigo.Focus();
                }
                else
                {
                    if (DgvDetalleFact.Rows[e.RowIndex].Cells[0].Value != null && DgvDetalleFact.Rows[e.RowIndex].Cells[1].Value != null)
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

               // txtCodigo.Focus();
            }
        }

        private void CalcularDevolucion()
        {
            float totalDevo = 0;
            for (int i = 0; i < indezp.Count; i++)
            {
                totalDevo += Convert.ToSingle(DgvDetalleFact.Rows[indezp[i]].Cells[5].Value);
            }
            txtTotalDevolucion.Text = totalDevo.ToString("#####0.00");
        }

        private bool verificarindex(int inde)
        {
            bool b = false;
            for (int i = 0; i < indezp.Count; i++)
            {
                if (indezp[i] == inde)
                {
                    posindexp = i;
                    b = true;
                }
            }
            return b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    if (product.Count > 0)
                    {
                        if (indezp.Count > 0)
                        {
                            indezp.Clear();
                        }
                        for (int i = 0; i < DgvDetalleFact.RowCount; i++)
                        {
                            if (Convert.ToString(DgvDetalleFact.Rows[i].Cells[0].Value) != "")
                            {
                                DgvDetalleFact.Rows[i].Cells[6].Value = true;
                                indezp.Add(i);
                            }
                            else
                            {
                                break;
                            }
                        }
                        CalcularDevolucion();
                        //MessageBox.Show("" + indezp.Count);
                    }
                      
                }
                else
                {
                    for (int i = 0; i < DgvDetalleFact.RowCount; i++)
                    {
                        if (Convert.ToString(DgvDetalleFact.Rows[i].Cells[0].Value) != "")
                        {
                            DgvDetalleFact.Rows[i].Cells[6].Value = false;
                        }
                        else
                        {
                            break;
                        }
                    }
                    indezp.Clear();
                    txtTotalDevolucion.Text = "0.00";
                    //MessageBox.Show(""+indezp.Count);
                }
               
            }
            catch (Exception ex)
            {
            }
        }

        private void ObtenerPedidos()
        {
            try
            {
                for (int i = 0; i < indezp.Count; i++)
                {

                    pedidos.Add("" + DgvDetalleFact.Rows[indezp[i]].Cells[0].Value + ";" + DgvDetalleFact.Rows[indezp[i]].Cells[2].Value);

                }
            }
            catch (Exception)
            {

                //throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            c = new Consultas();
            try
            {
                if (indezp.Count>0)
                {
                    if (MessageBox.Show("¿Estas seguro de darle de baja a estos Items?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ObtenerPedidos();
                        bool b = c.DevolucionVenta(pedidos, Convert.ToInt32(txtNumFact.Text));
                        if (b)
                        {
                            MessageBox.Show("Cambios realizados con exito.");
                            LimpiarTodo();
                        }
                        else
                        {
                            MessageBox.Show("Error al realizar devolucion.");
                        }
                    }
                    
                      
                }
                else
                {
                    MessageBox.Show("Selecciona al menos un Item.");
                }
               
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void LimpiarTodo()
        {
            txtCaja.Text = "";
            txtNumFact.Text = "";
            txtSucursal.Text = "";
            DgvDetalleFact.Rows.Clear();
            pedidos.Clear();
            posindexp = 0;
            indezp.Clear();
            lblUsuario.Text = "";
            txtTotalDevolucion.Text = "0.00";
            txtTotalFactura.Text = "0.00";
            for (int i = 0; i < 21; i++)
            {
                DgvDetalleFact.Rows.Add("");
            }
            txtSucursal.Focus();
        }

    }
}
