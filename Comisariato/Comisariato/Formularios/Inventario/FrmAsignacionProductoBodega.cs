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
    public partial class FrmAsignacionProductoBodega : Form
    {
        public FrmAsignacionProductoBodega()
        {
            InitializeComponent();
        }

        private void FrmAsignacionProductoBodega_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                dgvDatosProductoParaAsignacionBodega.Rows.Add();
                dgvDatosProductosAsignadosABodega.Rows.Add();
            }
        }
    }
}
