﻿using System;
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
=======
=======
<<<<<<< HEAD
                connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
=======
                
                connection = new SqlConnection("Data Source=DJSERATO\\SQLEXPRESS;Initial Catalog=BDComisariato;Integrated Security=True");
                //connection = new SqlConnection("Data Source=DESKTOP-SI5M9C5;Initial Catalog=BDComisariato;Integrated Security=True");
>>>>>>> 4888a7b3cadd82dd4904aac00ec568654eeab8f0
>>>>>>> 123f5f48f6c17d66ccf2c3708f31ebcdb854f34e
>>>>>>> 78ce00461c66d27f0b461499f1d70ce45b4b01d6
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
<<<<<<< HEAD
=======
=======
<<<<<<< HEAD
            connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
=======
            
            connection = new SqlConnection("Data Source=DJSERATO\\SQLEXPRESS;Initial Catalog=BDComisariato;Integrated Security=True");
           
>>>>>>> 4888a7b3cadd82dd4904aac00ec568654eeab8f0
>>>>>>> 123f5f48f6c17d66ccf2c3708f31ebcdb854f34e
>>>>>>> 78ce00461c66d27f0b461499f1d70ce45b4b01d6
            connection.Close();
        }
    }
}
