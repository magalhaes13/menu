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

        //todos os botoes do menu aq

        private cadastro_cliente Form = null;
        private cadastro_produto Form1 = null;
        private compra_produto Form2 = null;
        private cadastro_vendas Form3 = null;
        private contas Form4 = null;

        //cliente
        private void CLIENTES_Click(object sender, EventArgs e)
        {
            {
                this.Form = new cadastro_cliente();
                this.Form.TopLevel = false;
                this.Form.Visible = true;
                this.Controls.Add(this.Form);
                this.ArrangeFormSize0();

            }
        }
        private void ArrangeFormSize0()
        {
            this.Form.Location = new Point(
                this.ClientSize.Width - this.Form.Width,
            this.ClientSize.Height - this.Form.Height + 16);
        }

        //produto
        private void produto_Click(object sender, EventArgs e)
        {
            this.Form1 = new cadastro_produto();
            this.Form1.TopLevel = false;
            this.Form1.Visible = true;
            this.Controls.Add(this.Form1);
            this.ArrangeFormSize1();
        }
        private void ArrangeFormSize1()
        {
            this.Form1.Location = new Point(
                this.ClientSize.Width - this.Form1.Width,
            this.ClientSize.Height - this.Form1.Height + 16);
        }

        //compra
        private void COMPRAS_Click(object sender, EventArgs e)
        {
            this.Form2 = new compra_produto();
            this.Form2.TopLevel = false;
            this.Form2.Visible = true;
            this.Controls.Add(this.Form2);
            this.ArrangeFormSize2();
        }
        private void ArrangeFormSize2()
        {
            this.Form2.Location = new Point(
                this.ClientSize.Width - this.Form2.Width,
            this.ClientSize.Height - this.Form2.Height + 16);
        }

        //vendas
        private void VENDAS_Click(object sender, EventArgs e)
        {
            this.Form3 = new cadastro_vendas();
            this.Form3.TopLevel = false;
            this.Form3.Visible = true;
            this.Controls.Add(this.Form3);
            this.ArrangeFormSize3();
        }
        private void ArrangeFormSize3()
        {
            this.Form3.Location = new Point(
                this.ClientSize.Width - this.Form3.Width,
            this.ClientSize.Height - this.Form3.Height + 16);
        }

        //contas
        private void CONTAS_Click(object sender, EventArgs e)
        {
            //this.Form4 = new contas();
            this.Form4.TopLevel = false;
            this.Form4.Visible = true;
            this.Controls.Add(this.Form4);
            this.ArrangeFormSize4();
        }
        private void ArrangeFormSize4()
        {
            this.Form4.Location = new Point(
                this.ClientSize.Width - this.Form4.Width,
            this.ClientSize.Height - this.Form4.Height + 16);
        }
    }
}