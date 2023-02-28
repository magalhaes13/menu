
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
            this.label1 = new System.Windows.Forms.Label();
            this.CLIENTES = new Guna.UI2.WinForms.Guna2Button();
            this.produto = new Guna.UI2.WinForms.Guna2Button();
            this.COMPRAS = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.CONTAS = new System.Windows.Forms.Button();
            this.VENDAS = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 740);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Versão 1.0";
            // 
            // CLIENTES
            // 
            this.CLIENTES.BackColor = System.Drawing.Color.Transparent;
            this.CLIENTES.BorderRadius = 22;
            this.CLIENTES.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CLIENTES.Checked = true;
            this.CLIENTES.CheckedState.FillColor = System.Drawing.Color.White;
            this.CLIENTES.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.CLIENTES.CheckedState.Parent = this.CLIENTES;
            this.CLIENTES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CLIENTES.CustomImages.Parent = this.CLIENTES;
            this.CLIENTES.FillColor = System.Drawing.Color.Goldenrod;
            this.CLIENTES.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLIENTES.ForeColor = System.Drawing.Color.White;
            this.CLIENTES.HoverState.Parent = this.CLIENTES;
            this.CLIENTES.Location = new System.Drawing.Point(23, 150);
            this.CLIENTES.Name = "CLIENTES";
            this.CLIENTES.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.CLIENTES.ShadowDecoration.Parent = this.CLIENTES;
            this.CLIENTES.Size = new System.Drawing.Size(149, 43);
            this.CLIENTES.TabIndex = 5;
            this.CLIENTES.Text = "Clientes";
            this.CLIENTES.UseTransparentBackground = true;
            this.CLIENTES.CheckedChanged += new System.EventHandler(this.CLIENTES_CheckedChanged);
            this.CLIENTES.Click += new System.EventHandler(this.CLIENTES_Click);
            // 
            // produto
            // 
            this.produto.BackColor = System.Drawing.Color.Transparent;
            this.produto.BorderRadius = 22;
            this.produto.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.produto.CheckedState.FillColor = System.Drawing.Color.White;
            this.produto.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.produto.CheckedState.Parent = this.produto;
            this.produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produto.CustomImages.Parent = this.produto;
            this.produto.FillColor = System.Drawing.Color.Goldenrod;
            this.produto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produto.ForeColor = System.Drawing.Color.White;
            this.produto.HoverState.Parent = this.produto;
            this.produto.Location = new System.Drawing.Point(23, 300);
            this.produto.Name = "produto";
            this.produto.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.produto.ShadowDecoration.Parent = this.produto;
            this.produto.Size = new System.Drawing.Size(149, 43);
            this.produto.TabIndex = 6;
            this.produto.Text = "Vestidos";
            this.produto.UseTransparentBackground = true;
            this.produto.CheckedChanged += new System.EventHandler(this.CLIENTES_CheckedChanged);
            this.produto.Click += new System.EventHandler(this.produto_Click);
            // 
            // COMPRAS
            // 
            this.COMPRAS.BackColor = System.Drawing.Color.Transparent;
            this.COMPRAS.BorderRadius = 22;
            this.COMPRAS.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.COMPRAS.CheckedState.FillColor = System.Drawing.Color.White;
            this.COMPRAS.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.COMPRAS.CheckedState.Parent = this.COMPRAS;
            this.COMPRAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.COMPRAS.CustomImages.Parent = this.COMPRAS;
            this.COMPRAS.FillColor = System.Drawing.Color.Goldenrod;
            this.COMPRAS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPRAS.ForeColor = System.Drawing.Color.White;
            this.COMPRAS.HoverState.Parent = this.COMPRAS;
            this.COMPRAS.Location = new System.Drawing.Point(23, 450);
            this.COMPRAS.Name = "COMPRAS";
            this.COMPRAS.ShadowDecoration.Parent = this.COMPRAS;
            this.COMPRAS.Size = new System.Drawing.Size(149, 43);
            this.COMPRAS.TabIndex = 7;
            this.COMPRAS.Text = "Contrato";
            this.COMPRAS.UseTransparentBackground = true;
            this.COMPRAS.CheckedChanged += new System.EventHandler(this.CLIENTES_CheckedChanged);
            this.COMPRAS.Click += new System.EventHandler(this.COMPRAS_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.CLIENTES);
            this.panel1.Controls.Add(this.produto);
            this.panel1.Controls.Add(this.COMPRAS);
            this.panel1.Controls.Add(this.imgSlide);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 790);
            this.panel1.TabIndex = 8;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Goldenrod;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(57, 622);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(61, 51);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "Sair";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(-3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "_______________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(66, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "FLOR DE LIZ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::menu.Properties.Resources.fleur_de_lis_new_orleans_simbolo_dourado_logotipo_da_flor_icone_do_vetor_modelo_de_imagem_400_112543179_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imgSlide
            // 
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.Location = new System.Drawing.Point(141, 120);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(39, 101);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 9;
            this.imgSlide.TabStop = false;
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
            this.CONTAS.Location = new System.Drawing.Point(839, 323);
            this.CONTAS.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CONTAS.Name = "CONTAS";
            this.CONTAS.Size = new System.Drawing.Size(74, 61);
            this.CONTAS.TabIndex = 3;
            this.CONTAS.Text = "CONTAS";
            this.CONTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CONTAS.UseVisualStyleBackColor = false;
            this.CONTAS.Visible = false;
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
            this.VENDAS.Location = new System.Drawing.Point(917, 300);
            this.VENDAS.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.VENDAS.Name = "VENDAS";
            this.VENDAS.Size = new System.Drawing.Size(84, 55);
            this.VENDAS.TabIndex = 2;
            this.VENDAS.Text = "VENDAS";
            this.VENDAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VENDAS.UseVisualStyleBackColor = false;
            this.VENDAS.Visible = false;
            this.VENDAS.Click += new System.EventHandler(this.VENDAS_Click);
            // 
            // panelConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CONTAS);
            this.Controls.Add(this.VENDAS);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "panelConteudo";
            this.Text = "FLOR DE LIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CONTAS;
        private System.Windows.Forms.Button VENDAS;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button CLIENTES;
        private Guna.UI2.WinForms.Guna2Button produto;
        private Guna.UI2.WinForms.Guna2Button COMPRAS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgSlide;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

