using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Farmacia
{
    public partial class cadastrar_usuario : Form
    {
        public cadastrar_usuario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        MySqlCommand comando = new MySqlCommand();
        MySqlConnection conexao = new MySqlConnection(@"user id=root;server=localhost;database=farmacia;");
        MySqlDataAdapter Adaptador = new MySqlDataAdapter();

        public void add()
        {
            conexao.Open();
            string query = "INSERT INTO atendedor (username,senha) Values(@username, @senha)";
            comando = new MySqlCommand(query, conexao);

            //passar parametros(passar os dados digitados na textbox)
            comando.Parameters.AddWithValue("@username", textBox1.Text);
            comando.Parameters.AddWithValue("@senha", textBox2.Text);
            comando.ExecuteNonQuery();
            conexao.Close();
            MessageBox.Show("Adicionado");
            textBox1.Text = "";
            textBox2.Text = "";


        }
      
        
        private void btbproduto_Click(object sender, EventArgs e)
        {
            add();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlista_Click(object sender, EventArgs e)
        {
            ver_usuario ver = new ver_usuario();
            ver.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 cd = new Form1();
            cd.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            cadastrar_produtos cd = new cadastrar_produtos();
            cd.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Categoria cd = new Categoria();
            cd.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            cadastrar_usuario cd = new cadastrar_usuario();
            cd.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
           Vender cd = new Vender();
            cd.Show();
            this.Hide();
        }
    }
}
