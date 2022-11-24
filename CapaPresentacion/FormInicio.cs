using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            Hide();
            login.ShowDialog();
            Close();
        }
        
        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormPedido pedido = new FormPedido();
            Hide();
            pedido.ShowDialog();
            Close();
        }
    }
}
