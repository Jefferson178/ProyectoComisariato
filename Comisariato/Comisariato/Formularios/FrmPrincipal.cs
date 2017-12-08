using Comisariato.Clases;
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
            //Program.panelPrincipalVariable = panelPrincipal;

            string nombre = e.Node.Text;
            //-------------------------------------------------Mantenimiento---------------------------------------//
            //---------------------Cliente --------------------------------------//
            if (nombre == "Administrar Clientes")
            {
                //if (FrmCliente == null || FrmCliente.IsDisposed)
                //{
                //    FrmCliente = new FrmClientes();
                //    objFuncion.AddFormInPanel(FrmCliente, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmCliente);
                //    FrmCliente.BringToFront();
                //}
                if (FrmCliente == null || FrmCliente.IsDisposed)
                {
                    FrmCliente = new FrmClientes();
                    FrmCliente.MdiParent = this;
                    FrmCliente.BringToFront();
                    FrmCliente.Show();

                }
                else { FrmProducto.BringToFront(); }
            }
            //---------------------Empleado --------------------------------------//
            if (nombre == "Administrar Empleados")
            {
                //if (FrmEmpleado == null || FrmEmpleado.IsDisposed)
                //{
                //    FrmEmpleado = new FrmEmpleado();
                //    objFuncion.AddFormInPanel(FrmEmpleado, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    //int index = panelPrincipal.Controls.GetChildIndex(FrmEmpleado);
                //    FrmEmpleado.BringToFront();
                //}
                if (FrmEmpleado == null || FrmEmpleado.IsDisposed)
                {
                    FrmEmpleado = new FrmEmpleado();
                    FrmEmpleado.MdiParent = this;
                    FrmEmpleado.BringToFront();
                    FrmEmpleado.Show();

                }
                else { FrmProducto.BringToFront(); }
            }
            if (nombre == "Administrar Menu")
            {
                //if (FrmAsignarMenu == null || FrmAsignarMenu.IsDisposed)
                //{
                //    FrmAsignarMenu = new FrmAsignarMenu();
                //    objFuncion.AddFormInPanel(FrmAsignarMenu, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    //int index = panelPrincipal.Controls.GetChildIndex(FrmEmpleado);
                //    FrmAsignarMenu.BringToFront();
                //}
                if (FrmAsignarMenu == null || FrmAsignarMenu.IsDisposed)
                {
                    FrmAsignarMenu = new FrmAsignarMenu();
                    FrmAsignarMenu.MdiParent = this;
                    FrmAsignarMenu.BringToFront();
                    FrmAsignarMenu.Show();

                }
                else { FrmProducto.BringToFront(); }
            }
            //--------------------Empresa---------------------------------------//
            else if (nombre == "Cajas/Talonarios")
            {
                //if (FrmCajasTalonario == null || FrmCajasTalonario.IsDisposed)
                //{
                //    FrmCajasTalonario = new FrmCajasTalonario();
                //    objFuncion.AddFormInPanel(FrmCajasTalonario, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmCajasTalonario);
                //    FrmCajasTalonario.BringToFront();
                //}
                if (FrmCajasTalonario == null || FrmCajasTalonario.IsDisposed)
                {
                    FrmCajasTalonario = new FrmCajasTalonario();
                    FrmCajasTalonario.MdiParent = this;
                    FrmCajasTalonario.BringToFront();
                    FrmCajasTalonario.Show();

                }
                else { FrmProducto.BringToFront(); }
            }
            else if (nombre == "Empresa")
            {
                //if (FrmEmpresa == null || FrmEmpresa.IsDisposed)
                //{
                //    FrmEmpresa = new FrmEmpresa();
                //    objFuncion.AddFormInPanel(FrmEmpresa, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmEmpresa);
                //    FrmEmpresa.BringToFront();
                //}
                if (FrmEmpresa == null || FrmEmpresa.IsDisposed)
                {
                    FrmEmpresa = new FrmEmpresa();
                    FrmEmpresa.MdiParent = this;
                    FrmEmpresa.BringToFront();
                    FrmEmpresa.Show();

                }
                else { FrmProducto.BringToFront(); }
            }
            else if (nombre == "Impresion de Factura")
            {
                //if (FrmParametrosFactura == null || FrmParametrosFactura.IsDisposed)
                //{
                //    FrmParametrosFactura = new FrmParametrosFactura();
                //    objFuncion.AddFormInPanel(FrmParametrosFactura, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmParametrosFactura);
                //    FrmParametrosFactura.BringToFront();
                //}
                if (FrmParametrosFactura == null || FrmParametrosFactura.IsDisposed)
                {
                    FrmParametrosFactura = new FrmParametrosFactura();
                    FrmParametrosFactura.MdiParent = this;
                    FrmParametrosFactura.BringToFront();
                    FrmParametrosFactura.Show();

                }
                else { FrmProducto.BringToFront(); }
            }
            else if (nombre == "Sucursales")
            {
                //if (FrmSucursal == null || FrmSucursal.IsDisposed)
                //{
                //    FrmSucursal = new FrmSucursal();
                //    objFuncion.AddFormInPanel(FrmSucursal, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmSucursal);
                //    FrmSucursal.BringToFront();
                //}
                if (FrmSucursal == null || FrmSucursal.IsDisposed)
                {
                    FrmSucursal = new FrmSucursal();
                    FrmSucursal.MdiParent = this;
                    FrmSucursal.BringToFront();
                    FrmSucursal.Show();

                }
                else { FrmProducto.BringToFront(); }
            }
            //--------------------Proveedores---------------------------------------//
            else if (nombre == "Administrar Proveedores")
            {
                //if (FrmProveedor == null || FrmProveedor.IsDisposed)
                //{
                //    FrmProveedor = new FrmProveedores();
                //    objFuncion.AddFormInPanel(FrmProveedor, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmProveedor);
                //    FrmProveedor.BringToFront();
                //}
                if (FrmProveedor == null || FrmProveedor.IsDisposed)
                {
                    FrmProveedor = new FrmProveedores();
                    FrmProveedor.MdiParent = this;
                    FrmProveedor.BringToFront();
                    FrmProveedor.Show();

                }
                else { FrmProducto.BringToFront(); }
            }
            //--------------------Usuarios---------------------------------------//
            else if (nombre == "Administrar Usuarios")
            {
                //if (FrmUsuario == null || FrmUsuario.IsDisposed)
                //{
                //    FrmUsuario = new FrmUsuarios();
                //    objFuncion.AddFormInPanel(FrmUsuario, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmUsuario);
                //    FrmUsuario.BringToFront();
                //}
                if (FrmUsuario == null || FrmUsuario.IsDisposed)
                {
                    FrmUsuario = new FrmUsuarios();
                    FrmUsuario.MdiParent = this;
                    FrmUsuario.BringToFront();
                    FrmUsuario.Show();

                }
                else { FrmProducto.BringToFront(); }
            }
            //--------------------Inventario---------------------------------------//
            else if (nombre == "Productos")
            {
                //if (FrmProducto == null || FrmProducto.IsDisposed)
                //{
                //    FrmProducto = new FrmProductos();
                //    objFuncion.AddFormInPanel(FrmProducto, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmProducto);
                //    FrmProducto.BringToFront();
                //}
                if (FrmProducto == null || FrmProducto.IsDisposed)
                {
                    FrmProducto = new FrmProductos();
                    FrmProducto.BringToFront();
                    FrmProducto.MdiParent = this;
                    FrmProducto.Show();

                }
                else { FrmProducto.BringToFront(); }
            }
            else if (nombre == "Categoria Producto")
            {
                //if (FrmCategoriaProducto == null || FrmCategoriaProducto.IsDisposed)
                //{
                //    FrmCategoriaProducto = new FrmCategoriaProductos();
                //    objFuncion.AddFormInPanel(FrmCategoriaProducto, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmCategoriaProducto);
                //    FrmCategoriaProducto.BringToFront();
                //}
                if (FrmCategoriaProducto == null || FrmCategoriaProducto.IsDisposed)
                {
                    FrmCategoriaProducto = new FrmCategoriaProductos();
                    FrmCategoriaProducto.BringToFront();
                    FrmCategoriaProducto.MdiParent = this;
                    FrmCategoriaProducto.Show();

                }
                else { FrmCategoriaProducto.BringToFront(); }

            }
            else if (nombre == "Creacion de Bodega")
            {
                //if (FrmCreacionBodega == null || FrmCreacionBodega.IsDisposed)
                //{
                //    FrmCreacionBodega = new FrmCreacionBodega();
                //    objFuncion.AddFormInPanel(FrmCreacionBodega, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmCreacionBodega);
                //    FrmCreacionBodega.BringToFront();
                //}
                if (FrmCreacionBodega == null || FrmCreacionBodega.IsDisposed)
                {
                    FrmCreacionBodega = new FrmCreacionBodega();
                    FrmCreacionBodega.BringToFront();
                    FrmCreacionBodega.MdiParent = this;
                    FrmCreacionBodega.Show();

                }
                else { FrmCreacionBodega.BringToFront(); }
            }
            else if (nombre == "Combo de Productos")
            {
                //if (FrmComboProducto == null || FrmComboProducto.IsDisposed)
                //{
                //    FrmComboProducto = new FrmComboProductos();
                //    objFuncion.AddFormInPanel(FrmComboProducto, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmComboProducto);
                //    FrmComboProducto.BringToFront();
                //}
                if (FrmComboProducto == null || FrmComboProducto.IsDisposed)
                {
                    FrmComboProducto = new FrmComboProductos();
                    FrmComboProducto.BringToFront();
                    FrmComboProducto.MdiParent = this;
                    FrmComboProducto.Show();

                }
                else { FrmCreacionBodega.BringToFront(); }
            }
            else if (nombre == "Asignacion de Producto por Bodega")
            {
                //if (FrmAsignacionProductoBodega == null || FrmAsignacionProductoBodega.IsDisposed)
                //{
                //    FrmAsignacionProductoBodega = new FrmAsignacionProductoBodega();
                //    objFuncion.AddFormInPanel(FrmAsignacionProductoBodega, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmAsignacionProductoBodega);
                //    FrmAsignacionProductoBodega.BringToFront();
                //}
                if (FrmAsignacionProductoBodega == null || FrmAsignacionProductoBodega.IsDisposed)
                {
                    FrmAsignacionProductoBodega = new FrmAsignacionProductoBodega();
                    FrmAsignacionProductoBodega.BringToFront();
                    FrmAsignacionProductoBodega.MdiParent = this;
                    FrmAsignacionProductoBodega.Show();

                }
                else { FrmAsignacionProductoBodega.BringToFront(); }
            }
            //-------------------------------------------------Transacciones---------------------------------------//
            else if (nombre == "Ventas")
            {
                //if (FrmClaveUsuario == null || FrmClaveUsuario.IsDisposed)
                //{
                //    FrmClaveUsuario = new FrmClaveUsuario();
                //    FrmClaveUsuario.verificarMetodo = 1;
                //    objFuncion.AddFormInPanel(FrmClaveUsuario, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmClaveUsuario);
                //    FrmClaveUsuario.BringToFront();
                //}
                if (FrmClaveUsuario == null || FrmClaveUsuario.IsDisposed)
                {
                    FrmClaveUsuario = new FrmClaveUsuario();
                    FrmClaveUsuario.verificarMetodo = 1;
                    FrmClaveUsuario.BringToFront();
                    FrmClaveUsuario.MdiParent = this;
                    FrmClaveUsuario.Show();

                }
                else { FrmClaveUsuario.BringToFront(); }
            }
            else if (nombre == "Compras")
            {
                if (objConsulta.ObtenerValorCampo("IDPROVEEDOR", "TbProveedor", "") != "" && objConsulta.ObtenerValorCampo("IDSUCURSAL", "TbSucursal", "") != "" && objConsulta.ObtenerValorCampo("IDPARAMETROSFACTURA", "TbParametrosFactura", "") != "")
                {
                    //if (FrmCompra == null || FrmCompra.IsDisposed)
                    //{
                    //    FrmCompra = new FrmCompra();
                    //    objFuncion.AddFormInPanel(FrmCompra, Program.panelPrincipalVariable);
                    //}
                    //else
                    //{
                    //    int index = panelPrincipal.Controls.GetChildIndex(FrmCompra);
                    //    FrmCompra.BringToFront();
                    //}
                    if (FrmCompra == null || FrmCompra.IsDisposed)
                    {
                        FrmCompra = new FrmCompra();
                        FrmCompra.BringToFront();
                        FrmCompra.MdiParent = this;
                        FrmCompra.Show();

                    }
                    else { FrmCompra.BringToFront(); }
                }
                else
                {
                    MessageBox.Show("Para realizar un registro de compra debe de tener registrado lo siguiente:\n*Al menos un proveedor.\n*Al menos una sucursal.\n*Parametros para la factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (nombre == "Orden de Giro")
            {
                //if (FrmOrdenDeGiro == null || FrmOrdenDeGiro.IsDisposed)
                //{
                //    FrmOrdenDeGiro = new FrmOrdenDeGiro();
                //    objFuncion.AddFormInPanel(FrmOrdenDeGiro, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmOrdenDeGiro);
                //    FrmOrdenDeGiro.BringToFront();
                //}
                if (FrmOrdenDeGiro == null || FrmOrdenDeGiro.IsDisposed)
                {
                    FrmOrdenDeGiro = new FrmOrdenDeGiro();
                    FrmOrdenDeGiro.BringToFront();
                    FrmOrdenDeGiro.MdiParent = this;
                    FrmOrdenDeGiro.Show();

                }
                else { FrmOrdenDeGiro.BringToFront(); }
            }
            else if (nombre == "Devolución en Venta")
            {
                //if (FrmDevolucionVenta == null || FrmDevolucionVenta.IsDisposed)
                //{
                //    FrmDevolucionVenta = new FrmDevolucionVenta();
                //    objFuncion.AddFormInPanel(FrmDevolucionVenta, Program.panelPrincipalVariable);
                //}
                //else
                //{
                //    int index = panelPrincipal.Controls.GetChildIndex(FrmDevolucionVenta);
                //    FrmDevolucionVenta.BringToFront();
                //}
                if (FrmDevolucionVenta == null || FrmDevolucionVenta.IsDisposed)
                {
                    FrmDevolucionVenta = new FrmDevolucionVenta();
                    FrmDevolucionVenta.BringToFront();
                    FrmDevolucionVenta.MdiParent = this;
                    FrmDevolucionVenta.Show();

                }
                else { FrmDevolucionVenta.BringToFront(); }
            }

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            DataTable dt = objConsulta.BoolDataTable("Select FONDOPANTALLA from TbEmpresa where IDEMPRESA = 1");
            byte[] MyData = new byte[0];
            if (dt.Rows.Count > 0)
            {
                DataRow myRow = dt.Rows[0];

                MyData = (byte[])myRow["FONDOPANTALLA"];
                MemoryStream stream = new MemoryStream(MyData);
                //this.panelPrincipal.BackgroundImage = Image.FromStream(stream);
                this.BackgroundImage = Image.FromStream(stream);
                this.BackgroundImageLayout = ImageLayout.Stretch;

            }
            try
            {
                if (Program.Usuario !="ADMIN")
                {
                    llenarTreeViewPrincipal();
                }
            }
            catch (Exception ex)
            {
            }

            
        }        

        public void llenarTreeViewPrincipal()
        {
            for (int i = 0; i < tvPrincipal.Nodes.Count;)
            {
                tvPrincipal.Nodes.Remove(tvPrincipal.Nodes[0]);
            }
            objConsulta.BoolLlenarTreeViewMenu(tvPrincipal, "SELECT DISTINCT M.IDMENU, M.DESCRIPCION, M.NODOPADRE from TbMenu M, TbAsignacionMenu AM where M.IDMENU = AM.IDMENU AND AM.IDUSUARIO = " + Program.IDUsuarioMenu + " ORDER BY M.IDMENU;");
        }

        private void msPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        bool banderaMenuPrincipal = false;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!banderaMenuPrincipal)
            {
                tvPrincipal.Visible = false;
                banderaMenuPrincipal = true;
            }
            else
            {
                tvPrincipal.Visible = true;
                banderaMenuPrincipal = false;
            }
        }
    }
}
