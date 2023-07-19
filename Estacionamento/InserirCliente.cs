using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class InserirCliente : Form
        

    {
        private Conexao conexao = new Conexao();
        ListarCliente lc = new ListarCliente();
        Gerenciador gestor = new Gerenciador();
        public InserirCliente()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelBi_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmeter_Click(object sender, EventArgs e)
        {
            Random numeroCodico = new Random();
            string prefixo = "DRG";
            int codigo = numeroCodico.Next(1234567);
            string codigoCompleto = prefixo + codigo;

            if (VerificarCliente(txtNome.Texts, txtApelido.Texts) == true)
            {
                MessageBox.Show("O Cliente já existem na base de dados.");
            }
            else
            {
                try
                {

                    gestor.InserirCliente(codigoCompleto, txtNome.Texts, txtApelido.Texts, txtBi.Texts, dateNascimento.Text, txtEmail.Texts);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha na insercão dos dados " + ex);
                }
                
            }

          


          
        }
        public bool VerificarCliente(string nome, string apelido)
        {
            conexao.AbrirConexao();
            string query = $"SELECT COUNT(*) FROM Cliente WHERE Nome = '" + txtNome.Texts + "' AND Apelido = '" + txtApelido.Texts + "'";
            SqlCommand command = new SqlCommand(query, conexao.AbrirConexao());
            command.Parameters.AddWithValue("Nome", nome);
            command.Parameters.AddWithValue("Apelido", apelido);


            int count = Convert.ToInt32(command.ExecuteScalar());

            return count > 0;

        }
    }

}

