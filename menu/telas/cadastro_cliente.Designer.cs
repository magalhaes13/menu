
namespace menu.telas
{
    partial class cadastro_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_cliente));
            this.pg_cadastro = new System.Windows.Forms.TabControl();
            this.CADASTRO = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.textIDESCONDIDO = new System.Windows.Forms.TextBox();
            this.delet_cliente = new System.Windows.Forms.Button();
            this.textBoxUf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salvar_cliente = new System.Windows.Forms.Button();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.PESQUISA = new System.Windows.Forms.TabPage();
            this.button_Atualizar = new System.Windows.Forms.Button();
            this.button_Pesquisar = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pg_cadastro.SuspendLayout();
            this.CADASTRO.SuspendLayout();
            this.PESQUISA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pg_cadastro
            // 
            this.pg_cadastro.Controls.Add(this.CADASTRO);
            this.pg_cadastro.Controls.Add(this.PESQUISA);
            this.pg_cadastro.Location = new System.Drawing.Point(12, 30);
            this.pg_cadastro.Name = "pg_cadastro";
            this.pg_cadastro.SelectedIndex = 0;
            this.pg_cadastro.Size = new System.Drawing.Size(1155, 615);
            this.pg_cadastro.TabIndex = 0;
            // 
            // CADASTRO
            // 
            this.CADASTRO.BackColor = System.Drawing.Color.SlateGray;
            this.CADASTRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CADASTRO.Controls.Add(this.label10);
            this.CADASTRO.Controls.Add(this.label9);
            this.CADASTRO.Controls.Add(this.buttonLimpar);
            this.CADASTRO.Controls.Add(this.textIDESCONDIDO);
            this.CADASTRO.Controls.Add(this.delet_cliente);
            this.CADASTRO.Controls.Add(this.textBoxUf);
            this.CADASTRO.Controls.Add(this.label8);
            this.CADASTRO.Controls.Add(this.textBoxBairro);
            this.CADASTRO.Controls.Add(this.label7);
            this.CADASTRO.Controls.Add(this.textBoxCpf);
            this.CADASTRO.Controls.Add(this.label6);
            this.CADASTRO.Controls.Add(this.textBoxEndereco);
            this.CADASTRO.Controls.Add(this.label5);
            this.CADASTRO.Controls.Add(this.salvar_cliente);
            this.CADASTRO.Controls.Add(this.textBoxCidade);
            this.CADASTRO.Controls.Add(this.label4);
            this.CADASTRO.Controls.Add(this.textBoxTelefone);
            this.CADASTRO.Controls.Add(this.textBoxEmail);
            this.CADASTRO.Controls.Add(this.label3);
            this.CADASTRO.Controls.Add(this.label2);
            this.CADASTRO.Controls.Add(this.label1);
            this.CADASTRO.Controls.Add(this.TextBoxNome);
            this.CADASTRO.ForeColor = System.Drawing.SystemColors.Window;
            this.CADASTRO.Location = new System.Drawing.Point(4, 22);
            this.CADASTRO.Name = "CADASTRO";
            this.CADASTRO.Padding = new System.Windows.Forms.Padding(3);
            this.CADASTRO.Size = new System.Drawing.Size(1147, 589);
            this.CADASTRO.TabIndex = 0;
            this.CADASTRO.Text = "CADASTRO";
            this.CADASTRO.Click += new System.EventHandler(this.CADASTRO_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(469, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "DADOS PESSOAIS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-4, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1157, 31);
            this.label9.TabIndex = 21;
            this.label9.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Yellow;
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Location = new System.Drawing.Point(665, 456);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(102, 40);
            this.buttonLimpar.TabIndex = 20;
            this.buttonLimpar.Text = "LIMPAR";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // textIDESCONDIDO
            // 
            this.textIDESCONDIDO.Location = new System.Drawing.Point(864, 3);
            this.textIDESCONDIDO.Name = "textIDESCONDIDO";
            this.textIDESCONDIDO.Size = new System.Drawing.Size(53, 20);
            this.textIDESCONDIDO.TabIndex = 19;
            this.textIDESCONDIDO.Visible = false;
            this.textIDESCONDIDO.TextChanged += new System.EventHandler(this.textIDESCONDIDO_TextChanged);
            // 
            // delet_cliente
            // 
            this.delet_cliente.BackColor = System.Drawing.Color.Red;
            this.delet_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delet_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delet_cliente.Location = new System.Drawing.Point(436, 456);
            this.delet_cliente.Name = "delet_cliente";
            this.delet_cliente.Size = new System.Drawing.Size(116, 40);
            this.delet_cliente.TabIndex = 17;
            this.delet_cliente.Text = "EXCLUIR";
            this.delet_cliente.UseVisualStyleBackColor = false;
            this.delet_cliente.Click += new System.EventHandler(this.delet_cliente_Click);
            // 
            // textBoxUf
            // 
            this.textBoxUf.Location = new System.Drawing.Point(758, 367);
            this.textBoxUf.Name = "textBoxUf";
            this.textBoxUf.Size = new System.Drawing.Size(53, 20);
            this.textBoxUf.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(705, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "UF:";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(758, 288);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(164, 20);
            this.textBoxBairro.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(651, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "BAIRRO:";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(758, 106);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(159, 20);
            this.textBoxCpf.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(694, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "CPF:";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(175, 367);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(229, 20);
            this.textBoxEndereco.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(35, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "ENDEREÇO:";
            // 
            // salvar_cliente
            // 
            this.salvar_cliente.BackColor = System.Drawing.Color.Green;
            this.salvar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvar_cliente.Location = new System.Drawing.Point(227, 456);
            this.salvar_cliente.Name = "salvar_cliente";
            this.salvar_cliente.Size = new System.Drawing.Size(124, 40);
            this.salvar_cliente.TabIndex = 8;
            this.salvar_cliente.Text = "SALVAR";
            this.salvar_cliente.UseVisualStyleBackColor = false;
            this.salvar_cliente.Click += new System.EventHandler(this.salvar_cliente_Click);
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(175, 284);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(239, 20);
            this.textBoxCidade.TabIndex = 7;
            this.textBoxCidade.TextChanged += new System.EventHandler(this.textBoxCidade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(69, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "CIDADE:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(175, 173);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(223, 20);
            this.textBoxTelefone.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(758, 180);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(250, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(43, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "TELEFONE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(668, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "EMAIL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME:";
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(175, 104);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(347, 20);
            this.TextBoxNome.TabIndex = 0;
            // 
            // PESQUISA
            // 
            this.PESQUISA.BackColor = System.Drawing.Color.SlateGray;
            this.PESQUISA.Controls.Add(this.button_Atualizar);
            this.PESQUISA.Controls.Add(this.button_Pesquisar);
            this.PESQUISA.Controls.Add(this.textBoxPesquisa);
            this.PESQUISA.Controls.Add(this.dataGridView1);
            this.PESQUISA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PESQUISA.Location = new System.Drawing.Point(4, 22);
            this.PESQUISA.Name = "PESQUISA";
            this.PESQUISA.Padding = new System.Windows.Forms.Padding(3);
            this.PESQUISA.Size = new System.Drawing.Size(1147, 589);
            this.PESQUISA.TabIndex = 1;
            this.PESQUISA.Text = "PESQUISA";
            this.PESQUISA.Click += new System.EventHandler(this.PESQUISA_Click);
            // 
            // button_Atualizar
            // 
            this.button_Atualizar.BackColor = System.Drawing.Color.Transparent;
            this.button_Atualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Atualizar.BackgroundImage")));
            this.button_Atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Atualizar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Atualizar.Location = new System.Drawing.Point(474, 73);
            this.button_Atualizar.Name = "button_Atualizar";
            this.button_Atualizar.Size = new System.Drawing.Size(37, 36);
            this.button_Atualizar.TabIndex = 3;
            this.button_Atualizar.UseVisualStyleBackColor = false;
            this.button_Atualizar.Click += new System.EventHandler(this.button_Atualizar_Click);
            // 
            // button_Pesquisar
            // 
            this.button_Pesquisar.Location = new System.Drawing.Point(42, 82);
            this.button_Pesquisar.Name = "button_Pesquisar";
            this.button_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.button_Pesquisar.TabIndex = 2;
            this.button_Pesquisar.Text = "PESQUISA";
            this.button_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(132, 82);
            this.textBoxPesquisa.Multiline = true;
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(194, 23);
            this.textBoxPesquisa.TabIndex = 1;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLIENTE,
            this.NOME,
            this.CPF,
            this.EMAIL,
            this.TELEFONE,
            this.CIDADE,
            this.BAIRRO,
            this.ENDERECO,
            this.UF});
            this.dataGridView1.Location = new System.Drawing.Point(42, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1063, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "ID";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            // 
            // TELEFONE
            // 
            this.TELEFONE.DataPropertyName = "TELEFONE";
            this.TELEFONE.HeaderText = "Telefone";
            this.TELEFONE.Name = "TELEFONE";
            // 
            // CIDADE
            // 
            this.CIDADE.DataPropertyName = "CIDADE";
            this.CIDADE.HeaderText = "Cidade";
            this.CIDADE.Name = "CIDADE";
            // 
            // BAIRRO
            // 
            this.BAIRRO.DataPropertyName = "BAIRRO";
            this.BAIRRO.HeaderText = "Bairro";
            this.BAIRRO.Name = "BAIRRO";
            // 
            // ENDERECO
            // 
            this.ENDERECO.DataPropertyName = "ENDERECO";
            this.ENDERECO.HeaderText = "Endereço";
            this.ENDERECO.Name = "ENDERECO";
            // 
            // UF
            // 
            this.UF.DataPropertyName = "UF";
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            // 
            // cadastro_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 681);
            this.Controls.Add(this.pg_cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(12, 28);
            this.Name = "cadastro_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.cadastro_cliente_Load);
            this.pg_cadastro.ResumeLayout(false);
            this.CADASTRO.ResumeLayout(false);
            this.CADASTRO.PerformLayout();
            this.PESQUISA.ResumeLayout(false);
            this.PESQUISA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pg_cadastro;
        private System.Windows.Forms.TabPage CADASTRO;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.TabPage PESQUISA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button salvar_cliente;
        private System.Windows.Forms.TextBox textBoxUf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delet_cliente;
        private System.Windows.Forms.Button button_Pesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Button button_Atualizar;
        private System.Windows.Forms.TextBox textIDESCONDIDO;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}