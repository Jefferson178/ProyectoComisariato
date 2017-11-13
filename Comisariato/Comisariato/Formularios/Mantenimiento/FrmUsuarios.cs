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
        String GlovalIDUsuario = "";
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                dgvDatosUsuario.Rows.Add();
            }
            inicializarDatos();
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
            objConsul.BoolLlenarCheckListBox(CheckListBEmpresas, "Select IDEMPRESA as ID, NOMBRE as 'Texto' from TbEmpresa;");
            objConsul.BoolLlenarComboBox(cbPersonaUsuario, "Select IDEMPLEADO as ID,(E.APELLIDOS +' '+ E.NOMBRES) as Texto from TbEmpleado E  WHERE (E.NOMBRES != 'ADMINISTRADOR');");
            objConsul.BoolLlenarComboBox(cbTipoUsuario, "Select IDTIPOUSUARIO as ID,TIPO as Texto from TbTipousuario;");
            ckbFacturaUsuario.Checked = false;
            ckMostrarContra.Checked = false;
            cbPersonaUsuario.DropDownHeight = cbPersonaUsuario.ItemHeight = 150;
            cbTipoUsuario.DropDownHeight = cbTipoUsuario.ItemHeight = 150;

        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseñaUsuario.Text != "" && TxtConfirmarContraUsuario.Text != "")
            {
                if (txtContraseñaUsuario.Text == TxtConfirmarContraUsuario.Text)
                {
                    Usuario ObjUsuario = new Usuario(Convert.ToInt32(cbPersonaUsuario.SelectedValue), txtUsuario.Text, txtContraseñaUsuario.Text, Convert.ToInt32(cbTipoUsuario.SelectedValue), Convert.ToInt32(CheckListBEmpresas.SelectedValue));

                    String resultado = ObjUsuario.InsertarUsuario(); // retorna true si esta correcto todo
                    if (resultado == "Datos Guardados")
                    {
                        MessageBox.Show("Usuario Registrado Correctamente ", "Exito", MessageBoxButtons.OK);
                        //rbtActivosEmpleado.Checked = true;
                        inicializarDatos();
                    }
                    else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else if (resultado == "Existe") { MessageBox.Show("Ya Existe el Nombre de Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else if (bandera_Estado) // Para identificar si se va modificar
                    {

                        String Resultado = ObjUsuario.ModificarUsuario(GlovalIDUsuario); // retorna true si esta correcto todo
                        if (Resultado == "Correcto")
                        {
                            MessageBox.Show("Usuario Actualizado", "Exito");
                            //rbtActivosEmpleado.Checked = true;
                            GlovalIDUsuario = "";
                        }
                        else { MessageBox.Show("Error al actualizar Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        inicializarDatos();
                        bandera_Estado = false;
                        btnGuardarUsuario.Text = "&Guardar";
                    }
                }
                else
                { MessageBox.Show("Las contraseñas no Coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else { MessageBox.Show("Ingrese los datos del Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        private void dgvDatosUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex >= 0 && dgvDatosUsuario.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosUsuario.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\modificarDgv.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosUsuario.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosUsuario.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }

            if (rbtInactivos.Checked)
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosUsuario.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosUsuario.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\Habilitar.ico");
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosUsuario.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosUsuario.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosUsuario.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosUsuario.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosUsuario.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosUsuario.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }
    }
}
