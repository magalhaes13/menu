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
    public partial class cadastro_cliente : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string strSQL;
        
        public cadastro_cliente()
        {
            InitializeComponent();
        }

        private void cadastro_cliente_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd=");         
        }

        private void del_cliente()
        {
            strSQL = "DELETE FROM CLIENTE WHERE ID = @ID";
        }

        private void limpar_cliente()
        {
            TextBoxNome.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            textBoxCpf.Text = "";
            textBoxEmail.Text = "";
            textBoxEndereco.Text = "";
            textBoxTelefone.Text = "";
            textBoxUf.Text = "";
        }

        private void save_cliente()
        {
            try
            {
                if (TextBoxNome.Text != "" && textBoxCpf.Text != "")
                {
                    connection.Open();
                    strSQL = "INSERT INTO CLIENTE(NOME, CIDADE, BAIRRO, CPF, ENDERECO, UF, TELEFONE, EMAIL) VALUES (@NOME, @CIDADE, @BAIRRO, @CPF, @ENDERECO, @UF, @TELEFONE, @EMAIL )";
                    command = new MySqlCommand(strSQL, connection);
                    command.Parameters.AddWithValue("@NOME", TextBoxNome.Text);
                    command.Parameters.AddWithValue("@CIDADE", textBoxCidade.Text);
                    command.Parameters.AddWithValue("@BAIRRO", textBoxBairro.Text);
                    command.Parameters.AddWithValue("@CPF", textBoxCpf.Text);
                    command.Parameters.AddWithValue("@ENDERECO", textBoxEndereco.Text);
                    command.Parameters.AddWithValue("@UF", textBoxUf.Text);
                    command.Parameters.AddWithValue("@TELEFONE", textBoxTelefone.Text);
                    command.Parameters.AddWithValue("@EMAIL", textBoxEmail.Text);

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("SALVO COM SUCESSO");
                    return;
                }
                MessageBox.Show("NOME E CPF OBIGATORIO");


            }

            catch(Exception error)
            {
                MessageBox.Show("ERROR:", error.Message);
            }

        }

        private void salvar_cliente_Click(object sender, EventArgs e)
        {
            save_cliente();
            limpar_cliente();

        }

        private void readCliente()
        {
            connection.Open();
            strSQL = "SELECT * FROM cliente";
            command = new MySqlCommand(strSQL, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void PESQUISA_Click(object sender, EventArgs e)
        {
            
        }

        private void deletar_cliente()
        {
            try
            {
                connection.Open();
                strSQL = "DELETE FROM CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE";
                command = new MySqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@ID_CLIENTE", Convert.ToInt32(textIDESCONDIDO.Text));

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("REGISTRO DELETADO");
                limpar_cliente();

            }
            catch (Exception erro)
            {
                connection.Close();
                MessageBox.Show("ERRO AO EXCLUIR" + erro);
            }
        }
        private void delet_cliente_Click(object sender, EventArgs e)
        {
            deletar_cliente();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexID_CLIENTE = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_CLIENTE"].Value);
            string indexNOME = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NOME"].Value);
            string indexCIDADE = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["CIDADE"].Value);
            string indexBAIRRO = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["BAIRRO"].Value);
            string indexCPF = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["CPF"].Value);
            string indexENDERECO = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ENDERECO"].Value);
            string indexUF = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["UF"].Value);
            string indexTELEFONE = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["TELEFONE"].Value);
            string indexEMAIL = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["EMAIL"].Value);

            textIDESCONDIDO.Text = indexID_CLIENTE.ToString();
            TextBoxNome.Text = indexNOME.ToString();
            textBoxCidade.Text = indexCIDADE.ToString();
            textBoxBairro.Text = indexBAIRRO.ToString();
            textBoxCpf.Text = indexCPF.ToString();
            textBoxEndereco.Text = indexENDERECO.ToString();
            textBoxUf.Text = indexUF.ToString();
            textBoxTelefone.Text = indexTELEFONE.ToString();
            textBoxEmail.Text = indexEMAIL.ToString();

            pg_cadastro.SelectedIndex = 0;

        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Atualizar_Click(object sender, EventArgs e)
        {
            //datagrid clientes
            try
            {
                string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd = ";
                MySqlConnection conexao = new MySqlConnection(conect);

                conexao.Open();

                if (conexao.State == ConnectionState.Open)
                {
                    string comando = "SELECT * FROM CLIENTE";

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

        private void textIDESCONDIDO_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limpar_cliente();
        }

        private void CADASTRO_Click(object sender, EventArgs e)
        {

        }
    }
}
