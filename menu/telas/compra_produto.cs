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
        DateTime data_Compra;


        public compra_produto()
        {
            InitializeComponent();
        }

        private void compra_produto_Load(object sender, EventArgs e)
        {
                string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd=123456";
                connection = new MySqlConnection(conect);

                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string comando = "SELECT NOME, VALOR, ID_PRODUTO FROM PRODUTO";
                    MySqlCommand cmd = new MySqlCommand(comando, connection);

                    DataTable dt = new DataTable();

                    MySqlDataAdapter dados = new MySqlDataAdapter();
                    dados.SelectCommand = cmd;

                    dados.Fill(dt);


                    textBoxNomeCompras.Items.Clear();
                    textBoxNomeCompras.DataSource = dt;
                    textBoxNomeCompras.DisplayMember = "NOME";
                    textBoxNomeCompras.ValueMember = "ID_PRODUTO";

                    var lerbanco = textBoxNomeCompras.SelectedValue;

                    teste(lerbanco.ToString());
                    connection.Close();
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
            if(IDCOMPRAESCONDIDO.Text == "") {
                try
                {
                    if (textBoxNomeCompras.Text != "" && textBoxComprasValor.Text != "")
                    {
                        connection.Open();
                        strSQL = "INSERT INTO COMPRA(NOME, VALOR, DESCRICAO, QUANTIDADE, DATA_COMPRA) VALUES (@NOME, @VALOR, @DESCRICAO, @QUANTIDADE, @DATA_COMPRA)";
                        command = new MySqlCommand(strSQL, connection);
                        command.Parameters.AddWithValue("@NOME", textBoxNomeCompras.Text);
                        command.Parameters.AddWithValue("@VALOR", textBoxComprasValor.Text);
                        command.Parameters.AddWithValue("@DESCRICAO", textBoxComprasDescricao.Text);
                        command.Parameters.AddWithValue("@QUANTIDADE", textBoxQuantidade.Text);
                        command.Parameters.AddWithValue("@DATA_COMPRA", DateTime.Now);

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

            else
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SALVAR");
            }
           
        }

        private void atualizar()
        {
            try
            {
                string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd=123456";
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
                strSQL = "UPDATE COMPRA SET NOME = @NOME, VALOR = @VALOR, DESCRICAO = @DESCRICAO, QUANTIDADE = @QUANTIDADE, DATA_COMPRA = @DATA_COMPRA, WHERE ID_COMPRA = @ID_COMPRA";
                command = new MySqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@ID_COMPRA", Convert.ToInt32(IDCOMPRAESCONDIDO.Text));
                command.Parameters.AddWithValue("@NOME", textBoxNomeCompras.Text);
                command.Parameters.AddWithValue("@VALOR", textBoxComprasValor.Text);
                command.Parameters.AddWithValue("@DESCRICAO", textBoxComprasDescricao.Text);
                command.Parameters.AddWithValue("@QUANTIDADE", textBoxQuantidade.Text);
                command.Parameters.AddWithValue("@DATA_COMPRA", textBoxPegarData.Text);


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
            if (IDCOMPRAESCONDIDO.Text != "")
            {
                editar_compra();
                return;
            }

            salvar_compra();
            limpar_compra();
            atualizar();
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
                string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd=123456";
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
            string indexDATA_COMPRA = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["DATA_COMPRA"].Value);

            string[] V;
            V = indexDATA_COMPRA.Split(char.Parse(" "));
            //indexDATA_COMPRA = Convert.ToChar(indexDATA_COMPRA.Split();

            IDCOMPRAESCONDIDO.Text = indexID_COMPRA.ToString();
            textBoxNomeCompras.Text = indexNOME.ToString();
            textBoxComprasValor.Text = indexVALOR.ToString();
            textBoxComprasDescricao.Text = indexDESCRICAO.ToString();
            textBoxComprasDescricao.Text = indexQUANTIDADE.ToString();
            textBoxPegarData.Text = V[0];



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

            // string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd = ";
            // MySqlConnection conexao = new MySqlConnection(conect);
            //conexao.Open();

            //if (conexao.State == ConnectionState.Open)
            // {
            // var id_prod = textBoxNomeCompras.SelectedValue;
            // string comando = "SELECT VALOR, QUANTIDADE, DESCRICAO FROM PRODUTO WHERE ID_PRODUTO = @ID_PRODUTO";

            //MySqlCommand cmd = new MySqlCommand(comando, conexao);

            // MySqlDataAdapter dados = new MySqlDataAdapter();
            // dados.SelectCommand = cmd;

            //  dados.Fill(id_prod);

            // textBoxNomeCompras.Items.Clear();
            //textBoxComprasValor.Text = id_prod;
            //textBoxComprasValor.Text = "@VALOR";

            // }
        }


        private void compras_Click(object sender, EventArgs e)
        {

        }

        private void textBoxComprasValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomeCompras_SelectedValueChanged(object sender, EventArgs e)
        {
            if(textBoxNomeCompras.Items.Count != -1)
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();

                    var lerbanco = textBoxNomeCompras.SelectedValue;

                    string comando = $"SELECT * FROM COMPRA WHERE ID_COMPRA = {textBoxNomeCompras.SelectedValue}";

                    MySqlDataReader lerBanco;


                    command = new MySqlCommand(comando, connection);

                    try
                    {
                        //conexao.Open();
                        lerBanco = command.ExecuteReader();

                        lerBanco.Read();

                        string ID_ESCONDIDO = lerBanco.GetInt32("ID_COMPRA").ToString();
                        string VALOR = lerBanco.GetString("VALOR");
                        string DESCRICAO = lerBanco.GetString("DESCRICAO");
                        string QUANTIDADE = lerBanco.GetString("QUANTIDADE");
                        string DATA_COMPRA = lerBanco.GetString("DATA_COMPRA");


                        textBoxIdEscondidoCompra.Text = ID_ESCONDIDO;
                        textBoxComprasValor.Text = VALOR;
                        textBoxComprasDescricao.Text = DESCRICAO;
                        textBoxQuantidade.Text = QUANTIDADE;
                        textBoxPegarData.Text = DATA_COMPRA;

                        //conexao.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }
                    connection.Close();
                }

                else
                {
                    var lerbanco = textBoxNomeCompras.SelectedValue;

                    //foreach (DataRowView rowView in )
                    //{
                    //    DataRow row = rowView.Row;
                    //    // Do something //
                    //}

                    string comando = $"SELECT * FROM PRODUTO WHERE ID_PRODUTO = {textBoxNomeCompras.SelectedValue}";
                    MySqlDataReader lerBanco;

                    command = new MySqlCommand(comando, connection);

                    try
                    {
                        //conexao.Open();
                        lerBanco = command.ExecuteReader();

                        lerBanco.Read();

                        string ID_ESCONDIDO = lerBanco.GetInt32("ID_PRODUTO").ToString();
                        string VALOR = lerBanco.GetString("VALOR");
                        string DESCRICAO = lerBanco.GetString("DESCRICAO");
                        string QUANTIDADE = lerBanco.GetString("QUANTIDADE");
                        string DATA_COMPRA = lerBanco.GetString("DATA_COMPRA");


                        textBoxIdEscondidoCompra.Text = ID_ESCONDIDO;
                        textBoxComprasValor.Text = VALOR;
                        textBoxComprasDescricao.Text = DESCRICAO;
                        textBoxQuantidade.Text = QUANTIDADE;
                        textBoxPegarData.Text = DATA_COMPRA;

                        connection.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }
                }
            }


        }
        public void teste(string ID_PRODUTO)
        {
            string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd=123456";
            MySqlConnection conexao = new MySqlConnection(conect);

            conexao.Open();

            strSQL = $"SELECT VALOR from PRODUTO where ID_PRODUTO = {ID_PRODUTO}";
            command = new MySqlCommand(strSQL, conexao);
            MySqlDataReader leitura = command.ExecuteReader();

            string resultado;

            leitura.Read();
            resultado = leitura.GetString(0);
            textBoxComprasValor.Text = resultado;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd=123456";
            //MySqlConnection conexao = new MySqlConnection(conect);

            //conexao.Open();


            //strSQL = "SELECT DATA_COMPRA from COMPRA";
            //command = new MySqlCommand(strSQL, conexao);
            //MySqlDataReader leitura = command.ExecuteReader();

            //string resultado;

            //leitura.Read();
            //resultado = leitura.GetString(0);
            //textBoxComprasValor.Text = resultado;
        }
    }
}