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
    public partial class contas : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string strSQL;

        public contas()
        {
            InitializeComponent();
        }

        private void contas_Load(object sender, EventArgs e)
        {
            string conect = "Server=Localhost;Database=PrimeiroSistema;Uid=root;Pwd=123456";
            connection = new MySqlConnection(conect);

            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string comando = "SELECT NOME, ID_PRODUTO FROM PRODUTO";
                MySqlCommand cmd = new MySqlCommand(comando, connection);

                DataTable dt = new DataTable();

                MySqlDataAdapter dados = new MySqlDataAdapter();

                connection.Close();
            }
        }

            private void tabPage1_Click(object sender, EventArgs e)
            {

            }

            private void data1()
            {
                textBoxDataInicial.Text = monthCalendar1.SelectionStart.ToShortDateString();

            }

            private void data2()
            {
                textBoxDataFinal.Text = monthCalendar2.SelectionEnd.ToShortDateString();

            }

            private void pegar_data_Click(object sender, EventArgs e)
            {
                data1();
                data2();

             
        }

            private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
            {
                //data1();
                //data2();

            }
        }
    }

