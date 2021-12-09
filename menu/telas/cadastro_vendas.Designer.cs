
namespace menu.telas
{
    partial class cadastro_vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_vendas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxNomeVendas = new System.Windows.Forms.ComboBox();
            this.LimparVenda = new System.Windows.Forms.Button();
            this.textBoxIdEscondido = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExcluirVenda = new System.Windows.Forms.Button();
            this.SalvarVenda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVendasDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVendasValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 541);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.textBoxNomeVendas);
            this.tabPage1.Controls.Add(this.LimparVenda);
            this.tabPage1.Controls.Add(this.textBoxIdEscondido);
            this.tabPage1.Controls.Add(this.textBoxQuantidade);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ExcluirVenda);
            this.tabPage1.Controls.Add(this.SalvarVenda);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxVendasDescricao);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxVendasValor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1130, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "VENDAS";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBoxNomeVendas
            // 
            this.textBoxNomeVendas.FormattingEnabled = true;
            this.textBoxNomeVendas.Location = new System.Drawing.Point(78, 111);
            this.textBoxNomeVendas.Name = "textBoxNomeVendas";
            this.textBoxNomeVendas.Size = new System.Drawing.Size(121, 21);
            this.textBoxNomeVendas.TabIndex = 18;
            // 
            // LimparVenda
            // 
            this.LimparVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimparVenda.ForeColor = System.Drawing.SystemColors.Window;
            this.LimparVenda.Location = new System.Drawing.Point(444, 237);
            this.LimparVenda.Name = "LimparVenda";
            this.LimparVenda.Size = new System.Drawing.Size(75, 23);
            this.LimparVenda.TabIndex = 17;
            this.LimparVenda.Text = "LIMPAR";
            this.LimparVenda.UseVisualStyleBackColor = true;
            this.LimparVenda.Click += new System.EventHandler(this.LimparVenda_Click);
            // 
            // textBoxIdEscondido
            // 
            this.textBoxIdEscondido.Location = new System.Drawing.Point(444, 31);
            this.textBoxIdEscondido.Multiline = true;
            this.textBoxIdEscondido.Name = "textBoxIdEscondido";
            this.textBoxIdEscondido.Size = new System.Drawing.Size(48, 40);
            this.textBoxIdEscondido.TabIndex = 16;
            this.textBoxIdEscondido.Visible = false;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(750, 111);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(47, 20);
            this.textBoxQuantidade.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(666, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "QUANTIDADE";
            // 
            // ExcluirVenda
            // 
            this.ExcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirVenda.ForeColor = System.Drawing.SystemColors.Window;
            this.ExcluirVenda.Location = new System.Drawing.Point(278, 237);
            this.ExcluirVenda.Name = "ExcluirVenda";
            this.ExcluirVenda.Size = new System.Drawing.Size(75, 23);
            this.ExcluirVenda.TabIndex = 13;
            this.ExcluirVenda.Text = "EXCLUIR";
            this.ExcluirVenda.UseVisualStyleBackColor = true;
            this.ExcluirVenda.Click += new System.EventHandler(this.ExcluirVenda_Click);
            // 
            // SalvarVenda
            // 
            this.SalvarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalvarVenda.ForeColor = System.Drawing.SystemColors.Window;
            this.SalvarVenda.Location = new System.Drawing.Point(99, 237);
            this.SalvarVenda.Name = "SalvarVenda";
            this.SalvarVenda.Size = new System.Drawing.Size(75, 23);
            this.SalvarVenda.TabIndex = 12;
            this.SalvarVenda.Text = "SALVAR";
            this.SalvarVenda.UseVisualStyleBackColor = true;
            this.SalvarVenda.Click += new System.EventHandler(this.SalvarVenda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(441, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "DESCRICAO";
            // 
            // textBoxVendasDescricao
            // 
            this.textBoxVendasDescricao.Location = new System.Drawing.Point(516, 111);
            this.textBoxVendasDescricao.Name = "textBoxVendasDescricao";
            this.textBoxVendasDescricao.Size = new System.Drawing.Size(100, 20);
            this.textBoxVendasDescricao.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(229, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "VALOR";
            // 
            // textBoxVendasValor
            // 
            this.textBoxVendasValor.Location = new System.Drawing.Point(278, 111);
            this.textBoxVendasValor.Name = "textBoxVendasValor";
            this.textBoxVendasValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxVendasValor.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(33, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOME";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1130, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PESQUISA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(465, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 43);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_VENDA,
            this.Nome,
            this.Valor,
            this.DESCRICAO,
            this.QUANTIDADE});
            this.dataGridView1.Location = new System.Drawing.Point(30, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1016, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID_VENDA
            // 
            this.ID_VENDA.DataPropertyName = "ID_VENDA";
            this.ID_VENDA.HeaderText = "ID";
            this.ID_VENDA.Name = "ID_VENDA";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "NOME";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "VALOR";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "Descrição";
            this.DESCRICAO.Name = "DESCRICAO";
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.DataPropertyName = "QUANTIDADE";
            this.QUANTIDADE.HeaderText = "Quantidade";
            this.QUANTIDADE.Name = "QUANTIDADE";
            // 
            // cadastro_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastro_vendas";
            this.Text = "VENDAS";
            this.Load += new System.EventHandler(this.cadastro_vendas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVendasDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVendasValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ExcluirVenda;
        private System.Windows.Forms.Button SalvarVenda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdEscondido;
        private System.Windows.Forms.Button LimparVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.ComboBox textBoxNomeVendas;
    }
}