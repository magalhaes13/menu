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
            TextBoxNome.Text = " ";
            textBoxBairro.Text = " ";
            textBoxCidade.Text = " ";
            textBoxCpf.Text = " ";
            textBoxEmail.Text = " ";
            textBoxEndereco.Text = " ";
            textBoxTelefone.Text = " ";
            textBoxUf.Text = " ";
        }

        private void save_cliente()
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

        private void delet_cliente_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Atualizar_Click(object sender, EventArgs e)
        {
            //connection = new MySqlConnection("Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd=");
            //dataGridView1.DataSource = new DataGridView();


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
    }
}
