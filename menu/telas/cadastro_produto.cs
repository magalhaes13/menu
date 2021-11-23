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
    public partial class cadastro_produto : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string strSQL;
        public cadastro_produto()
        {
            InitializeComponent();
        }

        private void cadastro_produto_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd=");
        }

        private void del_produto()
        {
            strSQL = "DELETE FROM PRODUTO WHERE ID = @ID_PRODUTO";
        }
        private void ExcluirProduto_Click(object sender, EventArgs e)
        {
            deletar_produto();
        }

        private void limpar_produto()
        {
            textBoxNomeProd.Text = "";
            textBoxValor.Text = "";
            textBoxDescricao.Text = "";

        }
        private void LimparProduto_Click(object sender, EventArgs e)
        {
            limpar_produto();
        }

        private void save_produto()
        {
            try
            {
                if (textBoxNomeProd.Text != "" && textBoxValor.Text != "")
                {
                    connection.Open();
                    strSQL = "INSERT INTO PRODUTO(NOME, VALOR, DESCRICAO) VALUES (@NOME, @VALOR, @DESCRICAO)";
                    command = new MySqlCommand(strSQL, connection);
                    command.Parameters.AddWithValue("@NOME", textBoxNomeProd.Text);
                    command.Parameters.AddWithValue("@VALOR", textBoxValor.Text);
                    command.Parameters.AddWithValue("@DESCRICAO", textBoxDescricao.Text);

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

        private void SalvarProduto_Click_1(object sender, EventArgs e)
        {
            save_produto();
            limpar_produto();
        }

        private void readProduto()
        {
            connection.Open();
            strSQL = "SELECT * FROM PRODUTO";
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void deletar_produto()
        {
            try
            {
                connection.Open();
                strSQL = "DELETE FROM PRODUTO WHERE ID_PRODUTO = @ID_PRODUTO";
                command = new MySqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@ID_PRODUTO", Convert.ToInt32(txtIDPRODUTOESCONDIDO.Text));

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("PRODUTO DELETADO");
                limpar_produto();

            }
            catch (Exception erro)
            {
                connection.Close();
                MessageBox.Show("ERRO AO EXCLUIR" + erro);
            }
        }
        private void EXCLUIRPRODUTO_Click(object sender, EventArgs e)
        {
            deletar_produto();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button_AtualizarProd_Click(object sender, EventArgs e)
        {
            try
            {
                string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd = ";
                MySqlConnection conexao = new MySqlConnection(conect);

                conexao.Open();

                if (conexao.State == ConnectionState.Open)
                {
                    string comando = "SELECT * FROM PRODUTO";

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexID_PRODUTO = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_PRODUTO"].Value);
            string indexNOME = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NOME"].Value);
            string indexVALOR = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["VALOR"].Value);
            string indexDESCRICAO = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["DESCRICAO"].Value);

            txtIDPRODUTOESCONDIDO.Text = indexID_PRODUTO.ToString();
            textBoxNomeProd.Text = indexNOME.ToString();
            textBoxValor.Text = indexVALOR.ToString();
            textBoxDescricao.Text = indexDESCRICAO.ToString();

            tabControl1.SelectedIndex = 0;
        }
    }
}
