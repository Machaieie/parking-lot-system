using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Conexao
    {
        private SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-GVNN1CU\SQLEXPRESS;Initial Catalog=Estacionamento;Integrated Security=True");
        public SqlConnection AbrirConexao()
        {
            if(conexao.State == ConnectionState.Closed)
                conexao.Open(); 
            return conexao;
            
        }

        public SqlConnection FecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
            return conexao;
        }
    }
}
