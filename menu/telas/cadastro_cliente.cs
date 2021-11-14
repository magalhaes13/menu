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
        string sql;
        
        public cadastro_cliente()
        {
            InitializeComponent();
        }

        private void cadastro_cliente_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=Localhost;Database=ProjetoCadastro;Uid-root;Pwd=");
            
        }

        private void salvar_cliente_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "INSERT INTO CLIENTES(NOME, SOBRENOME, CPF, BAIRRO, TELEFONE) VALUES (@NOME, @CIDADE, @BAIRRO, @CEP, @ENDERECO, @UF, @TELEFONE, @EMAIL )";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", TextBoxNome.Text);
            command.Parameters.AddWithValue("@CIDADE", TextBoxNome.Text);
            command.Parameters.AddWithValue("@BAIRRO", TextBoxNome.Text);
            command.Parameters.AddWithValue("@CEP", TextBoxNome.Text);
            command.Parameters.AddWithValue("@ENDERECO", TextBoxNome.Text);
            command.Parameters.AddWithValue("@UF", TextBoxNome.Text);
            command.Parameters.AddWithValue("@TELEFONE", TextBoxNome.Text);
            command.Parameters.AddWithValue("@EMAIL", TextBoxNome.Text);

            command.ExecuteNonQuery();
            connection.Close();
            readCliente();
        }

        private void readCliente()
        {
            connection.Open();
            sql = "SELECT * FROM CLIENTES";
            command.ExecuteNonQuery();
            connection.Close();
        }

        

        private void PESQUISA_Click(object sender, EventArgs e)
        {

        }
    }
}
