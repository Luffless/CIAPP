using Dapper;
using System.Data.SQLite;

public class CreateTables
{
    public void CriaTabelas()
    {
        string sql;

        using (SQLiteConnection connection = new SQLiteConnection(StringConexao.stringConexao))
        {
            connection.Open();

            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                sql = @"create table if not exists usuario (
                            nome text,
                            login text,
                            senha text
                        )";

                connection.Execute(sql, transaction: transaction);

                sql = @"select count(*)
                          from usuario";

                if (!connection.QuerySingle<bool>(sql))
                {
                    sql = "insert into usuario values ('Admin', 'admin', '8a89e2c6bb99f438a671108c3c0f5c3f')";

                    connection.Execute(sql, transaction: transaction);
                }

                sql = @"create table if not exists prestador (
                            id integer,
                            cpf text,
                            nome text,
                            datanascimento text,
                            naturalidade text,
                            estadocivil text,
                            foto blob,
                            telefone integer,
                            etnia text,
                            sexo text,
                            profissao text,
                            rendafamiliar real,
                            religiao text,
                            grauinstrucao text,
                            recebebeneficio integer,
                            usaalcool integer,
                            usadrogas integer,
                            observacao text,
                            logradouro text,
                            numero integer,
                            complemento text,
                            bairro text,
                            municipio text,
                            cep text,
                            estado text
                        )";

                connection.Execute(sql, transaction: transaction);

                transaction.Commit();
            }
        }
    }
}