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
    public partial class FrmCompra : Form
    {
        public FrmCompra()
        {
            InitializeComponent();
        }
        public static DataGridView datosProductoCompra;
        public static ComboBox datosProveedor;

        Consultas consultas;
        EmcabezadoCompra ObjEncabezadoCompra;
        DetalleCompra ObjDetalleCompra;
        Producto objProducto;
        int ordenCompra = 0, idOrdenComrpa;
        private void FrmCompra_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                dgvProductosIngresos.Rows.Add();
            }
            consultas = new Consultas();
            consultas.BoolLlenarComboBox(cbSucursal, "select IDSUCURSAL AS Id, NOMBRESUCURSAL as Texto from TbSucursal");
            consultas.BoolLlenarComboBox(cbProveedor, "select IDPROVEEDOR AS Id, NOMBRES AS Texto from TbProveedor");
            idOrdenComrpa = consultas.ObtenerID("IDEMCABEZADOCOMPRA", "TbEncabezadoyPieCompra", "");
            ordenCompra = 1 + consultas.ObtenerID("ORDEN_COMPRA_NUMERO", "TbEncabezadoyPieCompra", " where IDEMCABEZADOCOMPRA ="+ idOrdenComrpa + "");
            consultas.BoolLlenarComboBox(cbImpuesto, "select IDIVA AS ID, IVA + '%' as TEXTO from tbIva");            
            txtOrdenCompra.Text = Convert.ToString(ordenCompra);
            //cbProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            //cbProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            //cbProveedor.AutoCompleteCustomSource = combData;
            datosProductoCompra = dgvProductosIngresos;
            datosProveedor = cbProveedor;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtFlete.Text != "" && txtPlazoOC.Text != "" && txtSerie1.Text != "" && txtSerie2.Text != "" && txtNumero.Text != "")
            {
                int idEncabezadoCompra = 0;
                ObjEncabezadoCompra = new EmcabezadoCompra(txtSerie1.Text, txtSerie2.Text, txtNumero.Text, Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSubtutalIVA.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSubtotal0.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSubtotal.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotal.Text)), txtOrdenCompra.Text, Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToSingle(txtFlete.Text), dtpFechaOC.Value, Convert.ToInt32(datosProveedor.SelectedValue), cbTerminoPago.Text, txtPlazoOC.Text, cbImpuesto.Text
                    , txtObservacion.Text, Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtIVA.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtICE.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtIRBP.Text)));
                String resultadoEncabezado = ObjEncabezadoCompra.InsertarEncabezadoyPieCompra(ObjEncabezadoCompra); // retorna true si esta correcto todo
                consultas.ObtenerIDCompra(ref idEncabezadoCompra, "select IDEMCABEZADOCOMPRA as ID FROM TbEncabezadoyPieCompra where ORDEN_COMPRA_NUMERO = '" + txtOrdenCompra.Text + "'");
                for (int i = 0; i < dgvProductosIngresos.RowCount; i++)
                {
                    ObjDetalleCompra = new DetalleCompra(Convert.ToSingle(datosProductoCompra.Rows[i].Cells[8].Value), Convert.ToSingle(datosProductoCompra.Rows[i].Cells[9].Value), idEncabezadoCompra, Convert.ToString(datosProductoCompra.Rows[i].Cells[0].Value), Convert.ToInt32(datosProductoCompra.Rows[i].Cells[2].Value), Convert.ToSingle(datosProductoCompra.Rows[i].Cells[3].Value),
                        Convert.ToSingle(datosProductoCompra.Rows[i].Cells[4].Value), Convert.ToSingle(datosProductoCompra.Rows[i].Cells[5].Value), Convert.ToSingle(datosProductoCompra.Rows[i].Cells[6].Value), Convert.ToSingle(datosProductoCompra.Rows[i].Cells[7].Value));
                    String resultadoDetalle = ObjDetalleCompra.InsertarDetalleCompra(ObjDetalleCompra);
                    if (resultadoDetalle == "Datos Guardados")
                    {
                        objProducto = new Producto(Convert.ToInt32(datosProductoCompra.Rows[i].Cells[2].Value), Convert.ToString(datosProductoCompra.Rows[i].Cells[0].Value));
                        if (objProducto.sumaCantidadProducto(objProducto)) { }
                        else MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (resultadoDetalle == "Error al Registrar")
                        MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (Convert.ToString(datosProductoCompra.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }

                if (resultadoEncabezado == "Datos Guardados")
                {
                    MessageBox.Show("Compra Registrada Correctamente ", "Exito", MessageBoxButtons.OK);
                }
                else if (resultadoEncabezado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else if (resultadoEncabezado == "Existe") { MessageBox.Show("Ya Existe el Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else
                MessageBox.Show("Ingrese los datos necesarios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void dgvProductosIngresos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            objProducto = new Producto();
            float iva = 0.0f, subtotal = 0.0f, total = 0.0f;
            try
            {
                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "codigo")
                {
                    objProducto = consultas.Consultarproducto(Convert.ToString(datosProductoCompra.CurrentRow.Cells[0].Value));                    
                    if (objProducto == null)
                    {
                        if (MessageBox.Show("¿Desea agregar el producto?", "CONFIRMACIÓN",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmProductos frmProducto = new FrmProductos();
                            Program.FormularioLlamado = true;
                            FrmProductos.codigo = Convert.ToString(datosProductoCompra.CurrentRow.Cells[0].Value);
                            objFuncion.AddFormInPanel(frmProducto, Program.panelPrincipalVariable);
                            datosProductoCompra.CurrentCell = datosProductoCompra.CurrentRow.Cells[2];
                        }
                    }
                    else
                    {
                        datosProductoCompra.CurrentRow.Cells[1].Value = objProducto.Nombreproducto;
                        //dgvProductosIngresos.CurrentRow.Cells[3].Value = objProducto.PrecioCompra;
                        //if (objProducto.Ivaestado)
                        //    dgvProductosIngresos.CurrentRow.Cells[3].Value = objProducto.Preciopublico_iva;
                        //else
                        //    dgvProductosIngresos.CurrentRow.Cells[3].Value = objProducto.Preciopublico_sin_iva;
                        SendKeys.Send("{TAB}");
                    }
                }
                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "precioCompra" || datosProductoCompra.Columns[e.ColumnIndex].Name == "cantidad")
                {
                    iva = ((Convert.ToSingle(datosProductoCompra.CurrentRow.Cells[3].Value.ToString()) * Convert.ToInt32(datosProductoCompra.CurrentRow.Cells[2].Value.ToString())) * 0.12f);
                    subtotal = ((Convert.ToSingle(datosProductoCompra.CurrentRow.Cells[3].Value.ToString()) * Convert.ToInt32(datosProductoCompra.CurrentRow.Cells[2].Value.ToString())) - iva);
                    total = subtotal + iva;
                    datosProductoCompra.CurrentRow.Cells[11].Value = iva.ToString("#####0.00");
                    datosProductoCompra.CurrentRow.Cells[10].Value = subtotal.ToString("#####0.00");
                    datosProductoCompra.CurrentRow.Cells[12].Value = total.ToString("#####0.00");
                }
            }
            catch (Exception)
            {
            }
            Calcular();
            SendKeys.Send("{UP}");
            SendKeys.Send("{TAB}");
            }
        string PrecioCompra;
        private void Calcular()
        {
            float sumasubiva = 0.0f, sumasubcero = 0.0f, totalpagar = 0.0f, ivatotal = 0.0f, sumaice = 0.0f, sumairbp = 0.0f;
            try
            {
                for (int i = 0; i < datosProductoCompra.RowCount; i++)
                {
                    if (Convert.ToSingle(datosProductoCompra.Rows[i].Cells[11].Value.ToString()) != 0)
                    {
                        sumasubiva += Convert.ToSingle(datosProductoCompra.Rows[i].Cells[12].Value.ToString());
                        ivatotal += Convert.ToSingle(datosProductoCompra.Rows[i].Cells[11].Value.ToString());
                    }
                    if (Convert.ToSingle(datosProductoCompra.Rows[i].Cells[11].Value.ToString()) == 0)
                    {
                        sumasubcero += Convert.ToSingle(datosProductoCompra.Rows[i].Cells[12].Value.ToString());
                    }
                    totalpagar += Convert.ToSingle(datosProductoCompra.Rows[i].Cells[12].Value.ToString());
                    sumaice += Convert.ToSingle(datosProductoCompra.Rows[i].Cells[8].Value.ToString());
                    sumairbp += Convert.ToSingle(datosProductoCompra.Rows[i].Cells[9].Value.ToString());
                    if (Convert.ToString(datosProductoCompra.Rows[i + 1].Cells[0].Value) == "")
                    {
                        break;
                    }
                }
                txtIRBP.Text = Funcion.reemplazarcaracter(sumairbp.ToString("#####0.00"));
                txtICE.Text = Funcion.reemplazarcaracter(sumaice.ToString("#####0.00"));
                txtSubtotal0.Text = Funcion.reemplazarcaracter(sumasubcero.ToString("#####0.00"));
                txtSubtotal.Text = Funcion.reemplazarcaracter(totalpagar.ToString("#####0.00"));
                txtSubtutalIVA.Text = Funcion.reemplazarcaracter(sumasubiva.ToString("#####0.00"));
                txtIVA.Text = Funcion.reemplazarcaracter(ivatotal.ToString("#####0.00"));
                txtTotal.Text = Funcion.reemplazarcaracter(totalpagar.ToString("#####0.00"));
            }
            catch (Exception EX)
            {
            }
        }

        private void dgvProductosIngresos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
        Funcion objFuncion = new Funcion();
        FrmPrincipal objPrincipal = new FrmPrincipal();
        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedor = new FrmProveedores();
            Program.FormularioLlamado = true;            
            objFuncion.AddFormInPanel(frmProveedor, Program.panelPrincipalVariable);
            consultas.BoolLlenarComboBox(cbProveedor, "select IDPROVEEDOR AS Id, NOMBRES AS Texto from TbProveedor");
            if (Program.FormularioProveedorCompra)
            {
                
            }
        }

        private void OnlyNumbersdgvcheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[2])
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[0])
            {
                Funcion.validar_Num_Letras(e);
            }
            if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[1])
            {
                Funcion.validar_Num_Letras(e);
            }
        }
        private void dgvProductosIngresos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbersdgvcheque_KeyPress;
            }
        }

        private void txtOrdenCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void txtFlete_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtFlete.Text);
        }

        private void txtObservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Letras(e);
        }

        private void txtPlazoOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.validar_Num_Letras(e);
        }

        private void txtICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtICE.Text);
        }

        private void txtIRBP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtIRBP.Text);
        }

        private void txtSerie1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void txtSerie2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }
        string valor;
        private void dgvProductosIngresos_KeyUp(object sender, KeyEventArgs e)
        {
            if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[3])
            {
                valor = Convert.ToString(dgvProductosIngresos.CurrentRow.Cells[3].Value);
            }
        }

        private void dgvProductosIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnSalirCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
