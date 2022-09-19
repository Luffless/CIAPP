using Dapper;
using Npgsql;
using System.Collections.Generic;
using System.Linq;

public class UsuarioDAO
{
    public void Insert(Usuario usuario)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            if (usuario.Tipo == "Fórum")
            {
                string sql = @"insert into usuario (id, nome, login, senha, email, tipo) values
                                                   (@id, @nome, @login, @senha, @email, @tipo)";

                connection.Query(sql, param: new
                {
                    id = usuario.Id,
                    nome = usuario.Nome,
                    login = usuario.Login,
                    senha = usuario.Senha,
                    email = usuario.Email,
                    tipo = usuario.Tipo
                });
            }
            else
            {
                string sql = @"insert into usuario (id, nome, login, senha, email, tipo, id_entidade) values
                                                   (@id, @nome, @login, @senha, @email, @tipo, @id_entidade)";
                connection.Query(sql, param: new
                {
                    id = usuario.Id,
                    nome = usuario.Nome,
                    login = usuario.Login,
                    senha = usuario.Senha,
                    email = usuario.Email,
                    tipo = usuario.Tipo,
                    id_entidade = usuario.Entidade.Id
                });
            }
        }
    }

    public void Update(Usuario usuario) 
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"update usuario
                              set nome = @nome,
                                  login = @login,";

            if (!string.IsNullOrWhiteSpace(usuario.Senha))
            {
                sql += " senha = @senha,";
            }

            sql += @" email = @email,
                       tipo = @tipo
                      where id = @id";

            if (string.IsNullOrWhiteSpace(usuario.Senha))
            {
                connection.Query(sql, param: new
                {
                    nome = usuario.Nome,
                    login = usuario.Login,
                    email = usuario.Email,
                    tipo = usuario.Tipo,
                    id = usuario.Id
                });
            }
            else
            {
                connection.Query(sql, param: new
                {
                    nome = usuario.Nome,
                    login = usuario.Login,
                    senha = usuario.Senha,
                    email = usuario.Email,
                    tipo = usuario.Tipo,
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

    public IEnumerable<Usuario> RecuperarTodos()
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from usuario
                             left join entidade 
                               on usuario.id_entidade = entidade.id
                            where usuario.id <> 0";

            return connection.Query<Usuario, Entidade, Usuario>(sql,
                   (usuario, entidade) =>
                   {
                       usuario.Entidade = entidade;
                       return usuario;
                   },
                   splitOn: "id_entidade");
        }
    }

    public Usuario RecuperarPorId(int idUsuario)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from usuario
                             left join entidade 
                               on usuario.id_entidade = entidade.id
                            where usuario.id = @id";

            return connection.Query<Usuario, Entidade, Usuario>(sql,
                   (usuario, entidade) =>
                   {
                       usuario.Entidade = entidade;
                       return usuario;
                   },
                   splitOn: "id_entidade",
                   param: new
                   {
                       id = idUsuario
                   }).Single();
        }
    }

    public bool ExisteUsuarioLogin(string loginUsuario, string senhaUsuario)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from usuario
                            where login = @login
                              and senha = @senha
                              and tipo = 'Fórum'";

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

    public bool ExisteEntidadeUsuario(int idEntidade)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from usuario
                            where id_entidade = @id";

            return connection.QuerySingle<bool>(sql, param: new { id = idEntidade });
        }
    }

    public bool ExisteEntidadeUsuarioDiferente(int idUsuario, int idEntidade)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from usuario
                            where id <> @id
                              and id_entidade = @id_entidade";

            return connection.QuerySingle<bool>(sql, param: new
                   {
                       id = idUsuario,
                       id_entidade = idEntidade
                   });
        }
    }
}