using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class Proveedor
    {
        Consultas ObjConsulta;

        string codigo;
        string nombres;
        string identificacion;
        string nacionalidad;
        string naturaleza;
        string direccion;
        string razosocial;
        string email;
        string telefono;
        string celular;
        string giracheque;
        string responsable;
        string tipogasto;
        string tiposervicio;
        int idparroquia;
        bool riseproveedor;
        string tipoIdentificacion;
        string plazo;
        string fax;
        bool estado;
        public Proveedor()
        {
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }
        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }
        public string Nacionalidad
        {
            get
            {
                return nacionalidad;
            }

            set
            {
                nacionalidad = value;
            }
        }
        public string Naturaleza
        {
            get
            {
                return naturaleza;
            }

            set
            {
                naturaleza = value;
            }
        }
        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }
        public string Razosocial
        {
            get
            {
                return razosocial;
            }

            set
            {
                razosocial = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }
        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }
        public string Giracheque
        {
            get
            {
                return giracheque;
            }

            set
            {
                giracheque = value;
            }
        }
        public string Responsable
        {
            get
            {
                return responsable;
            }

            set
            {
                responsable = value;
            }
        }
        public string Tipogasto
        {
            get
            {
                return tipogasto;
            }

            set
            {
                tipogasto = value;
            }
        }
        public string Tiposervicio
        {
            get
            {
                return tiposervicio;
            }

            set
            {
                tiposervicio = value;
            }
        }
        public int Idparroquia
        {
            get
            {
                return idparroquia;
            }

            set
            {
                idparroquia = value;
            }
        }
        public bool Riseproveedor
        {
            get
            {
                return riseproveedor;
            }

            set
            {
                riseproveedor = value;
            }
        }
        public string TipoIdentificacion
        {
            get
            {
                return tipoIdentificacion;
            }

            set
            {
                tipoIdentificacion = value;
            }
        }
        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Plazo
        {
            get
            {
                return plazo;
            }

            set
            {
                plazo = value;
            }
        }

        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public Proveedor(string fax, bool estado, string plazo, string codigo, string tipoIdentificacion,string nombres, string identificacion, string nacionalidad, string naturaleza, string direccion, string razosocial, string email, string telefono, string celular, string giracheque, string responsable, string tipogasto, string tiposervicio, int idparroquia, bool riseproveedor)
        {
            this.Nombres = nombres;
            this.Identificacion = identificacion;
            this.Nacionalidad = nacionalidad;
            this.Naturaleza = naturaleza;
            this.Direccion = direccion;
            this.Razosocial = razosocial;
            this.Email = email;
            this.Telefono = telefono;
            this.Celular = celular;
            this.Giracheque = giracheque;
            this.Responsable = responsable;
            this.Tipogasto = tipogasto;
            this.Tiposervicio = tiposervicio;
            this.Idparroquia = idparroquia;
            this.Riseproveedor = riseproveedor;
            this.TipoIdentificacion = tipoIdentificacion;
            this.Codigo = codigo;
            this.Plazo = plazo;
            this.Fax = fax;
            this.Estado = estado;
        }
        public string InsertarProveedor()
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("IDENTIFICACION", identificacion, "TbProveedor"))
            {
                if (ObjConsulta.EjecutarSQL("Insert into [dbo].[TbProveedor] ([CODIGO],[NOMBRES],[TIPOIDENTIFICACION],[IDENTIFICACION],[NACIONALIDAD],[NATURALEZA],[DIRECCION]" +
           ",[RAZONSOCIAL],[TELEFONO],[CELULAR],[RESPONSABLE],[TIPOSERVICIO],[PLAZO],[EMAIL],[GIRACHEQUEA],[IDPARROQUIA],[TIPOGASTO],[FAX]"+
           ",[ESTADO],[PROVEEDORRISE]) " +
                    " VALUES ('"+ codigo.ToUpper() +"','" + nombres.ToUpper() + "','"+ tipoIdentificacion.ToUpper() +"','" + identificacion.ToUpper() + "','" + nacionalidad.ToUpper() + "','" + naturaleza.ToUpper() + "','" + direccion.ToUpper() + 
                    "','" + razosocial.ToUpper() + "','" + telefono + "','" + celular + "','" + responsable.ToUpper() + "','" + tiposervicio.ToUpper() + "','" + plazo.ToUpper() +
                    "','" + email.ToUpper() + "','" + giracheque.ToUpper() + "'," + idparroquia + ",'" + tipogasto.ToUpper() + "','" + fax +  "','" + estado +"','" + riseproveedor + "');"))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }

        public string ModificarProveedor(string Identificacion)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbProveedor] SET[NOMBRES] = '"+nombres.ToUpper()+ "',[IDENTIFICACION] = '"+this.identificacion+ "' ,[NACIONALIDAD] = '"+nacionalidad+"'," +
                "[NATURALEZA] = '"+naturaleza+ "',[DIRECCION] = '"+direccion.ToUpper() + "',[RAZONSOCIAL] = '"+razosocial.ToUpper() + "',[EMAIL] = '"+email+ "',[TELEFONO] = '"+telefono+ "',[CELULAR] = '"+celular+"' ," +
                "[GIRACHEQUEA] = '"+giracheque.ToUpper() + "',[RESPONSABLE] = '"+responsable.ToUpper() + "' ,[TIPOGASTO] = '"+tipogasto+ "',[TIPOSERVICIO] = '"+tiposervicio+ "',[IDPARROQUIA] = "+idparroquia+ " , [PROVEEDORRISE] = '"+ riseproveedor + "' WHERE IDENTIFICACION = '" + Identificacion + "';"))
            {
                return "Correcto";
            }
            else { return "Error al Modificar"; }
        }

        public string EstadoProveedor(string Identificacion, int estado)
        {
            ObjConsulta = new Consultas();
            if (estado == 1)
                if (ObjConsulta.EjecutarSQL("UPDATE TbProveedor SET ESTADO = 1 WHERE IDENTIFICACION = '" + Identificacion + "'"))
                {
                    return "Habilitado";
                }
                else { return "Error"; }
            else if (estado == 2)
            {
                if (ObjConsulta.EjecutarSQL("UPDATE TbProveedor SET ESTADO = 0 WHERE IDENTIFICACION = '" + Identificacion + "'"))
                {
                    return "Correcto";
                }
                else { return "Error"; }
            }
            else { return "Sin Accion"; }
        }
    }
}