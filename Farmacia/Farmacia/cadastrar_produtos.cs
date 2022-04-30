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
    
    public partial class cadastrar_produtos : Form
    {

     
        public cadastrar_produtos()
        {
            InitializeComponent();
        }
        private void adiconar()
        {
            try
            {

                if (txtNome.Text != null || txtPreco.Text != null || txtQuant.Text != null )
                {
                    int idCategoria = 1;
                    DataTable dataC = new DataTable();
                    dataC = Conexao.getDados("SELECT * FROM categoria");
                    idCategoria = int.Parse(dataC.Rows[cmbCategoria.SelectedIndex][0].ToString());
                    if (Conexao.dml("INSERT INTO produtos (nome,preco,quantidade,idcategoria,estado) VALUES('" + txtNome.Text + "','" + txtPreco.Text + "','" + txtQuant.Text + "','" + idCategoria + "','" + txtclassificacao.Text + "')"))
                    {
                        MessageBox.Show("Cadastrado Com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Não Cadastradou");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os espaços");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Digita os dados corretamente");
            }



        }
      
        private void btbcadastrar_Click(object sender, EventArgs e)
        {
             adiconar();
        }

        public void preenchaCategoria()
        {
            cmbCategoria.Items.Clear();
            DataTable dataC = new DataTable();
            dataC = Conexao.getDados("SELECT * FROM categoria");
            for (int i = 0; i < dataC.Rows.Count; i++)
            {
                cmbCategoria.Items.Add(dataC.Rows[i][1]);
            }

        }
        private void cadastrar_produtos_Load(object sender, EventArgs e)
        {
            preenchaCategoria();

        }

        private void btnlista_Click(object sender, EventArgs e)
        {
            ver vr = new ver();
            vr.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 cd = new Form1();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
