using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Mantenimiento.Inventario
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        public static string codigo;

        Consultas Objconsul;
        String GlobalCodigoBarra = "";
        bool bandera_Estado = false;
        public static String nameImagen = "";
        byte[] AuxMyDataImagenProducto = new byte[0];

        public void inicializarDatos()
        {
            tcProducto.SelectedIndex = 0; //Seleccion el tab a mostrarse
            pbImagenProducto.Image = Comisariato.Properties.Resources.boxProducto;
            //limpiar los textbox
            txtNombreProducto.Text = "";
            txtCodigoBarraProducto.Text = "";
            txtStockMaximoProducto.Text = "0";
            txtStockMaximoProducto.Text = "0";
            txtCajaProducto.Text = "0";
            txtUnidadProducto.Text = "0";
            txtPVPConIVAProducto.Text = "0";
            txtPVPSinIVAProducto.Text = "0";
            txtPrecioMayorConIVAProducto.Text = "0";
            txtPrecioMayorSinIVAProducto.Text = "0";
            txtPrecioCajaConIVAProducto.Text = "0";
            txtPrecioCajaSinIVAProducto.Text = "0";
            TxtIce.Text = "0";
            TxtIRBP.Text = "0";
            txtObservacionesProducto.Text = "";
            ckbActivoProducto.Checked = true;

            //iniciar combos
            cbUnidadMedidaProducto.SelectedIndex = 0;
            cbTipoProducto.SelectedIndex = 0;
            cbPeso.SelectedIndex = 0;


            // Dimensionar lista combo
            cbTipoProducto.DropDownHeight = cbTipoProducto.ItemHeight = 150;
            cbUnidadMedidaProducto.DropDownHeight = cbTipoProducto.ItemHeight = 150;
            cbPeso.DropDownHeight = cbTipoProducto.ItemHeight = 100;

            //// llenar datadrigview solo los activos
            cargarDatos("1");
        }

        private void cargarDatos(string condicion)
        {
            Objconsul = new Consultas();
            Objconsul.boolLlenarDataGridView(dgvDatosProducto, "Select IDPRODUCTO AS ID, CODIGOBARRA AS 'CODIGO BARRA',NOMBREPRODUCTO as PRODUCTO,STOCKMAXIMO AS 'STOCK MAXIMO',TIPOPRODUCTO AS CATEGORIA,PRECIOPUBLICO_IVA as 'P.V.P.' , PRECIOALMAYOR_IVA as 'PRECIO MAYOR.',PRECIOPORCAJA_IVA AS 'PRECIO CAJA',IVAESTADO AS 'TIENE IVA' from TbProducto WHERE ACTIVO =" + condicion + ";");
            dgvDatosProducto.Columns["ID"].Visible = false;
        }
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            byte[] bitDataImagen = null;
            if (txtNombreProducto.Text != "" && txtCodigoBarraProducto.Text != "" && txtPVPSinIVAProducto.Text != "" && txtPrecioMayorSinIVAProducto.Text != "" && txtPrecioCajaSinIVAProducto.Text != "")
            {
                if (nameImagen != "")
                {
                    Image img = pbImagenProducto.Image;
                    bitDataImagen = Funcion.imgToByteArray(img);
                }
                //Objconsul.BoolDataTable("SELECT [CANTIDAD]  FROM [dbo].[TbProducto] where IDPRODUCTO = ''")
                Producto ObjProducto = new Producto(txtNombreProducto.Text, ckbActivoProducto.Checked, txtCodigoBarraProducto.Text, cbTipoProducto.Text, cbUnidadMedidaProducto.Text, cbPeso.Text, Convert.ToInt32(txtStockMaximoProducto.Text), Convert.ToInt32(txtStockMinimoProducto.Text), Convert.ToInt32(txtCajaProducto.Text), Convert.ToInt32(txtUnidadProducto.Text), Convert.ToSingle(txtPVPConIVAProducto.Text), Convert.ToSingle(txtPVPSinIVAProducto.Text), Convert.ToSingle(txtPrecioMayorConIVAProducto.Text), Convert.ToSingle(txtPrecioMayorSinIVAProducto.Text), Convert.ToSingle(txtPrecioCajaConIVAProducto.Text), Convert.ToSingle(txtPrecioCajaSinIVAProducto.Text), bitDataImagen, CkbIva.Checked, txtObservacionesProducto.Text, Convert.ToInt32(cbTipoProducto.SelectedValue), 0);

                if (!bandera_Estado) // Para identificar si se va ingresar
                {
                    String resultado = ObjProducto.InsertarProducto(ObjProducto); // retorna true si esta correcto todo
                    if (resultado == "Datos Guardados")
                    {
                        MessageBox.Show("Producto Registrado Correctamente ", "Exito", MessageBoxButtons.OK);
                        //rbtActivosEmpresa.Checked = true;
                        inicializarDatos();
                        cargarDatos("1");
                        if (Program.FormularioLlamado)
                        {
                            FrmCompra.nombreProducto = txtNombreProducto.Text;
                            this.Close();
                        }
                    }
                    else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else if (resultado == "Existe") { MessageBox.Show("Ya Existe el Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else if (bandera_Estado) // Para identificar si se va modificar
                {
                    String Resultado = ObjProducto.ModificarProducto(GlobalCodigoBarra); // retorna true si esta correcto todo
                    if (Resultado == "Correcto")
                    {
                        MessageBox.Show("Producto Actualizado", "Exito");
                        //rbtActivosEmpleado.Checked = true;
                        GlobalCodigoBarra = "";
                    }
                    else { MessageBox.Show("Error al actualizar el Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    inicializarDatos();
                    bandera_Estado = false;
                    btnGuardarProducto.Text = "&Guardar";
                    btnLimpiarProducto.Text = "&Limpiar";
                }
                //else if(txtCeluar1Empresa.Text == "")
                //{
                //    MessageBox.Show("Ingrese al menos un numero de telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}


            }
            else { MessageBox.Show("Ingrese los datos del Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtCodigoBarraProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && txtCodigoBarraProducto.Focused == true)
            {
                txtNombreProducto.Focus();
            }
            Funcion.validar_Num_Letras(e);
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Objconsul = new Consultas();
            SendKeys.Send("{TAB}");
            Objconsul.BoolLlenarComboBox(cbTipoProducto, "Select IDCATEGORIA as ID , DESCRIPCION AS TEXTO from TbCategoria;");
            cbUnidadMedidaProducto.SelectedIndex = 0;
            cbPeso.SelectedIndex = 0;
            inicializarDatos();
            if (Program.FormularioLlamado)
            {
                txtCodigoBarraProducto.Text = codigo;
            }
        }

        bool banderaCheckError = false;

        private void CkbIva_CheckedChanged(object sender, EventArgs e)
        {
            float PVPSinIva = 0.0f, PrecioMayorSinIva = 0.0f, PrecioCajaSinIva = 0.0f;
            if ((txtPVPConIVAProducto.Text != "" && txtPrecioMayorConIVAProducto.Text != "" && txtPrecioCajaConIVAProducto.Text != "") && (Convert.ToInt32(txtPVPConIVAProducto.Text) != 0 && Convert.ToInt32(txtPrecioMayorConIVAProducto.Text) != 0 && Convert.ToInt32(txtPrecioCajaConIVAProducto.Text) != 0))
            {
                if (CkbIva.Checked)
                {
                    
                    PVPSinIva = Convert.ToSingle(txtPVPConIVAProducto.Text) / 1.12f;
                    PrecioMayorSinIva = Convert.ToSingle(txtPrecioMayorConIVAProducto.Text) / 1.12f;
                    PrecioCajaSinIva = Convert.ToSingle(txtPrecioCajaConIVAProducto.Text)/ 1.12f;
                    banderaCheckError = false;
                }
                else {
                    
                }
            }
            else
            {
                if (!banderaCheckError)
                {//if (CkbIva.Checked || CkbICE.Checked || CkbIRBP.Checked)
                    //{
                    MessageBox.Show("Ingrese los Precios Con Iva", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    banderaCheckError = true;
                    CkbIva.Checked = false;
                    banderaCheckError = false;
                    //CkbICE.Checked = false;
                    //CkbIRBP.Checked = false;
                    txtPVPConIVAProducto.Focus();
                    //TxtIVA.Text = "";
                    //TxtIce.Text = "";
                    //TxtIRBP.Text = "";
                    //}
                }
            }
            if (PVPSinIva != 0 && PrecioMayorSinIva != 0 && PrecioCajaSinIva != 0)
            {
                
                txtPVPSinIVAProducto.Text = PVPSinIva.ToString("#####0.00");
                txtPrecioMayorSinIVAProducto.Text = PrecioMayorSinIva.ToString("#####0.00");
                txtPrecioCajaSinIVAProducto.Text = PrecioCajaSinIva.ToString("#####0.00");
                txtPVPSinIVAProducto.Text  = Funcion.reemplazarcaracter(txtPVPSinIVAProducto.Text);
                txtPrecioMayorSinIVAProducto.Text = Funcion.reemplazarcaracter(txtPrecioMayorSinIVAProducto.Text);
                txtPrecioCajaSinIVAProducto.Text = Funcion.reemplazarcaracter(txtPrecioCajaSinIVAProducto.Text);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pbImagenProducto.Image = Comisariato.Properties.Resources.boxProducto;
            //Image img = pbImagenProducto.Image;
        }

        private void btnBuscarImagenProducto_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarLogo = new OpenFileDialog();
            BuscarLogo.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg";
            if (BuscarLogo.ShowDialog() == DialogResult.OK)
            {
                nameImagen = BuscarLogo.FileName;
                pbImagenProducto.Image = Image.FromFile(BuscarLogo.FileName);
                pbImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void TxtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);

            if (e.KeyChar == (char)Keys.Return)
            {

                //int iva = Convert.ToInt32(TxtIVA.Text);
                //txtPVPConIVAProducto.Text = (((Convert.ToDouble(Funcion.reemplazarcaracterViceversa(txtPVPSinIVAProducto.Text)) * iva) / 100) + Convert.ToDouble(Funcion.reemplazarcaracterViceversa(txtPVPSinIVAProducto.Text))).ToString();
                //txtPrecioCajaConIVAProducto.Text = (((Convert.ToDouble(Funcion.reemplazarcaracterViceversa(txtPrecioCajaSinIVAProducto.Text)) * iva) / 100) + Convert.ToDouble(Funcion.reemplazarcaracterViceversa(txtPrecioCajaSinIVAProducto.Text))).ToString();
                //txtPrecioMayorConIVAProducto.Text = (((Convert.ToDouble(Funcion.reemplazarcaracterViceversa(txtPrecioMayorSinIVAProducto.Text)) * iva) / 100) + Convert.ToDouble(Funcion.reemplazarcaracterViceversa(txtPrecioMayorSinIVAProducto.Text))).ToString();

                txtObservacionesProducto.Focus();

            }

        }

        private void dgvDatosProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto ObjProducto = new Producto();
            if (rbtActivos.Checked)
            {
                if (this.dgvDatosProducto.Columns[e.ColumnIndex].Name == "Deshabilitar")
                {
                    ObjProducto.EstadoProducto(dgvDatosProducto.CurrentRow.Cells[3].Value.ToString(), 2);
                    cargarDatos("1");
                }
            }
            else if (rbtInactivos.Checked)
            {
                if (this.dgvDatosProducto.Columns[e.ColumnIndex].Name == "Deshabilitar")
                {
                    ObjProducto.EstadoProducto(dgvDatosProducto.CurrentRow.Cells[3].Value.ToString(), 1);
                    cargarDatos("0");
                }
            }

            if (this.dgvDatosProducto.Columns[e.ColumnIndex].Name == "Modificar")
            {
                //MessageBox.Show("modificar toca " + DgvDatosEmpleado.CurrentRow.Cells[3].Value.ToString());
                GlobalCodigoBarra = dgvDatosProducto.CurrentRow.Cells[3].Value.ToString();
                tcProducto.SelectedIndex = 0;
                bandera_Estado = true;
                //Llenar el DataTable
                DataTable dt = Objconsul.BoolDataTable("Select * from TbProducto where CODIGOBARRA = '" + GlobalCodigoBarra + "'");
                //Arreglo de byte en donde se almacenara la foto en bytes
                byte[] MyDataProducto = new byte[0];
                //Verificar si tiene Datos
                if (dt.Rows.Count > 0)
                {
                    DataRow myRow = dt.Rows[0];
                    MemoryStream stream;

                    //Se almacena el campo foto de la tabla en el arreglo de bytes

                    if (myRow["IMAGENPRODUCTO"] != System.DBNull.Value)
                    {
                        MyDataProducto = (byte[])myRow["IMAGENPRODUCTO"];
                        AuxMyDataImagenProducto = MyDataProducto;
                        //Se inicializa un flujo en memoria del arreglo de bytes
                        stream = new MemoryStream(MyDataProducto);
                        //En el picture box se muestra la imagen que esta almacenada en el flujo en memoria 
                        //el cual contiene el arreglo de bytes
                        pbImagenProducto.Image = Image.FromStream(stream);
                        stream.Dispose();
                    }

                    //Cargar los demas Datos
                    cbTipoProducto.SelectedValue = Convert.ToInt32(myRow["IDCATEGORIA"]);
                    ckbActivoProducto.Checked = Convert.ToBoolean(myRow["ACTIVO"]);
                    txtNombreProducto.Text = myRow["NOMBREPRODUCTO"].ToString();
                    txtCodigoBarraProducto.Text = myRow["CODIGOBARRA"].ToString();

                    cbUnidadMedidaProducto.SelectedItem = myRow["UNIDAMEDIDA"].ToString();
                    cbPeso.SelectedItem = myRow["PESO"];
                    txtStockMaximoProducto.Text = myRow["STOCKMAXIMO"].ToString();
                    txtStockMinimoProducto.Text = myRow["STOCKMINIMO"].ToString();

                    txtCajaProducto.Text = myRow["CAJA"].ToString();
                    txtUnidadProducto.Text = myRow["UNIDAD"].ToString();
                    txtPVPConIVAProducto.Text = myRow["PRECIOPUBLICO_IVA"].ToString();
                    txtPVPSinIVAProducto.Text = myRow["PRECIOPUBLICO_SIN_IVA"].ToString();
                    txtPrecioMayorConIVAProducto.Text = myRow["PRECIOALMAYOR_IVA"].ToString();
                    txtPrecioMayorSinIVAProducto.Text = myRow["PRECIOALMAYOR_SIN_IVA"].ToString();
                    txtPrecioCajaConIVAProducto.Text = myRow["PRECIOPORCAJA_IVA"].ToString();
                    txtPrecioCajaSinIVAProducto.Text = myRow["PRECIOPORCAJA_SIN_IVA"].ToString();
                    CkbIva.Checked = Convert.ToBoolean(myRow["IVAESTADO"]);
                    //CkbICE.Checked = Convert.ToBoolean(myRow["ICEESTADO"]);
                    //CkbIRBP.Checked = Convert.ToBoolean(myRow["IRBPESTADO"]);

                    //TxtIVA.Text = myRow["IVA"].ToString();
                    //TxtIce.Text = myRow["ICE"].ToString();
                    //TxtIRBP.Text = myRow["IRBP"].ToString();

                    txtObservacionesProducto.Text = myRow["OBSERVACIONES"].ToString();
                }
                btnLimpiarProducto.Text = "&Cancelar";
                btnGuardarProducto.Text = "&Modificar";

            }

        }

        private void txtPVPConIVAProducto_TextChanged(object sender, EventArgs e)
        {

            //txtPVPConIVAProducto.Text = Math.Round(Convert.ToDouble(txtPVPConIVAProducto.Text), 2).ToString();

            txtPVPConIVAProducto.Text = Funcion.reemplazarcaracter(txtPVPConIVAProducto.Text);
        }

        private void txtPrecioMayorConIVAProducto_TextChanged(object sender, EventArgs e)
        {
            txtPrecioMayorConIVAProducto.Text = Funcion.reemplazarcaracter(txtPrecioMayorConIVAProducto.Text);
        }

        private void txtPrecioCajaConIVAProducto_TextChanged(object sender, EventArgs e)
        {
            txtPrecioCajaConIVAProducto.Text = Funcion.reemplazarcaracter(txtPrecioCajaConIVAProducto.Text);
        }

        private void txtPVPSinIVAProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtPVPSinIVAProducto);
        }

        private void txtPrecioMayorSinIVAProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtPrecioMayorSinIVAProducto);
        }

        private void txtPrecioCajaSinIVAProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtPrecioCajaSinIVAProducto);
        }
        

        private void rbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtActivos.Checked)
            {
                cargarDatos("1");
                dgvDatosProducto.Columns[1].HeaderText = "Desabilitar";
            }
            else if (rbtInactivos.Checked)
            {
                cargarDatos("0");
                dgvDatosProducto.Columns[1].HeaderText = "Habilitar";
            }
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            if (btnLimpiarProducto.Text == "&Cancelar")
            {
                inicializarDatos();
                btnLimpiarProducto.Text = "&Limpiar";
                btnGuardarProducto.Text = "&Guardar";
            }
            else { inicializarDatos(); }
        }

        private void txtConsultarProducto_TextChanged(object sender, EventArgs e)
        {
            if (rbtActivos.Checked)
            {
                Objconsul.boolLlenarDataGridView(dgvDatosProducto, "Select IDPRODUCTO AS ID, CODIGOBARRA AS 'CODIGO BARRA',NOMBREPRODUCTO as PRODUCTO,STOCKMAXIMO AS 'STOCK MAXIMO',TIPOPRODUCTO AS CATEGORIA,PRECIOPUBLICO_IVA as 'P.V.P.' , PRECIOALMAYOR_IVA as 'PRECIO MAYOR.',PRECIOPORCAJA_IVA AS 'PRECIO CAJA',IVAESTADO AS 'TIENE IVA' from TbProducto WHERE ACTIVO   = 1 and CODIGOBARRA like '%" + txtConsultarProducto.Text + "%' or NOMBREPRODUCTO like '%"+ txtConsultarProducto.Text + "%' or TIPOPRODUCTO like '%" + txtConsultarProducto.Text + "%'  ; ");
                dgvDatosProducto.Columns[1].HeaderText = "Desabilitar";
                dgvDatosProducto.Columns["ID"].Visible = false;
            }
            else if (rbtInactivos.Checked)
            {
                Objconsul.boolLlenarDataGridView(dgvDatosProducto, "Select IDPRODUCTO AS ID, CODIGOBARRA AS 'CODIGO BARRA',NOMBREPRODUCTO as PRODUCTO,STOCKMAXIMO AS 'STOCK MAXIMO',TIPOPRODUCTO AS CATEGORIA,PRECIOPUBLICO_IVA as 'P.V.P.' , PRECIOALMAYOR_IVA as 'PRECIO MAYOR.',PRECIOPORCAJA_IVA AS 'PRECIO CAJA',IVAESTADO AS 'TIENE IVA' from TbProducto WHERE ACTIVO = 0 and CODIGOBARRA like '%" + txtConsultarProducto.Text + "%' or NOMBREPRODUCTO  like '%" + txtConsultarProducto.Text + "%' or TIPOPRODUCTO like '%" + txtConsultarProducto.Text + "%' ;");
                dgvDatosProducto.Columns[1].HeaderText = "Habilitar";
                dgvDatosProducto.Columns["ID"].Visible = false;
            }
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.validar_Num_Letras(e);
        }

        private void txtStockMaximoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void txtObservacionesProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.validar_Num_Letras(e);
        }

        private void CkbICE_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbICE.Checked)
            {
                TxtIce.Enabled = true;
            }
            else
                TxtIce.Enabled = false;
        }

        private void CkbIRBP_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbIRBP.Checked)
            {
                TxtIRBP.Enabled = true;
            }
            else
                TxtIRBP.Enabled = false;
        }
    }
}
