﻿
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
            this.pesquisa_compras = new System.Windows.Forms.TabPage();
            this.textBoxNomeCompras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComprasValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxComprasDescricao = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalvarCompra = new System.Windows.Forms.Button();
            this.ExcluirCompra = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(22, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // compras
            // 
            this.compras.Controls.Add(this.ExcluirCompra);
            this.compras.Controls.Add(this.SalvarCompra);
            this.compras.Controls.Add(this.label3);
            this.compras.Controls.Add(this.textBoxComprasDescricao);
            this.compras.Controls.Add(this.label2);
            this.compras.Controls.Add(this.textBoxComprasValor);
            this.compras.Controls.Add(this.label1);
            this.compras.Controls.Add(this.textBoxNomeCompras);
            this.compras.Location = new System.Drawing.Point(4, 22);
            this.compras.Name = "compras";
            this.compras.Padding = new System.Windows.Forms.Padding(3);
            this.compras.Size = new System.Drawing.Size(1103, 486);
            this.compras.TabIndex = 0;
            this.compras.Text = "COMPRAS";
            this.compras.UseVisualStyleBackColor = true;
            // 
            // pesquisa_compras
            // 
            this.pesquisa_compras.Controls.Add(this.dataGridView1);
            this.pesquisa_compras.Location = new System.Drawing.Point(4, 22);
            this.pesquisa_compras.Name = "pesquisa_compras";
            this.pesquisa_compras.Padding = new System.Windows.Forms.Padding(3);
            this.pesquisa_compras.Size = new System.Drawing.Size(1103, 486);
            this.pesquisa_compras.TabIndex = 1;
            this.pesquisa_compras.Text = "PESQUISAR";
            this.pesquisa_compras.UseVisualStyleBackColor = true;
            // 
            // textBoxNomeCompras
            // 
            this.textBoxNomeCompras.Location = new System.Drawing.Point(92, 50);
            this.textBoxNomeCompras.Name = "textBoxNomeCompras";
            this.textBoxNomeCompras.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomeCompras.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "VALOR";
            // 
            // textBoxComprasValor
            // 
            this.textBoxComprasValor.Location = new System.Drawing.Point(296, 50);
            this.textBoxComprasValor.Name = "textBoxComprasValor";
            this.textBoxComprasValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxComprasValor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESCRICAO";
            // 
            // textBoxComprasDescricao
            // 
            this.textBoxComprasDescricao.Location = new System.Drawing.Point(534, 50);
            this.textBoxComprasDescricao.Name = "textBoxComprasDescricao";
            this.textBoxComprasDescricao.Size = new System.Drawing.Size(100, 20);
            this.textBoxComprasDescricao.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Valor,
            this.Descrição});
            this.dataGridView1.Location = new System.Drawing.Point(101, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            // 
            // SalvarCompra
            // 
            this.SalvarCompra.Location = new System.Drawing.Point(145, 156);
            this.SalvarCompra.Name = "SalvarCompra";
            this.SalvarCompra.Size = new System.Drawing.Size(75, 23);
            this.SalvarCompra.TabIndex = 6;
            this.SalvarCompra.Text = "SALVAR";
            this.SalvarCompra.UseVisualStyleBackColor = true;
            // 
            // ExcluirCompra
            // 
            this.ExcluirCompra.Location = new System.Drawing.Point(296, 156);
            this.ExcluirCompra.Name = "ExcluirCompra";
            this.ExcluirCompra.Size = new System.Drawing.Size(75, 23);
            this.ExcluirCompra.TabIndex = 7;
            this.ExcluirCompra.Text = "EXCLUIR";
            this.ExcluirCompra.UseVisualStyleBackColor = true;
            // 
            // compra_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "compra_produto";
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
        private System.Windows.Forms.TextBox textBoxNomeCompras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxComprasDescricao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.Button ExcluirCompra;
        private System.Windows.Forms.Button SalvarCompra;
    }
}