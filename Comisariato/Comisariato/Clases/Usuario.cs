using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class Usuario
    {
        Consultas ObjConsulta;
        int idEmpleado;
        string usuarioname;
        string password;
        int tipoUsario;
        int idEmpresa;


        public Usuario()
        {
        }

        public Usuario(int idEmpleado, string usuarioname, string password, int tipoUsario, int idEmpresa)
        {
            this.idEmpleado = idEmpleado;
            this.Usuarioname = usuarioname;
            this.password = password;
            this.tipoUsario = tipoUsario;
            this.idEmpresa = idEmpresa;
        }

        public int IdEmpleado
        {
            get
            {
                return idEmpleado;
            }

            set
            {
                idEmpleado = value;
            }
        }


        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int TipoUsario
        {
            get
            {
                return tipoUsario;
            }

            set
            {
                tipoUsario = value;
            }
        }

        public int IdEmpresa
        {
            get
            {
                return idEmpresa;
            }

            set
            {
                idEmpresa = value;
            }
        }

        public string Usuarioname
        {
            get
            {
                return usuarioname;
            }

            set
            {
                usuarioname = value;
            }
        }



        public string InsertarUsuario()
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("USUARIO", usuarioname, "TbUsuario"))
            {
                if (ObjConsulta.EjecutarSQL("INSERT INTO [dbo].[TbUsuario]  ([IDEMPLEADO] ,[USUARIO]   ,[CONTRASEÑA] ,[IDTIPOUSUARIO],[IDEMPRESA],[ACTIVO])"
                        + "VALUES(" + idEmpleado + ",'" + usuarioname + "','" + password + "'," + tipoUsario + "," + idEmpresa + " )")) 
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }

        public string ModificarUsuario(string idusuario)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbUsuario] SET[IDEMPLEADO] = "+idEmpleado+",[USUARIO] = '"+usuarioname+"' ,[CONTRASEÑA] = '"+password+"' ,[IDTIPOUSUARIO] = "+tipoUsario+" ,[IDEMPRESA] = "+idEmpresa+",[ACTIVO] = 1 WHERE IDUSUARIO = "+ idusuario + ""))
            {
                return "Correcto";
            }
            else { return "Error al Modificar"; }
        }

        public string EstadoUsuario(string usuarioname, int estado)
        {
            ObjConsulta = new Consultas();
            if (estado == 1)
                if (ObjConsulta.EjecutarSQL("UPDATE TbUsuario SET ACTIVO = 1 WHERE USUARIO = '" + usuarioname + "'"))
                {
                    return "Habilitado";
                }
                else { return "Error"; }
            else if (estado == 2)
            {
                if (ObjConsulta.EjecutarSQL("UPDATE TbUsuario SET ACTIVO = 0 WHERE USUARIO = '" + usuarioname + "'"))
                {
                    return "Correcto";
                }
                else { return "Error"; }
            }
            else { return "Sin Accion"; }
        }
    }
}
