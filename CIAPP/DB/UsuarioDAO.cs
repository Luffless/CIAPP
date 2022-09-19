using Dapper;
using Npgsql;
using System.Collections.Generic;

public class UsuarioDAO
{
    public void Insert(Usuario usuario)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = "insert into usuario values (@id, @nome, @email, @login, @senha)";

            connection.Query(sql, param: new
            {
                id = usuario.Id,
                nome = usuario.Nome,
                email = usuario.Email,
                login = usuario.Login,
                senha = usuario.Senha
            });
        }
    }

    public void Update(Usuario usuario) 
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql;

            if (string.IsNullOrWhiteSpace(usuario.Senha))
            {
                sql = @"update usuario
                           set nome = @nome,
                               email = @email,
                               login = @login
                         where id = @id";

                connection.Query(sql, param: new
                {
                    nome = usuario.Nome,
                    email = usuario.Email,
                    login = usuario.Login,
                    id = usuario.Id
                });
            }
            else
            {
                sql = @"update usuario
                           set nome = @nome,
                               email = @email,
                               login = @login,
                               senha = @senha
                         where id = @id";

                connection.Query(sql, param: new
                {
                    nome = usuario.Nome,
                    email = usuario.Email,
                    login = usuario.Login,
                    senha = usuario.Senha,
                    id = usuario.Id
                });
            }
        }
    }

    public void Delete(int idUsuario)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"delete from usuario
                            where id = @id";

            connection.Query(sql, param: new { id = idUsuario });
        }
    }

    public IEnumerable<Usuario> RecuperarTodosFiltrado(string nomeUsuario, string emailUsuario)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from usuario
                            where id <> 0";

            if (!string.IsNullOrWhiteSpace(nomeUsuario))
            {
                sql += " and upper(nome) like upper(CONCAT('%', @nome, '%'))";
            }

            if (!string.IsNullOrWhiteSpace(emailUsuario))
            {
                sql += " and upper(email) like upper(CONCAT('%', @email, '%'))";
            }

            sql += " order by id";

            return connection.Query<Usuario>(sql, param: new
                   {
                       nome = nomeUsuario,
                       email = emailUsuario
                   });
        }
    }

    public Usuario RecuperarPorId(int idUsuario)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from usuario
                            where id = @id";

            return connection.QuerySingle<Usuario>(sql, param: new { id = idUsuario });
        }
    }

    public string RecuperarPorLogin(string loginUsuario)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select nome
                             from usuario
                            where login = @login";

            return connection.QuerySingle<string>(sql, param: new { login = loginUsuario });
        }
    }

    public bool ExisteUsuarioLogin(string loginUsuario, string senhaUsuario)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from usuario
                            where login = @login
                              and senha = @senha";

            return connection.QuerySingle<bool>(sql, param: new
                   {
                       login = loginUsuario,
                       senha = senhaUsuario
                   });
        }
    }

    public bool ExisteLogin(int idUsuario, string loginUsuario)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from usuario
                            where id <> @id
                              and login = @login";

            return connection.QuerySingle<bool>(sql, param: new
                   { 
                       id = idUsuario,
                       login = loginUsuario
                   });
        }
    }

    public bool ExisteEmail(int idUsuario, string emailUsuario)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from usuario
                            where id <> @id
                              and email = @email";

            return connection.QuerySingle<bool>(sql, param: new
                   {
                       id = idUsuario,
                       email = emailUsuario
                   });
        }
    }

    public int RetornaProximoId()
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select max(id) + 1
                             from usuario";

            return connection.QuerySingle<int>(sql);
        }
    }
}