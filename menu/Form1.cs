using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using menu.telas;

namespace menu
{
    public partial class panelConteudo : Form
    {
        public const int WM_NCLBUTTONWOEN = 0XA1;
        public const int HT_CAPTION = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public panelConteudo()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONWOEN, HT_CAPTION, 0);
            }
        }

        private void panelCabecalho_Paint(object sender, PaintEventArgs e)
        {

        }

        private cadastro_cliente Form = null;
        private void CLIENTES_Click(object sender, EventArgs e)
        {
            {
                this.Form = new cadastro_cliente();
                this.Form.TopLevel = false;
                this.Form.Visible = true;
                this.Controls.Add(this.Form);
                this.ArrangeFormSize1();

            }
        }

        private void ArrangeFormSize1()
        {
            this.Form.Location = new Point(
                this.ClientSize.Width - this.Form.Width,
            this.ClientSize.Height - this.Form.Height + 16);
        }

    }
}