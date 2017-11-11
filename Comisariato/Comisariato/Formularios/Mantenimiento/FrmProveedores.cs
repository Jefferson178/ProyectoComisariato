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
            

        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            cbIdentificacionProveedor.SelectedIndex = 0;
            cbNacionalidadProveedor.SelectedIndex = 0;
            cbNaturalezaProveedor.SelectedIndex = 0;
            cbTipoGastoProveedor.SelectedIndex = 0;
            consultas = new Consultas();
            consultas.BoolLlenarComboBox(cbPaisProveedor, "Select IDPAIS as ID, NOMBRE AS Texto from TbPais");

            //consul.boolLlenarDataGridView(dgvDatosProveedor, "");
            //for (int i = 0; i < 20; i++)
            //{
            //    dgvDatosProveedor.Rows.Add();
            //}
            
            for (int i = 0; i < 3; i++)
            {
                dgvCodigoRetencionProveedor.Rows.Add();
                dgvDatosAutorizacionProveedor.Rows.Add();
            }
            cargarDatos("1");

            inicializarDatos();
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
                    Convert.ToInt32(cbParroquiaProveedor.SelectedValue), ckbRISEProveedor.Checked);
                if (!bandera_Estado)
                {
                    String resultado = ObjProvee.InsertarProveedor();
                    if (resultado == "Datos Guardados")
                    {
                        MessageBox.Show("Proveedor Registrado Correctamente ", "Exito",MessageBoxButtons.OK);
                        //cargarDatos("1");
                        rbtActivosProveedor.Checked = true;
                        inicializarDatos();
                        if (Program.FormularioLlamado)
                        {
                            Program.FormularioLlamado = false;
                            Program.FormularioProveedorCompra = true;
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
                        //cargarDatos("1");
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
                dgvDatosProveedor.Columns[1].HeaderText = "Desabilitar";
            }
            else if (rbtInactivosProveedor.Checked)
            {
                cargarDatos("0");
                dgvDatosProveedor.Columns[1].HeaderText = "Habilitar";
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
                consultas.boolLlenarDataGridView(dgvDatosProveedor, "Select identificacion,NOMBRES AS 'NOMBRE PROVEEDOR', NACIONALIDAD,RAZONSOCIAL,GIRACHEQUEA as 'GIRA CHEQUE' from TbProveedor where ESTADO = 1 and IDENTIFICACION like '%"+ txtConsultarProveedor.Text + "%' or NOMBRES like '%"+txtConsultarProveedor.Text+"%'");
                dgvDatosProveedor.Columns[1].HeaderText = "Desabilitar";
            }
            else if (rbtInactivosProveedor.Checked)
            {
                consultas.boolLlenarDataGridView(dgvDatosProveedor, "Select identificacion,NOMBRES AS 'NOMBRE PROVEEDOR', NACIONALIDAD,RAZONSOCIAL,GIRACHEQUEA as 'GIRA CHEQUE' from TbProveedor where ESTADO = 0 and IDENTIFICACION like '%" + txtConsultarProveedor.Text + "%' or NOMBRES like '%" + txtConsultarProveedor.Text + "%'");
                dgvDatosProveedor.Columns[1].HeaderText = "Habilitar";
            }
        }

        private void dgvDatosProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Proveedor ObjProvee = new Proveedor();
            if (rbtActivosProveedor.Checked)
            {
                if (this.dgvDatosProveedor.Columns[e.ColumnIndex].Name == "DeshabilitarProveedor")
                {
                    ObjProvee.EstadoProveedor(dgvDatosProveedor.CurrentRow.Cells[2].Value.ToString(), 2);
                    cargarDatos("1");
                }
            }
            else if (rbtInactivosProveedor.Checked)
            {
                if (this.dgvDatosProveedor.Columns[e.ColumnIndex].Name == "DeshabilitarProveedor")
                {
                    ObjProvee.EstadoProveedor(dgvDatosProveedor.CurrentRow.Cells[2].Value.ToString(), 1);
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
                    cbTipoServicioProveedor.SelectedItem = myRow["TIPOSERVICIO"].ToString();
                    cbTipoGastoProveedor.SelectedItem = myRow["TIPOGASTO"].ToString();

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
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell bc = dgvDatosProveedor[0, e.RowIndex] as DataGridViewButtonCell;
                bool x;
                if (modificarProveedor.Tag == null)
                {
                    x = false;
                }
                else
                {
                    x = (bool)modificarProveedor.Tag;
                }
                if (x)
                {
                    Icon ico = new Icon("repair.ico");
                    e.Graphics.DrawIcon(ico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                }
                e.Handled = true;
            }
        }

        private void dgvDatosProveedor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = "Repair";
                e.FormattingApplied = true;
            }
        }
    }
}
