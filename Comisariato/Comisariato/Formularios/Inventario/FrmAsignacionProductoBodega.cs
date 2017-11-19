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

namespace Comisariato.Formularios.Mantenimiento.Inventario
{
    public partial class FrmAsignacionProductoBodega : Form
    {
        public FrmAsignacionProductoBodega()
        {
            InitializeComponent();
        }
        Consultas objconsul = new Consultas();
        private void FrmAsignacionProductoBodega_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 15; i++)
            //{
            //    dgvDatosProductoParaAsignacionBodega.Rows.Add();
            //    dgvDatosProductosAsignadosABodega.Rows.Add();
            //}
            inicializar();

            dgvDatosProductoParaAsignacionBodega.Columns["agregarProductosAbodega"].Width = 23;
            dgvDatosProductosAsignadosABodega.Columns["QuitarProductosAbodega"].Width = 23;
            for (int i = 1; i < dgvDatosProductoParaAsignacionBodega.ColumnCount; i++)
            {
                dgvDatosProductoParaAsignacionBodega.Columns[i].ReadOnly = true;
                dgvDatosProductosAsignadosABodega.Columns[i].ReadOnly = true;
            }
        }



        public void inicializar()
        {
            objconsul.BoolLlenarComboBox(cbEscogerBodega, "Select IDBODEGA as ID, NOMBRE as TEXTO from TbBodega");
            objconsul.boolLlenarDataGridView(dgvDatosProductosAsignadosABodega, "Select P.CODIGOBARRA as 'Código', P.NOMBREPRODUCTO as 'Nombre',P.CANTIDAD as Cantidad, C.DESCRIPCION as 'Categoria' from TbProducto P inner join TbAsignacionProdcutoBodega Asig on (Asig.IDPRODUCTO = P.IDPRODUCTO) inner join TbBodega B on ( Asig.IDBODEGA = B.IDBODEGA) inner join TbCategoria C on (P.IDCATEGORIA = C.IDCATEGORIA) where Asig.IDBODEGA = " + Convert.ToInt32(cbEscogerBodega.SelectedValue) + ";");
            objconsul.boolLlenarDataGridView(dgvDatosProductoParaAsignacionBodega, "Select P.CODIGOBARRA as 'Código', P.NOMBREPRODUCTO as 'Nombre',P.CANTIDAD, C.DESCRIPCION as 'Categoria' from TbProducto P, TbCategoria C where C.IDCATEGORIA= P.IDCATEGORIA and not exists (select * from TbAsignacionProdcutoBodega where TbAsignacionProdcutoBodega.IDPRODUCTO = P.IDPRODUCTO);");
            txtBuscarProducto.Text = "";
            txtUbicacionBodegaAsignacionProducto.Text = "";
            llenardatos();
        }

        public void llenardatos()
        {
            String ID = cbEscogerBodega.SelectedValue.ToString();
            objconsul = new Consultas();
            DataTable dt = objconsul.BoolDataTable("Select UBICACION from TbBodega where IDBODEGA = " + ID + ";");
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtUbicacionBodegaAsignacionProducto.Text = row["UBICACION"].ToString();
            }
        }

        private void cbEscogerBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEscogerBodega.SelectedValue.ToString() != null)
            {
                llenardatos();
            }
        }

        private void btnAsignarProducto_Click(object sender, EventArgs e)
        {
            DataTable dataTB = (DataTable)dgvDatosProductosAsignadosABodega.DataSource;
            //objconsul.BoolDataTable("Select P.CODIGOBARRA as 'Código', P.NOMBREPRODUCTO as 'Nombre',P.CANTIDAD as Cantidad, C.DESCRIPCION as 'Categoria' from TbProducto P inner join TbAsignacionProdcutoBodega Asig on (Asig.IDPRODUCTO = P.IDPRODUCTO) inner join TbBodega B on ( Asig.IDBODEGA = B.IDBODEGA) inner join TbCategoria C on (P.IDCATEGORIA = C.IDCATEGORIA) where Asig.IDBODEGA = " + Convert.ToInt32(cbEscogerBodega.SelectedValue) + ";");

            if (dgvDatosProductoParaAsignacionBodega.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDatosProductoParaAsignacionBodega.Rows.Count; i++)
                {
                    if ( Convert.ToBoolean(dgvDatosProductoParaAsignacionBodega.Rows[i].Cells["agregarProductosAbodega"].Value) == true)
                    {
                        //MessageBox.Show(dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[1].Value.ToString());
                        // Creamos un array con los valores que vamos a insertar
                        // en el segundo control DataGridView.
                        //
                        object[] values = {
                                          dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[1].Value,
                                          dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[2].Value,
                                          dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[3].Value,
                                          dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[4].Value};

                        // Creamos un nuevo objeto DataGridViewRow.
                        //
                        DataGridViewRow row = new DataGridViewRow();

                        // Creamos las celdas y las rellenamos con los valores existentes
                        // en el array.
                        //
                        row.CreateCells(dgvDatosProductosAsignadosABodega, values);
                        // Creamos un array con los valores que vamos a insertar

                        // Añadimos la nueva fila al segundo control DataGridView.


                        
                        dataTB.Rows.Add(values);
                        dgvDatosProductosAsignadosABodega.DataSource = dataTB;
                        
                    }

                }
                for (int i = 0; i < dgvDatosProductoParaAsignacionBodega.Rows.Count;)
                {
                    DataTable dt = (DataTable)dgvDatosProductoParaAsignacionBodega.DataSource;
                    if (Convert.ToBoolean(dgvDatosProductoParaAsignacionBodega.Rows[i].Cells["agregarProductosAbodega"].Value) == true)
                    {
                        dgvDatosProductoParaAsignacionBodega.Rows.Remove(dgvDatosProductoParaAsignacionBodega.Rows[i]);
                        //i = 0;
                    }
                    else { i++; }

                }
            }
            else
            {
                //no hay datos en el datagrid
            }
        }

        private void btnNoAsiganrProducto_Click(object sender, EventArgs e)
        {
            DataTable dataTB = (DataTable)dgvDatosProductoParaAsignacionBodega.DataSource;

            if (dgvDatosProductosAsignadosABodega.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDatosProductosAsignadosABodega.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvDatosProductosAsignadosABodega.Rows[i].Cells["QuitarProductosAbodega"].Value) == true)
                    {
                        //MessageBox.Show(dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[1].Value.ToString());
                        // Creamos un array con los valores que vamos a insertar
                        // en el segundo control DataGridView.
                        //
                        object[] values = {
                                          dgvDatosProductosAsignadosABodega.Rows[i].Cells[1].Value,
                                          dgvDatosProductosAsignadosABodega.Rows[i].Cells[2].Value,
                                          dgvDatosProductosAsignadosABodega.Rows[i].Cells[3].Value,
                                          dgvDatosProductosAsignadosABodega.Rows[i].Cells[4].Value};

                        // Creamos un nuevo objeto DataGridViewRow.
                        //
                        DataGridViewRow row = new DataGridViewRow();

                        // Creamos las celdas y las rellenamos con los valores existentes
                        // en el array.
                        //
                        row.CreateCells(dgvDatosProductosAsignadosABodega, values);
                        // Creamos un array con los valores que vamos a insertar

                        // Añadimos la nueva fila al segundo control DataGridView.



                        dataTB.Rows.Add(values);
                        dgvDatosProductoParaAsignacionBodega.DataSource = dataTB;

                    }

                }
                for (int i = 0; i < dgvDatosProductosAsignadosABodega.Rows.Count;)
                {
                    DataTable dt = (DataTable)dgvDatosProductosAsignadosABodega.DataSource;
                    if (Convert.ToBoolean(dgvDatosProductosAsignadosABodega.Rows[i].Cells["QuitarProductosAbodega"].Value) == true)
                    {
                        dgvDatosProductosAsignadosABodega.Rows.Remove(dgvDatosProductosAsignadosABodega.Rows[i]);
                        //i = 0;
                    }
                    else { i++; }

                }
            }
            else
            {
                //no hay datos en el datagrid
            }
        }
    }
}
