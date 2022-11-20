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
            listarPeido();
        }

        public void listarPeido()
        {
            dgvPedido.DataSource = logPedido.Instancia.ListarPedido();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPedidoID.Text = "";
            txtNombreCiente.Text = "";
        }
    }
}
