using Dapper;
using Npgsql;
using System.Collections.Generic;
using System.Linq;

public class ProcessoDAO
{
    public void Insert(Processo processo)
    {
        processo = VerificaEspacosEmBranco(processo);

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            connection.Open();

            using (NpgsqlTransaction transaction = connection.BeginTransaction())
            {
                string sql = "insert into processo values (@id, @varaorigem, @numeroartigopenal, @penaoriginaria, @horascumprir, @acordopersecucaopenal, @id_prestador)";

                connection.Execute(sql, param: new
                {
                    id = processo.Id,
                    varaorigem = processo.VaraOrigem,
                    numeroartigopenal = processo.NumeroArtigoPenal,
                    penaoriginaria = processo.PenaOriginaria,
                    horascumprir = processo.HorasCumprir,
                    acordopersecucaopenal = processo.AcordoPersecucaoPenal,
                    id_prestador = processo.Prestador.Id
                });

                sql = "insert into atividade values (@id_processo, @descricao)";

                for (int i = 0; i < processo.AtividadeList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_processo = processo.Id,
                        descricao = processo.AtividadeList[i].Descricao
                    }, transaction: transaction);
                }

                sql = "insert into frequencia values (@id_processo, @datafrequencia, @horascumpridas, @observacao)";

                for (int i = 0; i < processo.FrequenciaList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_processo = processo.Id,
                        datafrequencia = processo.FrequenciaList[i].DataFrequencia,
                        horascumpridas = processo.FrequenciaList[i].HorasCumpridas,
                        observacao = processo.FrequenciaList[i].Observacao
                    }, transaction: transaction);
                }

                transaction.Commit();
            }
        }
    }

    public void Update(Processo processo)
    {
        string sql;
        int i;

        processo = VerificaEspacosEmBranco(processo);

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            connection.Open();

            using (NpgsqlTransaction transaction = connection.BeginTransaction())
            {
                sql = @"update processo 
                           set varaorigem = @varaorigem,
                               numeroartigopenal = @numeroartigopenal,
                               penaoriginaria = @penaoriginaria, 
                               horascumprir = @horascumprir, 
                               acordopersecucaopenal = @acordopersecucaopenal, 
                               id_prestador = @id_prestador
                         where id = @id";

                connection.Execute(sql, param: new
                {
                    varaorigem = processo.VaraOrigem,
                    numeroartigopenal = processo.NumeroArtigoPenal,
                    penaoriginaria = processo.PenaOriginaria,
                    horascumprir = processo.HorasCumprir,
                    acordopersecucaopenal = processo.AcordoPersecucaoPenal,
                    id_prestador = processo.Prestador.Id,
                    id = processo.Id
                }, transaction: transaction);

                sql = @"delete from atividade
                         where id_processo = @id_processo";

                connection.Execute(sql, param: new { id_processo = processo.Id }, transaction: transaction);

                sql = @"delete from frequencia
                         where id_processo = @id_processo";

                connection.Execute(sql, param: new { id_processo = processo.Id }, transaction: transaction);

                sql = "insert into atividade values (@id_processo, @descricao)";

                for (i = 0; i < processo.AtividadeList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_processo = processo.Id,
                        descricao = processo.AtividadeList[i].Descricao
                    }, transaction: transaction);
                }

                sql = "insert into frequencia values (@id_processo, @datafrequencia, @horascumpridas, @observacao)";

                for (i = 0; i < processo.FrequenciaList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_processo = processo.Id,
                        datafrequencia = processo.FrequenciaList[i].DataFrequencia,
                        horascumpridas = processo.FrequenciaList[i].HorasCumpridas,
                        observacao = processo.FrequenciaList[i].Observacao
                    }, transaction: transaction);
                }

                transaction.Commit();
            }
        }
    }

    public void Delete(int idProcesso)
    {
        string sql;

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            connection.Open();

            using (NpgsqlTransaction transaction = connection.BeginTransaction())
            {
                sql = @"delete from frequencia
                         where id_processo = @id_processo";

                connection.Execute(sql, param: new { id_processo = idProcesso }, transaction: transaction);

                sql = @"delete from atividade
                         where id_processo = @id_processo";

                connection.Execute(sql, param: new { id_processo = idProcesso }, transaction: transaction);

                sql = @"delete from processo
                         where id = @id";

                connection.Execute(sql, param: new { id = idProcesso }, transaction: transaction);

                transaction.Commit();
            }
        }
    }

    private Processo VerificaEspacosEmBranco(Processo processo)
    {
        for (int i = 0; i < processo.FrequenciaList.Count; i++)
        {
            if (string.IsNullOrWhiteSpace(processo.FrequenciaList[i].Observacao))
            {
                processo.FrequenciaList[i].Observacao = null;
            }
        }

        return processo;
    }

    public IEnumerable<Processo> RecuperarTodosFiltrado(string cpfPrestador, string nomePrestador)
    {
        List<Processo> processoList = new List<Processo>();

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from processo, prestador
                            where processo.id_prestador = prestador.id";

            if (!string.IsNullOrWhiteSpace(cpfPrestador))
            {
                sql += " and prestador.cpf like CONCAT('%', @cpf, '%')";
            }

            if (!string.IsNullOrWhiteSpace(nomePrestador))
            {
                sql += " and upper(prestador.nome) like upper(CONCAT('%', @nome, '%'))";
            }

            sql += " order by processo.id";

            processoList = (List<Processo>)connection.Query<Processo, Prestador, Processo>(sql,
                           (processo, prestador) =>
                           {
                               processo.Prestador = prestador;
                               return processo;
                           },
                           splitOn: "Cpf",
                           param: new
                           {
                               cpf = cpfPrestador,
                               nome = nomePrestador
                           });

            for (int i = 0; i < processoList.Count; i++)
            {
                List<Atividade> atividadeList = new List<Atividade>();
                List<Frequencia> frequenciaList = new List<Frequencia>();

                sql = @"select *
                          from atividade
                         where id_processo = @id
                         order by descricao";

                atividadeList = (List<Atividade>)connection.Query<Atividade>(sql,
                                param: new
                                {
                                    id = processoList[i].Id
                                });

                sql = @"select *
                          from frequencia
                         where id_processo = @id
                         order by datafrequencia";

                frequenciaList = (List<Frequencia>)connection.Query<Frequencia>(sql,
                                 param: new
                                 {
                                     id = processoList[i].Id
                                 });

                processoList[i].AtividadeList = atividadeList;
                processoList[i].FrequenciaList = frequenciaList;
            }

            return processoList;
        }
    }

    public Processo RecuperarPorId(int idProcesso)
    {
        string sql;
        Processo processo;
        List<Atividade> atividadeList;
        List<Frequencia> frequenciaList;

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            sql = @"select *
                      from processo, prestador
                     where processo.id_prestador = prestador.id
                       and processo.id = @id";

            processo = connection.Query<Processo, Prestador, Endereco, Processo>(sql,
                       (processoRegistro, prestador, endereco) =>
                       {
                           processoRegistro.Prestador = prestador;
                           processoRegistro.Prestador.Endereco = endereco;
                           return processoRegistro;
                       },
                       splitOn: "Id, Logradouro",
                       param: new
                       {
                           id = idProcesso
                       }).Single();

            sql = @"select *
                      from atividade
                     where id_processo = @id
                     order by descricao";

            atividadeList = (List<Atividade>)connection.Query<Atividade>(sql,
                            param: new
                            {
                                id = idProcesso
                            });

            sql = @"select *
                      from frequencia
                     where id_processo = @id
                     order by datafrequencia";

            frequenciaList = (List<Frequencia>)connection.Query<Frequencia>(sql,
                             param: new
                             {
                                 id = idProcesso
                             });

            processo.AtividadeList = atividadeList;
            processo.FrequenciaList = frequenciaList;

            return processo;
        }
    }

    public int RetornaProximoId()
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select coalesce(max(id), 0) + 1
                             from processo";

            return connection.QuerySingle<int>(sql);
        }
    }

    public bool ExisteCpfProcesso(string cpfPrestador)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from processo, prestador
                            where processo.id_prestador = prestador.id
                              and prestador.cpf = @cpf";

            return connection.QuerySingle<bool>(sql, param: new
            {
                cpf = cpfPrestador
            });
        }
    }

    public bool ExisteCpfProcessoDiferente(int idProcesso, string cpfPrestador)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from processo, prestador
                            where processo.id_prestador = prestador.id
                              and processo.id <> @id
                              and prestador.cpf = @cpf";

            return connection.QuerySingle<bool>(sql, param: new
            {
                id = idProcesso,
                cpf = cpfPrestador
            });
        }
    }
}