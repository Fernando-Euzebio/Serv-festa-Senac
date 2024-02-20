using bibliotecaDoSeuZe;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppProjetoServ_Festa
{
    public class MovimentacaoMercadoriaData
    {
        readonly string conexao = @"Server=SJR0577174W10-1\SQLEXPRESS;Database=ProjetoServFest;Integrated Security=SSPI;TrustServerCertificate=True";
        public void AdicionarSaldoMercadoria(Mercadoria mercadoria)
        {
            //conexao
            SqlConnection conexaoBd = new SqlConnection(conexao);
            //comando
            SqlCommand comandoBd = new SqlCommand();
            comandoBd.CommandText = "update Mercadorias set saldo_estoque = saldo_estoque + @adicionar_valor where cod_mercadorias=@cod_mercadorias";
            comandoBd.Connection = conexaoBd;
            //parametros do comando

            comandoBd.Parameters.AddWithValue("@adicionar_valor", mercadoria.adicionar_valor);
            comandoBd.Parameters.AddWithValue("@cod_mercadorias", mercadoria.cod_mercadorias);

            //tratamento de erros
            try
            {
                //conecta no BD
                conexaoBd.Open();
                //executa o comando no BD
                comandoBd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                //captura a mensagem em caso de erro
                throw new Exception(erro.Message);
            }
            finally
            {
                //desconecta do BD
                conexaoBd.Close();
            }
        }
        public void SubtrairSaldoMercadoria(Mercadoria mercadoria)
        {
            //conexao
            SqlConnection conexaoBd = new SqlConnection(conexao);
            //comando
            SqlCommand comandoBd = new SqlCommand();
            comandoBd.CommandText = "update Mercadorias set saldo_estoque = saldo_estoque - @adicionar_valor where cod_mercadorias=@cod_mercadorias";
            comandoBd.Connection = conexaoBd;
            //parametros do comando

            comandoBd.Parameters.AddWithValue("@adicionar_valor", mercadoria.adicionar_valor);
            comandoBd.Parameters.AddWithValue("@cod_mercadorias", mercadoria.cod_mercadorias);

            //tratamento de erros
            try
            {
                //conecta no BD
                conexaoBd.Open();
                //executa o comando no BD
                comandoBd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                //captura a mensagem em caso de erro
                throw new Exception(erro.Message);
            }
            finally
            {
                //desconecta do BD
                conexaoBd.Close();
            }
        }
        public void CadastrarMovimentacao(MovimentacaoMercadoria movimentacao)
        {
            //conexao
            SqlConnection conexaoBd = new SqlConnection(conexao);
            //comando
            SqlCommand comandoBd = new SqlCommand();
            comandoBd.CommandText = "Insert Into MovimentacaoMercadoria (cod_movimentacao, cod_mercadoria, quantidade, nome, data_movimentacao) Values (@cod_movimentacao, @cod_mercadoria, @quantidade, @nome, @data_movimentacao)";
            comandoBd.Connection = conexaoBd;
            //parametros do comando
            comandoBd.Parameters.AddWithValue("@cod_movimentacao", movimentacao.cod_movimentacao);
            comandoBd.Parameters.AddWithValue("@cod_mercadoria", movimentacao.cod_mercadoria);
            comandoBd.Parameters.AddWithValue("@quantidade", movimentacao.quantidade);
            comandoBd.Parameters.AddWithValue("@nome", movimentacao.nome);
            comandoBd.Parameters.AddWithValue("@data_movimentacao", movimentacao.data_movimentacao);


            //tratamento de erros
            try
            {
                //conecta no BD
                conexaoBd.Open();
                //executa o comando no BD
                comandoBd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                //captura a mensagem em caso de erro

                throw new Exception(erro.Message);

                // Relança a exceção original.
                throw;
            }
            finally
            {
                //desconecta do BD
                conexaoBd.Close();
            }
        }
    }
}
