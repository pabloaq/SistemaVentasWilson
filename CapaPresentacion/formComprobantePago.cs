using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formComprobantePago : Form
    {
        int x = 0, y = 0;
        public formComprobantePago()
        {
            InitializeComponent();
            //txtCodigoCom.Enabled = false;
            listarMetodoPagoComboBox();
            listarPedidosIdComboBox();
            llenarDatosComboBoxLocal();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listarPedidosIdComboBox()
        {
            cbxIdPedido.DataSource = logPedido.Instancia.ListarPedido();
            cbxIdPedido.DisplayMember = "nombreCliente";
            cbxIdPedido.ValueMember = "PeidoId";
        }

        private void listarMetodoPagoComboBox()
        {
            cbxMetodoPago.DataSource = logCategoriaMetodoPago.Instancia.ListarCategoriaMetodoPago();
            cbxMetodoPago.DisplayMember = "nombreCategoria";
            cbxMetodoPago.ValueMember = "idCategoriaMetodoPago";
        }
        private void llenarDatosComboBoxLocal()
        {
            cbxIdLocal.DataSource = logLocal.GetInstancia.ListarLocal();
            cbxIdLocal.DisplayMember = "nombre";
            cbxIdLocal.ValueMember = "idLocal";

        }
        private void btnRealizarComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                entComprobante comprobante = new entComprobante();
                comprobante.PedidoID = Convert.ToInt32(cbxIdPedido.SelectedValue);
                comprobante.MetodopagoID = Convert.ToInt32(cbxMetodoPago.SelectedValue);
                comprobante.LocalID = Convert.ToInt32(cbxIdLocal.SelectedValue);
                comprobante.montoTotal = float.Parse(txtTotal.Text);


                if (comprobante.montoTotal == logComprobante.GetInstancia.VerificarMontoTotal(comprobante))
                {
                    MessageBox.Show("Monto total ha sido verificado correctamente");
                    logComprobante.GetInstancia.InsertarDatosComprobante(comprobante);
                    entPedido pedido = new entPedido();
                    pedido.estado = 1;
                    pedido.PeidoId = comprobante.PedidoID;
                    logPedido.Instancia.DeshabilitarPedido(pedido);
                    MessageBox.Show("Comprobante generado correctamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("El monto ingresado no coincide con el monto de su pedido");

                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el comprobante" + ex);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxIdPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            entComprobante comprobante = new entComprobante();
            comprobante.PedidoID = Convert.ToInt32(cbxIdPedido.SelectedValue);

            lbMontoTotal.Text = logComprobante.GetInstancia.VerificarMontoTotal(comprobante).ToString();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                Left = Left + (e.X - x);
                Top = Top + (e.Y - y);
            }
        }
    }
}
