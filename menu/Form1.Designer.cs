
namespace menu
{
    partial class panelConteudo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelConteudo));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.produto = new System.Windows.Forms.Button();
            this.CONTAS = new System.Windows.Forms.Button();
            this.COMPRAS = new System.Windows.Forms.Button();
            this.VENDAS = new System.Windows.Forms.Button();
            this.CLIENTES = new System.Windows.Forms.Button();
            this.panelCabecalho.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelCabecalho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCabecalho.BackgroundImage")));
            this.panelCabecalho.Controls.Add(this.panel2);
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Location = new System.Drawing.Point(-5, -1);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1692, 56);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCabecalho_Paint);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 386);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE VENDAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.produto);
            this.panel3.Controls.Add(this.CONTAS);
            this.panel3.Controls.Add(this.COMPRAS);
            this.panel3.Controls.Add(this.VENDAS);
            this.panel3.Controls.Add(this.CLIENTES);
            this.panel3.Location = new System.Drawing.Point(1, 51);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 599);
            this.panel3.TabIndex = 1;
            // 
            // produto
            // 
            this.produto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.produto.Location = new System.Drawing.Point(2, 105);
            this.produto.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.produto.Name = "produto";
            this.produto.Size = new System.Drawing.Size(168, 45);
            this.produto.TabIndex = 4;
            this.produto.Text = "PRODUTO";
            this.produto.UseVisualStyleBackColor = true;
            this.produto.Click += new System.EventHandler(this.produto_Click);
            // 
            // CONTAS
            // 
            this.CONTAS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CONTAS.Location = new System.Drawing.Point(2, 337);
            this.CONTAS.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CONTAS.Name = "CONTAS";
            this.CONTAS.Size = new System.Drawing.Size(168, 45);
            this.CONTAS.TabIndex = 3;
            this.CONTAS.Text = "CONTAS";
            this.CONTAS.UseVisualStyleBackColor = true;
            this.CONTAS.Click += new System.EventHandler(this.CONTAS_Click);
            // 
            // COMPRAS
            // 
            this.COMPRAS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.COMPRAS.Location = new System.Drawing.Point(2, 178);
            this.COMPRAS.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.COMPRAS.Name = "COMPRAS";
            this.COMPRAS.Size = new System.Drawing.Size(168, 45);
            this.COMPRAS.TabIndex = 2;
            this.COMPRAS.Text = "COMPRAS";
            this.COMPRAS.UseVisualStyleBackColor = true;
            this.COMPRAS.Click += new System.EventHandler(this.COMPRAS_Click);
            // 
            // VENDAS
            // 
            this.VENDAS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VENDAS.Location = new System.Drawing.Point(2, 255);
            this.VENDAS.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.VENDAS.Name = "VENDAS";
            this.VENDAS.Size = new System.Drawing.Size(168, 45);
            this.VENDAS.TabIndex = 2;
            this.VENDAS.Text = "VENDAS";
            this.VENDAS.UseVisualStyleBackColor = true;
            this.VENDAS.Click += new System.EventHandler(this.VENDAS_Click);
            // 
            // CLIENTES
            // 
            this.CLIENTES.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CLIENTES.Location = new System.Drawing.Point(2, 30);
            this.CLIENTES.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CLIENTES.Name = "CLIENTES";
            this.CLIENTES.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CLIENTES.Size = new System.Drawing.Size(168, 45);
            this.CLIENTES.TabIndex = 0;
            this.CLIENTES.Text = "CLIENTES";
            this.CLIENTES.UseVisualStyleBackColor = true;
            this.CLIENTES.Click += new System.EventHandler(this.CLIENTES_Click);
            // 
            // panelConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 685);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelCabecalho);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "panelConteudo";
            this.Text = "RNTSCN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CONTAS;
        private System.Windows.Forms.Button COMPRAS;
        private System.Windows.Forms.Button VENDAS;
        private System.Windows.Forms.Button CLIENTES;
        private System.Windows.Forms.Button produto;
        private System.Windows.Forms.Label label1;
    }
}

