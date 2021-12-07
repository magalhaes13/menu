using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.telas
{
    public partial class compra_produto : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string strSQL;

        public compra_produto()
        {
            InitializeComponent();
        }

        private void compra_produto_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd=");
            string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd = ";
            MySqlConnection conexao = new MySqlConnection(conect);

            conexao.Open();

            if (conexao.State == ConnectionState.Open)
            {
                string comando = "SELECT NOME, ID_PRODUTO FROM PRODUTO";

                MySqlCommand cmd = new MySqlCommand(comando, conexao);

                DataTable dt = new DataTable();

                MySqlDataAdapter dados = new MySqlDataAdapter();
                dados.SelectCommand = cmd;

                dados.Fill(dt);

                textBoxNomeCompras.Items.Clear();
                textBoxNomeCompras.DataSource = dt;
                textBoxNomeCompras.DisplayMember = "NOME";

            }

            
        }

        private void del_compra()
        {
            strSQL = "DELETE FROM COMPRA WHERE ID = @ID";
        }

        private void limpar_compra()
        {
            textBoxNomeCompras.Text = "";
            textBoxComprasValor.Text = "";
            textBoxComprasDescricao.Text = "";
            textBoxQuantidade.Text = "";
        }

        private void salvar_compra()
        {
            try
            {
                if (textBoxNomeCompras.Text != "" && textBoxComprasValor.Text != "")
                {
                    connection.Open();
                    strSQL = "INSERT INTO COMPRA(NOME, VALOR, DESCRICAO, QUANTIDADE) VALUES (@NOME, @VALOR, @DESCRICAO, @QUANTIDADE)";
                    command = new MySqlCommand(strSQL, connection);
                    command.Parameters.AddWithValue("@NOME", textBoxNomeCompras.Text);
                    command.Parameters.AddWithValue("@VALOR", textBoxComprasValor.Text);
                    command.Parameters.AddWithValue("@DESCRICAO", textBoxComprasDescricao.Text);
                    command.Parameters.AddWithValue("@QUANTIDADE", textBoxQuantidade.Text);

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("SALVO COM SUCESSO");
                    return;
                }
                MessageBox.Show("NOME E VALOR OBIGATORIO");


            }

            catch (Exception error)
            {
                MessageBox.Show("ERROR:", error.Message);
            }
        }

        private void atualizar()
        {
            try
            {
                string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd = ";
                MySqlConnection conexao = new MySqlConnection(conect);

                conexao.Open();

                if (conexao.State == ConnectionState.Open)
                {
                    string comando = "SELECT * FROM COMPRA";

                    MySqlCommand cmd = new MySqlCommand(comando, conexao);

                    DataTable dt = new DataTable();

                    MySqlDataAdapter dados = new MySqlDataAdapter();
                    dados.SelectCommand = cmd;

                    dados.Fill(dt);

                    this.dataGridView1.DataSource = dt;

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void editar_compra()
        {
            try
            {
                if (textBoxNomeCompras.Text == "" || textBoxComprasValor.Text == "")
                {
                    MessageBox.Show("PREENCHA O NOME E VALOR");
                    return;
                }

                connection.Open();
                strSQL = "UPDATE COMPRA SET NOME = @NOME, VALOR = @VALOR, DESCRICAO = @DESCRICAO, QUANTIDADE = @QUANTIDADE WHERE ID_COMPRA = @ID_COMPRA";
                command = new MySqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@ID_COMPRA", Convert.ToInt32(textBoxIdEscondidoCompra.Text));
                command.Parameters.AddWithValue("@NOME", textBoxNomeCompras.Text);
                command.Parameters.AddWithValue("@VALOR", textBoxComprasValor.Text);
                command.Parameters.AddWithValue("@DESCRICAO", textBoxComprasDescricao.Text);
                command.Parameters.AddWithValue("@QUANTIDADE", textBoxQuantidade.Text);


                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("REGISTRO ALTERADO");

                atualizar();
                limpar_compra();

            }
            catch (Exception erro)
            {
                connection.Close();
                MessageBox.Show($"ERRO AO EDITAR {erro}");
            }
        }

        private void SalvarCompra_Click(object sender, EventArgs e)
        {
            if (textBoxIdEscondidoCompra.Text != "")
            {
                editar_compra();
                return;
            }

            salvar_compra();
            limpar_compra();
            ATUALIZAR();
        }

        private void read_cliente()
        {
            connection.Open();
            strSQL = "SELECT * FROM COMPRA";
            command = new MySqlCommand(strSQL, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Deletar_Compra()
        {
            try
            {
                connection.Open();
                strSQL = "DELETE FROM COMPRA WHERE ID_COMPRA = @ID_COMPRA";
                command = new MySqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@ID_COMPRA", Convert.ToInt32(textBoxIdEscondidoCompra.Text));

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("REGISTRO DELETADO");
                limpar_compra();

            }
            catch (Exception erro)
            {
                connection.Close();
                MessageBox.Show("ERRO AO EXCLUIR" + erro);
            }
        }

        private void ExcluirCompra_Click(object sender, EventArgs e)
        {
            Deletar_Compra();
            limpar_compra();
            ATUALIZAR();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ATUALIZAR()
        {
            try
            {
                string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd = ";
                MySqlConnection conexao = new MySqlConnection(conect);

                conexao.Open();

                if (conexao.State == ConnectionState.Open)
                {
                    string comando = "SELECT * FROM COMPRA";

                    MySqlCommand cmd = new MySqlCommand(comando, conexao);

                    DataTable dt = new DataTable();

                    MySqlDataAdapter dados = new MySqlDataAdapter();
                    dados.SelectCommand = cmd;

                    dados.Fill(dt);

                    this.dataGridView1.DataSource = dt;

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        } 

        private void ATUALIZAR_COMPRA_Click(object sender, EventArgs e)
        {
            ATUALIZAR();
        }

            private void textBoxIdEscondidoCompra_TextChanged(object sender, EventArgs e)
                {

                }

        private void LimparCompra_Click(object sender, EventArgs e)
        {
            limpar_compra();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexID_COMPRA = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_COMPRA"].Value);
            string indexNOME = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NOME"].Value);
            string indexVALOR = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["VALOR"].Value);
            string indexDESCRICAO = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["DESCRICAO"].Value);
            string indexQUANTIDADE = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["QUANTIDADE"].Value);

            textBoxIdEscondidoCompra.Text = indexID_COMPRA.ToString();
            textBoxNomeCompras.Text = indexNOME.ToString();
            textBoxComprasValor.Text = indexVALOR.ToString();
            textBoxComprasDescricao.Text = indexDESCRICAO.ToString();
            textBoxComprasDescricao.Text = indexQUANTIDADE.ToString();


            tabControl1.SelectedIndex = 0;
        }

        private void pesquisa_compras_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNomeCompras_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomeCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void compras_Click(object sender, EventArgs e)
        {

        }

        private void textBoxComprasValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}