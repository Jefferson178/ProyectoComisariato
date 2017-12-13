using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Informes
{
    public partial class FrmKardex : Form
    {
        public FrmKardex()
        {
            InitializeComponent();
        }
        Consultas objConsulta = new Consultas();
        //Select para las compras

        //select e.SERIE1+''+e.SERIE2+''+e.NUMERO as NFactura, d.PRECIOCOMRPA, e.FECHAORDENCOMPRA, d.CANTIDAD
        //from TbEncabezadoyPieCompra e, TbDetalleCompra d, TbProducto p  where e.IDEMCABEZADOCOMPRA = d.IDENCABEZADOCOMPRA and
        //d.CODIGOBARRAPRODUCTO = p.CODIGOBARRA and p.CODIGOBARRA = 123456789 and e.FECHAORDENCOMPRA between  '' and ''

        //Select parqa ventas

        //select e.SUCURSAL, e.CAJA, e.NFACTURA, d.PRECIO, d.CANTIDAD, e.FECHA
        //from TbEncabezadoFactura e, TbDetalleFactura d, TbProducto p where e.IDFACTURA = d.NFACTURA and
        //d.CODIGOBARRAPRODUCTO = p.CODIGOBARRA and p.CODIGOBARRA = 123456789 and e.FECHA between  '' and ''
        private void FrmKardex_Load(object sender, EventArgs e)
        {
            objConsulta.BoolLlenarComboBox(cbCategoria, "Select IDCATEGORIA as ID, Descripcion as Texto from TbCategoria");
            for (int i = 0; i < 17; i++)
            {
                dgvKardex.Rows.Add();
            }
        }

        private void btnGenerarKardex_Click(object sender, EventArgs e)
        {
            DataTable datosCompra = objConsulta.BoolDataTable("select e.SERIE1+''+e.SERIE2+''+e.NUMERO as NFactura, d.PRECIOCOMRPA, e.FECHAORDENCOMPRA, d.CANTIDAD" +
            " from TbEncabezadoyPieCompra e, TbDetalleCompra d, TbProducto p  where e.IDEMCABEZADOCOMPRA = d.IDENCABEZADOCOMPRA and" +
            " d.CODIGOBARRAPRODUCTO = p.CODIGOBARRA and p.CODIGOBARRA = 123456789 and e.FECHAORDENCOMPRA between  '"+ Convert.ToString(dtpDesde.Value) + "' and '" + Convert.ToString(dtpHasta.Value) + "' order by e.FECHAORDENCOMPRA");

            DataTable datosVenta = objConsulta.BoolDataTable("select e.SUCURSAL, e.CAJA, e.NFACTURA, d.PRECIO, d.CANTIDAD, e.FECHA" +
            " from TbEncabezadoFactura e, TbDetalleFactura d, TbProducto p where e.IDFACTURA = d.NFACTURA and" +
            " d.CODIGOBARRAPRODUCTO = p.CODIGOBARRA and p.CODIGOBARRA = 123456789 and e.FECHA between  '" + Convert.ToString(dtpDesde.Value) + "' and '" + Convert.ToString(dtpHasta.Value) + "' order by e.FECHA");

            //int cantidadCompras = datosCompra.Rows.Count, cantidadVentas = datosVenta.Rows.Count, contadorCompra = 0, contadorventa = 0;
            //bool quienMayor = false;
            //int filaDGV = 0;
            //int limiteGeneral = cantidadCompras + cantidadVentas;
            for (int i = 0; i < datosCompra.Rows.Count; i++)
            {
                DataRow dtCompra = datosCompra.Rows[i];
                dgvKardex.Rows[i].Cells[0].Value = dtCompra["FECHAORDENCOMPRA"];
                dgvKardex.Rows[i].Cells[1].Value = "Compra S/F " + dtCompra["NFactura"];
                dgvKardex.Rows[i].Cells[2].Value = dtCompra["CANTIDAD"];
                dgvKardex.Rows[i].Cells[3].Value = dtCompra["PRECIOCOMRPA"];
                dgvKardex.Rows[i].Cells[4].Value = Convert.ToSingle(dgvKardex.Rows[i].Cells[3].Value) * Convert.ToInt32(dgvKardex.Rows[i].Cells[2].Value);
                if (i == dgvKardex.RowCount -1)
                {
                    dgvKardex.Rows.Add();
                }
                dgvKardex.Rows.Insert(1,1);
            }
            
            for (int i = 0; i <datosVenta.Rows.Count; i++)
            {
                DataRow dtVenta = datosVenta.Rows[i];
                for (int j = 0; j < dgvKardex.RowCount -1; j++)
                {
                    if (Convert.ToDateTime(dtVenta["FECHA"]) < Convert.ToDateTime(dgvKardex.Rows[j].Cells[0].Value))
                    {
                        
                    }
                }                
            }           
        }
    }
}
