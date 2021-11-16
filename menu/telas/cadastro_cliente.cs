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

            readCliente();
        }
        private void salvar_cliente_Click(object sender, EventArgs e)
        {
            save_cliente();

        }

        private void readCliente()
        {
            connection.Open();
            strSQL = "SELECT * FROM CLIENTE";
            command.ExecuteNonQuery();
            connection.Close();
        }

        

        private void PESQUISA_Click(object sender, EventArgs e)
        {

        }

        private void delet_cliente_Click(object sender, EventArgs e)
        {
            
        }
    }
}
