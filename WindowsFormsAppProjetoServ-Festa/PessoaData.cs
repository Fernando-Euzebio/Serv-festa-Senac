using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseNamespace;
using bibliotecaDoSeuZe;

namespace PessoaDataNamespace
{
    internal class PessoaData
    {
        readonly string conexao = @"Server=SJR0577174W10-1\SQLEXPRESS;Database=ProjetoServFest;Integrated Security=SSPI;TrustServerCertificate=True";


        public void IncluirPessoa(Pessoa pessoa)
        {
            //conexao
            SqlConnection conexaoBd = new SqlConnection(conexao);
            SqlCommand commandBd = new SqlCommand();
            commandBd.CommandText = "Insert Into Pessoa (nome, data_nascimento, tipo) Values(@nome, @data_nascimento, @tipo)";
            commandBd.Connection= conexaoBd;    
            commandBd.Parameters.AddWithValue("@nome", pessoa.nome);
            commandBd.Parameters.AddWithValue("@data_nascimento", pessoa.data_nascimento);
            commandBd.Parameters.AddWithValue("@tipo", pessoa.tipo);

            //tratamento de erros
            try
            {
                //conecta no BD
                conexaoBd.Open();
                //executa o comando no BD
                commandBd.ExecuteNonQuery();

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

        public void AlterarPessoa(Pessoa pessoa)
        {
            //conexao
            SqlConnection conexaoBd = new SqlConnection(conexao);
            //comando
            SqlCommand comandoBd = new SqlCommand();
            comandoBd.CommandText = "update Pessoa set nome=@nome, tipo=@tipo, data_nascimento=@data_nascimento where cod_pessoa=@cod_pessoa";
            comandoBd.Connection = conexaoBd;
            //parametros do comando

            comandoBd.Parameters.AddWithValue("@nome", pessoa.nome);
            comandoBd.Parameters.AddWithValue("@tipo", pessoa.tipo);
            comandoBd.Parameters.AddWithValue("@data_nascimento", pessoa.data_nascimento);
            comandoBd.Parameters.AddWithValue("@cod_pessoa", pessoa.cod_pessoa);

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
        public void DeletarPessoa(int cod_pessoa)
        {
            //conexao
            SqlConnection conexaoBd = new SqlConnection(conexao);
            //comando
            SqlCommand comandoBd = new SqlCommand();
            comandoBd.CommandText = "delete Pessoa where cod_pessoa=@cod_pessoa";
            comandoBd.Connection = conexaoBd;
            //parametros do comando


            comandoBd.Parameters.AddWithValue("@cod_pessoa", cod_pessoa);

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
    }
}
