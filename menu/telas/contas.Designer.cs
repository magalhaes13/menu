
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
            this.CalculoTotal = new System.Windows.Forms.Button();
            this.textBoxPrejuizo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLucro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1113, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.ExcluirContas);
            this.tabPage1.Controls.Add(this.SalvarContas);
            this.tabPage1.Controls.Add(this.textBoxDespesasGerais);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxContasFuncionarios);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1105, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CONTAS";
            // 
            // ExcluirContas
            // 
            this.ExcluirContas.Location = new System.Drawing.Point(300, 159);
            this.ExcluirContas.Name = "ExcluirContas";
            this.ExcluirContas.Size = new System.Drawing.Size(75, 23);
            this.ExcluirContas.TabIndex = 5;
            this.ExcluirContas.Text = "EXCLUIR";
            this.ExcluirContas.UseVisualStyleBackColor = true;
            // 
            // SalvarContas
            // 
            this.SalvarContas.Location = new System.Drawing.Point(173, 159);
            this.SalvarContas.Name = "SalvarContas";
            this.SalvarContas.Size = new System.Drawing.Size(75, 23);
            this.SalvarContas.TabIndex = 4;
            this.SalvarContas.Text = "SALVAR";
            this.SalvarContas.UseVisualStyleBackColor = true;
            // 
            // textBoxDespesasGerais
            // 
            this.textBoxDespesasGerais.Location = new System.Drawing.Point(410, 74);
            this.textBoxDespesasGerais.Name = "textBoxDespesasGerais";
            this.textBoxDespesasGerais.Size = new System.Drawing.Size(100, 20);
            this.textBoxDespesasGerais.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DESPESAS GERAIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FUNCIONÁRIOS";
            // 
            // textBoxContasFuncionarios
            // 
            this.textBoxContasFuncionarios.Location = new System.Drawing.Point(146, 74);
            this.textBoxContasFuncionarios.Name = "textBoxContasFuncionarios";
            this.textBoxContasFuncionarios.Size = new System.Drawing.Size(100, 20);
            this.textBoxContasFuncionarios.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.CalculoTotal);
            this.tabPage2.Controls.Add(this.textBoxPrejuizo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxLucro);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.monthCalendar2);
            this.tabPage2.Controls.Add(this.monthCalendar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1105, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DATA";
            // 
            // CalculoTotal
            // 
            this.CalculoTotal.Location = new System.Drawing.Point(314, 254);
            this.CalculoTotal.Name = "CalculoTotal";
            this.CalculoTotal.Size = new System.Drawing.Size(75, 23);
            this.CalculoTotal.TabIndex = 7;
            this.CalculoTotal.Text = "CALCULAR";
            this.CalculoTotal.UseVisualStyleBackColor = true;
            // 
            // textBoxPrejuizo
            // 
            this.textBoxPrejuizo.Location = new System.Drawing.Point(232, 369);
            this.textBoxPrejuizo.Name = "textBoxPrejuizo";
            this.textBoxPrejuizo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrejuizo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "PREJUÍZO";
            // 
            // textBoxLucro
            // 
            this.textBoxLucro.Location = new System.Drawing.Point(216, 316);
            this.textBoxLucro.Name = "textBoxLucro";
            this.textBoxLucro.Size = new System.Drawing.Size(100, 20);
            this.textBoxLucro.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "LUCRO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ATÉ";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(416, 78);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(59, 78);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "contas";
            this.Text = "CONTAS";
            this.Load += new System.EventHandler(this.contas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxPrejuizo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLucro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}