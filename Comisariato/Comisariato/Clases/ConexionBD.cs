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
                connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
=======
                connection = new SqlConnection("data source = AIRC0NTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");

                connection = new SqlConnection("data source = AIRC0NTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
                
                connection = new SqlConnection("Data Source=DJSERATO\\SQLEXPRESS;Initial Catalog=BDComisariato;Integrated Security=True");
>>>>>>> b816f6c0035b717af4925bdd29bd79139856bf42
                //connection = new SqlConnection("Data Source=DESKTOP-SI5M9C5;Initial Catalog=BDComisariato;Integrated Security=True");
                connection.Open();
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectarse a la Base De Datos " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

        }
        public void Cerrar()
        {
<<<<<<< HEAD
            connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
=======
            connection = new SqlConnection("data source = AIRC0NTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
            connection = new SqlConnection("data source = AIRC0NTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");

            connection = new SqlConnection("data source = AIRC0NTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
 
            connection = new SqlConnection("Data Source=DJSERATO\\SQLEXPRESS;Initial Catalog=BDComisariato;Integrated Security=True");

>>>>>>> b816f6c0035b717af4925bdd29bd79139856bf42
            connection.Close();
        }
    }
}
