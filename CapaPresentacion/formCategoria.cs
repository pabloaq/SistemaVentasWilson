using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formCategoria : Form
    {
        public formCategoria()
        {
            InitializeComponent();
            ListarCategoria();
        }

        #region Limpiar Variables
        
        public void LimpiarVariables()
        {
            txtCodigoCategoria.Text = "";
            txtNombreCategoria.Text = "";
            txtDescripcionCategoria.Text = "";
        }

        #endregion Limpiar Variables

        #region Listar Categoria Producto

        public void ListarCategoria() =>  dgvCategoriaProducto.DataSource = logCategoriaProducto.GetInstancia.ListarCategoriasProducto();

        #endregion Listar Categoria Producto

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoCategoria.Text != "" && txtNombreCategoria.Text != "" && txtDescripcionCategoria.Text != "")
                {
                    entCategoriaProducto cate = new entCategoriaProducto
                    {
                        nombreCategoria = txtNombreCategoria.Text,
                        descripcion = txtDescripcionCategoria.Text
                    };

                    logCategoriaProducto.GetInstancia.InsertarCategoriasProducto(cate);
                }
                else
                {
                    MessageBox.Show("Casillas vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    

            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            ListarCategoria();
            LimpiarVariables();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoCategoria.Text != "" && txtNombreCategoria.Text != "" && txtDescripcionCategoria.Text != "")
                {
                    entCategoriaProducto cate = new entCategoriaProducto
                    {
                        idCategoriaProducto = Convert.ToInt32(txtCodigoCategoria.Text.Trim()),
                        nombreCategoria = txtNombreCategoria.Text,
                        descripcion = txtDescripcionCategoria.Text
                    };

                    logCategoriaProducto.GetInstancia.ModificarCategoriasProducto(cate);
                }
                else
                {
                    MessageBox.Show("Casilla vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            ListarCategoria();
            LimpiarVariables();
        }

        private void dgvCategoriaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCategoriaProducto.Rows[e.RowIndex];

            txtCodigoCategoria.Text = filaActual.Cells[0].Value.ToString();
            txtNombreCategoria.Text = filaActual.Cells[1].Value.ToString(); 
            txtDescripcionCategoria.Text = filaActual.Cells[2].Value.ToString(); 

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoriaProducto cate = new entCategoriaProducto
                {
                    idCategoriaProducto = Convert.ToInt32(txtCodigoCategoria.Text.Trim())
                };

                logCategoriaProducto.GetInstancia.EliminarCategoriasProducto(cate);
            }
            catch(Exception ex)
            {
                if(txtCodigoCategoria.Text == "")
                    MessageBox.Show("Seleccione un registro para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarVariables();
            ListarCategoria();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
