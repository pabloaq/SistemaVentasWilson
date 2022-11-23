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
    public partial class MantenedorMetodoPago : Form
    {
        public MantenedorMetodoPago()
        {
            InitializeComponent();
            ListarMetodoPago();
        }

        private void LimpiarVariables()
        {
            txtMetodoPago.Text = "";
            txtCategoriaMetodoPago.Text = "";
            txtNombreMetodoPago.Text = "";
            txtDescripcionMetodoPago.Text = "";
        }
        public void ListarMetodoPago()
        {
            dgvMetodoPago.DataSource = logMantenedorMetodoPago.GetInstancia.ListarMetodoPago();
        }

        private void btnAgregarMetodoPago_Click(object sender, EventArgs e)
        {
            try
            {
                entMantenedorMetodoPago MetodoPago = new entMantenedorMetodoPago();
                MetodoPago.MetodopagoID = Convert.ToInt32(txtMetodoPago.Text.Trim());
                MetodoPago.CategoriametodopagoID = Convert.ToInt32(txtCategoriaMetodoPago.Text.Trim());
                MetodoPago.nombre = txtNombreMetodoPago.Text;
                MetodoPago.descripcion = txtDescripcionMetodoPago.Text;
                logMantenedorMetodoPago.GetInstancia.InsertarMetodoPago(MetodoPago);
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
                entMantenedorMetodoPago MetodoPago = new entMantenedorMetodoPago();
                MetodoPago.MetodopagoID = Convert.ToInt32(txtMetodoPago.Text.Trim());
                MetodoPago.CategoriametodopagoID = Convert.ToInt32(txtCategoriaMetodoPago.Text.Trim());
                MetodoPago.nombre = txtNombreMetodoPago.Text;
                MetodoPago.descripcion = txtDescripcionMetodoPago.Text;
                logMantenedorMetodoPago.GetInstancia.ModificarMetodoPago(MetodoPago);
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
                entMantenedorMetodoPago MetodoPago = new entMantenedorMetodoPago();

                MetodoPago.MetodopagoID = Convert.ToInt32(txtMetodoPago.Text.Trim());

                logMantenedorMetodoPago.GetInstancia.EliminarMetodoPago(MetodoPago);
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
            txtCategoriaMetodoPago.Text = filaActual.Cells[1].Value.ToString();
            txtNombreMetodoPago.Text = filaActual.Cells[2].Value.ToString();
            txtDescripcionMetodoPago.Text = filaActual.Cells[3].Value.ToString();
        }
    }
}
