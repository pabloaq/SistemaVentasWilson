using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormMetodoPago : Form
    {
        public FormMetodoPago()
        {
            InitializeComponent();
            llenarComboBoxCategoriaMetodoPago();
            ListarMetodoPago();
        }

        private void llenarComboBoxCategoriaMetodoPago()
        {
            cbCategoriaMetodoPago.DataSource = logCategoriaMetodoPago.Instancia.ListarCategoriaMetodoPago();
            cbCategoriaMetodoPago.DisplayMember = "idCategoriaMetodoPago";
            cbCategoriaMetodoPago.ValueMember = "nombreCategoria";
        }


        private void LimpiarVariables()
        {
            txtMetodoPago.Text = "";
            cbCategoriaMetodoPago.Text = "";
            txtNombreMetodoPago.Text = "";
            txtDescripcionMetodoPago.Text = "";
        }
        public void ListarMetodoPago()
        {
            dgvMetodoPago.DataSource = logMetodoPago.GetInstancia.ListarMetodoPago();
        }

        private void btnAgregarMetodoPago_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago MetodoPago = new entMetodoPago();
                MetodoPago.MetodopagoID = Convert.ToInt32(txtMetodoPago.Text.Trim());
                MetodoPago.CategoriametodopagoID = Convert.ToInt32(cbCategoriaMetodoPago.SelectedValue);
                MetodoPago.nombre = txtNombreMetodoPago.Text;
                MetodoPago.descripcion = txtDescripcionMetodoPago.Text;

                logMetodoPago.GetInstancia.InsertarMetodoPago(MetodoPago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            LimpiarVariables();
            ListarMetodoPago();
        }

        private void btnModificarMetodoPago_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago MetodoPago = new entMetodoPago();

                MetodoPago.MetodopagoID = Convert.ToInt32(txtMetodoPago.Text.Trim());
                MetodoPago.CategoriametodopagoID = Convert.ToInt32(cbCategoriaMetodoPago.SelectedValue);
                MetodoPago.nombre = txtNombreMetodoPago.Text;
                MetodoPago.descripcion = txtDescripcionMetodoPago.Text;

                logMetodoPago.GetInstancia.ModificarMetodoPago(MetodoPago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            LimpiarVariables();
            ListarMetodoPago();
        }

        private void btnEliminarMetodoPago_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago MetodoPago = new entMetodoPago();

                MetodoPago.MetodopagoID = Convert.ToInt32(txtMetodoPago.Text.Trim());

                logMetodoPago.GetInstancia.EliminarMetodoPago(MetodoPago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            LimpiarVariables();
            ListarMetodoPago();
        }

        private void dgvMetodoPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMetodoPago.Rows[e.RowIndex];

            txtMetodoPago.Text = filaActual.Cells[0].Value.ToString();
            cbCategoriaMetodoPago.Text = filaActual.Cells[1].Value.ToString();
            txtNombreMetodoPago.Text = filaActual.Cells[2].Value.ToString();
            txtDescripcionMetodoPago.Text = filaActual.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
