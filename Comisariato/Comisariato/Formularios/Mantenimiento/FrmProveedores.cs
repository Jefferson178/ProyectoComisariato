using Comisariato.Clases;
using Comisariato.Formularios.Mantenimiento.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }


        Consultas consultas;
        bool bandera_Estado = false;
        String identificacion = "";

        public void inicializarDatos()
        {
            cbIdentificacionProveedor.SelectedIndex = 0;
            cbNacionalidadProveedor.SelectedIndex = 0;
            cbNaturalezaProveedor.SelectedIndex = 0;
            //CmbPais.SelectedIndex = 1;
            //CmbParroquia.SelectedIndex = 1;
            //cbProvinciaProveedor.SelectedIndex = 1;
            cbTipoGastoProveedor.SelectedIndex = 0;
            //CmbTipoServicio.SelectedIndex = 1;

            txtDireccionProveedor.Text = "";
            txtRazonSocialProveedor.Text = "";
            txtResponsableProveedor.Text = "";
            txtCelularProveedor.Text = "";
            txtTelefonoProveedor.Text = "";
            txtEmailProveedor.Text = "";
            txtGiraChequeProveedor.Text = "";
            txtPlazo.Text = "";
            txtFax.Text = "";
            ckbRISEProveedor.Checked = false;
            Funcion.Limpiarobjetos(gbDatosAutorizacionProveedor);
            Funcion.Limpiarobjetos(gbInformcionGeneralProveedor);
            dgvDatosAutorizacionProveedor.Controls.Clear();
            //dgvDatosProveedor.Controls.Clear();
            dgvCodigoRetencionProveedor.Controls.Clear();
            txtConsultarProveedor.Text = "";

            cargarDatos("1");

            //cbPaisProveedor.SelectedIndex = 0;
            cbProvinciaProveedor.SelectedValue = 9;
            cbCantonProveedor.SelectedValue = 80;
            cbParroquiaProveedor.SelectedValue = 41;


            consultas.BoolLlenarComboBox(cbPaisProveedor, "Select IDPAIS as ID, NOMBRE AS Texto from TbPais");
            consultas.BoolLlenarComboBox(cbCuentaContableProveedor, "Select IDPLANCUENTA as ID ,'[' +CUENTA +']' + ' - ' + DESCRIPCIONCUENTA AS Texto FROM dbo.TbPlanCuenta ");
            consultas.BoolLlenarComboBox(cbTipoServicioProveedor, "Select IDSERVICIO as ID, DESCRIPCION AS Texto from TbTipoServicio");

        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            cbIdentificacionProveedor.SelectedIndex = 0;
            cbNacionalidadProveedor.SelectedIndex = 0;
            cbNaturalezaProveedor.SelectedIndex = 0;
            cbTipoGastoProveedor.SelectedIndex = 0;
            consultas = new Consultas();




            inicializarDatos();
            //consul.boolLlenarDataGridView(dgvDatosProveedor, "");
            //for (int i = dgvDatosProveedor.Rows.Count; i < 20; i++)
            //{
            //    dgvDatosProveedor.Rows.Add();
            //}

            for (int i = 0; i < 3; i++)
            {
                dgvCodigoRetencionProveedor.Rows.Add();
                dgvDatosAutorizacionProveedor.Rows.Add();
            }
            // Dimensionar lista combo

            cbPaisProveedor.DropDownHeight = cbPaisProveedor.ItemHeight = 150;
            cbProvinciaProveedor.DropDownHeight = cbProvinciaProveedor.ItemHeight = 150;
            cbCantonProveedor.DropDownHeight = cbCantonProveedor.ItemHeight = 150;
            cbParroquiaProveedor.DropDownHeight = cbParroquiaProveedor.ItemHeight = 150;

            cbCuentaContableProveedor.DropDownHeight = cbCuentaContableProveedor.ItemHeight = 150;
            cbTipoServicioProveedor.DropDownHeight = cbTipoServicioProveedor.ItemHeight = 150;

            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text != "" && txtNumeroIdentificacionProveedor.Text != "" && txtDireccionProveedor.Text != "" && txtCelularProveedor.Text != "" && txtGiraChequeProveedor.Text != "" && cbTipoGastoProveedor.Text != "" && Convert.ToInt32(cbParroquiaProveedor.SelectedValue) >= 1)
            {
                Proveedor ObjProvee = new Proveedor(txtFax.Text, ckbEstado.Checked, txtPlazo.Text, txtCodigo.Text, cbIdentificacionProveedor.Text, 
                    txtNombreProveedor.Text, txtNumeroIdentificacionProveedor.Text, cbNacionalidadProveedor.Text, cbNaturalezaProveedor.Text,
                    txtDireccionProveedor.Text, txtRazonSocialProveedor.Text, txtEmailProveedor.Text, txtTelefonoProveedor.Text, txtCelularProveedor.Text, 
                    txtGiraChequeProveedor.Text, txtResponsableProveedor.Text, cbTipoGastoProveedor.Text, cbTipoServicioProveedor.Text, 
                    Convert.ToInt32(cbParroquiaProveedor.SelectedValue), ckbRISEProveedor.Checked,Convert.ToInt32(cbCuentaContableProveedor.SelectedValue));
                if (!bandera_Estado)
                {
                    String resultado = ObjProvee.InsertarProveedor();
                    if (resultado == "Datos Guardados")
                    {
                        MessageBox.Show("Proveedor Registrado Correctamente ", "Exito",MessageBoxButtons.OK);
                        cargarDatos("1");
                        rbtActivosProveedor.Checked = true;
                        inicializarDatos();
                        if (Program.FormularioLlamado)
                        {
                            Program.FormularioLlamado = false;
                            Program.FormularioProveedorCompra = true;
                            consultas.BoolLlenarComboBox(FrmCompra.datosProveedor, "select IDPROVEEDOR AS Id, NOMBRES AS Texto from TbProveedor");
                            FrmCompra.datosProveedor.SelectedValue = consultas.ObtenerID("IDPROVEEDOR", "TbProveedor", "");
                            this.Close();
                        }
                    }
                    else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else if (resultado == "Existe") { MessageBox.Show("Ya Existe el Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else if (bandera_Estado)
                {
                    String Resultado = ObjProvee.ModificarProveedor(identificacion);
                    if (Resultado == "Correcto")
                    {
                        MessageBox.Show("Proveedor Actualizado", "Exito");
                        cargarDatos("1");
                        rbtActivosProveedor.Checked = true;
                        identificacion = "";
                    }
                    else { MessageBox.Show("Error al actualizar Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    bandera_Estado = false;
                    btnGuardarProveedor.Text = "&Guardar";
                    btnLimpiarProveedor.Text = "&Limpiar";
                    //Funcion.Limpiarobjetos(gbDatosAutorizacionProveedor);
                    inicializarDatos();
                }
            }
            else { MessageBox.Show("Ingrese los datos del Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (btnLimpiarProveedor.Text == "&Cancelar")
            {
                inicializarDatos();
                btnLimpiarProveedor.Text = "&Limpiar";
                btnGuardarProveedor.Text = "&Guardar";
            }
            else { inicializarDatos(); }
        }
        

        

        private void TxtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Letras(e);
        }

        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.validar_Num_Letras(e);
        }
        

        private void RbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtActivosProveedor.Checked)
            {
                cargarDatos("1");
                //dgvDatosProveedor.Columns[1].HeaderText = "Desabilitar";
            }
            else if (rbtInactivosProveedor.Checked)
            {
                cargarDatos("0");
                //dgvDatosProveedor.Columns[1].HeaderText = "Habilitar";
            }
        }


        private void cargarDatos(string condicion)
        {
            consultas = new Consultas();
            consultas.boolLlenarDataGridView(dgvDatosProveedor, "Select IDProveedor AS ID, Identificacion,NOMBRES AS 'Nombre Proveedor', Nacionalidad,RAZONSOCIAL as 'Razón Social',GIRACHEQUEA as 'Gira Cheque' from TbProveedor WHERE ESTADO = "+condicion+";");
            dgvDatosProveedor.Columns["ID"].Visible = false;
        }

        private void TxtConsultar_TextChanged(object sender, EventArgs e)
        {

            if (rbtActivosProveedor.Checked)
            {
                consultas.boolLlenarDataGridView(dgvDatosProveedor, "Select IDProveedor AS ID, identificacion,NOMBRES AS 'NOMBRE PROVEEDOR', NACIONALIDAD,RAZONSOCIAL,GIRACHEQUEA as 'GIRA CHEQUE' from TbProveedor where ESTADO = 1 and IDENTIFICACION like '%" + txtConsultarProveedor.Text + "%' or NOMBRES like '%"+txtConsultarProveedor.Text+"%'");
                //dgvDatosProveedor.Columns[1].HeaderText = "Desabilitar";
                dgvDatosProveedor.Columns["ID"].Visible = false;
            }
            else if (rbtInactivosProveedor.Checked)
            {
                consultas.boolLlenarDataGridView(dgvDatosProveedor, "Select IDProveedor AS ID, identificacion,NOMBRES AS 'NOMBRE PROVEEDOR', NACIONALIDAD,RAZONSOCIAL,GIRACHEQUEA as 'GIRA CHEQUE' from TbProveedor where ESTADO = 0 and IDENTIFICACION like '%" + txtConsultarProveedor.Text + "%' or NOMBRES like '%" + txtConsultarProveedor.Text + "%'");
                //dgvDatosProveedor.Columns[1].HeaderText = "Habilitar";
                dgvDatosProveedor.Columns["ID"].Visible = false;
            }
        }

        private void dgvDatosProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Proveedor ObjProvee = new Proveedor();
            if (rbtActivosProveedor.Checked)
            {
                if (this.dgvDatosProveedor.Columns[e.ColumnIndex].Name == "DeshabilitarProveedor")
                {
                    ObjProvee.EstadoProveedor(dgvDatosProveedor.CurrentRow.Cells[3].Value.ToString(), 2);
                    cargarDatos("1");
                }
            }
            else if (rbtInactivosProveedor.Checked)
            {
                if (this.dgvDatosProveedor.Columns[e.ColumnIndex].Name == "DeshabilitarProveedor")
                {
                    ObjProvee.EstadoProveedor(dgvDatosProveedor.CurrentRow.Cells[3].Value.ToString(), 1);
                    cargarDatos("0");
                }
            }

            if (this.dgvDatosProveedor.Columns[e.ColumnIndex].Name == "modificarProveedor")
            {
                identificacion = dgvDatosProveedor.CurrentRow.Cells[3].Value.ToString();
                tcProveedor.SelectedIndex = 0;
                bandera_Estado = true;
                //Llenar el DataTable
                DataTable dt = consultas.BoolDataTable("Select * from TbProveedor where IDENTIFICACION = '" + identificacion + "'");
                //Arreglo de byte en donde se almacenara la foto en bytes
                byte[] MyData = new byte[0];
                //Verificar si tiene Datos
                if (dt.Rows.Count > 0)
                {
                    DataRow myRow = dt.Rows[0];
                    txtCodigo.Text = myRow["CODIGO"].ToString();
                    txtNombreProveedor.Text = myRow["NOMBRES"].ToString();
                    txtNumeroIdentificacionProveedor.Text = myRow["IDENTIFICACION"].ToString();
                    txtDireccionProveedor.Text = myRow["DIRECCION"].ToString();
                    txtRazonSocialProveedor.Text = myRow["RAZONSOCIAL"].ToString();
                    txtCelularProveedor.Text = myRow["CELULAR"].ToString();
                    txtTelefonoProveedor.Text = myRow["TELEFONO"].ToString();
                    txtResponsableProveedor.Text = myRow["RESPONSABLE"].ToString();
                    txtPlazo.Text = myRow["PLAZO"].ToString();
                    txtEmailProveedor.Text = myRow["EMAIL"].ToString();
                    txtGiraChequeProveedor.Text = myRow["GIRACHEQUEA"].ToString();
                    txtFax.Text = myRow["FAX"].ToString();

                    ckbEstado.Checked = Convert.ToBoolean(myRow["ESTADO"]);
                    ckbRISEProveedor.Checked = Convert.ToBoolean(myRow["PROVEEDORRISE"]);


                    cbIdentificacionProveedor.SelectedItem = myRow["TIPOIDENTIFICACION"].ToString();
                    cbNacionalidadProveedor.SelectedItem = myRow["NACIONALIDAD"].ToString();
                    cbNaturalezaProveedor.SelectedItem = myRow["NATURALEZA"].ToString();
                    cbTipoGastoProveedor.SelectedItem = myRow["TIPOGASTO"].ToString();


                    int idservicion = consultas.ObtenerID("IDSERVICIO", "TbTipoServicio", " where DESCRIPCION = '" + myRow["TIPOSERVICIO"].ToString() + "' ");

                    cbTipoServicioProveedor.SelectedValue = idservicion;
                    int indexservicio = cbTipoServicioProveedor.SelectedIndex;
                    cbTipoServicioProveedor.SelectedIndex = indexservicio;

                    cbCuentaContableProveedor.SelectedValue = Convert.ToInt32(myRow["IDCuentaContable"]);
                    int indexcuenta = cbCuentaContableProveedor.SelectedIndex;
                    cbCuentaContableProveedor.SelectedIndex = indexcuenta;

                    consultas.LLenarCombosUbicacion(Convert.ToInt32(myRow["IDPARROQUIA"]), ref cbPaisProveedor, ref cbProvinciaProveedor, ref cbCantonProveedor, ref cbParroquiaProveedor);
                }

                btnLimpiarProveedor.Text = "&Cancelar";
                btnGuardarProveedor.Text = "&Modificar";
            }
        }

        private void cbPaisProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaisProveedor.SelectedValue.ToString() != null)
            {
                String ID = cbPaisProveedor.SelectedValue.ToString();
                consultas = new Consultas();
                consultas.BoolLlenarComboBox(cbProvinciaProveedor, "Select IDPROVINCIA as ID, NOMBRE AS Texto from TbProvincia where IDPAIS = " + ID + ";");
            }
        }

        private void cbProvinciaProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvinciaProveedor.SelectedValue.ToString() != null)
            {
                String ID = cbProvinciaProveedor.SelectedValue.ToString();
                consultas = new Consultas();
                consultas.BoolLlenarComboBox(cbCantonProveedor, "Select IDCANTON as ID, NOMBRE AS Texto from TbCanton where IDPROVINCIA = " + ID + ";");
            }
        }

        private void cbCantonProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCantonProveedor.SelectedValue.ToString() != null)
            {
                String ID = cbCantonProveedor.SelectedValue.ToString();
                consultas = new Consultas();
                consultas.BoolLlenarComboBox(cbParroquiaProveedor, "Select IDPARROQUIA as ID, NOMBRE AS Texto from TbParroquia where IDCANTON = " + ID + ";");
            }
        }

        private void txtNumeroIdentificacionProveedor_Leave(object sender, EventArgs e)
        {
            if (cbIdentificacionProveedor.SelectedIndex == 0)
            {
                if (!Funcion.VerificarCedula(txtNumeroIdentificacionProveedor.Text))
                {
                    MessageBox.Show("Ingrese la Cédula Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtNumeroIdentificacionProveedor.Focus();
                    txtNumeroIdentificacionProveedor.Select(0, txtNumeroIdentificacionProveedor.Text.Length);
                }
            }
            if (cbIdentificacionProveedor.SelectedIndex == 1)
            {
                if (txtNumeroIdentificacionProveedor.Text.Length == 13)
                {
                    if (txtNumeroIdentificacionProveedor.Text.Substring(10, 3) != "001" || Funcion.VerificarCedula(txtNumeroIdentificacionProveedor.Text.Substring(0, 10)) == false)
                    {
                        MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtNumeroIdentificacionProveedor.Focus();
                        txtNumeroIdentificacionProveedor.Select(0, txtNumeroIdentificacionProveedor.Text.Length);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); txtNumeroIdentificacionProveedor.Focus();
                    txtNumeroIdentificacionProveedor.Select(0, txtNumeroIdentificacionProveedor.Text.Length);
                }
            }
        }

        private void dgvDatosProveedor_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDatosProveedor.Columns[e.ColumnIndex].Name == "modificarProveedor" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosProveedor.Rows[e.RowIndex].Cells["modificarProveedor"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\modificarDgv.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosProveedor.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosProveedor.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }

            if (rbtInactivosProveedor.Checked)
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosProveedor.Columns[e.ColumnIndex].Name == "DeshabilitarProveedor" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosProveedor.Rows[e.RowIndex].Cells["DeshabilitarProveedor"] as DataGridViewButtonCell;
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\Habilitar.ico");
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosProveedor.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosProveedor.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosProveedor.Columns[e.ColumnIndex].Name == "DeshabilitarProveedor" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosProveedor.Rows[e.RowIndex].Cells["DeshabilitarProveedor"] as DataGridViewButtonCell;
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosProveedor.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosProveedor.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }

        private void dgvDatosProveedor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
        //--------------------------------------------------------------COMBOMULTICOLUMN CREDITO--------------------------------------------------------------
        bool apareceDataDeCombos = true;

        private void dgvCredito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            consultas.BoolLlenarComboBox(cbCreditoProveedor, "SELECT IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as Texto FROM TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(dgvCredito.CurrentRow.Cells[0].Value));
            dgvCredito.Visible = false;
            apareceDataDeCombos = true;
            cbICEProveedor.Focus();
            
        }
        private void cbCreditoProveedor_Enter(object sender, EventArgs e)
        {
            if (apareceDataDeCombos)
            {
                dgvCredito.Visible = true;
                consultas.boolLlenarDataGridView(dgvCredito, "select CS.IDCODIGOSRI, '[' + CS.CODIGOSRI + '] - ' + CS.DESCRIPCION as CODIGO_SRI, TCS.CODIGO AS TIPO, CS.RETENCION AS RETENCION, CS.FECHAVALIDODESDE AS DESDE, CS.FECHAVALIDOHASTA AS HASTA from TbCodigoSRI CS, TbTipoCodigoSRI TCS WHERE TCS.IDTIPOCODIGOSRI = CS.IDTIPOCODIGOSRI AND TCS.CODIGO = 'COD_IDCREDITO'");
                dgvCredito.Columns["IDCODIGOSRI"].Visible = false;
                dgvCredito.Columns["CODIGO_SRI"].Width = 400;
                dgvCredito.Columns["TIPO"].Width = 125;
                dgvCredito.Focus();
                dgvCredito.CurrentCell = dgvCredito.Rows[0].Cells[1];
            }
            else
            {
                dgvCredito.Visible = false;
                apareceDataDeCombos = true;
                if (cbCreditoProveedor.SelectedText != "")
                {
                    cbICEProveedor.Focus();
                }
                else
                    dgvCodigoRetencionProveedor.Focus();
            }
            
        }

        private void dgvCredito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                consultas.BoolLlenarComboBox(cbCreditoProveedor, "SELECT IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as Texto FROM TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(dgvCredito.CurrentRow.Cells[0].Value));
                dgvCredito.Visible = false;
                //----Si no funciona es esto
                apareceDataDeCombos = true;
                //-------------------------
                cbICEProveedor.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                dgvCredito.Visible = false;
                cbICEProveedor.Focus();
            }
        }

        private void dgvCredito_Enter(object sender, EventArgs e)
        {
            apareceDataDeCombos = false;
            dgvCredito.BringToFront();
        }
        //--------------------------------------------------------------COMBOMULTICOLUMN ICE--------------------------------------------------------------
        private void cbICEProveedor_Enter(object sender, EventArgs e)
        {
            if (apareceDataDeCombos)
            {
                dgvICE.Visible = true;
                consultas.boolLlenarDataGridView(dgvICE, "select CS.IDCODIGOSRI, '[' + CS.CODIGOSRI + '] - ' + CS.DESCRIPCION as CODIGO_SRI, TCS.CODIGO AS TIPO, CS.RETENCION AS RETENCION, CS.FECHAVALIDODESDE AS DESDE, CS.FECHAVALIDOHASTA AS HASTA from TbCodigoSRI CS, TbTipoCodigoSRI TCS WHERE TCS.IDTIPOCODIGOSRI = CS.IDTIPOCODIGOSRI AND TCS.CODIGO = 'COD_ICE'");
                dgvICE.Columns["IDCODIGOSRI"].Visible = false;
                dgvICE.Columns["CODIGO_SRI"].Width = 400;
                dgvICE.Columns["TIPO"].Width = 125;
                dgvICE.Focus();
                dgvICE.CurrentCell = dgvICE.Rows[0].Cells[1];
            }
            else
            {
                dgvICE.Visible = false;
                apareceDataDeCombos = true;
                if (cbICEProveedor.SelectedText != "")
                {
                    cbCodigo101Proveedor.Focus();
                }
                else
                    dgvCodigoRetencionProveedor.Focus();

            }
            
        }

        private void dgvICE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            consultas.BoolLlenarComboBox(cbICEProveedor, "SELECT IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as Texto FROM TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(dgvICE.CurrentRow.Cells[0].Value));
            dgvICE.Visible = false;
            apareceDataDeCombos = true;
            cbCodigo101Proveedor.Focus();
        }

        private void dgvICE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                consultas.BoolLlenarComboBox(cbICEProveedor, "SELECT IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as Texto FROM TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(dgvICE.CurrentRow.Cells[0].Value));
                dgvICE.Visible = false;
                //----Si no funciona es esto
                apareceDataDeCombos = true;
                //-------------------------
                cbCodigo101Proveedor.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                dgvICE.Visible = false;
                cbCodigo101Proveedor.Focus();
            }
        }

        private void dgvICE_Enter(object sender, EventArgs e)
        {
            apareceDataDeCombos = false;
            dgvICE.BringToFront();
        }
        //--------------------------------------------------------------COMBOMULTICOLUMN 101--------------------------------------------------------------
        private void cbCodigo101Proveedor_Enter(object sender, EventArgs e)
        {
            if (apareceDataDeCombos)
            {
                dgvCodigo101.Visible = true;
                consultas.boolLlenarDataGridView(dgvCodigo101, "select CS.IDCODIGOSRI, '[' + CS.CODIGOSRI + '] - ' + CS.DESCRIPCION as CODIGO_SRI, TCS.CODIGO AS TIPO, CS.RETENCION AS RETENCION, CS.FECHAVALIDODESDE AS DESDE, CS.FECHAVALIDOHASTA AS HASTA from TbCodigoSRI CS, TbTipoCodigoSRI TCS WHERE TCS.IDTIPOCODIGOSRI = CS.IDTIPOCODIGOSRI AND TCS.CODIGO = 'COD_101'");
                dgvCodigo101.Columns["IDCODIGOSRI"].Visible = false;
                dgvCodigo101.Columns["CODIGO_SRI"].Width = 400;
                dgvCodigo101.Columns["TIPO"].Width = 125;
                dgvCodigo101.Focus();
                dgvCodigo101.CurrentCell = dgvCodigo101.Rows[0].Cells[1];
            }
            else
            {
                dgvCodigo101.Visible = false;
                apareceDataDeCombos = true;
                dgvCodigoRetencionProveedor.Focus();

            }
        }

        private void dgvCodigo101_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            consultas.BoolLlenarComboBox(cbCodigo101Proveedor, "SELECT IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as Texto FROM TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(dgvCodigo101.CurrentRow.Cells[0].Value));
            dgvCodigo101.Visible = false;
            apareceDataDeCombos = true;
            dgvCodigoRetencionProveedor.Focus();
        }

        private void dgvCodigo101_Enter(object sender, EventArgs e)
        {
            apareceDataDeCombos = false;
            dgvCodigo101.BringToFront();
        }

        private void dgvCodigo101_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                consultas.BoolLlenarComboBox(cbCodigo101Proveedor, "SELECT IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as Texto FROM TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(dgvCodigo101.CurrentRow.Cells[0].Value));
                dgvCodigo101.Visible = false;
                //----Si no funciona es esto
                apareceDataDeCombos = true;
                //-------------------------
                cbCodigo101Proveedor.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                dgvCodigo101.Visible = false;
                dgvCodigoRetencionProveedor.Focus();
            }
        }
    }
}
