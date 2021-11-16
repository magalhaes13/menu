using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace menu.telas
{
    public partial class cadastro_produto : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string sql;
        public cadastro_produto()
        {
            InitializeComponent();
        }

        private void cadastro_produto_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=Localhost;Database=PrimeiroSistema;Uid-root;Pwd=");
        }

        private void SalvarProduto_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "INSERT INTO PRODUTO(NOME,VALOR,DESCRICAO) VALUES (@NOME, @VALOR, @DESCRICAO)";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", textBoxNomeProd.Text);
            command.Parameters.AddWithValue("@VALOR", textBoxNomeProd.Text);
            command.Parameters.AddWithValue("@DESCRICAO", textBoxNomeProd.Text);

            command.ExecuteNonQuery();
            connection.Close();
            readProduto();
        }

        private void readProduto()
        {
            connection.Open();
            sql = "SELECT * FROM PRODUTO";
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
