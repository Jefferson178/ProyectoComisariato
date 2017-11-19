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

namespace Comisariato.Formularios.Mantenimiento.Inventario
{
    public partial class FrmComboProductos : Form
    {
        List<Producto> datos;
        Consultas objc;
        List<int> indezp = new List<int>();
        private int posindexp = 0;


        //NOMBREPRODUCTO like '%" + txtconsultar.Text + "%' or CODIGOBARRA like '%" + txtconsultar.Text +"%'
        public FrmComboProductos()
        {
            InitializeComponent();
        }

        private void FrmComboProductos_Load(object sender, EventArgs e)
        {
            objc = new Consultas();

            objc.CargarProductoCombo("SELECT TbProducto.IDPRODUCTO, TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProdcutoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProdcutoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProdcutoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA);", dgvProductosParaCombo);
            dgvProductosParaCombo.Columns[7].Visible = false;
            //dgvProductosParaCombo.Columns[0].Width = 150;

        }

        private void btnAgregarProductoACombo_Click(object sender, EventArgs e)
        {
            ObtenerCombo();
        }

        private void dgvProductosParaCombo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProductosParaCombo.CurrentCell != this.dgvProductosParaCombo.CurrentRow.Cells[6])
                {
                    dgvProductosParaCombo.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                    //txtCodigo.Focus();
                }
                else
                {
                    if (dgvProductosParaCombo.Rows[e.RowIndex].Cells[0].Value != null && dgvProductosParaCombo.Rows[e.RowIndex].Cells[1].Value != null)
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

        private void ObtenerCombo()
        {
            try
            {

                if (indezp.Count>0)
                {
                    
                    for (int i = 0; i < indezp.Count; i++)
                    {
                        dgvProductosEnCombo.Rows.Add(" ");
                        // dgvProductosParaCombo.Rows[indezp[i]].Cells[4].Value
                        dgvProductosEnCombo.Rows[i].Cells[0].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[0].Value;
                        dgvProductosEnCombo.Rows[i].Cells[1].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[2].Value;
                        dgvProductosEnCombo.Rows[i].Cells[2].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[1].Value;
                        dgvProductosEnCombo.Rows[i].Cells[4].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[3].Value;
                        dgvProductosEnCombo.Rows[i].Cells[5].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[4].Value;
                        dgvProductosEnCombo.Rows[i].Cells[6].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[5].Value;
                        dgvProductosEnCombo.Rows[i].Cells[7].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[7].Value;
                        dgvProductosParaCombo.Rows.RemoveAt(indezp[i]);
                        dgvProductosParaCombo.Rows.Add(" ");

                    }
                    dgvProductosEnCombo.CurrentCell = dgvProductosEnCombo.Rows[0].Cells[3];
                    dgvProductosEnCombo.BeginEdit(true);
                }
                
            }
            catch (Exception)
            {

                //throw;
            }

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

        private void btnGuardarCombo_Click(object sender, EventArgs e)
        {
            try
            {
                objc = new Consultas();
                
                if (indezp.Count > 0)
                {
                    if (VerificarCantidades())
                    {
                        if (txtCodigoCombo.Text!="")
                        {
                            bool b1 = objc.verificarRepetido("select * from TbCombo U where U.CODIGO='" + txtCodigoCombo.Text + "'");
                            if (!b1)
                            {
                                if (txtNombreCombo.Text != "")
                                {
                                    if (txtCantCombo.Text != "")
                                    {
                                        if (txtPrecioCombo.Text != "")
                                        {
                                            //Consultas c = new Consultas();
                                            int filas = indezp.Count;
                                            List<String> encabezadoCombo = new List<String>();
                                            encabezadoCombo.Add(txtCodigoCombo.Text);
                                            encabezadoCombo.Add(txtNombreCombo.Text);
                                            encabezadoCombo.Add(txtCantCombo.Text);
                                            encabezadoCombo.Add(txtPrecioCombo.Text);
                                            bool b = objc.GrabarCombo(encabezadoCombo, dgvProductosEnCombo, filas);
                                            if (b)
                                            {
                                                MessageBox.Show("Registro realizado con exito.");
                                                Limpiar();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error al realizar el registro.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ingresa el precio del combo.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingresa la cantidad del combo.");
                                        txtCantCombo.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingresa el nombre del codigo.");
                                    txtNombreCombo.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ya existe un combo registrado con ese codigo");
                                txtCodigoCombo.Focus();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Ingresa el código del combo.");
                            txtCodigoCombo.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingresa todas las cantidades de la tabla 'Combo de Productos'.");
                        dgvProductosEnCombo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona al menos dos productos diferentes\npara formar un combo.");
                }
            }
            catch (Exception)
            {

                //throw;
            }
           
        }

        private bool VerificarCantidades()
        {
            bool b=true;
            for (int i = 0; i < indezp.Count; i++)
            {
                if (dgvProductosEnCombo.Rows[i].Cells[3].Value==null)
                {
                    b = false;
                    break;
                }
            }
            return b;
        }

        private void txtBuscarProductosParaCombo_TextChanged(object sender, EventArgs e)
        {
            objc = new Consultas();
            objc.CargarProductoCombo("SELECT TbProducto.IDPRODUCTO, TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProdcutoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProdcutoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProdcutoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA) where TbProducto.NOMBREPRODUCTO like '%" + txtBuscarProductosParaCombo.Text + "%' or TbProducto.CODIGOBARRA like '%" + txtBuscarProductosParaCombo.Text + "%'", dgvProductosParaCombo);
            //datos = objc.CargarProductoCombo("SELECT TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProdcutoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProdcutoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProdcutoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA) where TbProducto.NOMBREPRODUCTO like '%" + txtBuscarProductosParaCombo.Text + "%' or TbProducto.CODIGOBARRA like '%" + txtBuscarProductosParaCombo.Text + "%'");
            dgvProductosParaCombo.Columns[7].Visible = false;
        }

        private void btnLimpiarCombo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtBuscarProductosParaCombo.Text = "";
            txtConsultarCombo.Text = "";
            txtNombreCombo.Text = "";
            txtCodigoCombo.Text = "";
            txtCantCombo.Text = "";
            txtPrecioCombo.Text = "";
            dgvProductosEnCombo.Rows.Clear();
            objc = new Consultas();

            objc.CargarProductoCombo("SELECT TbProducto.IDPRODUCTO, TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProdcutoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProdcutoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProdcutoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA);", dgvProductosParaCombo);
            dgvProductosParaCombo.Columns[7].Visible = false;
            txtCodigoCombo.Focus();
        }

        private void txtCodigoCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCodigoCombo.Text!="")
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    objc = new Consultas();
                    bool b = objc.verificarRepetido("select * from TbCombo U where U.CODIGO='" + txtCodigoCombo.Text + "'");
                    if (b)
                    {
                        MessageBox.Show("Ya existe un combo registrado con ese codigo");
                        txtCodigoCombo.Focus();
                    }
                    else
                    {
                        txtNombreCombo.Focus();
                    }
                }
            }
            else
            {
                txtCodigoCombo.Focus();
            }
            
        }

        private void txtCantCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtCantCombo.Text!="")
                {
                    txtPrecioCombo.Focus();
                }
                else
                {
                    txtCantCombo.Focus();
                }
            }
            else
            {
                Funcion.Validar_Numeros(e);
            }
        }

        private void txtPrecioCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtPrecioCombo.Text != "")
                {
                    btnGuardarCombo.Focus();
                }
                else
                {
                    txtPrecioCombo.Focus();
                }
            }
            else
            {
                Funcion.SoloValores(e,txtPrecioCombo.Text);
            }
        }
    }
}
