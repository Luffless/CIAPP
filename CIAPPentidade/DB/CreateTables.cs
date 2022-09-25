using Dapper;
using System.Data.SQLite;

public class CreateTables
{
    public void CriaTabelas()
    {
        string sql;

        using (SQLiteConnection connection = new SQLiteConnection(StringConexao.stringConexao))
        {
            sql = @"create table if not exists usuario (
                        nome text,
                        login text,
                        senha text
                    )";

            connection.Execute(sql);

            sql = @"select count(*)
                      from usuario";

            if (!connection.QuerySingle<bool>(sql))
            {
                sql = "insert into usuario values ('Admin', 'admin', '8a89e2c6bb99f438a671108c3c0f5c3f')";

                connection.Execute(sql);
            }
        }
    }
}