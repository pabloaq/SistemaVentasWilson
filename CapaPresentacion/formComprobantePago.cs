using CapaEntidad;
using CapaLogica;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formComprobantePago : Form
    {
        int x = 0, y = 0;
        public formComprobantePago()
        {
            InitializeComponent();     
            txtCodigoCom.Enabled = false;
            MostrarLocalCBX();

        }
        private void MostrarLocalCBX()
        {
            cbxIdLocal.DataSource = logLocal.GetInstancia.ListarLocal();
            cbxIdLocal.DisplayMember = "nombre";
            cbxIdLocal.ValueMember = "LocalID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnRealizarComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                entComprobante comprobante = new entComprobante();
                comprobante.PedidoID = Convert.ToInt32(cbxIdPedido.Text);
                comprobante.MetodopagoID = Convert.ToInt32(cbxMetodoPago.Text);
                //comprobante.LocalID = Convert.ToInt32(cbxIdLocal.Text);
                comprobante.LocalID = Convert.ToInt32(cbxIdLocal.SelectedValue);
                comprobante.montoTotal = float.Parse(txtTotal.Text);


                //MessageBox.Show(logComprobante.GetInstancia.VerificarMontoTotal(comprobante).ToString());

                if (comprobante.montoTotal == logComprobante.GetInstancia.VerificarMontoTotal(comprobante))
                {
                    MessageBox.Show("Monto total ha sido verificado correctamente");
                    logComprobante.GetInstancia.InsertarDatosComprobante(comprobante);
                    MessageBox.Show("Comprobante generado correctamente");
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

  

    }



}

