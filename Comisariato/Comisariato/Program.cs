using Comisariato.Clases;
using Comisariato.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static string RutaImpresora="";
        public static string Usuario="",contraseñausuarioactual;
        public static string FecaInicio;
        public static string horainicio ;
        public static string IDUsuario = "", NOMBRES="",APELLIDOS="", IDTIPOUSUARIO,IDEMPRESA;
        public static int numfact = 0;
        public static bool estado;
        public static string piefactura="";
        public static EmcabezadoFactura em = new EmcabezadoFactura();
        // ------- Variables Usadas por Andres 
        public static Panel panelPrincipalVariable;
        public static bool FormularioLlamado = false;
        public static bool FormularioProveedorCompra = false;


        //datos empresa
        public static string nombreempresa;
        public static string rucempresa;
        public static string direccionempresa;
        //-----------------------------------------
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
