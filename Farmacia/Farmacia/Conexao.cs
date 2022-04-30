
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Farmacia
{
    class Conexao
    {
        public static MySqlConnection getConexao()
        {
            MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;database=farmacia;SslMode=none;");
            return conexao;
        }

        public static DataTable getDados(string select)
        {
            DataTable data = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(select, getConexao());
            adapter.Fill(data);
            return data;
        }

        public static bool dml(string query)
        {
            MySqlConnection c = Conexao.getConexao();
            c.Open();
            MySqlCommand comando = new MySqlCommand();
            comando = new MySqlCommand(query, c);
            bool r = comando.ExecuteNonQuery() >= 0;
            c.Close();
            return r;
        }
    }
}
