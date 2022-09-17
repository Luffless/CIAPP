using Npgsql;
using System;
using Npgsql;
using System.Data.SqlClient;

namespace CIAPP.DB
{
    internal class UsuarioDAO
    {
        public UsuarioDAO() { }

        NpgsqlConnection conexao;

        //da pra criar uma classe só pra conexão pra n ficar conectando toda hora
        String conexao_postgre = @"Server=127.0.0.1;Port=5432;User id=postgres;Password=admin;Database=CIAPP";

        public void insert(Usuario usuario) 
        {
            string sql1;
            sql1 = ("Insert into usuario (nome, login, senha, email, tipo) values (@nome, @login, @senha, @email, @tipo)");
            try
            {
                conexao = new NpgsqlConnection(conexao_postgre);
                NpgsqlCommand sql = new NpgsqlCommand(sql1,conexao);
                sql.Parameters.AddWithValue("@nome",usuario.Nome);
                sql.Parameters.AddWithValue("@login",usuario.Login);
                sql.Parameters.AddWithValue("@senha",usuario.Senha);
                sql.Parameters.AddWithValue("@email",usuario.Email);
                sql.Parameters.AddWithValue("@tipo",usuario.Tipo);

                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception oErro)
            {

                throw oErro;
            }
            finally
            {
                conexao.Close();
            }
        
        }

        public void alter(Usuario usuario) 
        {
        
        
        }

        public void delete(Usuario usuario)
        { 
        
        }
    }
}
