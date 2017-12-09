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
            cbTipo.SelectedIndex = 0;
            cbAutorizacionSRI.SelectedIndex = 0;
        }
        public string agregra0Decimal(string valor)
        {
            
            int i;
            int ocurrencias = valor.Split('.').Length - 1;
            if (ocurrencias == 0)
            {
                valor += ".0";
            }
            string[] s = valor.Split('.');
            for (i = 0; i < s[1].Length;)
            {
                i++;
            }
            if (i < 4)
            {
                for (int j = i; j < 4; j++)
                {
                    s[1] += "0"; 
                }
            }
            return s[0] + "." + s[1];
        }
        public void llenarDatosOG(int ecnabezadoCompra)
        {
            SqlDataReader datos = null;
            datos = ObjConsul.obtenerDatos("select * from TbEncabezadoyPieCompra where IDEMCABEZADOCOMPRA = " + ecnabezadoCompra + "");
            txtNumero.Text = Convert.ToString(datos["NUMERO"]);
            txtSerie1.Text = Convert.ToString(datos["SERIE1"]);
            txtSerie2.Text = Convert.ToString(datos["SERIE2"]);
            txtBaseImponible.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["SUBTOTAL"]));
            txtBaseImponible.Text = agregra0Decimal(txtBaseImponible.Text);
            txtICE.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["TOTALICE"]));
            txtICE.Text = agregra0Decimal(txtICE.Text);
            txtIRBP.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["TOTALIRBP"]));
            txtIRBP.Text = agregra0Decimal(txtIRBP.Text);
            txtSubtotalIVA.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["SUBTOTALIVA"]));
            txtSubtotalIVA.Text = agregra0Decimal(txtSubtotalIVA.Text);
            txtSubtotal0.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["SUBTOTAL0"]));
            txtSubtotal0.Text = agregra0Decimal(txtSubtotal0.Text);
            txtTotal.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["TOTAL"]));
            txtTotal.Text = agregra0Decimal(txtTotal.Text);
            txtIVA.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["TOTALIVA"]));
            txtIVA.Text = agregra0Decimal(txtIVA.Text);
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
                    
                }
                else
                {
                    dgvDatosRetencion.Rows[i].Cells[1].Value = "IVA";
                }
                dgvDatosRetencion.Rows[i].Cells[3].Value = txtBaseImponible.Text;
                dgvDatosRetencion.Rows[i].Cells[4].Value = Funcion.reemplazarcaracter(((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvDatosRetencion.Rows[i].Cells[3].Value.ToString())) * Convert.ToSingle(dgvDatosRetencion.Rows[i].Cells[2].Value)) / 100).ToString());
                dgvDatosRetencion.Rows[i].Cells[6].Value = Convert.ToDateTime(myRow["FECHAVALIDODESDE"]).ToShortDateString() + " - " + Convert.ToDateTime(myRow["FECHAVALIDOHASTA"]).ToShortDateString();

            }
        }

        private void FrmOrdenDeGiro_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                dgvDatosLibroDiario.Rows.Add();
            }
            for (int i = 0; i < 14; i++)
            {
                dgvDatosRetencion.Rows.Add();
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
            cbTipo.SelectedIndex = 0;
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

        private void txtValorPagar_TextChanged(object sender, EventArgs e)
        {
            float saldo = 0.0f;
            try
            {

                saldo = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotal.Text)) - Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtValorPagar.Text));
                if (saldo < 0)
                {
                    txtSaldo.Text = "";
                }
                else
                {
                    txtSaldo.Text = saldo.ToString("##.0000");
                }
            }
            catch (Exception)
            {
            }
            if (txtValorPagar.Text == "")
            {
                txtSaldo.Text = "";
            }
        }

        private void txtValorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtValorPagar.Text);
        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {
            if(txtValorPagar.Text != "" && txtConcepto.Text != "" && cbFormaPago.Text != "")
            {
                dgvDatosLibroDiario.Rows.Clear();
                for (int i = 0; i < 5; i++)
                {
                    dgvDatosLibroDiario.Rows.Add();
                }
                //fila 0 para inventario 0%
                dgvDatosLibroDiario.Rows[0].Cells[2].Value = txtSubtotal0.Text;
                dgvDatosLibroDiario.Rows[0].Cells[0].Value = "101.03.03.01 - Inventario 0%";
                //fila 0 para inventario 12%
                dgvDatosLibroDiario.Rows[1].Cells[2].Value = txtSubtotalIVA.Text;
                dgvDatosLibroDiario.Rows[1].Cells[0].Value = "101.03.03.02 - Inventario 12%";
                //fila 0 para iva
                dgvDatosLibroDiario.Rows[2].Cells[2].Value = txtIVA.Text;
                dgvDatosLibroDiario.Rows[2].Cells[0].Value = "101.05.01.01 - IVA";
                //fila 0 para ice
                dgvDatosLibroDiario.Rows[3].Cells[2].Value = txtICE.Text;
                dgvDatosLibroDiario.Rows[3].Cells[0].Value = "ICE";
                //fila 0 para irbp
                dgvDatosLibroDiario.Rows[4].Cells[2].Value = txtIRBP.Text;
                dgvDatosLibroDiario.Rows[4].Cells[0].Value = "IRBP";
                int contadorFilaLibroDiario = 5;
                
                for (int i = 0; i < dgvDatosRetencion.RowCount - 1; i++)
                {
                    if (contadorFilaLibroDiario < dgvDatosLibroDiario.RowCount - 1)
                    {
                        dgvDatosLibroDiario.Rows[contadorFilaLibroDiario].Cells[3].Value = dgvDatosRetencion.Rows[i].Cells[4].Value;
                        string concepto = Convert.ToString(dgvDatosRetencion.Rows[i].Cells[0].Value) + "(" + Convert.ToString(dgvDatosRetencion.Rows[i].Cells[1].Value) + ")";
                        dgvDatosLibroDiario.Rows[contadorFilaLibroDiario].Cells[0].Value = concepto;
                        contadorFilaLibroDiario++;                        
                    }
                    else
                    {
                        dgvDatosLibroDiario.Rows.Add();
                        i--;
                        //contadorFilaLibroDiario--;
                    }
                    if (dgvDatosRetencion.Rows[i + 1].Cells[4].Value == null)
                    {
                        break;
                    }
                }
                dgvDatosLibroDiario.Rows.Add();
                dgvDatosLibroDiario.Rows[contadorFilaLibroDiario].Cells[3].Value = txtValorPagar.Text;
                if (txtPlazo.Text == "0")
                {
                    //dgvDatosLibroDiario.Rows.Add();
                    if (cbFormaPago.SelectedIndex == 0)
                    {
                        dgvDatosLibroDiario.Rows[contadorFilaLibroDiario].Cells[0].Value = "101.01.01 - CAJA";
                    }
                    else
                    {
                        dgvDatosLibroDiario.Rows[contadorFilaLibroDiario].Cells[0].Value = "101.01.02 - BANCO";
                    }                    
                }
                else
                {
                    dgvDatosLibroDiario.Rows[contadorFilaLibroDiario].Cells[0].Value = "CTA X PAGAR";
                }
                for (int i = 0; i < dgvDatosLibroDiario.RowCount - 1 ; i++)
                {
                    dgvDatosLibroDiario.Rows[i].Cells[4].Value = txtConcepto.Text;
                }
                quitarValores0DGVLD();
                calcularLibroDiario();
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos necesarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void quitarValores0DGVLD()
        {
            int columna;
            for (int i = 0; i < dgvDatosLibroDiario.RowCount -1; i++)
            {
                if (dgvDatosLibroDiario.Rows[i].Cells[2].Value != null)
                {
                    columna = 2;
                }
                else
                    columna = 3;
                if (Convert.ToString(dgvDatosLibroDiario.Rows[i].Cells[columna].Value) == "0.0000")
                {
                    dgvDatosLibroDiario.Rows.Remove(dgvDatosLibroDiario.Rows[i]);
                }
            }
        }
        public void calcularLibroDiario()
        {
            float sumaDebe = 0.0f, sumaHaber = 0.0f;
            for (int i = 0; i < dgvDatosLibroDiario.RowCount - 1; i++)
            {
                if (dgvDatosLibroDiario.Rows[i].Cells[2].Value != null)
                {
                    sumaDebe = sumaDebe + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvDatosLibroDiario.Rows[i].Cells[2].Value.ToString()));
                }
                else
                    sumaHaber = sumaHaber + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvDatosLibroDiario.Rows[i].Cells[3].Value.ToString()));
            }
            txtTotalDebe.Text = Funcion.reemplazarcaracter(sumaDebe.ToString());
            txtTotalHaber.Text = Funcion.reemplazarcaracter(sumaHaber.ToString());
        }
        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (txtValorPagar.Text != "" && txtConcepto.Text != "" && cbFormaPago.Text != "" && txtNAutorizacion.Text != "" && cbTipo.Text != "")
            {
                //EncabezadoOrdenGiro objEncabezadoOG = new EncabezadoOrdenGiro(Convert.ToInt32(txtOrdenGiro.Text), CmbTipoDocumento.SelectedValue, CmbProveedor.SelectedValue, cbTipo.Text, txtPlazo.Text,
                //    txtConcepto.Text, txtNAutorizacion.Text, txtNumero.Text, Convert.ToInt32(txtSerie1.Text), Convert.ToInt32(txtSerie2.Text), ckbRISE.Checked, ckbDeclaraSRI.Checked, ckbManual.Checked,
                //    dtpFechaDocumentacion, dtpFechaContabilizacion, dtpFechaOrdenGiro, dtpFechaVigente, ;
            }
        }
    }
}
