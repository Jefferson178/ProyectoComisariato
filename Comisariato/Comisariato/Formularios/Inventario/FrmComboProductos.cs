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

            objc.CargarProductoCombo("SELECT TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProdcutoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProdcutoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProdcutoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA);", dgvProductosParaCombo);
            //dgvProductosParaCombo.Columns[0].Width = 150;
            //dgvProductosParaCombo.Columns[1].Width = 150;
            //dgvProductosParaCombo.Columns[2].Width = 100;
            //dgvProductosParaCombo.Columns[3].Width = 100;
            //dgvProductosParaCombo.Columns[4].Width = 80;
            //dgvProductosParaCombo.Columns[5].Width = 80;
            //dgvProductosParaCombo.Columns[6].Width = 50;

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
           
        }

        private void txtBuscarProductosParaCombo_TextChanged(object sender, EventArgs e)
        {
            objc = new Consultas();
            objc.CargarProductoCombo("SELECT TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProdcutoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProdcutoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProdcutoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA) where TbProducto.NOMBREPRODUCTO like '%" + txtBuscarProductosParaCombo.Text + "%' or TbProducto.CODIGOBARRA like '%" + txtBuscarProductosParaCombo.Text + "%'", dgvProductosParaCombo);
            //datos = objc.CargarProductoCombo("SELECT TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProdcutoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProdcutoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProdcutoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA) where TbProducto.NOMBREPRODUCTO like '%" + txtBuscarProductosParaCombo.Text + "%' or TbProducto.CODIGOBARRA like '%" + txtBuscarProductosParaCombo.Text + "%'");

        }

        private void btnLimpiarCombo_Click(object sender, EventArgs e)
        {
            txtBuscarProductosParaCombo.Text = "";
            txtConsultarCombo.Text = "";
            txtNombreCombo.Text = "";
            txtCodigoCombo.Text = "";
            dgvProductosEnCombo.Rows.Clear();
        }
    }
}
