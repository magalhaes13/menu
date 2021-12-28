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
    public partial class cadastro_vendas : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string strSQL;

        public cadastro_vendas()
        {
            InitializeComponent();
        }

        private void cadastro_vendas_Load(object sender, EventArgs e)
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

                textBoxNomeVendas.Items.Clear();
                textBoxNomeVendas.DataSource = dt;
                textBoxNomeVendas.DisplayMember = "NOME";
                textBoxNomeVendas.ValueMember = "ID_PRODUTO";

                var lerbanco = textBoxNomeVendas.SelectedValue;

                teste(lerbanco.ToString());
                connection.Close();

            }
            string data = dateTimePicker1.Value.ToShortDateString();

        }

        private void del_venda()
        {
            strSQL = "DELETE FROM VENDA WHERE ID = @ID";
        }

        private void limpar_vendas()
        {
            textBoxNomeVendas.Text = "";
            textBoxVendasValor.Text = "";
            textBoxVendasDescricao.Text = "";
            textBoxQuantidade.Text = "";
        }

        private void salvar_venda()
        {

            if(IDVENDAESCONDIDO.Text == "")
            {
                try
                {
                    if (textBoxNomeVendas.Text != "" && textBoxVendasValor.Text != "")
                    {
                        connection.Open();
                        strSQL = "INSERT INTO VENDA(NOME, VALOR, DESCRICAO, QUANTIDADE) VALUES (@NOME, @VALOR, @DESCRICAO, @QUANTIDADE)";
                        command = new MySqlCommand(strSQL, connection);
                        command.Parameters.AddWithValue("@NOME", textBoxNomeVendas.Text);
                        command.Parameters.AddWithValue("@VALOR", textBoxVendasValor.Text);
                        command.Parameters.AddWithValue("@DESCRICAO", textBoxVendasDescricao.Text);
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
                    string comando = "SELECT * FROM VENDA";

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
                if (textBoxNomeVendas.Text == "" || textBoxVendasValor.Text == "")
                {
                    MessageBox.Show("PREENCHA O NOME E VALOR");
                    return;
                }

                connection.Open();
                strSQL = "UPDATE VENDA SET NOME = @NOME, VALOR = @VALOR, DESCRICAO = @DESCRICAO, QUANTIDADE = @QUANTIDADE WHERE ID_VENDA = @ID_VENDA";
                command = new MySqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@ID_VENDA", Convert.ToInt32(IDVENDAESCONDIDO.Text));
                command.Parameters.AddWithValue("@NOME", textBoxNomeVendas.Text);
                command.Parameters.AddWithValue("@VALOR", textBoxVendasValor.Text);
                command.Parameters.AddWithValue("@DESCRICAO", textBoxVendasDescricao.Text);
                command.Parameters.AddWithValue("@QUANTIDADE", textBoxQuantidade.Text);


                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("REGISTRO ALTERADO");

                atualizar();
                limpar_vendas();

            }
            catch (Exception erro)
            {
                connection.Close();
                MessageBox.Show($"ERRO AO EDITAR {erro}");
            }
        }

        private void SalvarVenda_Click(object sender, EventArgs e)
        {
            if (IDVENDAESCONDIDO.Text != "")
            {
                editar_compra();
                return;
            }

            salvar_venda();
            limpar_vendas();
            atualizar();
        }

        private void read_cliente()
        {
            connection.Open();
            strSQL = "SELECT * FROM VENDA";
            command = new MySqlCommand(strSQL, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void deletar_venda()
        {
            try
            {
                connection.Open();
                strSQL = "DELETE FROM VENDA WHERE ID_VENDA = @ID_VENDA";
                command = new MySqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@ID_VENDA", Convert.ToInt32(textBoxIdEscondido.Text));

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("REGISTRO DELETADO");
                limpar_vendas();

            }
            catch (Exception erro)
            {
                connection.Close();
                MessageBox.Show("ERRO AO EXCLUIR" + erro);
            }
        }

        private void ExcluirVenda_Click(object sender, EventArgs e)
        {
            deletar_venda();
            limpar_vendas();
            atualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATUALIZAR();
        }

        private void LimparVenda_Click(object sender, EventArgs e)
        {
            limpar_vendas();
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
                    string comando = "SELECT * FROM VENDA";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexID_VENDA = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_VENDA"].Value);
            string indexNOME = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NOME"].Value);
            string indexVALOR = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["VALOR"].Value);
            string indexDESCRICAO = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["DESCRICAO"].Value);
            string indexQUANTIDADE = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["QUANTIDADE"].Value);

            IDVENDAESCONDIDO.Text = indexID_VENDA.ToString();
            textBoxNomeVendas.Text = indexNOME.ToString();
            textBoxVendasValor.Text = indexVALOR.ToString();
            textBoxVendasDescricao.Text = indexDESCRICAO.ToString();
            textBoxQuantidade.Text = indexQUANTIDADE.ToString();


            tabControl1.SelectedIndex = 0;
        }

        private void ordem()
        {

            try
            {
                connection.Open();
                strSQL = "SELECT NOME, ID_PRODUTO FROM PRODUTO ORDER BY NOME ASC";
                command = new MySqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@ID_PRODUTO, @NOME", Convert.ToString(textBoxNomeVendas.Text));

                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception erro)
            {
                connection.Close();
                MessageBox.Show("ERRO AO SELECIONAR" + erro);
            }
        }

        private void textBoxNomeVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ordem();
        }

        private void textBoxNomeVendas_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((int)textBoxNomeVendas.SelectedValue != -1)
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();

                    var lerbanco = textBoxNomeVendas.SelectedValue;

                    string comando = $"SELECT * FROM PRODUTO WHERE ID_PRODUTO = {textBoxNomeVendas.SelectedValue}";

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

                        textBoxIdEscondido.Text = ID_ESCONDIDO;
                        textBoxVendasValor.Text = VALOR;
                        textBoxVendasDescricao.Text = DESCRICAO;
                        textBoxQuantidade.Text = QUANTIDADE;
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
                    var lerbanco = textBoxNomeVendas.SelectedValue;

                    string comando = $"SELECT * FROM PRODUTO WHERE ID_PRODUTO = {textBoxNomeVendas.SelectedValue}";

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

                        textBoxIdEscondido.Text = ID_ESCONDIDO;
                        textBoxVendasValor.Text = VALOR;
                        textBoxVendasDescricao.Text = DESCRICAO;
                        textBoxQuantidade.Text = QUANTIDADE;
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
                    textBoxVendasValor.Text = resultado;



                }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

