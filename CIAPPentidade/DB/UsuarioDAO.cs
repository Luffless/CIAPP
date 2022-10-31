using Dapper;
using System.Data.SQLite;

public class UsuarioDAO
{
    public Usuario RecuperarPorLogin(string loginUsuario)
    {
        using (SQLiteConnection connection = new SQLiteConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from usuario
                            where login = @login";

            return connection.QuerySingle<Usuario>(sql, param: new { login = loginUsuario });
        }
    }

    public bool ExisteUsuarioLogin(string loginUsuario, string senhaUsuario)
    {
        using (SQLiteConnection connection = new SQLiteConnection(StringConexao.stringConexao))
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
}