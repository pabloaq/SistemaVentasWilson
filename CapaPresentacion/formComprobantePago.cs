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
    public partial class formComprobantePago : Form
    {
        int x = 0, y = 0;
        public formComprobantePago()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtCodigoCom.Text=="1")
            {
                txtCodigoCom.Text = "";
                txtCodigoCom.ForeColor = Color.Gray;
            }
        }

        private void txtCodigoCom_Leave(object sender, EventArgs e)
        {
            if (txtCodigoCom.Text == "")
            {
                txtCodigoCom.Text = "1";
                txtCodigoCom.ForeColor = Color.Gray;
            }
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
