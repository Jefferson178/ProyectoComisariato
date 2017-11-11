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
    public partial class FrmComboProductos : Form
    {
        public FrmComboProductos()
        {
            InitializeComponent();
        }

        private void FrmComboProductos_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                dgvProductosEnCombo.Rows.Add();
                dgvProductosParaCombo.Rows.Add();
            }
        }
    }
}
