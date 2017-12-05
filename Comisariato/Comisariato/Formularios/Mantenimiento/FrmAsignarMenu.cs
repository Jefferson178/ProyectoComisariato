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
    public partial class FrmAsignarMenu : Form
    {
        public FrmAsignarMenu()
        {
            InitializeComponent();
        }

        private void FrmAsignarMenu_Load(object sender, EventArgs e)
        {
            Consultas objConsul = new Consultas();
            objConsul.BoolLlenarCheckListBox(cklMenu, "Select IDMENU AS ID, DESCRIPCION AS Texto FROM TbMenu");
        }
    }
}
