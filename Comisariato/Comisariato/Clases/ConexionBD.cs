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
                connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
<<<<<<< HEAD
                //connection = new SqlConnection("Data Source=DESKTOP-SI5M9C5;Initial Catalog=BDComisariato;Integrated Security=True");
=======
>>>>>>> 0e26af5b1eb99a32dee495bad3ef5da8d9395214
                connection.Open();
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectarse a la Base De Datos " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

        }
        public void Cerrar()
        {
            connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
            connection.Close();
        }
    }
}
