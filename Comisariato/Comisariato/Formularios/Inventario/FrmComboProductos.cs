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
            


            objc.CargarCombos("SELECT TbCombo.IDCOMBO, TbCombo.PRECIO, TbCombo.CANTIDAD, TbCombo.CODIGO, TbCombo.NOMBRE from TbCombo", dgvDatosCombo);
            //dgvProductosParaCombo.Columns[0].Width = 150;
            AnchoColumna();
        }

        private void AnchoColumna()
        {

            dgvProductosParaCombo.Columns[7].Visible = false;
            dgvDatosCombo.Columns[6].Visible = false;
            dgvProductosParaCombo.Columns[6].Width = 20;
            dgvProductosParaCombo.Columns[1].Width = 181;
            dgvProductosParaCombo.Columns[0].Width = 150;

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
                    //dgvProductosParaCombo.Rows[e.RowIndex].Cells[6].Value = true;
                    //if (dgvProductosParaCombo.Rows[e.RowIndex].Cells[0].Value != null && dgvProductosParaCombo.Rows[e.RowIndex].Cells[1].Value != null)
                    //{
                        
                    //    if (verificarindex(e.RowIndex))
                    //    {
                            
                    //        indezp.RemoveAt(posindexp);
                    //    }
                    //    else
                    //    {
                    //        indezp.Add(e.RowIndex);
                    //    }
                    //}
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
                int cont=0;
                //if (indezp.Count>2)
                //{
                if (indezp.Count>0)
                {
                    indezp.Clear();
                }
                    dgvProductosEnCombo.Rows.Clear();
                    for (int i = 0; i < dgvProductosParaCombo.RowCount; i++)
                    {
                    if (Convert.ToBoolean(dgvProductosParaCombo.Rows[i].Cells[6].Value)==true)
                    {
                        dgvProductosEnCombo.Rows.Add(" ");
                        dgvProductosEnCombo.Rows[cont].Cells[0].Value = dgvProductosParaCombo.Rows[i].Cells[0].Value;
                        dgvProductosEnCombo.Rows[cont].Cells[1].Value = dgvProductosParaCombo.Rows[i].Cells[2].Value;
                        dgvProductosEnCombo.Rows[cont].Cells[2].Value = dgvProductosParaCombo.Rows[i].Cells[1].Value;
                        dgvProductosEnCombo.Rows[cont].Cells[4].Value = dgvProductosParaCombo.Rows[i].Cells[3].Value;
                        dgvProductosEnCombo.Rows[cont].Cells[5].Value = dgvProductosParaCombo.Rows[i].Cells[4].Value;
                        dgvProductosEnCombo.Rows[cont].Cells[6].Value = dgvProductosParaCombo.Rows[i].Cells[5].Value;
                        dgvProductosEnCombo.Rows[cont].Cells[7].Value = dgvProductosParaCombo.Rows[i].Cells[7].Value;
                        cont++;
                        indezp.Add(i);

                    }

                    // dgvProductosParaCombo.Rows[indezp[i]].Cells[4].Value
                    //dgvProductosEnCombo.Rows[i].Cells[0].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[0].Value;
                    //dgvProductosEnCombo.Rows[i].Cells[1].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[2].Value;
                    //dgvProductosEnCombo.Rows[i].Cells[2].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[1].Value;
                    //dgvProductosEnCombo.Rows[i].Cells[4].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[3].Value;
                    //dgvProductosEnCombo.Rows[i].Cells[5].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[4].Value;
                    //dgvProductosEnCombo.Rows[i].Cells[6].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[5].Value;
                    //dgvProductosEnCombo.Rows[i].Cells[7].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[7].Value;
                    //dgvProductosParaCombo.Rows.RemoveAt(indezp[i]);
                    //dgvProductosParaCombo.Rows.Add(" ");

                }
                    dgvProductosEnCombo.CurrentCell = dgvProductosEnCombo.Rows[0].Cells[3];
                    dgvProductosEnCombo.BeginEdit(true);
                //}
                //else
                //{
                //    MessageBox.Show("Selecciona al menos tres productos para poder formar un combo");
                //}
                
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }

        }

        //private bool verificarindex(int inde)
        //{
        //    bool b = false;
        //    for (int i = 0; i < indezp.Count; i++)
        //    {
        //        if (indezp[i] == inde)
        //        {
        //            posindexp = i;
        //            b = true;
        //        }
        //    }
        //    return b;
        //}

        private void btnGuardarCombo_Click(object sender, EventArgs e)
        {
            try
            {
                objc = new Consultas();
                
                if (indezp.Count > 2)
                {
                    if (VerificarCantidades())
                    {
                        if (verificarCantidadeslimites())
                        {
                            if (txtCodigoCombo.Text != "")
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
                            MessageBox.Show("La cantidad ingresada nunca debe ser mayor a la cantida en bodega\n Errror... Fila: "+posicion+"  Producto: "+producto);
                            dgvProductosEnCombo.Focus();
                            dgvProductosEnCombo.CurrentCell = dgvProductosEnCombo.Rows[posicion - 1].Cells[3];
                            dgvProductosEnCombo.BeginEdit(true);
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
                    MessageBox.Show("Selecciona al menos tres productos diferentes\npara formar un combo.");
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

        private int posicion = 0;
        private string producto;

        private bool verificarCantidadeslimites()
        {
            bool b = true;
            for (int i = 0; i < indezp.Count; i++)
            {
                int cantidadingresada = Convert.ToInt32(dgvProductosEnCombo.Rows[i].Cells[3].Value);
                int cantidadbodega= Convert.ToInt32(dgvProductosEnCombo.Rows[i].Cells[5].Value);
                if ( cantidadingresada>cantidadbodega)
                {
                    producto =Convert.ToString(dgvProductosEnCombo.Rows[i].Cells[2].Value);
                    posicion = i+1;
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
            cargarDatos("1");
            //dgvProductosParaCombo.Columns[0].Width = 150;
            AnchoColumna();
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

        private void dgvProductosEnCombo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
            if (dgvProductosEnCombo.CurrentCell == this.dgvProductosEnCombo.CurrentRow.Cells[3])
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

        private void txtConsultarCombo_TextChanged(object sender, EventArgs e)
        {
            objc = new Consultas();
            objc.CargarCombos("SELECT TbCombo.IDCOMBO, TbCombo.PRECIO, TbCombo.CANTIDAD, TbCombo.CODIGO, TbCombo.NOMBRE from TbCombo where TbCombo.NOMBRE like '%" + txtConsultarCombo.Text + "%' or TbCombo.CODIGO like '%" + txtConsultarCombo.Text + "%'", dgvDatosCombo);
            //datos = objc.CargarProductoCombo("SELECT TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProdcutoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProdcutoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProdcutoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA) where TbProducto.NOMBREPRODUCTO like '%" + txtBuscarProductosParaCombo.Text + "%' or TbProducto.CODIGOBARRA like '%" + txtBuscarProductosParaCombo.Text + "%'");
            dgvDatosCombo.Columns[6].Visible = false;
        }

        private void dgvDatosCombo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //objc = new Consultas();
                //objc.CargarProductosdelcombo(Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[4].Value), dgvDetalleCombo);


                if (rdbCombosActivos.Checked)
                {

                    if (this.dgvDatosCombo.Columns[e.ColumnIndex].Name == "Desabilitar")
                    {
                        ///"UPDATE TbProveedor SET ESTADO = 1 WHERE IDENTIFICACION = '" + Identificacion + "'"
                        //objc = new Consultas();
                        //objc.EjecutarSQL("UPDATE TbCombo SET ESTADO = 1 WHERE IDENTIFICACION = '" + Identificacion + "'");
                        //cargarDatos("1");
                    }
                }
                else if (rdbCombosInactivos.Checked)
                {
                    if (this.dgvDatosCombo.Columns[e.ColumnIndex].Name == "Desabilitar")
                    {
                       // objc.EstadoProveedor(dgvDatosProveedor.CurrentRow.Cells[3].Value.ToString(), 1);
                        //cargarDatos("0");
                    }
                }

                if (this.dgvDatosCombo.Columns[e.ColumnIndex].Name == "Modificar")
                {
                    //identificacion = dgvDatosProveedor.CurrentRow.Cells[3].Value.ToString();
                    //tcProveedor.SelectedIndex = 0;
                    //bandera_Estado = true;
                    ////Llenar el DataTable
                    //DataTable dt = consultas.BoolDataTable("Select * from TbProveedor where IDENTIFICACION = '" + identificacion + "'");
                    ////Arreglo de byte en donde se almacenara la foto en bytes
                    //byte[] MyData = new byte[0];
                    ////Verificar si tiene Datos
                    //if (dt.Rows.Count > 0)
                    //{

                    //}
                }
                //btnLimpiarProveedor.Text = "&Cancelar";
                //btnGuardarProveedor.Text = "&Modificar";
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDatosCombo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDatosCombo.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosCombo.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\modificarDgv.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosCombo.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosCombo.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }

            if (rdbCombosInactivos.Checked)
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosCombo.Columns[e.ColumnIndex].Name == "Desabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosCombo.Rows[e.RowIndex].Cells["Desabilitar"] as DataGridViewButtonCell;
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\Habilitar.ico");
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosCombo.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosCombo.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosCombo.Columns[e.ColumnIndex].Name == "Desabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosCombo.Rows[e.RowIndex].Cells["Desabilitar"] as DataGridViewButtonCell;
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosCombo.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosCombo.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }

        private void rdbCombosActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCombosActivos.Checked)
            {
               cargarDatos("1");
                //dgvDatosProveedor.Columns[1].HeaderText = "Desabilitar";
            }
            else if (rdbCombosInactivos.Checked)
            {
                cargarDatos("0");
                //dgvDatosProveedor.Columns[1].HeaderText = "Habilitar";
            }
        }

        private void cargarDatos(string condicion)
        {
            objc = new Consultas();
            objc.boolLlenarDataGridView(dgvDatosCombo, "SELECT TbCombo.IDCOMBO, TbCombo.PRECIO, TbCombo.CANTIDAD, TbCombo.CODIGO, TbCombo.NOMBRE from TbCombo WHERE ESTADO = " + condicion + ";");
            dgvDatosCombo.Columns[6].Visible = false;
        }

        private void dgvDatosCombo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            objc = new Consultas();
            objc.CargarProductosdelcombo(Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[6].Value), dgvDetalleCombo);
        }
    }
}
