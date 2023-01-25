
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPegarData = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.IDCOMPRAESCONDIDO = new System.Windows.Forms.TextBox();
            this.textBoxNomeCompras = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.LimparCompra = new System.Windows.Forms.Button();
            this.textBoxIdEscondidoCompra = new System.Windows.Forms.TextBox();
            this.ExcluirCompra = new System.Windows.Forms.Button();
            this.SalvarCompra = new System.Windows.Forms.Button();
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
            this.tabControl1.SuspendLayout();
            this.compras.SuspendLayout();
            this.pesquisa_compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.compras.BackColor = System.Drawing.Color.SlateGray;
            this.compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compras.Controls.Add(this.label5);
            this.compras.Controls.Add(this.textBoxPegarData);
            this.compras.Controls.Add(this.labelData);
            this.compras.Controls.Add(this.IDCOMPRAESCONDIDO);
            this.compras.Controls.Add(this.textBoxNomeCompras);
            this.compras.Controls.Add(this.label4);
            this.compras.Controls.Add(this.textBoxQuantidade);
            this.compras.Controls.Add(this.LimparCompra);
            this.compras.Controls.Add(this.textBoxIdEscondidoCompra);
            this.compras.Controls.Add(this.ExcluirCompra);
            this.compras.Controls.Add(this.SalvarCompra);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(52, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "DATA";
            // 
            // textBoxPegarData
            // 
            this.textBoxPegarData.Enabled = false;
            this.textBoxPegarData.Location = new System.Drawing.Point(97, 20);
            this.textBoxPegarData.Multiline = true;
            this.textBoxPegarData.Name = "textBoxPegarData";
            this.textBoxPegarData.Size = new System.Drawing.Size(124, 17);
            this.textBoxPegarData.TabIndex = 16;
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
            this.IDCOMPRAESCONDIDO.Location = new System.Drawing.Point(664, 186);
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
            this.textBoxNomeCompras.Location = new System.Drawing.Point(97, 81);
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
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(685, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "QUANTIDADE";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(769, 81);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(44, 20);
            this.textBoxQuantidade.TabIndex = 10;
            // 
            // LimparCompra
            // 
            this.LimparCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimparCompra.ForeColor = System.Drawing.SystemColors.Window;
            this.LimparCompra.Location = new System.Drawing.Point(463, 186);
            this.LimparCompra.Name = "LimparCompra";
            this.LimparCompra.Size = new System.Drawing.Size(75, 23);
            this.LimparCompra.TabIndex = 9;
            this.LimparCompra.Text = "LIMPAR";
            this.LimparCompra.UseVisualStyleBackColor = true;
            this.LimparCompra.Click += new System.EventHandler(this.LimparCompra_Click);
            // 
            // textBoxIdEscondidoCompra
            // 
            this.textBoxIdEscondidoCompra.Location = new System.Drawing.Point(839, 186);
            this.textBoxIdEscondidoCompra.Multiline = true;
            this.textBoxIdEscondidoCompra.Name = "textBoxIdEscondidoCompra";
            this.textBoxIdEscondidoCompra.Size = new System.Drawing.Size(52, 40);
            this.textBoxIdEscondidoCompra.TabIndex = 8;
            this.textBoxIdEscondidoCompra.Visible = false;
            this.textBoxIdEscondidoCompra.TextChanged += new System.EventHandler(this.textBoxIdEscondidoCompra_TextChanged);
            // 
            // ExcluirCompra
            // 
            this.ExcluirCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirCompra.ForeColor = System.Drawing.SystemColors.Window;
            this.ExcluirCompra.Location = new System.Drawing.Point(297, 187);
            this.ExcluirCompra.Name = "ExcluirCompra";
            this.ExcluirCompra.Size = new System.Drawing.Size(75, 23);
            this.ExcluirCompra.TabIndex = 7;
            this.ExcluirCompra.Text = "EXCLUIR";
            this.ExcluirCompra.UseVisualStyleBackColor = true;
            this.ExcluirCompra.Click += new System.EventHandler(this.ExcluirCompra_Click);
            // 
            // SalvarCompra
            // 
            this.SalvarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalvarCompra.ForeColor = System.Drawing.SystemColors.Window;
            this.SalvarCompra.Location = new System.Drawing.Point(146, 187);
            this.SalvarCompra.Name = "SalvarCompra";
            this.SalvarCompra.Size = new System.Drawing.Size(75, 23);
            this.SalvarCompra.TabIndex = 6;
            this.SalvarCompra.Text = "SALVAR";
            this.SalvarCompra.UseVisualStyleBackColor = true;
            this.SalvarCompra.Click += new System.EventHandler(this.SalvarCompra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(460, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESCRICAO";
            // 
            // textBoxComprasDescricao
            // 
            this.textBoxComprasDescricao.Location = new System.Drawing.Point(535, 81);
            this.textBoxComprasDescricao.Name = "textBoxComprasDescricao";
            this.textBoxComprasDescricao.Size = new System.Drawing.Size(100, 20);
            this.textBoxComprasDescricao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(248, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "VALOR";
            // 
            // textBoxComprasValor
            // 
            this.textBoxComprasValor.Location = new System.Drawing.Point(297, 81);
            this.textBoxComprasValor.Name = "textBoxComprasValor";
            this.textBoxComprasValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxComprasValor.TabIndex = 2;
            this.textBoxComprasValor.TextChanged += new System.EventHandler(this.textBoxComprasValor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(52, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME";
            // 
            // pesquisa_compras
            // 
            this.pesquisa_compras.BackColor = System.Drawing.Color.SlateGray;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUTO,
            this.NOME,
            this.VALOR,
            this.QUANTIDADE,
            this.DESCRICAO});
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
            // compra_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1179, 681);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.Button ExcluirCompra;
        private System.Windows.Forms.Button SalvarCompra;
        private System.Windows.Forms.TextBox textBoxIdEscondidoCompra;
        private System.Windows.Forms.Button LimparCompra;
        private System.Windows.Forms.Button ATUALIZAR_COMPRA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.ComboBox textBoxNomeCompras;
        private System.Windows.Forms.TextBox IDCOMPRAESCONDIDO;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxPegarData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
    }
}