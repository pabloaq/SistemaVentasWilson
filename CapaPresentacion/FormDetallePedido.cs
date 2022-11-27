using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormDetallePedido : Form
    {
        public FormDetallePedido()
        {
            InitializeComponent();
            listarDetallePedido();
            listarDatosComboBoxPedido();
            listarDatosComboBoxProducto();
        }

        public void listarDetallePedido()
        {
            dgvDetPedido.DataSource = logDetallePedido.Instancia.ListarDetallePedido();
        }

        private void listarDatosComboBoxPedido()
        {
            cmbPedidoId.DataSource = logPedido.Instancia.ListarPedido();
            cmbPedidoId.DisplayMember = "nombreCliente";
            cmbPedidoId.ValueMember = "PeidoId";
        }
        private void listarDatosComboBoxProducto()
        {
            cmbProductoId.DataSource = logProducto.GetInstancia.ListarProducto();
            cmbProductoId.DisplayMember = "nombre";
            cmbProductoId.ValueMember = "ProductoID";
        }

        private void dgvDetPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDetPedido.Rows[e.RowIndex];
            cmbPedidoId.SelectedIndex = 0; //int.Parse(filaActual.Cells[0].Value.ToString())-1;
            cmbProductoId.SelectedIndex = int.Parse(filaActual.Cells[1].Value.ToString())-1;
            nudCantidad.Value = int.Parse(filaActual.Cells[2].Value.ToString());
        }

        private void limpiarVariables()
        {
            cmbPedidoId.SelectedIndex = 0;
            cmbProductoId.SelectedIndex = 0;
            nudCantidad.Value = 1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarVariables();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entDetallePedido detPedido = new entDetallePedido();
                detPedido.PedidoId = Convert.ToInt32(cmbPedidoId.SelectedValue);
                detPedido.ProductoId = Convert.ToInt32(cmbProductoId.SelectedValue);
                detPedido.cantidad = Convert.ToInt32(nudCantidad.Value);
                logDetallePedido.Instancia.InsertaDetallePedido(detPedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            listarDetallePedido();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entDetallePedido detPedido = new entDetallePedido();
                detPedido.PedidoId = Convert.ToInt32(cmbPedidoId.SelectedValue);
                detPedido.ProductoId = Convert.ToInt32(cmbProductoId.SelectedValue);
                detPedido.cantidad = int.Parse(nudCantidad.Value.ToString());
                logDetallePedido.Instancia.EditaDetallePedido(detPedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            listarDetallePedido();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entDetallePedido detPedido = new entDetallePedido();
                detPedido.PedidoId = Convert.ToInt32(cmbPedidoId.SelectedValue);
                detPedido.ProductoId = Convert.ToInt32(cmbProductoId.SelectedValue);
                logDetallePedido.Instancia.eliminarDetallePedido(detPedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            listarDetallePedido();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormPedido pedido = new FormPedido();
            Hide();
            pedido.ShowDialog();
            Close();
        }
    }
}
