using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace MantenedorProducto
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
            llenarDatosComboBoxPedido();
            llenarDatosComboBoxLocal();
            ListarProducto();
        }

        private void llenarDatosComboBoxPedido()
        {
            cb_Cod_Categoria.DataSource = logCategoriaProducto.GetInstancia.ListarCategoriasProducto();
            cb_Cod_Categoria.DisplayMember = "nombreCategoria";
            cb_Cod_Categoria.ValueMember = "idCategoriaProducto";
        }

        private void llenarDatosComboBoxLocal()
        {
            cb_ID_Local.DataSource = logLocal.GetInstancia.ListarLocal();
            cb_ID_Local.DisplayMember = "nombre";
            cb_ID_Local.ValueMember = "idLocal";

        }
        public void ListarProducto()
        {
            dgv_listaProductos.DataSource = logProducto.GetInstancia.ListarProducto();
        }

        private void LimpiarVariables()
        {
            txt_codProducto.Text = "";
            cb_ID_Local.Text = " ";
            txt_nomProducto.Text = " ";
            txt_stockProducto.Text = " ";
            txt_PrecioUnitario.Text = " ";

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                if (txt_nomProducto.Text != "" && txt_stockProducto.Text != "" && txt_PrecioUnitario.Text != "")
                {
                    entProducto p = new entProducto();
                    p.CategoriaproductoID = Convert.ToInt32(cb_Cod_Categoria.SelectedValue);
                    p.LocalID = Convert.ToInt32(cb_ID_Local.SelectedValue);
                    p.nombre = txt_nomProducto.Text.Trim();
                    p.stock = int.Parse(txt_stockProducto.Text.Trim());
                    p.precioUnitario = float.Parse(txt_PrecioUnitario.Text.Trim());
                    p.fechaCaducidad = dt_fechaCaducidad.Value;

                    logProducto.GetInstancia.InsertaProducto(p);
                }
                else
                    MessageBox.Show("Casillas vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarProducto();
        }

        private void dgv_listaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgv_listaProductos.Rows[e.RowIndex]; 

            txt_codProducto.Text = filaActual.Cells[0].Value.ToString();
            cb_Cod_Categoria.SelectedIndex = int.Parse(filaActual.Cells[1].Value.ToString())-1;
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
                if (txt_codProducto.Text != "" && txt_nomProducto.Text != "" && txt_stockProducto.Text != "" && txt_PrecioUnitario.Text != "")
                {
                    entProducto p = new entProducto();
                    p.ProductoID = int.Parse(txt_codProducto.Text.Trim());
                    p.CategoriaproductoID = Convert.ToInt32(cb_Cod_Categoria.SelectedValue);
                    p.LocalID = Convert.ToInt32(cb_ID_Local.SelectedValue);
                    p.nombre = txt_nomProducto.Text.Trim();
                    p.stock = int.Parse(txt_stockProducto.Text.Trim());
                    p.precioUnitario = Convert.ToSingle(txt_PrecioUnitario.Text.Trim());
                    p.fechaCaducidad = dt_fechaCaducidad.Value;

                    logProducto.GetInstancia.EditaProducto(p);
                }
                else
                {
                    MessageBox.Show("Casilla vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                if (txt_codProducto.Text != "")
                {
                    entProducto p = new entProducto();
                    p.ProductoID = int.Parse(txt_codProducto.Text.Trim());

                    logProducto.GetInstancia.EliminarProducto(p);
                }
                else
                {
                    MessageBox.Show("Seleccione un registro para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                    
            }
            LimpiarVariables();
            ListarProducto();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }
    }
}
