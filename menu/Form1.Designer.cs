
namespace menu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CADASTRO = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.materiais = new System.Windows.Forms.ToolStripMenuItem();
            this.CADASTRO.SuspendLayout();
            this.SuspendLayout();
            // 
            // CADASTRO
            // 
            this.CADASTRO.AccessibleName = "";
            this.CADASTRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CADASTRO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cliente,
            this.fornecedor,
            this.materiais});
            this.CADASTRO.Name = "CADASTRO";
            this.CADASTRO.ShowImageMargin = false;
            this.CADASTRO.Size = new System.Drawing.Size(156, 92);
            this.CADASTRO.Text = "CADASTRO";
            // 
            // cliente
            // 
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(155, 22);
            this.cliente.Text = "Cliente";
            // 
            // fornecedor
            // 
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.Size = new System.Drawing.Size(155, 22);
            this.fornecedor.Text = "Fornecedor";
            // 
            // materiais
            // 
            this.materiais.Name = "materiais";
            this.materiais.Size = new System.Drawing.Size(155, 22);
            this.materiais.Text = "Materiais";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.CADASTRO.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip CADASTRO;
        private System.Windows.Forms.ToolStripMenuItem cliente;
        private System.Windows.Forms.ToolStripMenuItem fornecedor;
        private System.Windows.Forms.ToolStripMenuItem materiais;
    }
}

