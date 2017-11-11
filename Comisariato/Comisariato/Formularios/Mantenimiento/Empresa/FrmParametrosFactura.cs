﻿using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Mantenimiento.Empresa
{
    public partial class FrmParametrosFactura : Form
    {
        public FrmParametrosFactura()
        {
            InitializeComponent();
        }
        private void rbPreimpresa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbPreimpresa.Checked == true)
            {
                gbAutorizadoImprimir.Visible = false;
                gbPreimpresa.Visible = true;
            }
        }
        private void rbAutorizadoImprimir_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbAutorizadoImprimir.Checked == true)
            {
                gbAutorizadoImprimir.Visible = true;
                gbPreimpresa.Visible = false;
            }
        }
        Consultas consultas = new Consultas();
        private void FrmParametrosFactura_Load(object sender, EventArgs e)
        {
            consultas.BoolLlenarComboBox(cbIVA, "select IDIVA as ID, IVA as Texto FROM [dbo].[TbIva]");
        }

        private void cbIVA_Enter(object sender, EventArgs e)
        {
            consultas.BoolLlenarComboBox(cbIVA, "select IDIVA as ID, IVA as Texto FROM [dbo].[TbIva]");
        }
        Funcion objFuncion = new Funcion();
        private void btnRegistrarIVA_Click(object sender, EventArgs e)
        {
            FrmRegistrarIVA frmRegistrarIVA = new FrmRegistrarIVA();
            objFuncion.AddFormInPanel(frmRegistrarIVA, Program.panelPrincipalVariable);
            Program.FormularioLlamado = true;
        }
        public void inicializarDatos()
        {

            Funcion.Limpiarobjetos(gbAutorizadoImprimir);
            Funcion.Limpiarobjetos(gbSRIEmpresa);
            if (cbIVA.Items.Count > 0)
            {
                cbIVA.SelectedIndex = 0;
            }
            ckbContribuyenteEspecial.Checked = false;
            ckbObligadoContabilidad.Checked = false;
            TxtAncho.Text = "";
            TxtLargo.Text = "";
            TxtNumeroItemsFactura.Text = "";

        }


        private void btnLimpiarEmpresa_Click(object sender, EventArgs e)
        {
            inicializarDatos();
        }

        private void btnGuardarEmpresa_Click(object sender, EventArgs e)
        {
            if (txtMontoMinimoFacturaEmpresa.Text!="" && cbIVA.SelectedIndex>=0 )
            {
                ParametrosFactura ObjParametrosFactura = new ParametrosFactura(txtMontoMinimoFacturaEmpresa.Text, Convert.ToInt32(cbIVA.Text), ckbContribuyenteEspecial.Checked, ckbObligadoContabilidad.Checked, TxtAncho.Text, TxtLargo.Text, Convert.ToInt32(TxtNumeroItemsFactura.Text), TxtPie1.Text, TxtPie2.Text, TxtPie3.Text, TxtPie4.Text);
                    String resultado = ObjParametrosFactura.InsertarParametrosFactura(); // retorna true si esta correcto todo
                    if (resultado == "Datos Guardados")
                    {
                        MessageBox.Show("Datos Registrado Correctamente ", "Exito", MessageBoxButtons.OK);
                        //rbtActivos.Checked = true;
                        inicializarDatos();

                    }
                    else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else if (resultado == "Existe") { MessageBox.Show("Ya Exsiten estos Parametros de La factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
            else { MessageBox.Show("Ingrese los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
