using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PagoTrabajador : Form
    {
        public PagoTrabajador()
        {
            InitializeComponent();
            Listar();
        }

        public void Listar() => dgvPagoTrabajador.DataSource = logPagoTrabajador.GetInstancia.ListarPagoTrabajador();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPagoTrabajador.Rows[e.RowIndex];

            dpFechaRegistro.Text = filaActual.Cells[1].Value.ToString();
            txtPersonalID.Text = filaActual.Cells[2].Value.ToString();
            txtSueldo.Text = filaActual.Cells[3].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPersonalID.Text = "";
            txtSueldo.Text = "";
            dpFechaRegistro.Text = "";
        }

        public void limpiarVariables()
        {
            txtPersonalID.Text = "";
            txtSueldo.Text = "";
            dpFechaRegistro.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entPagoTrabajador entPago = new entPagoTrabajador
                {
                    fechaRegistro = dpFechaRegistro.Value,
                    PersonalID = Convert.ToInt32(txtPersonalID.Text),
                    sueldo = Convert.ToSingle(txtSueldo.Text),

                };

                logPagoTrabajador.GetInstancia.InsertarPagoTrabajador(entPago);

            }catch(Exception ex) { 
                MessageBox.Show("Error" + ex.Message); 
            }
            limpiarVariables();
            Listar();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
