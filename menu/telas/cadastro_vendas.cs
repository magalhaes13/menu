﻿using System;
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

                textBoxNomeVendas.Items.Clear();
                textBoxNomeVendas.DataSource = dt;
                textBoxNomeVendas.DisplayMember = "NOME";

            }
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

        private void atualizar()
        {
            try
            {
                string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd = ";
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

                command.Parameters.AddWithValue("@ID_VENDA", Convert.ToInt32(textBoxIdEscondido.Text));
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
            if (textBoxIdEscondido.Text != "")
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
                string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd = ";
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

            textBoxIdEscondido.Text = indexID_VENDA.ToString();
            textBoxNomeVendas.Text = indexNOME.ToString();
            textBoxVendasValor.Text = indexVALOR.ToString();
            textBoxVendasDescricao.Text = indexDESCRICAO.ToString();
            textBoxQuantidade.Text = indexQUANTIDADE.ToString();


            tabControl1.SelectedIndex = 0;
        }
    }
}