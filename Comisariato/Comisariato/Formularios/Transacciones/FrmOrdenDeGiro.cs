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

            ObjConsul.BoolLlenarComboBox(cbCuentaDeudoraCero, "select IdctaCble AS ID, '[' +IdctaCble +']' + ' ' + pc_Cuenta AS Texto FROM dbo.TbPlanCuenta");
            ObjConsul.BoolLlenarComboBox(cbCuentaDeudora12, "select IdctaCble AS ID, '[' +IdctaCble +']' + ' ' + pc_Cuenta AS Texto FROM dbo.TbPlanCuenta");
            ObjConsul.BoolLlenarComboBox(cbCuentaDeudoraIRBP, "select IdctaCble AS ID, '[' +IdctaCble +']' + ' ' + pc_Cuenta AS Texto FROM dbo.TbPlanCuenta");
            ObjConsul.BoolLlenarComboBox(cbIvaPagar, "select IdctaCble AS ID, '[' +IdctaCble +']' + ' ' + pc_Cuenta AS Texto FROM dbo.TbPlanCuenta");
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

        }
        
    }
}
