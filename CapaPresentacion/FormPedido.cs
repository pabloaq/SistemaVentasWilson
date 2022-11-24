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
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            InitializeComponent();
            listarPedido();
        }

        public void listarPedido()
        {
            dgvPedido.DataSource = logPedido.Instancia.ListarPedido();
        }
        private void limpiarVariables ()
        {
            txtPedidoID.Text = "";
            txtNombreCiente.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarVariables();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entPedido Pedido = new entPedido();
                Pedido.nombreCliente = txtNombreCiente.Text.Trim();
                logPedido.Instancia.InsertaPedido(Pedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            listarPedido();
        }

        private void dgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPedido.Rows[e.RowIndex];
            txtPedidoID.Text = filaActual.Cells[0].Value.ToString();
            txtNombreCiente.Text = filaActual.Cells[1].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entPedido Pedido = new entPedido();
                Pedido.PeidoId = int.Parse(txtPedidoID.Text.Trim());
                Pedido.nombreCliente = txtNombreCiente.Text.Trim();
                logPedido.Instancia.EditaPedido(Pedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            listarPedido();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entPedido Pedido = new entPedido();

                Pedido.PeidoId = int.Parse(txtPedidoID.Text.Trim());
                Pedido.estado = -1;
                logPedido.Instancia.DeshabilitarPedido(Pedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            listarPedido();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FormDetallePedido detpe = new FormDetallePedido();
            Hide();
            detpe.ShowDialog();
            Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormInicio inicio = new FormInicio();
            Hide();
            inicio.ShowDialog();
            Close();
        }
    }
}
