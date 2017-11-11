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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        Consultas objConsul = new Consultas();

        bool bandera_Estado = false;
        String GlovalUsuario = "";
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                dgvDatosUsuario.Rows.Add();
            }
            objConsul.BoolLlenarCheckListBox(CheckListBEmpresasProveedor, "Select IDEMPRESA as ID, NOMBRE as 'Texto' from TbEmpresa;");
            objConsul.BoolLlenarComboBox(cbPersonaUsuario, "Select IDEMPLEADO as ID,(E.APELLIDOS +' '+ E.NOMBRES) as Texto from TbEmpleado E  WHERE (E.NOMBRES != 'ADMINISTRADOR');");

            cbPersonaUsuario.DropDownHeight = cbPersonaUsuario.ItemHeight = 150;
        }

        

        private void ckMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtContraseñaUsuario.Text;
            if (ckMostrarContra.Checked)
            {
                txtContraseñaUsuario.UseSystemPasswordChar = false;
                txtContraseñaUsuario.Text = text;
            }else {
                txtContraseñaUsuario.UseSystemPasswordChar = true;
                txtContraseñaUsuario.Text = text;
            }
        }

        public void inicializarDatos()
        {
            txtConsultarUsuario.Text = "";
            TxtConfirmarContraUsuario.Text = "";
            txtContraseñaUsuario.Text = "";
            txtUsuario.Text = "";
            if (cbPersonaUsuario.Items.Count > 0)
            {
                cbPersonaUsuario.SelectedIndex = 0;
            }
            objConsul.BoolLlenarCheckListBox(CheckListBEmpresasProveedor, "Select IDEMPRESA as ID, NOMBRE as 'Texto' from TbEmpresa;");
            objConsul.BoolLlenarComboBox(cbPersonaUsuario, "Select IDEMPLEADO as ID,(E.APELLIDOS +' '+ E.NOMBRES) as Texto from TbEmpleado E  WHERE (E.NOMBRES != 'ADMINISTRADOR');");
            ckbFacturaUsuario.Checked = false;
            ckMostrarContra.Checked = false;

        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseñaUsuario.Text != "" && TxtConfirmarContraUsuario.Text != "")
            {

                Usuario ObjUsuario = new Usuario();

                String resultado = ""/*ObjUsuario.InsertarEmpleado(ObjUsuario)*/; // retorna true si esta correcto todo
                if (resultado == "Datos Guardados")
                {
                    MessageBox.Show("Cliente Registrado Correctamente ", "Exito", MessageBoxButtons.OK);
                        //rbtActivosEmpleado.Checked = true;
                    inicializarDatos();
                }
                else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else if (resultado == "Existe") { MessageBox.Show("Ya Existe el Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (bandera_Estado) // Para identificar si se va modificar
                {

                    String Resultado = ""/*ObjUsuario.ModificarEmpleado(identificacion, bitDataFoto)*/; // retorna true si esta correcto todo
                    if (Resultado == "Correcto")
                    {
                        MessageBox.Show("Empleado Actualizado", "Exito");
                        //rbtActivosEmpleado.Checked = true;
                        GlovalUsuario = "";
                    }
                    else { MessageBox.Show("Error al actualizar Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    inicializarDatos();
                    bandera_Estado = false;
                    btnGuardarUsuario.Text = "&Guardar";
                }

            }
            else { MessageBox.Show("Ingrese los datos del Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            if (btnLimpiarProveedor.Text == "&Cancelar")
            {
                inicializarDatos();
                btnLimpiarProveedor.Text = "&Limpiar";
                btnGuardarUsuario.Text = "&Guardar";
            }
            else { inicializarDatos(); }
        }
    }
}
