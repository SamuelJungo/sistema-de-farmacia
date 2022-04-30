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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }
        MySqlCommand comando = new MySqlCommand();
        MySqlConnection conexao = new MySqlConnection(@"user id=root;server=localhost;database=farmacia;");
        MySqlDataAdapter Adaptador = new MySqlDataAdapter();

        public void add()
        {
           conexao.Open();
           string query = "INSERT INTO categoria (categoria) Values(@categoria)";
           comando = new MySqlCommand(query, conexao);
           comando.Parameters.AddWithValue("@categoria", txtcategoria.Text);
           comando.ExecuteNonQuery();
           conexao.Close();
           MessageBox.Show("Adicionado");
           txtcategoria.Text = "";
            

        }
        private void Categoria_Load(object sender, EventArgs e)
        {

        }

        private void btbcategoria_Click(object sender, EventArgs e)
        {
            add();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlista_Click(object sender, EventArgs e)
        {
            vercategoria ct = new vercategoria();
            ct.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Categoria ct = new Categoria();
            ct.Show();
            ct.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            cadastrar_usuario cd = new cadastrar_usuario();
            cd.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            cadastrar_produtos cd = new cadastrar_produtos();
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
