using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Estacionamento
{
    class Gerenciador
    {
        private Crud objectCrud = new Crud();

        public DataTable ExibirCliente()
        {
            DataTable tabela = new DataTable();
            tabela = objectCrud.Mostrar();
            return tabela;

        }

        public void InserirCliente(string codico, string nome, string apelido, string numeroId, string DataNasc, string email)
        {
            objectCrud.InserirCliente(codico,nome,apelido,numeroId,DataNasc,email);
        }

        public void AtualizarCliente(string codico, string nome, string apelido, string numeroId, string DataNasc, string email)
        {
            objectCrud.Atualizar(codico, nome, apelido, numeroId, DataNasc, email);
        }

        public void ApagarCliente(string codigo)
        {
            objectCrud.Eliminar(codigo);
        }

    }
}
