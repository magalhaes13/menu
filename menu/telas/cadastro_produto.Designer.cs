﻿
namespace menu.telas
{
    partial class cadastro_produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_produto));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonNewProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCODPRODUTO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.LimparProduto = new System.Windows.Forms.Button();
            this.txtIDPRODUTOESCONDIDO = new System.Windows.Forms.TextBox();
            this.ExcluirProduto = new System.Windows.Forms.Button();
            this.SalvarProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeProd = new System.Windows.Forms.TextBox();
            this.tabPagePESQUISA = new System.Windows.Forms.TabPage();
            this.textBoxPesquisaVestidos = new System.Windows.Forms.TextBox();
            this.button_AtualizarProd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCloseProducts = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPagePESQUISA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPagePESQUISA);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1155, 1000);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Goldenrod;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.buttonNewProduct);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textCODPRODUTO);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxQuantidade);
            this.tabPage1.Controls.Add(this.LimparProduto);
            this.tabPage1.Controls.Add(this.txtIDPRODUTOESCONDIDO);
            this.tabPage1.Controls.Add(this.ExcluirProduto);
            this.tabPage1.Controls.Add(this.SalvarProduto);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxDescricao);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxValor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxNomeProd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1147, 974);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CADASTRO";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonNewProduct
            // 
            this.buttonNewProduct.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewProduct.ForeColor = System.Drawing.Color.White;
            this.buttonNewProduct.Location = new System.Drawing.Point(193, 422);
            this.buttonNewProduct.Name = "buttonNewProduct";
            this.buttonNewProduct.Size = new System.Drawing.Size(124, 40);
            this.buttonNewProduct.TabIndex = 15;
            this.buttonNewProduct.Text = "NOVO";
            this.buttonNewProduct.UseVisualStyleBackColor = false;
            this.buttonNewProduct.Click += new System.EventHandler(this.buttonNewProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(469, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "VESTIDOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(87, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "CÓDIGO PRODUTO:";
            // 
            // textCODPRODUTO
            // 
            this.textCODPRODUTO.Location = new System.Drawing.Point(306, 104);
            this.textCODPRODUTO.Name = "textCODPRODUTO";
            this.textCODPRODUTO.Size = new System.Drawing.Size(144, 20);
            this.textCODPRODUTO.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(43, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "QUANTIDADE:";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(207, 171);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(57, 20);
            this.textBoxQuantidade.TabIndex = 3;
            // 
            // LimparProduto
            // 
            this.LimparProduto.BackColor = System.Drawing.Color.Yellow;
            this.LimparProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimparProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimparProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.LimparProduto.Location = new System.Drawing.Point(699, 422);
            this.LimparProduto.Name = "LimparProduto";
            this.LimparProduto.Size = new System.Drawing.Size(124, 40);
            this.LimparProduto.TabIndex = 9;
            this.LimparProduto.Text = "LIMPAR";
            this.LimparProduto.UseVisualStyleBackColor = false;
            this.LimparProduto.Click += new System.EventHandler(this.LimparProduto_Click);
            // 
            // txtIDPRODUTOESCONDIDO
            // 
            this.txtIDPRODUTOESCONDIDO.Location = new System.Drawing.Point(865, 6);
            this.txtIDPRODUTOESCONDIDO.Multiline = true;
            this.txtIDPRODUTOESCONDIDO.Name = "txtIDPRODUTOESCONDIDO";
            this.txtIDPRODUTOESCONDIDO.Size = new System.Drawing.Size(59, 19);
            this.txtIDPRODUTOESCONDIDO.TabIndex = 8;
            this.txtIDPRODUTOESCONDIDO.Visible = false;
            // 
            // ExcluirProduto
            // 
            this.ExcluirProduto.BackColor = System.Drawing.Color.Red;
            this.ExcluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.ExcluirProduto.Location = new System.Drawing.Point(536, 422);
            this.ExcluirProduto.Name = "ExcluirProduto";
            this.ExcluirProduto.Size = new System.Drawing.Size(124, 40);
            this.ExcluirProduto.TabIndex = 7;
            this.ExcluirProduto.Text = "EXCLUIR";
            this.ExcluirProduto.UseVisualStyleBackColor = false;
            this.ExcluirProduto.Click += new System.EventHandler(this.ExcluirProduto_Click);
            // 
            // SalvarProduto
            // 
            this.SalvarProduto.BackColor = System.Drawing.Color.Green;
            this.SalvarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalvarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalvarProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.SalvarProduto.Location = new System.Drawing.Point(357, 422);
            this.SalvarProduto.Name = "SalvarProduto";
            this.SalvarProduto.Size = new System.Drawing.Size(124, 40);
            this.SalvarProduto.TabIndex = 6;
            this.SalvarProduto.Text = "SALVAR";
            this.SalvarProduto.UseVisualStyleBackColor = false;
            this.SalvarProduto.Click += new System.EventHandler(this.SalvarProduto_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(633, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESCRIÇÃO:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(782, 175);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(274, 144);
            this.textBoxDescricao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(43, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "VALOR:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(135, 246);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(165, 20);
            this.textBoxValor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(694, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME:";
            // 
            // textBoxNomeProd
            // 
            this.textBoxNomeProd.Location = new System.Drawing.Point(782, 108);
            this.textBoxNomeProd.Name = "textBoxNomeProd";
            this.textBoxNomeProd.Size = new System.Drawing.Size(201, 20);
            this.textBoxNomeProd.TabIndex = 2;
            // 
            // tabPagePESQUISA
            // 
            this.tabPagePESQUISA.BackColor = System.Drawing.Color.Goldenrod;
            this.tabPagePESQUISA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPagePESQUISA.Controls.Add(this.textBoxPesquisaVestidos);
            this.tabPagePESQUISA.Controls.Add(this.button_AtualizarProd);
            this.tabPagePESQUISA.Controls.Add(this.dataGridView1);
            this.tabPagePESQUISA.Location = new System.Drawing.Point(4, 22);
            this.tabPagePESQUISA.Name = "tabPagePESQUISA";
            this.tabPagePESQUISA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePESQUISA.Size = new System.Drawing.Size(1147, 974);
            this.tabPagePESQUISA.TabIndex = 1;
            this.tabPagePESQUISA.Text = "PESQUISA";
            this.tabPagePESQUISA.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBoxPesquisaVestidos
            // 
            this.textBoxPesquisaVestidos.Location = new System.Drawing.Point(138, 82);
            this.textBoxPesquisaVestidos.Name = "textBoxPesquisaVestidos";
            this.textBoxPesquisaVestidos.Size = new System.Drawing.Size(194, 20);
            this.textBoxPesquisaVestidos.TabIndex = 2;
            // 
            // button_AtualizarProd
            // 
            this.button_AtualizarProd.BackColor = System.Drawing.Color.White;
            this.button_AtualizarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AtualizarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AtualizarProd.Location = new System.Drawing.Point(42, 82);
            this.button_AtualizarProd.Name = "button_AtualizarProd";
            this.button_AtualizarProd.Size = new System.Drawing.Size(90, 23);
            this.button_AtualizarProd.TabIndex = 1;
            this.button_AtualizarProd.Text = "PESQUISAR";
            this.button_AtualizarProd.UseVisualStyleBackColor = false;
            this.button_AtualizarProd.Click += new System.EventHandler(this.button_AtualizarProd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUTO,
            this.CODPRODUTO,
            this.NOME,
            this.VALOR,
            this.DESCRICAO,
            this.QUANTIDADE});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(42, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 433);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID_PRODUTO
            // 
            this.ID_PRODUTO.DataPropertyName = "ID_PRODUTO";
            this.ID_PRODUTO.HeaderText = "ID";
            this.ID_PRODUTO.Name = "ID_PRODUTO";
            // 
            // CODPRODUTO
            // 
            this.CODPRODUTO.DataPropertyName = "CODPRODUTO";
            this.CODPRODUTO.HeaderText = "COD PRODUTO";
            this.CODPRODUTO.Name = "CODPRODUTO";
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.Width = 200;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "VALOR";
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Width = 400;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.DataPropertyName = "QUANTIDADE";
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.buttonCloseProducts);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 22);
            this.panel1.TabIndex = 2;
            // 
            // buttonCloseProducts
            // 
            this.buttonCloseProducts.BackColor = System.Drawing.Color.Black;
            this.buttonCloseProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCloseProducts.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonCloseProducts.Location = new System.Drawing.Point(1142, -1);
            this.buttonCloseProducts.Name = "buttonCloseProducts";
            this.buttonCloseProducts.Size = new System.Drawing.Size(31, 23);
            this.buttonCloseProducts.TabIndex = 16;
            this.buttonCloseProducts.Text = "X";
            this.buttonCloseProducts.UseVisualStyleBackColor = false;
            this.buttonCloseProducts.Click += new System.EventHandler(this.buttonCloseProducts_Click);
            // 
            // cadastro_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(12, 28);
            this.Name = "cadastro_produto";
            this.Text = "VESTIDOS";
            this.Load += new System.EventHandler(this.cadastro_produto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPagePESQUISA.ResumeLayout(false);
            this.tabPagePESQUISA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeProd;
        private System.Windows.Forms.TabPage tabPagePESQUISA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SalvarProduto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ExcluirProduto;
        private System.Windows.Forms.Button button_AtualizarProd;
        private System.Windows.Forms.TextBox txtIDPRODUTOESCONDIDO;
        private System.Windows.Forms.Button LimparProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCODPRODUTO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPesquisaVestidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCloseProducts;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button buttonNewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
    }
}