using bibliotecaDoSeuZe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoriaDataNamespace;

namespace WindowsFormsAppProjetoServ_Festa
{

    public partial class frmmercadoria : Form
    {
        MercadoriaData mercadoriaData;
        public frmmercadoria()

          
        {
            InitializeComponent();
            mercadoriaData = new MercadoriaData();
        }


        private void frmmercadoria_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_box5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Mercadoria mercadoria = new Mercadoria();
            mercadoria.nome = txtNome.Text;
            mercadoria.validade = Convert.ToDateTime(dateTime.Text);
            mercadoria.alcool= txtAlcool.Text;
            mercadoria.saldo_estoque = Convert.ToInt32(txtSaldo.Text);  
            mercadoria.valor_produto = Convert.ToInt32(txtValor.Text);
            mercadoriaData.IncluiMercadoria(mercadoria);
            Console.WriteLine("mercadoria");
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtSaldo.Clear();
            txtValor.Clear();
            txtAlcool.Clear();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Mercadoria mercadoria = new Mercadoria();
            mercadoria.nome = txtNome.Text;
            mercadoria.alcool = txtAlcool.Text;
            mercadoria.saldo_estoque = Convert.ToInt32(txtSaldo.Text);
            mercadoria.valor_produto = Convert.ToInt32(txtValor.Text);
            mercadoria.validade = Convert.ToDateTime(dateTime.Text);
            mercadoria.cod_mercadorias = Convert.ToInt32(txtCodigo.Text);
            mercadoriaData.AlterarMercadoria(mercadoria);
            Console.WriteLine("mercadoria");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Mercadoria mercadoria = new Mercadoria();
            mercadoria.cod_mercadorias = Convert.ToInt32(txtCodigo.Text);
            mercadoriaData.DeletarMercadoria(mercadoria.cod_mercadorias);
            Console.WriteLine("mercadoria");
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }  
}
