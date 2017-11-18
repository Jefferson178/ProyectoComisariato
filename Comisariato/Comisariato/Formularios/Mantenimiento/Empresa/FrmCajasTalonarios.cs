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

namespace Comisariato.Formularios.Mantenimiento
{
    public partial class FrmCajasTalonario : Form
    {
        public FrmCajasTalonario()
        {
            InitializeComponent();
        }
        Consultas consultas = new Consultas();
        String GlobalIDCajaTalonario = "";
        bool bandera_Estado = false;

        public void inicializarDatos()
        {
            tcCajaTalonario.SelectedIndex = 0; //Seleccion el tab a mostrarse

            txtConsultarCaja.Text = "";
            txtDocumentoInicialCaja.Text = "";
            txtDocumentoActualCaja.Text = "";
            txtDocumentoFinalCaja.Text = "";
            txtSerie1Caja.Text = "";
            txtSerie2Caja.Text = "";
            txtAutorizacionCaja.Text = "";
            txtEstacionCaja.Text = "";
            TxtIP.Text = "";

            ckbActivoCaja.Checked = true;
            //cbTipoDocumentoCaja.SelectedIndex = 0;

            consultas.BoolLlenarComboBox(cbSucursalCaja, "Select IDSUCURSAL as ID, NOMBRESUCURSAL as TEXTO from TbSucursal where ESTADO = 1;");
            consultas.BoolLlenarComboBox(cbBodegaCaja, "Select IDBODEGA as ID, NOMBRE as TEXTO from TbBodega where ESTADO = 1;");
            consultas.BoolLlenarComboBox(cbTipoDocumentoCaja, "Select CODIGO as ID, NOMBREDOCUMENTO as TEXTO from TbTipoDocumento;");


            //// llenar datadrigview solo los activos
            cargarDatos("1");
        }

        private void cargarDatos(string condicion)
        {
            consultas.boolLlenarDataGridView(dgvDatosCaja, "Select IDCAJATALONARIO AS ID, TIPODOCUMENTO as 'TIPO DOC.', TbSucursal.NOMBRESUCURSAL as 'SUCURSAL', TbBodega.NOMBRE,TbCajasTalonario.SERIE1,TbCajasTalonario.SERIE2, TbCajasTalonario.FECHACADUCIDAD as 'Fecha Caducidad', TbCajasTalonario.AUTORIZACION,TbCajasTalonario.DOCUMENTOINICIAL as 'DOC. I.',TbCajasTalonario.DOCUMENTOFINAL AS 'DOC. F.',TbCajasTalonario.DOCUMENTOACTUAL AS 'DOC. A.',TbCajasTalonario.ESTACION , TbCajasTalonario.IPESTACION from TbCajasTalonario, TbBodega,TbSucursal  where TbBodega.IDBODEGA = TbCajasTalonario.IDBODEGA and TbSucursal.IDSUCURSAL = TbCajasTalonario.IDSUCURSAL  and TbCajasTalonario.ESTADO = '" + condicion+"'");
            dgvDatosCaja.Columns["ID"].Visible = false;
        }


        private void dgvDatosCaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Empleado ObjEmpleado = new Empleado();

            if (this.dgvDatosCaja.Columns[e.ColumnIndex].Name == "Modificar")
            {
                //MessageBox.Show("modificar toca " + DgvDatosEmpleado.CurrentRow.Cells[3].Value.ToString());
                GlobalIDCajaTalonario = dgvDatosCaja.CurrentRow.Cells[4].Value.ToString();
                inicializarDatos();
                tcCajaTalonario.SelectedIndex = 0;
                bandera_Estado = true;
                //Llenar el DataTable
                DataTable dt = consultas.BoolDataTable("Select * from TbEmpresa where RUC = '" + GlobalIDCajaTalonario + "'");
                //Verificar si tiene Datos
                if (dt.Rows.Count > 0)
                {
                    ////Cargar los demas Datos
                    //txtNombreEmpresa.Text = myRow["NOMBRE"].ToString();
                    //txtRUCEmpresa.Text = myRow["RUC"].ToString();
                    //txtNombreComercialEmpresa.Text = myRow["NOMBRECOMERCIAL"].ToString();
                    //txtRazonSocialEmpresa.Text = myRow["RAZONSOCIAL"].ToString();
                    //txtGerenteEmpresa.Text = myRow["GERENTE"].ToString();
                    //txtDireccionEmpresa.Text = myRow["DIRECCION"].ToString();
                    //txtEmailEmpresa.Text = myRow["EMAIL"].ToString();
                    //dtpFechaInicioContableEmpresa.Value = Convert.ToDateTime(myRow["FECHAINICIOCONTABLE"]);
                    //txtCeluar1Empresa.Text = myRow["CELULAR1"].ToString();
                    //txtCelular2Empresa.Text = myRow["CELULAR2"].ToString();
                    //txtRUCContadorEmpresa.Text = myRow["RUCCONTADOR"].ToString();
                    //txtNombreContadorempresa.Text = myRow["NOMBRECONTADOR"].ToString();
                    //txtEmailContadorEmpresa.Text = myRow["EMAILCONTADOR"].ToString();
                    //txtCelular1ContadorEmpresa.Text = myRow["CELULAR1CONTADOR"].ToString();
                    //txtCelular2ContadorEmpresa.Text = myRow["CELULAR2CONTADOR"].ToString();

                }
                btnLimpiarProveedor.Text = "&Cancelar";
                btnGuardarUsuario.Text = "&Modificar";

            }
        }

        private void dgvDatosCaja_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDatosCaja.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosCaja.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\modificarDgv.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosCaja.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosCaja.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }

            if (rbtInactivos.Checked)
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosCaja.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosCaja.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\Habilitar.ico");
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosCaja.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosCaja.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosCaja.Columns[e.ColumnIndex].Name == "DeshabilitarCliente" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosCaja.Rows[e.RowIndex].Cells["DeshabilitarCliente"] as DataGridViewButtonCell;
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosCaja.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosCaja.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }

        private void FrmCajasTalonario_Load(object sender, EventArgs e)
        {
            inicializarDatos();
            cbTipoDocumentoCaja.DropDownHeight = cbTipoDocumentoCaja.ItemHeight = 150;
            cbBodegaCaja.DropDownHeight = cbBodegaCaja.ItemHeight = 150;
            cbSucursalCaja.DropDownHeight = cbSucursalCaja.ItemHeight = 150;
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (txtSerie1Caja.Text != "" && txtSerie2Caja.Text != "" && txtDocumentoActualCaja.Text != "" && txtDocumentoFinalCaja.Text != "" && txtDocumentoInicialCaja.Text != "" && txtAutorizacionCaja.Text != "" && txtEstacionCaja.Text != "" && TxtIP.Text != "")
            {

                CajaTalonarioEmpresa ObjCajaTalonarioEmpresa = new CajaTalonarioEmpresa(Convert.ToInt32(cbSucursalCaja.SelectedValue), Convert.ToInt32(cbBodegaCaja.SelectedValue), cbTipoDocumentoCaja.SelectedValue.ToString(), txtDocumentoInicialCaja.Text, txtDocumentoFinalCaja.Text, txtDocumentoActualCaja.Text, dtpFechaCaducidadCaja.Value.ToShortDateString().ToString(), ckbActivoCaja.Checked, txtEstacionCaja.Text, TxtIP.Text, txtSerie1Caja.Text, txtSerie2Caja.Text, txtAutorizacionCaja.Text);
                if (!bandera_Estado) // Para identificar si se va ingresar
                {
                    String resultado = ObjCajaTalonarioEmpresa.Insertar(); // retorna true si esta correcto todo
                    if (resultado == "Datos Guardados")
                    {
                        inicializarDatos();
                        cargarDatos("1");
                        MessageBox.Show("Registrado Correctamente ", "Exito", MessageBoxButtons.OK);
                        rbtActivos.Checked = true;
                    }
                    else if (resultado == "Error al Registrar")
                    {
                        MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (resultado == "Existe") { MessageBox.Show("Ya Existe la Serie", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }

            }
            else if (bandera_Estado) // Para identificar si se va modificar
            {
                //String Resultado = Objcliente.ModificarCliente(identificacion); // retorna true si esta correcto todo
                //ModificarOtraInfCliente(idcliente);
                //if (Resultado == "Correcto")
                ////{
                //MessageBox.Show("Cliente Actualizado", "Exito");
                //cargarDatos("1");
                //rbtActivosCliente.Checked = true;
                //identificacion = "";
                //inicializarDatos();
                ////}
                //else { MessageBox.Show("Error al actualizar Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                //inicializarDatos();
                //bandera_Estado = false;
                //btnGuardarCliente.Text = "&Guardar";
                //}
            }
            else
            {
                MessageBox.Show("Ingrese los datos ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}