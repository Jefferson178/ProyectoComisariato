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

namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmOrdenDeGiro : Form
    {
        public FrmOrdenDeGiro()
        {
            InitializeComponent();
        }

        Consultas ObjConsul = new Consultas();

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

            if (Program.FormularioLlamado)
            {
                //FrmCompra.IDEncabezadoCompraOG;
                ObjConsul.BoolLlenarComboBox(CmbProveedor, "Select P.NOMBRES from TbProveedor P , TbEncabezadoyPieCompra E where E.IDPROVEEDOR = P.IDPROVEEDOR and E.IDEMCABEZADOCOMPRA = " + FrmCompra.IDEncabezadoCompraOG + "");
                ObjConsul.BoolLlenarComboBox(CmbProveedor, "Select C.DESCRIPCION from TbProveedor P, TbCodigoSRI C  where  P.CREDITO = C.IDCODIGOSRI and  P.IDPROVEEDOR = "+ Convert.ToInt32(CmbProveedor.SelectedValue) +"");

            }

        }
        
    }
}
