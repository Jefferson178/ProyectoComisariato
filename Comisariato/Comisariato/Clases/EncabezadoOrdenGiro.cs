﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class EncabezadoOrdenGiro
    {
        int numeroOrdenGiro, tipoDocumento, proveedor;
        string tipo, plazo, concepto, atorizacionProveedor,numeroProveedor;
        int  serie1Proveedor, serie2Proveedor;
        bool rise, declaraSRI, retencionManual;
        DateTime fechaDocumento, fechaContabilizacion, fechaOrdenGiro, FechaVigente;
        int encabezadoCompra;
        float total, valorPagar, saldo;
        int cuentaDeudora0, cuentadDeudora12, cuentaDeudoraiRBP, cuentaIVAPagar;
        DateTime fechaRetencion, fechaVenceDocumento;
        int serie1Retencion, serie2Retencion, numeroRetencion;
        string autorizacionretencion;
        float totalDebe, totalHaber;

        public EncabezadoOrdenGiro(int numeroOrdenGiro, int tipoDocumento, int proveedor, string tipo, string plazo, string concepto, string atorizacionProveedor, string numeroProveedor, int serie1Proveedor, int serie2Proveedor, bool rise, bool declaraSRI, bool retencionManual, DateTime fechaDocumento, DateTime fechaContabilizacion, DateTime fechaOrdenGiro, DateTime fechaVigente, int encabezadoCompra, float total, float valorPagar, float saldo, int cuentaDeudora0, int cuentadDeudora12, int cuentaDeudoraiRBP, int cuentaIVAPagar, DateTime fechaRetencion, DateTime fechaVenceDocumento, int serie1Retencion, int serie2Retencion, int numeroRetencion, string autorizacionretencion, float totalDebe, float totalHaber)
        {
            this.numeroOrdenGiro = numeroOrdenGiro;
            this.tipoDocumento = tipoDocumento;
            this.proveedor = proveedor;
            this.tipo = tipo;
            this.plazo = plazo;
            this.concepto = concepto;
            this.atorizacionProveedor = atorizacionProveedor;
            this.numeroProveedor = numeroProveedor;
            this.serie1Proveedor = serie1Proveedor;
            this.serie2Proveedor = serie2Proveedor;
            this.rise = rise;
            this.declaraSRI = declaraSRI;
            this.retencionManual = retencionManual;
            this.fechaDocumento = fechaDocumento;
            this.fechaContabilizacion = fechaContabilizacion;
            this.fechaOrdenGiro = fechaOrdenGiro;
            FechaVigente = fechaVigente;
            this.encabezadoCompra = encabezadoCompra;
            this.total = total;
            this.valorPagar = valorPagar;
            this.saldo = saldo;
            this.cuentaDeudora0 = cuentaDeudora0;
            this.cuentadDeudora12 = cuentadDeudora12;
            this.cuentaDeudoraiRBP = cuentaDeudoraiRBP;
            this.cuentaIVAPagar = cuentaIVAPagar;
            this.fechaRetencion = fechaRetencion;
            this.fechaVenceDocumento = fechaVenceDocumento;
            this.serie1Retencion = serie1Retencion;
            this.serie2Retencion = serie2Retencion;
            this.numeroRetencion = numeroRetencion;
            this.autorizacionretencion = autorizacionretencion;
            this.totalDebe = totalDebe;
            this.totalHaber = totalHaber;
        }

        public int NumeroOrdenGiro
        {
            get
            {
                return numeroOrdenGiro;
            }

            set
            {
                numeroOrdenGiro = value;
            }
        }

        public int TipoDocumento
        {
            get
            {
                return tipoDocumento;
            }

            set
            {
                tipoDocumento = value;
            }
        }

        public int Proveedor
        {
            get
            {
                return proveedor;
            }

            set
            {
                proveedor = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
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

        public string Concepto
        {
            get
            {
                return concepto;
            }

            set
            {
                concepto = value;
            }
        }

        public string AtorizacionProveedor
        {
            get
            {
                return atorizacionProveedor;
            }

            set
            {
                atorizacionProveedor = value;
            }
        }

        public string NumeroProveedor
        {
            get
            {
                return numeroProveedor;
            }

            set
            {
                numeroProveedor = value;
            }
        }

        public int Serie1Proveedor
        {
            get
            {
                return serie1Proveedor;
            }

            set
            {
                serie1Proveedor = value;
            }
        }

        public int Serie2Proveedor
        {
            get
            {
                return serie2Proveedor;
            }

            set
            {
                serie2Proveedor = value;
            }
        }

        public bool Rise
        {
            get
            {
                return rise;
            }

            set
            {
                rise = value;
            }
        }

        public bool DeclaraSRI
        {
            get
            {
                return declaraSRI;
            }

            set
            {
                declaraSRI = value;
            }
        }

        public bool RetencionManual
        {
            get
            {
                return retencionManual;
            }

            set
            {
                retencionManual = value;
            }
        }

        public DateTime FechaDocumento
        {
            get
            {
                return fechaDocumento;
            }

            set
            {
                fechaDocumento = value;
            }
        }

        public DateTime FechaContabilizacion
        {
            get
            {
                return fechaContabilizacion;
            }

            set
            {
                fechaContabilizacion = value;
            }
        }

        public DateTime FechaOrdenGiro
        {
            get
            {
                return fechaOrdenGiro;
            }

            set
            {
                fechaOrdenGiro = value;
            }
        }

        public DateTime FechaVigente1
        {
            get
            {
                return FechaVigente;
            }

            set
            {
                FechaVigente = value;
            }
        }

        public int EncabezadoCompra
        {
            get
            {
                return encabezadoCompra;
            }

            set
            {
                encabezadoCompra = value;
            }
        }

        public float Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public float ValorPagar
        {
            get
            {
                return valorPagar;
            }

            set
            {
                valorPagar = value;
            }
        }

        public float Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        public int CuentaDeudora0
        {
            get
            {
                return cuentaDeudora0;
            }

            set
            {
                cuentaDeudora0 = value;
            }
        }

        public int CuentadDeudora12
        {
            get
            {
                return cuentadDeudora12;
            }

            set
            {
                cuentadDeudora12 = value;
            }
        }

        public int CuentaDeudoraiRBP
        {
            get
            {
                return cuentaDeudoraiRBP;
            }

            set
            {
                cuentaDeudoraiRBP = value;
            }
        }

        public int CuentaIVAPagar
        {
            get
            {
                return cuentaIVAPagar;
            }

            set
            {
                cuentaIVAPagar = value;
            }
        }

        public DateTime FechaRetencion
        {
            get
            {
                return fechaRetencion;
            }

            set
            {
                fechaRetencion = value;
            }
        }

        public DateTime FechaVenceDocumento
        {
            get
            {
                return fechaVenceDocumento;
            }

            set
            {
                fechaVenceDocumento = value;
            }
        }

        public int Serie1Retencion
        {
            get
            {
                return serie1Retencion;
            }

            set
            {
                serie1Retencion = value;
            }
        }

        public int Serie2Retencion
        {
            get
            {
                return serie2Retencion;
            }

            set
            {
                serie2Retencion = value;
            }
        }

        public int NumeroRetencion
        {
            get
            {
                return numeroRetencion;
            }

            set
            {
                numeroRetencion = value;
            }
        }

        public string Autorizacionretencion
        {
            get
            {
                return autorizacionretencion;
            }

            set
            {
                autorizacionretencion = value;
            }
        }

        public float TotalDebe
        {
            get
            {
                return totalDebe;
            }

            set
            {
                totalDebe = value;
            }
        }

        public float TotalHaber
        {
            get
            {
                return totalHaber;
            }

            set
            {
                totalHaber = value;
            }
        }
        Consultas ObjConsulta;
        public string InsertarEncabezadoyPieCompra(EmcabezadoCompra objEncabezadoCompra)
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("IDPROVEEDOR = " + proveedor + " AND NUMERO = " + numeroProveedor + " AND SERIE1 = " + serie1Proveedor + " AND SERIE2", serie2Proveedor.ToString(), "TbEncabezadoyPieCompra"))
            {
                if (ObjConsulta.EjecutarPROCEDUREEncabezadoCompra(objEncabezadoCompra))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }


    }
}