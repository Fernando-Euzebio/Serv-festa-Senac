using bibliotecaDoSeuZe;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseNamespace;

namespace MercadoriaDataNamespace
{
    internal class MercadoriaData
    {
        //atributo
        readonly string conexao = @"Server=SJR0577174W10-1\SQLEXPRESS;Database=ProjetoServFest;Integrated Security=SSPI;TrustServerCertificate=True";
        //string conexao;
        //metodo construtor
        public MercadoriaData()
        {
          //conexao = Database.getConnectionString();
        }
        public void IncluiMercadoria(Mercadoria mercadoria)
        {
            //conexao
            SqlConnection conexaoBd = new SqlConnection(conexao);
            //comando
            SqlCommand comandoBd = new SqlCommand();
            comandoBd.CommandText = "Insert Into Mercadorias (nome,validade, alcool, saldo_estoque, valor_produto) Values (@nome, @validade, @alcool, @saldo, @valor)";
            comandoBd.Connection = conexaoBd;
            //parametros do comando
            comandoBd.Parameters.AddWithValue("@nome", mercadoria.nome);
            comandoBd.Parameters.AddWithValue("@validade", mercadoria.validade);
            comandoBd.Parameters.AddWithValue("@alcool", mercadoria.alcool);
            comandoBd.Parameters.AddWithValue("@saldo", mercadoria.saldo_estoque);
            comandoBd.Parameters.AddWithValue("@valor", mercadoria.valor_produto);


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
        //metodo de consulta de dados no BD   
        public void AlterarMercadoria(Mercadoria mercadoria)
        {
            //conexao
            SqlConnection conexaoBd = new SqlConnection(conexao);
            //comando
            SqlCommand comandoBd = new SqlCommand();
            comandoBd.CommandText = "update Mercadorias set nome=@nome, alcool=@alcool, saldo_estoque=@saldo, valor_produto=@valor, validade=@validade where cod_mercadorias=@cod_mercadorias";
            comandoBd.Connection = conexaoBd;
            //parametros do comando

            comandoBd.Parameters.AddWithValue("@nome", mercadoria.nome);
            comandoBd.Parameters.AddWithValue("@validade", mercadoria.validade);
            comandoBd.Parameters.AddWithValue("@alcool", mercadoria.alcool);
            comandoBd.Parameters.AddWithValue("@saldo", mercadoria.saldo_estoque);
            comandoBd.Parameters.AddWithValue("@valor", mercadoria.valor_produto);
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
        public void DeletarMercadoria(int cod_mercadorias)
        {
            //conexao
            SqlConnection conexaoBd = new SqlConnection(conexao);
            //comando
            SqlCommand comandoBd = new SqlCommand();
            comandoBd.CommandText = "delete Mercadorias where cod_mercadorias=@cod_mercadorias";
            comandoBd.Connection = conexaoBd;
            //parametros do comando

            
            comandoBd.Parameters.AddWithValue("@cod_mercadorias", cod_mercadorias);

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
        //metodo de consulta de dados no BD
        public Mercadoria ObtemMercadoria(int codigo)
        {
            //conexao
            SqlConnection conexaoBD = new SqlConnection(conexao);
            //comando
            SqlCommand comandoBD = new SqlCommand();
            comandoBD.CommandText = "Select * From mercadorias Where cod_mercadorias=@codigo";
            comandoBD.Parameters.AddWithValue("@codigo", codigo);
            comandoBD.Connection = conexaoBD;
            //tratamento de erros
            try
            {
                //conecta no banco de dados
                conexaoBD.Open();
                //ler os dados em memoria
                SqlDataReader tabelaBD = comandoBD.ExecuteReader();
                //converte os dados da tabela para o objeto cliente
                Mercadoria mercadoria = new Mercadoria();
                while (tabelaBD.Read())
                {
                    //converte os dados da tabela
                    mercadoria.nome = tabelaBD["nome"].ToString();
                    mercadoria.alcool = tabelaBD["alcool"].ToString();
                    mercadoria.saldo_estoque = Convert.ToInt32(tabelaBD["saldo_estoque"]);
                }
                //retorna os dados armazenado do cliente
                return mercadoria;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                //desconecta do banco de dados
                conexaoBD.Close();
            }
        }
    }
}
