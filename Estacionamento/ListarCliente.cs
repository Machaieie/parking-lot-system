using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class ListarCliente : Form
    {
        private Gerenciador gestor = new Gerenciador();
        public ListarCliente()
        {
            InitializeComponent();
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        public void ListarClientes()
        {
            dataGridViewDados.DataSource = gestor.ExibirCliente();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDados.SelectedRows.Count > 0)
            {
                gestor.AtualizarCliente(txtCodigo.Texts,txtNome.Texts,txtApelido.Texts,txtBi.Texts,txtData.Text,txtEmail.Texts);


            }
            else
                MessageBox.Show("Selecione Uma fila.");
        }
        public void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void darkXTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDados.SelectedRows.Count > 0)
            {
                txtCodigo.Texts = dataGridViewDados.CurrentRow.Cells["Codigo_Cliente"].Value.ToString();
                gestor.ApagarCliente(txtCodigo.Texts);
                MessageBox.Show("Cliente Apagado com Sucesso.");
                ListarClientes();

            }
            else
            {
                MessageBox.Show("Selecione Uma fila.");
            }
        }

        /*private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDados.SelectedRows.Count > 0)
            {
                txtCodigo.Texts = dataGridViewDados.CurrentRow.Cells["Codigo_Cliente"].Value.ToString();
                txtNome.Texts = dataGridViewDados.CurrentRow.Cells["Nome"].Value.ToString();
                txtApelido.Texts = dataGridViewDados.CurrentRow.Cells["Apelido"].Value.ToString();
                txtBi.Texts = dataGridViewDados.CurrentRow.Cells["Numero_Identificacao"].Value.ToString();
                txtData.Text = dataGridViewDados.CurrentRow.Cells["Data_nascimento"].Value.ToString();
                txtEmail.Texts = dataGridViewDados.CurrentRow.Cells["Email"].Value.ToString();

            }
            else
                MessageBox.Show("Selecione Uma fila.");
        }
    }*/
    }
}
 

