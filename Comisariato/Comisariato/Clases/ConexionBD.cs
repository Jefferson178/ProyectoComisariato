using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Clases
{
   public class ConexionBD
    {
        public static SqlConnection connection = null;

        public void conectar()
        {
            try
            {
<<<<<<< HEAD
                //connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
                connection = new SqlConnection("Data Source=DESKTOP-SI5M9C5;Initial Catalog=BDComisariato;Integrated Security=True");
=======
<<<<<<< HEAD
                //data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;
                connection = new SqlConnection("Data Source = DJSERATO\\SQLEXPRESS; Initial Catalog = BDComisariato; Integrated Security = True");
=======
<<<<<<< HEAD
                //connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
                connection = new SqlConnection("Data Source=DESKTOP-SI5M9C5;Initial Catalog=BDComisariato;Integrated Security=True");
=======
                //Data Source=DESKTOP-FUFA7EG\ANDRES;Initial Catalog=BDComisariato;Integrated Security=True
                //connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
                connection = new SqlConnection("Data Source=DESKTOP-FUFA7EG\\ANDRES;Initial Catalog=BDComisariato;Integrated Security=True");
>>>>>>> 99f7d573b46d67aa4d44cb61ddbcea3cd002512c
>>>>>>> 66abf7b412d975243cad8c7269b7c45e4e26a0df
>>>>>>> c8060b76e7ee3766d9e2b4bb4f9bbf7d6b42a4f5
                connection.Open();
               // MessageBox.Show("conexion exitosa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectarse a la Base De Datos " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

        }
        public void Cerrar()
        {
<<<<<<< HEAD
            //connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
            connection = new SqlConnection("Data Source=DESKTOP-SI5M9C5;Initial Catalog=BDComisariato;Integrated Security=True");
=======
<<<<<<< HEAD
            connection = new SqlConnection("Data Source = DJSERATO\\SQLEXPRESS; Initial Catalog = BDComisariato; Integrated Security = True");
=======
<<<<<<< HEAD
            //connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
            connection = new SqlConnection("Data Source=DESKTOP-SI5M9C5;Initial Catalog=BDComisariato;Integrated Security=True");
=======
            connection = new SqlConnection("Data Source=DESKTOP-FUFA7EG\\ANDRES;Initial Catalog=BDComisariato;Integrated Security=True");
>>>>>>> 99f7d573b46d67aa4d44cb61ddbcea3cd002512c
>>>>>>> 66abf7b412d975243cad8c7269b7c45e4e26a0df
>>>>>>> c8060b76e7ee3766d9e2b4bb4f9bbf7d6b42a4f5
            connection.Close();
        }
    }
}
