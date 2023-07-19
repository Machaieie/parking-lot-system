using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Crud
    {
        private Conexao conexao = new Conexao();
        SqlDataReader leitor;
        DataTable tabela = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexao.AbrirConexao();
            comando.CommandText = "ListarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leitor = comando.ExecuteReader();
            tabela.Load(leitor);
            conexao.FecharConexao();
            return tabela;

        }

       public void InserirCliente(string codico,string nome,string apelido,string numeroId, string DataNasc, string email)
        {



            comando.Connection = conexao.AbrirConexao();
            comando.CommandText = "INSERT INTO Cliente(Codigo_Cliente,Nome,Apelido,Numero_Identificacao,Data_Nascimento,Email) values" +
                " ('"+codico+"','"+nome+"','"+apelido+"','"+numeroId+"','"+DataNasc+"','"+email+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

        }


       public void Atualizar(string codico, string nome, string apelido, string numeroId, string DataNasc, string email)
        {
            comando.Connection = conexao.AbrirConexao();
            comando.CommandText = "Update Cliente set Nome = '"+nome+"', Apelido = '"+apelido+"',Numero_Identificacao = '"+numeroId+"',Data_Nascimento = '"+DataNasc+"',Email = '"+email+"' where Codigo_Cliente = '"+codico+"'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

        }

        public void Eliminar(String codigo  )
        {
            comando.Connection = conexao.AbrirConexao();
            comando.CommandText = "delete from Cliente where Codigo_Cliente = '"+codigo+"'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            Mostrar();
        }
        
       
        
    }
  
    


}

