using bibliotecaDoSeuZe;
using MercadoriaDataNamespace;
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
    public partial class frmsaida : Form
    {
        MercadoriaData mercadoriaData;
        MovimentacaoMercadoriaData movimentacaoMercadoriaData;
        public frmsaida()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_entrada_Click(object sender, EventArgs e)
        {
           //
            Mercadoria mercadoria = new Mercadoria();
            MovimentacaoMercadoriaData movimentacaoMercadoriaData = new MovimentacaoMercadoriaData();
            mercadoria.saldo_estoque = Convert.ToInt32(txtSaldo.Text);
            mercadoria.cod_mercadorias = Convert.ToInt32(txtCodProduto.Text);
            mercadoria.adicionar_valor = Convert.ToInt32(txtSaldo.Text);
            movimentacaoMercadoriaData.AdicionarSaldoMercadoria(mercadoria);
            Console.WriteLine("mercadoria");
           
            MovimentacaoMercadoria movimentacao = new MovimentacaoMercadoria();
            movimentacao.nome = txtNome.Text;
            movimentacao.data_movimentacao = Convert.ToDateTime(dataTime.Text);
            movimentacao.cod_mercadoria = Convert.ToInt32(txtCodProduto.Text);
            movimentacao.adicionar_valor = Convert.ToInt32(txtSaldo.Text);
            movimentacao.quantidade = Convert.ToInt32(txtSaldo.Text);
            movimentacaoMercadoriaData.CadastrarMovimentacao(movimentacao);
            Console.WriteLine("movimentacao");

        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            Mercadoria mercadoria = new Mercadoria();
            MercadoriaData mercadoriadata = new MercadoriaData();

            mercadoria = mercadoriadata.ObtemMercadoria(Convert.ToInt32(txtCodProduto.Text));
            txtNome.Text = mercadoria.nome.ToString(); 
            txtTipo.Text = mercadoria.alcool.ToString();
            txtSaldo.Text = mercadoria.saldo_estoque.ToString();

        }

        private void btn_saida_Click(object sender, EventArgs e)
        {
            Mercadoria mercadoria = new Mercadoria();
            MovimentacaoMercadoriaData movimentacaoMercadoriaData = new MovimentacaoMercadoriaData();
            mercadoria.saldo_estoque = Convert.ToInt32(txtSaldo.Text);
            mercadoria.cod_mercadorias = Convert.ToInt32(txtCodProduto.Text);
            mercadoria.adicionar_valor = Convert.ToInt32(txtSaldo.Text);
            movimentacaoMercadoriaData.SubtrairSaldoMercadoria(mercadoria);
            Console.WriteLine("mercadoria");

            MovimentacaoMercadoria movimentacao = new MovimentacaoMercadoria();
            movimentacao.nome = txtNome.Text;
            movimentacao.data_movimentacao = Convert.ToDateTime(dataTime.Text);
            movimentacao.cod_mercadoria = Convert.ToInt32(txtCodProduto.Text);
            movimentacao.adicionar_valor = Convert.ToInt32(txtSaldo.Text);
            movimentacao.quantidade = Convert.ToInt32(txtSaldo.Text);
            movimentacaoMercadoriaData.CadastrarMovimentacao(movimentacao);
            Console.WriteLine("movimentacao");
        }
    }
}
