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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmOrdenDeGiro : Form
    {
        public FrmOrdenDeGiro()
        {
            InitializeComponent();
        }

        Consultas ObjConsul = new Consultas();
        public void inicializar()
        {
            Funcion.Limpiarobjetos(gbDatosFactura);
            txtSerie1.Text = "";
            txtSerie2.Text = "";
            txtNumero.Text = "";
            cbSustentoTributario.Text = "";
            CmbTipo.SelectedIndex = 0;
            cbAutorizacionSRI.SelectedIndex = 0;
        }
        public void llenarDatosOG(int ecnabezadoCompra)
        {
            SqlDataReader datos = null;
            datos = ObjConsul.obtenerDatos("select * from TbEncabezadoyPieCompra where IDEMCABEZADOCOMPRA = " + ecnabezadoCompra + "");
            txtNumero.Text = Convert.ToString(datos["NUMERO"]);
            txtSerie1.Text = Convert.ToString(datos["SERIE1"]);
            txtSerie2.Text = Convert.ToString(datos["SERIE2"]);
            txtBaseImponible.Text = Convert.ToString(datos["SUBTOTAL"]);
            txtICE.Text = Convert.ToString(datos["TOTALICE"]);
            txtIRBP.Text = Convert.ToString(datos["TOTALIRBP"]);
            txtSubtotalIVA.Text = Convert.ToString(datos["SUBTOTALIVA"]);
            txtSubtotal0.Text = Convert.ToString(datos["SUBTOTAL0"]);
            txtTotal.Text = Convert.ToString(datos["TOTAL"]);
            txtIVA.Text = Convert.ToString(datos["TOTALIVA"]);
            datos = ObjConsul.obtenerDatos("select PROVEEDORRISE from TbProveedor where IDPROVEEDOR = " + CmbProveedor.SelectedValue + "");
            ckbRISE.Checked = Convert.ToBoolean(datos["PROVEEDORRISE"]);
            cbIVA.Text = FrmCompra.IVA;
            cbIVA.Enabled = false;
            //objData = ObjConsul.BoolDataTable("select * from TbEncabezadoyPieCompra where IDEMCABEZADOCOMPRA = " + idEncabezadoOG + "");
            //txtNumero.Text = objData.["NUMERO"].ToString();
            DataTable datosRetencion = new DataTable();
            datosRetencion = ObjConsul.BoolDataTable("select * from VistaRetencion where IDPROVEEDOR = " + CmbProveedor.SelectedValue + "");
            //DataRow myRow = datosRetencion.Rows[0];
            for (int i = 0; i < datosRetencion.Rows.Count; i++)
            {
                DataRow myRow = datosRetencion.Rows[i];
                dgvDatosRetencion.Rows[i].Cells[0].Value = myRow["DESCRIPCION"];
                dgvDatosRetencion.Rows[i].Cells[2].Value = myRow["RETENCION"];
                if (myRow["CODIGO"].ToString() == "COD_RET_FUE")
                {
                    dgvDatosRetencion.Rows[i].Cells[1].Value = "FUENTE";
                    dgvDatosRetencion.Rows[i].Cells[3].Value = txtBaseImponible.Text;
                    dgvDatosRetencion.Rows[i].Cells[4].Value = (Convert.ToSingle(dgvDatosRetencion.Rows[i].Cells[3].Value) * Convert.ToSingle(dgvDatosRetencion.Rows[i].Cells[2].Value)) / 100;
                }
                else
                {
                    dgvDatosRetencion.Rows[i].Cells[1].Value = "IVA";
                    dgvDatosRetencion.Rows[i].Cells[3].Value = Convert.ToSingle(txtBaseImponible.Text) * Convert.ToSingle(txtIVA.Text);
                    dgvDatosRetencion.Rows[i].Cells[4].Value = (Convert.ToSingle(dgvDatosRetencion.Rows[i].Cells[3].Value) * Convert.ToSingle(dgvDatosRetencion.Rows[i].Cells[2].Value)) / 100;
                }
                dgvDatosRetencion.Rows[i].Cells[6].Value = Convert.ToDateTime(myRow["FECHAVALIDODESDE"]).ToShortDateString() + " - " + Convert.ToDateTime(myRow["FECHAVALIDOHASTA"]).ToShortDateString();

            }
        }

        private void FrmOrdenDeGiro_Load(object sender, EventArgs e)
        {

            ObjConsul.BoolLlenarComboBox(cbCuentaDeudoraCero, "Select IDPLANCUENTA as ID ,'[' +CUENTA +']' + ' - ' + DESCRIPCIONCUENTA AS Texto FROM dbo.TbPlanCuenta");
            cbCuentaDeudoraCero.SelectedValue = 26;
            ObjConsul.BoolLlenarComboBox(cbCuentaDeudora12, "Select IDPLANCUENTA as ID ,'[' +CUENTA +']' + ' - ' + DESCRIPCIONCUENTA AS Texto FROM dbo.TbPlanCuenta");
            cbCuentaDeudora12.SelectedValue = 27;
            ObjConsul.BoolLlenarComboBox(cbCuentaDeudoraIRBP, "Select IDPLANCUENTA as ID ,'[' +CUENTA +']' + ' - ' + DESCRIPCIONCUENTA AS Texto FROM dbo.TbPlanCuenta");
            ObjConsul.BoolLlenarComboBox(cbIvaPagar, "Select IDPLANCUENTA as ID ,'[' +CUENTA +']' + ' - ' + DESCRIPCIONCUENTA AS Texto FROM dbo.TbPlanCuenta");
            for (int i = 0; i < 7; i++)
            {
                dgvDatosLibroDiario.Rows.Add();
            }
            for (int i = 0; i < 14; i++)
            {
                dgvDatosRetencion.Rows.Add();
            }
            for (int i = 0; i < 20; i++)
            {
                dgvDatosImportacionesRelacionadas.Rows.Add();
            }
            for (int i = 0; i < 25; i++)
            {
                dgvDatosOG.Rows.Add();
            }

            ObjConsul = new Clases.Consultas();
            ObjConsul.BoolLlenarComboBox(CmbProveedor, "Select IDPROVEEDOR AS ID , NOMBRES AS TEXTO from TbProveedor");
            // hacer aparecer un scrollBar, poniendo un limite de item que aparezcan
            CmbProveedor.DropDownHeight = CmbProveedor.ItemHeight = 100;
            ObjConsul.BoolLlenarComboBox(CmbTipoDocumento, "Select IDTIPODOCUMENTO ID, NOMBREDOCUMENTO AS TEXTO from TbTipoDocumento");
            // hacer aparecer un scrollBar, poniendo un limite de item que aparezcan
            CmbTipoDocumento.DropDownHeight = CmbTipoDocumento.ItemHeight = 100;
            CmbTipo.SelectedIndex = 0;
            cbAutorizacionSRI.SelectedIndex = 0;
            int idOrdenGiro = ObjConsul.ObtenerID("IDORDENGIRO", "TbEncabezadoOrdenGiro", "");
            int NordenGiro = 1 + ObjConsul.ObtenerID("NUMEROORDENGIRO", "TbEncabezadoOrdenGiro", " where IDORDENGIRO =" + idOrdenGiro + "");
            txtOrdenGiro.Text = NordenGiro.ToString();
            if (Program.FormularioLlamado)
            {
                int idEncabezadoOG = FrmCompra.IDEncabezadoCompraOG;
                //FrmCompra.IDEncabezadoCompraOG;
                ObjConsul.BoolLlenarComboBox(CmbProveedor, "Select P.IDPROVEEDOR as ID,  P.NOMBRES as Texto from TbProveedor P , TbEncabezadoyPieCompra E where E.IDPROVEEDOR = P.IDPROVEEDOR and E.IDEMCABEZADOCOMPRA = " + idEncabezadoOG + "");
                CmbProveedor.Enabled = false;
                ObjConsul.BoolLlenarComboBox(cbSustentoTributario, "Select C.IDCODIGOSRI as ID,  C.DESCRIPCION as Texto from TbProveedor P, TbCodigoSRI C  where  P.CREDITO = C.IDCODIGOSRI and  P.IDPROVEEDOR = " + CmbProveedor.SelectedValue + "");
                cbSustentoTributario.Enabled = false;
                txtNumero.ReadOnly = true;
                txtSerie1.ReadOnly = true;
                txtSerie2.ReadOnly = true;
                llenarDatosOG(idEncabezadoOG);
                Program.FormularioLlamado = false;
            }
            else
            {
                inicializar();
                ObjConsul.BoolLlenarComboBox(cbSustentoTributario, "Select C.IDCODIGOSRI as ID,  C.DESCRIPCION as Texto from TbProveedor P, TbCodigoSRI C  where  P.CREDITO = C.IDCODIGOSRI and  P.IDPROVEEDOR = " + CmbProveedor.SelectedValue + "");
                cbSustentoTributario.Enabled = false;                
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            try
            {
                string condicion = "where SERIE1 = " + Convert.ToInt32(txtSerie1.Text) + " AND SERIE2 = " + Convert.ToInt32(txtSerie2.Text) + " AND NUMERO = " + Convert.ToInt32(txtNumero.Text) + " AND IDPROVEEDOR = " + Convert.ToInt32(CmbProveedor.SelectedValue);
                int IDEncabezadoCompraOG = Convert.ToInt32(ObjConsul.ObtenerValorCampo("IDEMCABEZADOCOMPRA", "TbEncabezadoyPieCompra", condicion));
                llenarDatosOG(IDEncabezadoCompraOG);
            }
            catch (Exception)
            {
            }
        }

        private void CmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            inicializar();
            ObjConsul.BoolLlenarComboBox(cbSustentoTributario, "Select C.IDCODIGOSRI as ID,  C.DESCRIPCION as Texto from TbProveedor P, TbCodigoSRI C  where  P.CREDITO = C.IDCODIGOSRI and  P.IDPROVEEDOR = " + CmbProveedor.SelectedValue + "");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void txtNAutorizacion_Enter(object sender, EventArgs e)
        {
            if (cbAutorizacionSRI.SelectedIndex == 0)
            {
                txtNAutorizacion.MaxLength = 49;
            }
            else if (cbAutorizacionSRI.SelectedIndex == 1)
            {
                txtNAutorizacion.MaxLength = 10;
            }
        }

        private void txtPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void txtPlazo_TextChanged(object sender, EventArgs e)
        {
           // txtPlazo.Text += "Días";
        }

        private void cbAutorizacionSRI_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNAutorizacion.Text = "";
        }
    }
}
