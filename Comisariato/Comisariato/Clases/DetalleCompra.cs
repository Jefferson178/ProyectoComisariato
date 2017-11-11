using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class DetalleCompra
    {
        //-------------detalle--------
        string codigo;
        int cantidad;
        float precioCompra;
        float descuento;
        float precioVentaPublico;
        float precioMayorista;
        float precioCajas;
        int idEncabezadoCompra;

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

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public float PrecioCompra
        {
            get
            {
                return precioCompra;
            }

            set
            {
                precioCompra = value;
            }
        }

        public float Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }

        public float PrecioVentaPublico
        {
            get
            {
                return precioVentaPublico;
            }

            set
            {
                precioVentaPublico = value;
            }
        }

        public float PrecioMayorista
        {
            get
            {
                return precioMayorista;
            }

            set
            {
                precioMayorista = value;
            }
        }

        public float PrecioCajas
        {
            get
            {
                return precioCajas;
            }

            set
            {
                precioCajas = value;
            }
        }
        public int IdEncabezadoCompra
        {
            get
            {
                return idEncabezadoCompra;
            }

            set
            {
                idEncabezadoCompra = value;
            }
        }

        Consultas ObjConsulta;
        public DetalleCompra()
        {

        }
        public DetalleCompra(int idEncabezadoCompra, string codigo, int cantidad, float precioCompra, float descuento, float precioVentaPublico, float precioMayorista, float precioCajas)
        {
            this.IdEncabezadoCompra = idEncabezadoCompra;
            this.Codigo = codigo;
            this.Cantidad = cantidad;
            this.PrecioCompra = precioCompra;
            this.Descuento = descuento;
            this.PrecioVentaPublico = precioVentaPublico;
            this.PrecioMayorista = precioMayorista;
            this.PrecioCajas = precioCajas;
        }
        public string InsertarDetalleCompra(DetalleCompra objDetalleCompra)
        {
            ObjConsulta = new Consultas();
            if (ObjConsulta.EjecutarPROCEDUREDetalleCompra(objDetalleCompra))
                return "Datos Guardados";
            else
                return "Error al Registrar";
        }
    }
}
