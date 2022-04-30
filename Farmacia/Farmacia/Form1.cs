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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlCommand comando = new MySqlCommand();
        MySqlConnection conexao = new MySqlConnection(@"user id=root;server=localhost;database=farmacia;");
        MySqlDataAdapter Adaptador = new MySqlDataAdapter();

        DataTable tabela = new DataTable();
        DataTable tabela1 = new DataTable();
        DataTable tabela2 = new DataTable();
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnproduto_Click(object sender, EventArgs e)
        {
            cadastrar_produtos produtos = new cadastrar_produtos();
            produtos.Show();
            this.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            index id = new index();
            id.Show();
            this.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Show();
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        public void Mostrar()
        {
            
            string select = "SELECT * FROM produtos";
            Adaptador.SelectCommand = new MySqlCommand(select, conexao);
            Adaptador.Fill(tabela);
            conta1.Text = tabela.Rows.Count.ToString();
            string select1 = "SELECT * FROM categoria";
            Adaptador.SelectCommand = new MySqlCommand(select1, conexao);
            Adaptador.Fill(tabela1);
            conta2.Text = tabela1.Rows.Count.ToString();
            string select2 = "SELECT * FROM atendedor";
            Adaptador.SelectCommand = new MySqlCommand(select2, conexao);
            Adaptador.Fill(tabela2);
            conta3.Text = tabela2.Rows.Count.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("benvindo" + index.usernamelogado);
            label15.Text =  index.usernamelogado;
            Mostrar();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Vender vd = new Vender();
            vd.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            cadastrar_usuario cdu = new cadastrar_usuario();
            cdu.Show();
            this.Hide();
        }

       
    }
}
