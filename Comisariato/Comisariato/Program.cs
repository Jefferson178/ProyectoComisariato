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
        public static string Usuario="";
        public static string FecaInicio;
        public static string horainicio ;
        public static string IDUsuario = "", NOMBRES="",APELLIDOS="", IDTIPOUSUARIO;
        public static int numfact = 0;
        public static EmcabezadoFactura em = new EmcabezadoFactura();
        // ------- Variables Usadas por Andres 
        public static Panel panelPrincipalVariable;
        public static bool FormularioLlamado = false;
        public static bool FormularioProveedorCompra = false;
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
