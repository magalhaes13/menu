
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.COMPRAS = new System.Windows.Forms.Button();
            this.produto = new System.Windows.Forms.Button();
            this.CLIENTES = new System.Windows.Forms.Button();
            this.CONTAS = new System.Windows.Forms.Button();
            this.VENDAS = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.labelDataa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.buttonLogo);
            this.panel3.Controls.Add(this.COMPRAS);
            this.panel3.Controls.Add(this.produto);
            this.panel3.Controls.Add(this.CLIENTES);
            this.panel3.Controls.Add(this.CONTAS);
            this.panel3.Controls.Add(this.VENDAS);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 685);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // COMPRAS
            // 
            this.COMPRAS.BackColor = System.Drawing.Color.Black;
            this.COMPRAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.COMPRAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.COMPRAS.FlatAppearance.BorderSize = 0;
            this.COMPRAS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.COMPRAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMPRAS.Font = new System.Drawing.Font("Segoe Script", 15.75F);
            this.COMPRAS.ForeColor = System.Drawing.SystemColors.Window;
            this.COMPRAS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.COMPRAS.Location = new System.Drawing.Point(-11, 330);
            this.COMPRAS.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.COMPRAS.Name = "COMPRAS";
            this.COMPRAS.Size = new System.Drawing.Size(184, 101);
            this.COMPRAS.TabIndex = 2;
            this.COMPRAS.Text = "CONTRATO";
            this.COMPRAS.UseVisualStyleBackColor = false;
            this.COMPRAS.Click += new System.EventHandler(this.COMPRAS_Click);
            // 
            // produto
            // 
            this.produto.BackColor = System.Drawing.Color.Black;
            this.produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produto.FlatAppearance.BorderSize = 0;
            this.produto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produto.Font = new System.Drawing.Font("Segoe Script", 15.75F);
            this.produto.ForeColor = System.Drawing.SystemColors.Window;
            this.produto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.produto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.produto.Location = new System.Drawing.Point(-11, 230);
            this.produto.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.produto.Name = "produto";
            this.produto.Size = new System.Drawing.Size(184, 101);
            this.produto.TabIndex = 4;
            this.produto.Text = "VESTIDOS";
            this.produto.UseVisualStyleBackColor = false;
            this.produto.Click += new System.EventHandler(this.produto_Click);
            // 
            // CLIENTES
            // 
            this.CLIENTES.BackColor = System.Drawing.Color.Black;
            this.CLIENTES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CLIENTES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CLIENTES.FlatAppearance.BorderSize = 0;
            this.CLIENTES.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CLIENTES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.CLIENTES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLIENTES.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLIENTES.ForeColor = System.Drawing.SystemColors.Window;
            this.CLIENTES.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CLIENTES.Location = new System.Drawing.Point(-11, 130);
            this.CLIENTES.Margin = new System.Windows.Forms.Padding(1000);
            this.CLIENTES.Name = "CLIENTES";
            this.CLIENTES.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CLIENTES.Size = new System.Drawing.Size(184, 101);
            this.CLIENTES.TabIndex = 0;
            this.CLIENTES.Text = "CLIENTES";
            this.CLIENTES.UseVisualStyleBackColor = false;
            this.CLIENTES.Click += new System.EventHandler(this.CLIENTES_Click);
            // 
            // CONTAS
            // 
            this.CONTAS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CONTAS.BackgroundImage")));
            this.CONTAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CONTAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CONTAS.FlatAppearance.BorderSize = 0;
            this.CONTAS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.CONTAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CONTAS.ForeColor = System.Drawing.SystemColors.Window;
            this.CONTAS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CONTAS.Location = new System.Drawing.Point(-11, 526);
            this.CONTAS.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CONTAS.Name = "CONTAS";
            this.CONTAS.Size = new System.Drawing.Size(184, 101);
            this.CONTAS.TabIndex = 3;
            this.CONTAS.Text = "CONTAS";
            this.CONTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CONTAS.UseVisualStyleBackColor = true;
            this.CONTAS.Click += new System.EventHandler(this.CONTAS_Click);
            // 
            // VENDAS
            // 
            this.VENDAS.BackColor = System.Drawing.Color.Black;
            this.VENDAS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VENDAS.BackgroundImage")));
            this.VENDAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VENDAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VENDAS.FlatAppearance.BorderSize = 0;
            this.VENDAS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.VENDAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VENDAS.ForeColor = System.Drawing.SystemColors.Window;
            this.VENDAS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VENDAS.Location = new System.Drawing.Point(-11, 426);
            this.VENDAS.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.VENDAS.Name = "VENDAS";
            this.VENDAS.Size = new System.Drawing.Size(184, 101);
            this.VENDAS.TabIndex = 2;
            this.VENDAS.Text = "VENDAS";
            this.VENDAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VENDAS.UseVisualStyleBackColor = false;
            this.VENDAS.Click += new System.EventHandler(this.VENDAS_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F);
            this.labelData.ForeColor = System.Drawing.Color.White;
            this.labelData.Location = new System.Drawing.Point(189, 672);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(0, 13);
            this.labelData.TabIndex = 2;
            // 
            // labelDataa
            // 
            this.labelDataa.AutoSize = true;
            this.labelDataa.BackColor = System.Drawing.Color.Transparent;
            this.labelDataa.ForeColor = System.Drawing.Color.White;
            this.labelDataa.Location = new System.Drawing.Point(148, 661);
            this.labelDataa.Name = "labelDataa";
            this.labelDataa.Size = new System.Drawing.Size(0, 13);
            this.labelDataa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(426, 672);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Versão 1.0";
            // 
            // buttonLogo
            // 
            this.buttonLogo.BackgroundImage = global::menu.Properties.Resources.flordeliz;
            this.buttonLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogo.Location = new System.Drawing.Point(-11, -7);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(184, 137);
            this.buttonLogo.TabIndex = 5;
            this.buttonLogo.UseVisualStyleBackColor = true;
            // 
            // panelConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::menu.Properties.Resources.flordeliz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDataa);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "panelConteudo";
            this.Text = "FLOR DE LIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CONTAS;
        private System.Windows.Forms.Button COMPRAS;
        private System.Windows.Forms.Button VENDAS;
        private System.Windows.Forms.Button CLIENTES;
        private System.Windows.Forms.Button produto;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelDataa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLogo;
    }
}

