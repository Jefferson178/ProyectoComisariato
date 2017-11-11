﻿using Comisariato.Clases;
using Comisariato.Formularios.Mantenimiento;
using Comisariato.Formularios.Mantenimiento.Empresa;
using Comisariato.Formularios.Mantenimiento.Inventario;
using Comisariato.Formularios.Transacciones;
using Comisariato.Formularios.Transacciones.Devolucion_Venta;
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
    public partial class FrmPrincipal : Form
    {


        FrmClientes FrmCliente;
        FrmProveedores FrmProveedor;
        FrmUsuarios FrmUsuario;
        FrmEmpresa FrmEmpresa;
        FrmProductos FrmProducto;
        FrmCategoriaProductos FrmCategoriaProducto;
        FrmCreacionBodega FrmCreacionBodega;
        FrmComboProductos FrmComboProducto;
        FrmClaveUsuario FrmClaveUsuario;
        FrmCompra FrmCompra;
        FrmCajasTalonario FrmCajasTalonario;
        FrmParametrosFactura FrmParametrosFactura;
        FrmSucursal FrmSucursal;
        FrmAsignacionProductoBodega FrmAsignacionProductoBodega;
        FrmEmpleado FrmEmpleado;
        FrmOrdenDeGiro FrmOrdenDeGiro;
        FrmDevolucionVenta FrmDevolucionVenta;

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        Funcion objFuncion = new Funcion();
        

        private void tvPrincipal_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Program.panelPrincipalVariable = panelPrincipal;
            
            string nombre = e.Node.Text;
            //-------------------------------------------------Mantenimiento---------------------------------------//
            //---------------------Cliente --------------------------------------//
            if (nombre == "Administrar Clientes")
            {
                if (FrmCliente == null || FrmCliente.IsDisposed)
                {
                    FrmCliente = new FrmClientes();
                    objFuncion.AddFormInPanel(FrmCliente, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmCliente);
                    FrmCliente.BringToFront();
                }
            }
            //---------------------Empleado --------------------------------------//
            if (nombre == "Administrar Empleados")
            {
                if (FrmEmpleado == null || FrmEmpleado.IsDisposed)
                {
                    FrmEmpleado = new FrmEmpleado();
                    objFuncion.AddFormInPanel(FrmEmpleado, Program.panelPrincipalVariable);
                }
                else
                {
                    //int index = panelPrincipal.Controls.GetChildIndex(FrmEmpleado);
                    FrmEmpleado.BringToFront();
                }
            }
            //--------------------Empresa---------------------------------------//
            else if (nombre == "Cajas/Talonarios")
            {
                if (FrmCajasTalonario == null || FrmCajasTalonario.IsDisposed)
                {
                    FrmCajasTalonario = new FrmCajasTalonario();
                    objFuncion.AddFormInPanel(FrmCajasTalonario, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmCajasTalonario);
                    FrmCajasTalonario.BringToFront();
                }
            }
            else if (nombre == "Empresa")
            {
                if (FrmEmpresa == null || FrmEmpresa.IsDisposed)
                {
                    FrmEmpresa = new FrmEmpresa();
                    objFuncion.AddFormInPanel(FrmEmpresa, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmEmpresa);
                    FrmEmpresa.BringToFront();
                }
            }
            else if (nombre == "Impresion de Factura")
            {
                if (FrmParametrosFactura == null || FrmParametrosFactura.IsDisposed)
                {
                    FrmParametrosFactura = new FrmParametrosFactura();
                    objFuncion.AddFormInPanel(FrmParametrosFactura, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmParametrosFactura);
                    FrmParametrosFactura.BringToFront();
                }
            }
            else if (nombre == "Sucursales")
            {
                if (FrmSucursal == null || FrmSucursal.IsDisposed)
                {
                    FrmSucursal = new FrmSucursal();
                    objFuncion.AddFormInPanel(FrmSucursal, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmSucursal);
                    FrmSucursal.BringToFront();
                }
            }
            //--------------------Proveedores---------------------------------------//
            else if (nombre == "Administrar Proveedores")
            {
                if (FrmProveedor == null || FrmProveedor.IsDisposed)
                {
                    FrmProveedor = new FrmProveedores();
                    objFuncion.AddFormInPanel(FrmProveedor, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmProveedor);
                    FrmProveedor.BringToFront();
                }
            }
            //--------------------Usuarios---------------------------------------//
            else if (nombre == "Administrar Usuarios")
            {
                if (FrmUsuario == null || FrmUsuario.IsDisposed)
                {
                    FrmUsuario = new FrmUsuarios();
                    objFuncion.AddFormInPanel(FrmUsuario, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmUsuario);
                    FrmUsuario.BringToFront();
                }
            }
            //--------------------Inventario---------------------------------------//
            else if (nombre == "Productos")
            {
                if (FrmProducto == null || FrmProducto.IsDisposed)
                {
                    FrmProducto = new FrmProductos();
                    objFuncion.AddFormInPanel(FrmProducto, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmProducto);
                    FrmProducto.BringToFront();
                }
            }
            else if (nombre == "Categoria Producto")
            {
                if (FrmCategoriaProducto == null || FrmCategoriaProducto.IsDisposed)
                {
                    FrmCategoriaProducto = new FrmCategoriaProductos();
                    objFuncion.AddFormInPanel(FrmCategoriaProducto, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmCategoriaProducto);
                    FrmCategoriaProducto.BringToFront();
                }
            }
            else if (nombre == "Creacion de Bodega")
            {
                if (FrmCreacionBodega == null || FrmCreacionBodega.IsDisposed)
                {
                    FrmCreacionBodega = new FrmCreacionBodega();
                    objFuncion.AddFormInPanel(FrmCreacionBodega, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmCreacionBodega);
                    FrmCreacionBodega.BringToFront();
                }
            }
            else if (nombre == "Combo de Productos")
            {
                if (FrmComboProducto == null || FrmComboProducto.IsDisposed)
                {
                    FrmComboProducto = new FrmComboProductos();
                    objFuncion.AddFormInPanel(FrmComboProducto, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmComboProducto);
                    FrmComboProducto.BringToFront();
                }
            }
            else if (nombre == "Asignacion de Producto por Bodega")
            {
                if (FrmAsignacionProductoBodega == null || FrmAsignacionProductoBodega.IsDisposed)
                {
                    FrmAsignacionProductoBodega = new FrmAsignacionProductoBodega();
                    objFuncion.AddFormInPanel(FrmAsignacionProductoBodega, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmAsignacionProductoBodega);
                    FrmAsignacionProductoBodega.BringToFront();
                }
            }
            //-------------------------------------------------Transacciones---------------------------------------//
            else if (nombre == "Ventas")
            {
                if (FrmClaveUsuario == null || FrmClaveUsuario.IsDisposed)
                {
                    FrmClaveUsuario = new FrmClaveUsuario();
                    FrmClaveUsuario.verificarMetodo = 1;
                    FrmClaveUsuario.ShowDialog();
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmClaveUsuario);
                    FrmClaveUsuario.BringToFront();
                }
            }
            else if (nombre == "Compras")
            {
                if (FrmCompra == null || FrmCompra.IsDisposed)
                {
                    FrmCompra = new FrmCompra();
                    objFuncion.AddFormInPanel(FrmCompra, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmCompra);
                    FrmCompra.BringToFront();
                }
            }
            else if (nombre == "Orden de Giro")
            {
                if (FrmOrdenDeGiro == null || FrmOrdenDeGiro.IsDisposed)
                {
                    FrmOrdenDeGiro = new FrmOrdenDeGiro();
                    objFuncion.AddFormInPanel(FrmOrdenDeGiro, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmOrdenDeGiro);
                    FrmOrdenDeGiro.BringToFront();
                }
            }
            else if (nombre == "Devolución Venta")
            {
                if (FrmDevolucionVenta == null || FrmDevolucionVenta.IsDisposed)
                {
                    FrmDevolucionVenta = new FrmDevolucionVenta();
                    objFuncion.AddFormInPanel(FrmDevolucionVenta, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmDevolucionVenta);
                    FrmDevolucionVenta.BringToFront();
                }
            }

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult Resul = MessageBox.Show("Esta Seguro que Quiere Cerrar la Sesión", "Estado de Cesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //if (Resul == DialogResult.Yes)
            //{
            //    Application.Restart();
            //}
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss");
        }

        private void tsmCerrarSesion_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult Resul = MessageBox.Show("Esta Seguro que Quiere Cerrar la Sesión", "Estado de Cesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resul == DialogResult.Yes)
                {
                    String HoraSalida = DateTime.Now.TimeOfDay.ToString();
                    Bitacora ObjBitacora = new Bitacora(HoraSalida, "Sesión Finalizada");
                    ObjBitacora.insertarBitacora();
                    Application.Restart();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
