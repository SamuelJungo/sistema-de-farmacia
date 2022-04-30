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
using MySql.Data;

namespace Farmacia
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }
        // string de conexao para chamar o bancos de dados
        MySqlConnection con = new MySqlConnection("server=localhost; database=farmacia; username=root; password=;");


        // contador para verificar quantas vezes erraste
        int count;
        private void label1_Click(object sender, EventArgs e)
        {
        }

        //variavel publicar para receber o nome do usuario logado
        public static string usernamelogado;
        //veficando o usuario e a senha
        private void btnentrar_Click(object sender, EventArgs e)
        {
            // receber os dados digitados na textbox nessas variavel
            string usuario, pass;
            usuario = txtusuario.Text;
            pass = txtsenha.Text;
            usernamelogado = txtusuario.Text;

            //contar total de vezes errada
            count = count + 1;
            if (count > 3)
            {
                MessageBox.Show("Errou mais de 3 vezes a senha", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                //string de verificacao da tabela de login
                string query = "select *from atendedor where username='" + usuario + "' && senha='" + pass + "' ";
                MySqlDataAdapter data = new MySqlDataAdapter(query, con);
                DataTable DATA = new DataTable();
                data.Fill(DATA);

                //se estiver correto vai ao Fom1

                if (DATA.Rows.Count == 1)
                {
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
                    //se nao diz senha errada
                else
                  {
                    label3.Text = " errada";
                }
            }


        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
