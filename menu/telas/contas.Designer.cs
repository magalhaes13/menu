
namespace menu.telas
{
    partial class contas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ExcluirContas = new System.Windows.Forms.Button();
            this.SalvarContas = new System.Windows.Forms.Button();
            this.textBoxDespesasGerais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContasFuncionarios = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.pegar_data = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.CalculoTotal = new System.Windows.Forms.Button();
            this.textBoxDataFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDataInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.ExcluirContas);
            this.tabPage1.Controls.Add(this.SalvarContas);
            this.tabPage1.Controls.Add(this.textBoxDespesasGerais);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxContasFuncionarios);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1139, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CONTAS";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ExcluirContas
            // 
            this.ExcluirContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirContas.Location = new System.Drawing.Point(610, 182);
            this.ExcluirContas.Name = "ExcluirContas";
            this.ExcluirContas.Size = new System.Drawing.Size(75, 23);
            this.ExcluirContas.TabIndex = 5;
            this.ExcluirContas.Text = "EXCLUIR";
            this.ExcluirContas.UseVisualStyleBackColor = true;
            // 
            // SalvarContas
            // 
            this.SalvarContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalvarContas.Location = new System.Drawing.Point(421, 182);
            this.SalvarContas.Name = "SalvarContas";
            this.SalvarContas.Size = new System.Drawing.Size(75, 23);
            this.SalvarContas.TabIndex = 4;
            this.SalvarContas.Text = "SALVAR";
            this.SalvarContas.UseVisualStyleBackColor = true;
            // 
            // textBoxDespesasGerais
            // 
            this.textBoxDespesasGerais.Location = new System.Drawing.Point(383, 102);
            this.textBoxDespesasGerais.Name = "textBoxDespesasGerais";
            this.textBoxDespesasGerais.Size = new System.Drawing.Size(100, 20);
            this.textBoxDespesasGerais.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(261, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME FUNCIONÁRIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(598, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALÁRIO";
            // 
            // textBoxContasFuncionarios
            // 
            this.textBoxContasFuncionarios.Location = new System.Drawing.Point(657, 102);
            this.textBoxContasFuncionarios.Name = "textBoxContasFuncionarios";
            this.textBoxContasFuncionarios.Size = new System.Drawing.Size(100, 20);
            this.textBoxContasFuncionarios.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.monthCalendar2);
            this.tabPage2.Controls.Add(this.pegar_data);
            this.tabPage2.Controls.Add(this.monthCalendar1);
            this.tabPage2.Controls.Add(this.CalculoTotal);
            this.tabPage2.Controls.Add(this.textBoxDataFinal);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxDataInicial);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1139, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DATA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(189, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 191);
            this.dataGridView1.TabIndex = 11;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(704, 61);
            this.monthCalendar2.MaxSelectionCount = 31;
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 10;
            // 
            // pegar_data
            // 
            this.pegar_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pegar_data.ForeColor = System.Drawing.SystemColors.Window;
            this.pegar_data.Location = new System.Drawing.Point(428, 75);
            this.pegar_data.Name = "pegar_data";
            this.pegar_data.Size = new System.Drawing.Size(264, 23);
            this.pegar_data.TabIndex = 9;
            this.pegar_data.Text = "PEGAR DATA";
            this.pegar_data.UseVisualStyleBackColor = true;
            this.pegar_data.Click += new System.EventHandler(this.pegar_data_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(189, 61);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // CalculoTotal
            // 
            this.CalculoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculoTotal.ForeColor = System.Drawing.Color.White;
            this.CalculoTotal.Location = new System.Drawing.Point(533, 486);
            this.CalculoTotal.Name = "CalculoTotal";
            this.CalculoTotal.Size = new System.Drawing.Size(75, 23);
            this.CalculoTotal.TabIndex = 7;
            this.CalculoTotal.Text = "CALCULAR";
            this.CalculoTotal.UseVisualStyleBackColor = true;
            // 
            // textBoxDataFinal
            // 
            this.textBoxDataFinal.Enabled = false;
            this.textBoxDataFinal.Location = new System.Drawing.Point(478, 167);
            this.textBoxDataFinal.Name = "textBoxDataFinal";
            this.textBoxDataFinal.Size = new System.Drawing.Size(175, 20);
            this.textBoxDataFinal.TabIndex = 6;
            this.textBoxDataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(786, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DATA FINAL";
            // 
            // textBoxDataInicial
            // 
            this.textBoxDataInicial.Enabled = false;
            this.textBoxDataInicial.Location = new System.Drawing.Point(478, 122);
            this.textBoxDataInicial.Name = "textBoxDataInicial";
            this.textBoxDataInicial.Size = new System.Drawing.Size(175, 20);
            this.textBoxDataInicial.TabIndex = 4;
            this.textBoxDataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(256, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DATA INICIAL";
            // 
            // contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1179, 681);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(12, 28);
            this.Name = "contas";
            this.Text = "CONTAS";
            this.Load += new System.EventHandler(this.contas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button ExcluirContas;
        private System.Windows.Forms.Button SalvarContas;
        private System.Windows.Forms.TextBox textBoxDespesasGerais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContasFuncionarios;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CalculoTotal;
        private System.Windows.Forms.TextBox textBoxDataFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDataInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pegar_data;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}