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
using System.IO;
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
        FrmAsignarMenu FrmAsignarMenu;

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        Funcion objFuncion = new Funcion();
        Consultas objConsulta = new Consultas();


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
            if (nombre == "Administrar Menu")
            {
                if (FrmAsignarMenu == null || FrmAsignarMenu.IsDisposed)
                {
                    FrmAsignarMenu = new FrmAsignarMenu();
                    objFuncion.AddFormInPanel(FrmAsignarMenu, Program.panelPrincipalVariable);
                }
                else
                {
                    //int index = panelPrincipal.Controls.GetChildIndex(FrmEmpleado);
                    FrmAsignarMenu.BringToFront();
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
                    objFuncion.AddFormInPanel(FrmClaveUsuario, Program.panelPrincipalVariable);
                }
                else
                {
                    int index = panelPrincipal.Controls.GetChildIndex(FrmClaveUsuario);
                    FrmClaveUsuario.BringToFront();
                }
            }
            else if (nombre == "Compras")
            {
                if (objConsulta.ObtenerValorCampo("IDPROVEEDOR", "TbProveedor", "") != "" && objConsulta.ObtenerValorCampo("IDSUCURSAL", "TbSucursal", "") != "" && objConsulta.ObtenerValorCampo("IDPARAMETROSFACTURA", "TbParametrosFactura", "") != "")
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
                else
                {
                    MessageBox.Show("Para realizar un registro de compra debe de tener registrado lo siguiente:\n*Al menos un proveedor.\n*Al menos una sucursal.\n*Parametros para la factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else if (nombre == "Devolución en Venta")
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
        
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Consultas consultas = new Consultas();
            DataTable dt = objConsulta.BoolDataTable("Select FONDOPANTALLA from TbEmpresa where IDEMPRESA = 1");
            byte[] MyData = new byte[0];
            if (dt.Rows.Count > 0)
            {
                DataRow myRow = dt.Rows[0];

                MyData = (byte[])myRow["FONDOPANTALLA"];
                MemoryStream stream = new MemoryStream(MyData);
                this.panelPrincipal.BackgroundImage = Image.FromStream(stream);

            }
            //DataTable usuraio = consultas.BoolDataTable("select IDTIPOUSUARIO FROM TbUsuario WHERE IDUSUARIO = '" + Convert.ToInt32(Program.IDTIPOUSUARIO) + "'");
            //if (Program.IDTIPOUSUARIO == "2")
            //{
            //    for (int i = 0; i < 6; i++)
            //    {
            //        if (i > 2)
            //        {
            //            tvPrincipal.Nodes.Remove(tvPrincipal.Nodes[1]);
            //        }
            //        else if (i < 2)
            //        {
            //            tvPrincipal.Nodes.Remove(tvPrincipal.Nodes[0]);
            //        }
            //    }
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (i > 0)
            //        {
            //            tvPrincipal.Nodes.Remove(tvPrincipal.Nodes[0].Nodes[1]);
            //        }
            //    }

            //}
            try
            {
                    
                DataTable NodosPadres = objConsulta.BoolDataTable("Select DISTINCT NODOPADRE from TbMenu where (NODOPADRE!= 0);");
                if (NodosPadres.Rows.Count > 0)
                {
                    int CantidadNodosPadres = NodosPadres.Rows.Count;
                    List<int> padres = new List<int>();
                    
                    for (int i = 0; i < CantidadNodosPadres; i++)
                    {
                        DataRow rows = NodosPadres.Rows[i];
                        padres.Add(Convert.ToInt32(rows[0]));
                    }
                    //Declaracion de Lista
                    List<int> Padre1 = new List<int>();
                    List<int> Padre2 = new List<int>();
                    List<int> Padre3 = new List<int>();
                    List<int> Padre4 = new List<int>();
                    List<int> Padre5 = new List<int>();
                    List<int> Padre6 = new List<int>();
                    List<int> Padre7 = new List<int>();

                    //Llenar el primer elemento de las listas con el nodo padre
                    Padre1.Add(Convert.ToInt32(padres[0])); //1
                    Padre2.Add(Convert.ToInt32(padres[1])); //5
                    Padre3.Add(Convert.ToInt32(padres[2])); //14
                    Padre4.Add(Convert.ToInt32(padres[3])); //20
                    Padre5.Add(Convert.ToInt32(padres[4])); //26
                    Padre6.Add(Convert.ToInt32(padres[5])); //28
                    Padre7.Add(Convert.ToInt32(padres[6])); //30

                    //Obtener el menu del usuario logeado TbAsignacionMenu
                    DataTable MenuUsuarioLogeado = objConsulta.BoolDataTable("Select * from TbAsignacionMenu where IDUSUARIO = "+Program.IDUsuarioMenu+";");
                    for (int i = 0; i < MenuUsuarioLogeado.Rows.Count; i++)
                    {
                        DataRow rows = MenuUsuarioLogeado.Rows[i];
                        int hijo = Convert.ToInt32(rows["IDMENU"]);
                        int Padre = ObtenerPadreDeHijo(hijo);

                        if (Padre != 0)
                        {
                            switch (Padre)
                            {
                                case 1:
                                    Padre1.Add(hijo);
                                    break;
                                case 5:
                                    Padre2.Add(hijo);
                                    break;
                                case 14:
                                    Padre3.Add(hijo);
                                    break;
                                case 20:
                                    Padre4.Add(hijo);
                                    break;
                                case 26:
                                    Padre5.Add(hijo);
                                    break;
                                case 28:
                                    Padre6.Add(hijo);
                                    break;
                                case 30:
                                    Padre7.Add(hijo);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    //MessageBox.Show("SSS");
                }
            }
            catch (Exception ex)
            {
                                
            }


        }


        public int ObtenerPadreDeHijo(int Hijo)
        {
            try
            {
                int Padre = 0;
                DataTable MenuUsuarioLogeado = objConsulta.BoolDataTable("Select * from TbMenu where IDMENU = " + Hijo + ";");
                if (MenuUsuarioLogeado.Rows.Count > 0)
                {
                    DataRow myRow = MenuUsuarioLogeado.Rows[0];
                    Padre = Convert.ToInt32(myRow["NODOPADRE"]);
                }
                    return Padre;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
