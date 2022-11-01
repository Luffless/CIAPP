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
                            nome text not null,
                            login text not null,
                            senha text not null
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
                            id integer primary key,
                            cpf text not null unique,
                            nome text not null,
                            datanascimento text not null,
                            naturalidade text not null,
                            estadocivil text not null,
                            foto blob not null,
                            telefone integer not null,
                            etnia text not null,
                            sexo text not null,
                            profissao text not null,
                            rendafamiliar real not null,
                            religiao text not null,
                            grauinstrucao text not null,
                            recebebeneficio integer not null,
                            usaalcool integer not null,
                            usadrogas integer not null,
                            observacao text,
                            logradouro text not null,
                            numero integer not null,
                            complemento text,
                            bairro text not null,
                            municipio text not null,
                            cep text not null,
                            estado text not null
                        )";

                connection.Execute(sql, transaction: transaction);

                sql = @"create table if not exists parentesco (
                            id_prestador integer,
                            nome text,
                            grauparentesco text not null,
                            primary key(id_prestador, nome),
                            foreign key(id_prestador) references prestador(id)
                        )";

                connection.Execute(sql, transaction: transaction);

                sql = @"create table if not exists habilidade (
                            id_prestador integer,
                            descricao text,
                            primary key(id_prestador, descricao),
                            foreign key(id_prestador) references prestador(id)
                        )";

                connection.Execute(sql, transaction: transaction);

                sql = @"create table if not exists deficiencia (
                            id_prestador integer,
                            descricao text,
                            primary key(id_prestador, descricao),
                            foreign key(id_prestador) references prestador(id)
                        )";

                connection.Execute(sql, transaction: transaction);

                sql = @"create table if not exists doenca (
                            id_prestador integer,
                            descricao text,
                            primary key(id_prestador, descricao),
                            foreign key(id_prestador) references prestador(id)
                        )";

                connection.Execute(sql, transaction: transaction);

                sql = @"create table if not exists processo (
                            id integer primary key,
                            varaorigem text not null,
                            numeroartigopenal integer not null,
                            penaoriginaria text not null,
                            horascumprir integer not null,
                            acordopersecucaopenal integer not null,
                            id_prestador integer not null,
                            foreign key(id_prestador) references prestador(id)
                        )";

                connection.Execute(sql, transaction: transaction);

                sql = @"create table if not exists atividade (
                            id_processo integer,
                            descricao text,
                            primary key(id_processo, descricao),
                            foreign key(id_processo) references processo(id)
                        )";

                connection.Execute(sql, transaction: transaction);

                sql = @"create table if not exists frequencia (
                            id_processo integer,
                            datafrequencia text,
                            horascumpridas integer not null,
                            observacao text,
                            primary key(id_processo, datafrequencia),
                            foreign key(id_processo) references processo(id)
                        )";

                connection.Execute(sql, transaction: transaction);

                transaction.Commit();
            }
        }
    }
}