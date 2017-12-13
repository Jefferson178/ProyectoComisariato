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

namespace Comisariato.Formularios.Informes
{
    public partial class FrmKardex : Form
    {
        public FrmKardex()
        {
            InitializeComponent();
        }
        Consultas objConsulta = new Consultas();
        private void FrmKardex_Load(object sender, EventArgs e)
        {
            objConsulta.BoolLlenarComboBox(cbCategoria, "Select IDCATEGORIA as ID, Descripcion as Texto from TbCategoria");
        }
    }
}
