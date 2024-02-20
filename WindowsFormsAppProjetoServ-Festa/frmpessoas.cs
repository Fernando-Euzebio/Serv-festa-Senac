using bibliotecaDoSeuZe;
using MercadoriaDataNamespace;
using PessoaDataNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProjetoServ_Festa
{
    public partial class frmpessoas : Form
    {
        PessoaData pessoaData;
        public frmpessoas()
        {
            InitializeComponent();
            pessoaData = new PessoaData();
        }

        private void frmpessoas_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = txtNome.Text;
            pessoa.tipo = txtTipo.Text;
            pessoa.data_nascimento = Convert.ToDateTime(dataTime.Text);
            pessoa.cod_pessoa = Convert.ToInt32(txtCod.Text);
            pessoaData.AlterarPessoa(pessoa);
            Console.WriteLine("pessoa");
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = txtNome.Text;
            pessoa.tipo = txtTipo.Text;
            pessoa.data_nascimento = Convert.ToDateTime(dataTime.Text);
            pessoaData.IncluirPessoa(pessoa);

            Console.WriteLine("pessoa");
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "0";
            txtNome.Clear();
            txtTipo.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.cod_pessoa = Convert.ToInt32(txtCod.Text);
            pessoaData.DeletarPessoa(pessoa.cod_pessoa);
            Console.WriteLine("pessoa");
        }
    }
}
