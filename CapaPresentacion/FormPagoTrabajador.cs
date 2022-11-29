using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPagoTrabajador : Form
    {
        public FormPagoTrabajador()
        {
            InitializeComponent();
            ListarComboBoxIDEmpleado();
            Listar();
        }

        public void Listar() => dgvPagoTrabajador.DataSource = logPagoTrabajador.GetInstancia.ListarPagoTrabajador();

        private void ListarComboBoxIDEmpleado()
        {
            cbIdEmpleado.DataSource = logTipoPersonal.GetInstancia.ListarTipoPersonal();
            cbIdEmpleado.DisplayMember = "nombre";
            cbIdEmpleado.ValueMember = "TipopersonalID";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPagoTrabajador.Rows[e.RowIndex];

            dpFechaRegistro.Text = filaActual.Cells[0].Value.ToString();
            cbIdEmpleado.Text = filaActual.Cells[1].Value.ToString();
            txtSueldo.Text = filaActual.Cells[2].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSueldo.Text = "";
            cbIdEmpleado.Text = "";
            dpFechaRegistro.Text = "";
        }

        public void limpiarVariables()
        {
            txtSueldo.Text = "";
            cbIdEmpleado.Text = "";
            dpFechaRegistro.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entPagoTrabajador entPago = new entPagoTrabajador
                {
                    PersonalID = Convert.ToInt32(cbIdEmpleado.SelectedValue),
                    fechaRegistro = dpFechaRegistro.Value,
                    sueldo = Convert.ToSingle(txtSueldo.Text),

                };

                logPagoTrabajador.GetInstancia.InsertarPagoTrabajador(entPago);

            }catch(Exception ex) { 
                MessageBox.Show("Error" + ex.Message); 
            }

            Listar();
            limpiarVariables();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
