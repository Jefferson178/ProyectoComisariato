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
        //------------------------------Conexion Andres ----------------------------------------//
        //Data Source=DESKTOP-FUFA7EG\\ANDRES;Initial Catalog=BDComisariato;Integrated Security=True
        //------------------------------Conexion Servidor----------------------------------------//
        //data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;
        //------------------------------Conexion Byron ----------------------------------------//
        //Data Source = DESKTOP - SI5M9C5; Initial Catalog = BDComisariato; Integrated Security = True

        public void conectar()
        {
            try
            {
<<<<<<< HEAD
                connection = new SqlConnection("Data Source = DJSERATO\\SQLEXPRESS; Initial Catalog = BDComisariato; Integrated Security = True");
=======
                connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
>>>>>>> 62d0d42ab1da7a30007bee5dd20b09b7e6f82fae
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
            connection = new SqlConnection("Data Source = DJSERATO\\SQLEXPRESS; Initial Catalog = BDComisariato; Integrated Security = True");
=======
            connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;");
>>>>>>> 62d0d42ab1da7a30007bee5dd20b09b7e6f82fae
            connection.Close();
        }
    }
}
