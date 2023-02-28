
namespace menu.telas
{
    partial class compra_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compra_produto));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.compras = new System.Windows.Forms.TabPage();
            this.textBoxDataDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDataLocacao = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonNovoContrato = new System.Windows.Forms.Button();
            this.LimparCompra = new System.Windows.Forms.Button();
            this.ExcluirCompra = new System.Windows.Forms.Button();
            this.SalvarCompra = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.IDCOMPRAESCONDIDO = new System.Windows.Forms.TextBox();
            this.textBoxNomeCompras = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxIdEscondidoCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxComprasDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComprasValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pesquisa_compras = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATUALIZAR_COMPRA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCloseProducts = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.codVestido = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.compras.SuspendLayout();
            this.pesquisa_compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.compras);
            this.tabControl1.Controls.Add(this.pesquisa_compras);
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // compras
            // 
            this.compras.BackColor = System.Drawing.Color.Goldenrod;
            this.compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compras.Controls.Add(this.label9);
            this.compras.Controls.Add(this.codVestido);
            this.compras.Controls.Add(this.textBoxDataDevolucao);
            this.compras.Controls.Add(this.textBoxDataEntrega);
            this.compras.Controls.Add(this.textBoxDataLocacao);
            this.compras.Controls.Add(this.label8);
            this.compras.Controls.Add(this.label7);
            this.compras.Controls.Add(this.buttonNovoContrato);
            this.compras.Controls.Add(this.LimparCompra);
            this.compras.Controls.Add(this.ExcluirCompra);
            this.compras.Controls.Add(this.SalvarCompra);
            this.compras.Controls.Add(this.label6);
            this.compras.Controls.Add(this.label5);
            this.compras.Controls.Add(this.labelData);
            this.compras.Controls.Add(this.IDCOMPRAESCONDIDO);
            this.compras.Controls.Add(this.textBoxNomeCompras);
            this.compras.Controls.Add(this.label4);
            this.compras.Controls.Add(this.textBoxQuantidade);
            this.compras.Controls.Add(this.textBoxIdEscondidoCompra);
            this.compras.Controls.Add(this.label3);
            this.compras.Controls.Add(this.textBoxComprasDescricao);
            this.compras.Controls.Add(this.label2);
            this.compras.Controls.Add(this.textBoxComprasValor);
            this.compras.Controls.Add(this.label1);
            this.compras.Location = new System.Drawing.Point(4, 22);
            this.compras.Name = "compras";
            this.compras.Padding = new System.Windows.Forms.Padding(3);
            this.compras.Size = new System.Drawing.Size(1139, 563);
            this.compras.TabIndex = 0;
            this.compras.Text = "COMPRAS";
            this.compras.Click += new System.EventHandler(this.compras_Click);
            // 
            // textBoxDataDevolucao
            // 
            this.textBoxDataDevolucao.Location = new System.Drawing.Point(1006, 269);
            this.textBoxDataDevolucao.Mask = "00/00/0000";
            this.textBoxDataDevolucao.Name = "textBoxDataDevolucao";
            this.textBoxDataDevolucao.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataDevolucao.TabIndex = 29;
            this.textBoxDataDevolucao.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textBoxDataDevolucao.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxDataEntrega
            // 
            this.textBoxDataEntrega.Location = new System.Drawing.Point(610, 266);
            this.textBoxDataEntrega.Mask = "00/00/0000";
            this.textBoxDataEntrega.Name = "textBoxDataEntrega";
            this.textBoxDataEntrega.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataEntrega.TabIndex = 28;
            this.textBoxDataEntrega.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textBoxDataEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxDataLocacao
            // 
            this.textBoxDataLocacao.Location = new System.Drawing.Point(244, 265);
            this.textBoxDataLocacao.Mask = "00/00/0000";
            this.textBoxDataLocacao.Name = "textBoxDataLocacao";
            this.textBoxDataLocacao.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataLocacao.TabIndex = 27;
            this.textBoxDataLocacao.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textBoxDataLocacao.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Verdana", 15F);
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(756, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "DATA DE DEVOLUÇÃO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Verdana", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(391, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "DATA DE ENTREGA:";
            // 
            // buttonNovoContrato
            // 
            this.buttonNovoContrato.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonNovoContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNovoContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoContrato.ForeColor = System.Drawing.Color.White;
            this.buttonNovoContrato.Location = new System.Drawing.Point(147, 391);
            this.buttonNovoContrato.Name = "buttonNovoContrato";
            this.buttonNovoContrato.Size = new System.Drawing.Size(124, 40);
            this.buttonNovoContrato.TabIndex = 19;
            this.buttonNovoContrato.Text = "NOVO";
            this.buttonNovoContrato.UseVisualStyleBackColor = false;
            // 
            // LimparCompra
            // 
            this.LimparCompra.BackColor = System.Drawing.Color.Yellow;
            this.LimparCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimparCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimparCompra.ForeColor = System.Drawing.Color.White;
            this.LimparCompra.Location = new System.Drawing.Point(843, 391);
            this.LimparCompra.Name = "LimparCompra";
            this.LimparCompra.Size = new System.Drawing.Size(124, 40);
            this.LimparCompra.TabIndex = 22;
            this.LimparCompra.Text = "LIMPAR";
            this.LimparCompra.UseVisualStyleBackColor = false;
            // 
            // ExcluirCompra
            // 
            this.ExcluirCompra.BackColor = System.Drawing.Color.Red;
            this.ExcluirCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExcluirCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirCompra.ForeColor = System.Drawing.Color.White;
            this.ExcluirCompra.Location = new System.Drawing.Point(629, 391);
            this.ExcluirCompra.Name = "ExcluirCompra";
            this.ExcluirCompra.Size = new System.Drawing.Size(124, 40);
            this.ExcluirCompra.TabIndex = 21;
            this.ExcluirCompra.Text = "EXCLUIR";
            this.ExcluirCompra.UseVisualStyleBackColor = false;
            // 
            // SalvarCompra
            // 
            this.SalvarCompra.BackColor = System.Drawing.Color.Green;
            this.SalvarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalvarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalvarCompra.ForeColor = System.Drawing.Color.White;
            this.SalvarCompra.Location = new System.Drawing.Point(380, 391);
            this.SalvarCompra.Name = "SalvarCompra";
            this.SalvarCompra.Size = new System.Drawing.Size(124, 40);
            this.SalvarCompra.TabIndex = 20;
            this.SalvarCompra.Text = "SALVAR";
            this.SalvarCompra.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(469, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "CONTRATO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Verdana", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(23, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "DATA DE LOCAÇÃO:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelData.Location = new System.Drawing.Point(740, 196);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(0, 13);
            this.labelData.TabIndex = 15;
            // 
            // IDCOMPRAESCONDIDO
            // 
            this.IDCOMPRAESCONDIDO.Location = new System.Drawing.Point(761, 17);
            this.IDCOMPRAESCONDIDO.Multiline = true;
            this.IDCOMPRAESCONDIDO.Name = "IDCOMPRAESCONDIDO";
            this.IDCOMPRAESCONDIDO.Size = new System.Drawing.Size(52, 40);
            this.IDCOMPRAESCONDIDO.TabIndex = 14;
            this.IDCOMPRAESCONDIDO.Visible = false;
            // 
            // textBoxNomeCompras
            // 
            this.textBoxNomeCompras.DisplayMember = "NOME";
            this.textBoxNomeCompras.FormattingEnabled = true;
            this.textBoxNomeCompras.Location = new System.Drawing.Point(453, 103);
            this.textBoxNomeCompras.Name = "textBoxNomeCompras";
            this.textBoxNomeCompras.Size = new System.Drawing.Size(121, 21);
            this.textBoxNomeCompras.TabIndex = 12;
            this.textBoxNomeCompras.ValueMember = "NOME";
            this.textBoxNomeCompras.SelectedIndexChanged += new System.EventHandler(this.textBoxNomeCompras_SelectedIndexChanged);
            this.textBoxNomeCompras.SelectedValueChanged += new System.EventHandler(this.textBoxNomeCompras_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(679, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "QUANTIDADE:";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(843, 176);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(81, 20);
            this.textBoxQuantidade.TabIndex = 10;
            // 
            // textBoxIdEscondidoCompra
            // 
            this.textBoxIdEscondidoCompra.Location = new System.Drawing.Point(896, 17);
            this.textBoxIdEscondidoCompra.Multiline = true;
            this.textBoxIdEscondidoCompra.Name = "textBoxIdEscondidoCompra";
            this.textBoxIdEscondidoCompra.Size = new System.Drawing.Size(52, 40);
            this.textBoxIdEscondidoCompra.TabIndex = 8;
            this.textBoxIdEscondidoCompra.Visible = false;
            this.textBoxIdEscondidoCompra.TextChanged += new System.EventHandler(this.textBoxIdEscondidoCompra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(694, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESCRICAO:";
            // 
            // textBoxComprasDescricao
            // 
            this.textBoxComprasDescricao.Location = new System.Drawing.Point(843, 108);
            this.textBoxComprasDescricao.Name = "textBoxComprasDescricao";
            this.textBoxComprasDescricao.Size = new System.Drawing.Size(100, 20);
            this.textBoxComprasDescricao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(80, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "VALOR:";
            // 
            // textBoxComprasValor
            // 
            this.textBoxComprasValor.Location = new System.Drawing.Point(175, 176);
            this.textBoxComprasValor.Name = "textBoxComprasValor";
            this.textBoxComprasValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxComprasValor.TabIndex = 2;
            this.textBoxComprasValor.TextChanged += new System.EventHandler(this.textBoxComprasValor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(344, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "VESTIDO:";
            // 
            // pesquisa_compras
            // 
            this.pesquisa_compras.BackColor = System.Drawing.Color.Goldenrod;
            this.pesquisa_compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pesquisa_compras.Controls.Add(this.dataGridView1);
            this.pesquisa_compras.Controls.Add(this.ATUALIZAR_COMPRA);
            this.pesquisa_compras.Location = new System.Drawing.Point(4, 22);
            this.pesquisa_compras.Name = "pesquisa_compras";
            this.pesquisa_compras.Padding = new System.Windows.Forms.Padding(3);
            this.pesquisa_compras.Size = new System.Drawing.Size(1139, 563);
            this.pesquisa_compras.TabIndex = 1;
            this.pesquisa_compras.Text = "PESQUISAR";
            this.pesquisa_compras.Click += new System.EventHandler(this.pesquisa_compras_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUTO,
            this.NOME,
            this.VALOR,
            this.QUANTIDADE,
            this.DESCRICAO});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(125, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 266);
            this.dataGridView1.TabIndex = 2;
            // 
            // ID_PRODUTO
            // 
            this.ID_PRODUTO.DataPropertyName = "ID_PRODUTO";
            this.ID_PRODUTO.HeaderText = "ID_PRODUTO";
            this.ID_PRODUTO.Name = "ID_PRODUTO";
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "VALOR";
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.DataPropertyName = "QUANTIDADE";
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            // 
            // ATUALIZAR_COMPRA
            // 
            this.ATUALIZAR_COMPRA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ATUALIZAR_COMPRA.BackgroundImage")));
            this.ATUALIZAR_COMPRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ATUALIZAR_COMPRA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ATUALIZAR_COMPRA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ATUALIZAR_COMPRA.Location = new System.Drawing.Point(460, 61);
            this.ATUALIZAR_COMPRA.Name = "ATUALIZAR_COMPRA";
            this.ATUALIZAR_COMPRA.Size = new System.Drawing.Size(42, 36);
            this.ATUALIZAR_COMPRA.TabIndex = 1;
            this.ATUALIZAR_COMPRA.UseVisualStyleBackColor = true;
            this.ATUALIZAR_COMPRA.Click += new System.EventHandler(this.ATUALIZAR_COMPRA_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.buttonCloseProducts);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 22);
            this.panel1.TabIndex = 3;
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
            this.buttonCloseProducts.Click += new System.EventHandler(this.buttonCloseProducts_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 15F);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(80, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "COD:";
            // 
            // codVestido
            // 
            this.codVestido.Enabled = false;
            this.codVestido.Location = new System.Drawing.Point(147, 106);
            this.codVestido.Name = "codVestido";
            this.codVestido.Size = new System.Drawing.Size(100, 20);
            this.codVestido.TabIndex = 30;
            // 
            // compra_produto
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
            this.Name = "compra_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPRA PRODUTO";
            this.Load += new System.EventHandler(this.compra_produto_Load);
            this.tabControl1.ResumeLayout(false);
            this.compras.ResumeLayout(false);
            this.compras.PerformLayout();
            this.pesquisa_compras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage compras;
        private System.Windows.Forms.TabPage pesquisa_compras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxComprasValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxComprasDescricao;
        private System.Windows.Forms.TextBox textBoxIdEscondidoCompra;
        private System.Windows.Forms.Button ATUALIZAR_COMPRA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.ComboBox textBoxNomeCompras;
        private System.Windows.Forms.TextBox IDCOMPRAESCONDIDO;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCloseProducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonNovoContrato;
        private System.Windows.Forms.Button LimparCompra;
        private System.Windows.Forms.Button ExcluirCompra;
        private System.Windows.Forms.Button SalvarCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox textBoxDataDevolucao;
        private System.Windows.Forms.MaskedTextBox textBoxDataEntrega;
        private System.Windows.Forms.MaskedTextBox textBoxDataLocacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox codVestido;
    }
}