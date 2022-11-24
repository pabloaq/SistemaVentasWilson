using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCategoriaMetodoPago : Form
    {
        public FormCategoriaMetodoPago()
        {
            InitializeComponent();
            listarCategoriaMetodoPago();
        }

        private void limpiarVariables()
        {
            txtCodigoCatMetodoPago.Text = "";
            txtNombreCatMetodoPago.Text = "";
            txtDescripcionCatMetodoPago.Text = "";
        }

        public void listarCategoriaMetodoPago()
        {
            dgvCatMetodoPago.DataSource = logCategoriaMetodoPago.Instancia.ListarCategoriaMetodoPago();
        }

        private void btn_AgregarCatMetodoPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoCatMetodoPago.Text != "" && txtNombreCatMetodoPago.Text != "")
                {
                    entCategoriaMetodoPago catMetodoPago = new entCategoriaMetodoPago();
                    catMetodoPago.idCategoriaMetodoPago = Convert.ToInt32(txtCodigoCatMetodoPago.Text.Trim());
                    catMetodoPago.nombreCategoria = txtNombreCatMetodoPago.Text;
                    catMetodoPago.descripcion = txtDescripcionCatMetodoPago.Text;
                    logCategoriaMetodoPago.Instancia.InsertaCategoriaMetodoPago(catMetodoPago);
                }
                else
                {
                    MessageBox.Show("Casillas vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            limpiarVariables();
            listarCategoriaMetodoPago();
        }

        private void btn_ModificarCatMetodoPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoCatMetodoPago.Text != "" && txtNombreCatMetodoPago.Text != "")
                {
                    entCategoriaMetodoPago catMetodoPago = new entCategoriaMetodoPago();
                    catMetodoPago.idCategoriaMetodoPago = Convert.ToInt32(txtCodigoCatMetodoPago.Text.Trim());
                    catMetodoPago.nombreCategoria = txtNombreCatMetodoPago.Text;
                    catMetodoPago.descripcion = txtDescripcionCatMetodoPago.Text;

                    logCategoriaMetodoPago.Instancia.EditaCategoriaMetodoPago(catMetodoPago);
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

            limpiarVariables();
            listarCategoriaMetodoPago();
        }

        private void btn_EliminarCatMetodoPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoCatMetodoPago.Text != "")
                {
                    entCategoriaMetodoPago catMetodoPago = new entCategoriaMetodoPago();

                    catMetodoPago.idCategoriaMetodoPago = Convert.ToInt32(txtCodigoCatMetodoPago.Text.Trim());

                    logCategoriaMetodoPago.Instancia.EliminaCategoriaMetodoPago(catMetodoPago);
                }
                else
                {
                    MessageBox.Show("Seleccione un registro para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            limpiarVariables();
            listarCategoriaMetodoPago();
        }

        private void dgvCatMetodoPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCatMetodoPago.Rows[e.RowIndex];

            txtCodigoCatMetodoPago.Text = filaActual.Cells[0].Value.ToString();
            txtNombreCatMetodoPago.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcionCatMetodoPago.Text = filaActual.Cells[2].Value.ToString();
        }

        private void btnAtrasCatMetodoPago_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
