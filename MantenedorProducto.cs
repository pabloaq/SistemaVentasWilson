using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MantenedorProducto
{
    public partial class MantenedorProducto : Form
    {
        public MantenedorProducto()
        {
            InitializeComponent();
            ListarProducto();
        }
        public void ListarProducto()
        {
            dgv_listaProductos.DataSource = logProducto.Instancia.ListarProducto();
        }


        private void MantenedorProducto_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entProducto p = new entProducto();
                p.ProductoID = int.Parse(txt_codProducto.Text.Trim());
                p.CategoriaproductoID = int.Parse(cb_Cod_Categoria.Text.Trim());
                p.LocalID = int.Parse(cb_ID_Local.Text.Trim());
                p.nombre = txt_nomProducto.Text.Trim();
                p.stock = int.Parse(txt_stockProducto.Text.Trim());
                p.precioUnitario = txt_PrecioUnitario.Text.Trim();
                p.fechaCaducidad = dt_fechaCaducidad.Value;
                logProducto.Instancia.InsertaProducto(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarProducto();

        }

        private void LimpiarVariables()
        {
            txt_codProducto.Text = "";
            cb_Cod_Categoria.Text = " ";
            cb_ID_Local.Text = " ";
            txt_nomProducto.Text = " ";
            txt_stockProducto.Text = " ";
            txt_PrecioUnitario.Text = " ";

        }

        private void dgv_listaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_listaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgv_listaProductos.Rows[e.RowIndex]; //
            txt_codProducto.Text = filaActual.Cells[0].Value.ToString();
            cb_Cod_Categoria.Text = filaActual.Cells[1].Value.ToString();
            cb_ID_Local.Text = filaActual.Cells[2].Value.ToString();
            txt_nomProducto.Text = filaActual.Cells[3].Value.ToString();
            txt_stockProducto.Text = filaActual.Cells[4].Value.ToString();
            txt_PrecioUnitario.Text = filaActual.Cells[5].Value.ToString();
            dt_fechaCaducidad.Text = filaActual.Cells[6].Value.ToString();
        }

        private void btn_Modificarprodu_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto p = new entProducto();
                p.ProductoID = int.Parse(txt_codProducto.Text.Trim());
                p.CategoriaproductoID = int.Parse(cb_Cod_Categoria.Text.Trim());
                p.LocalID = int.Parse(cb_ID_Local.Text.Trim());
                p.nombre = txt_nomProducto.Text.Trim();
                p.stock = int.Parse(txt_stockProducto.Text.Trim());
                p.precioUnitario = txt_PrecioUnitario.Text.Trim();
                p.fechaCaducidad = dt_fechaCaducidad.Value;
                logProducto.Instancia.EditaProducto(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarProducto();
        }

        private void btn_EliminarProd_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto p = new entProducto();
                p.ProductoID = int.Parse(txt_codProducto.Text.Trim());
                logProducto.Instancia.EliminarProducto(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarProducto();
        }

    }
}

