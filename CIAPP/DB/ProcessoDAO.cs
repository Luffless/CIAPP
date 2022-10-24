using Dapper;
using Npgsql;
using System.Collections.Generic;
using System.Linq;

public class ProcessoDAO
{
    public void Insert(Processo processo)
    {
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

                sql = "insert into processo_entidade values (@id_processo, @id_entidade, @horascumprir, @atividade)";

                for (int i = 0; i < processo.ProcessoEntidadeList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_processo = processo.Id,
                        id_entidade = processo.ProcessoEntidadeList[i].Entidade.Id,
                        horascumprir = processo.ProcessoEntidadeList[i].HorasCumprir,
                        atividade = processo.ProcessoEntidadeList[i].Atividade
                    }, transaction: transaction);
                }

                transaction.Commit();
            }
        }
    }

    public IEnumerable<Processo> RecuperarTodosFiltrado(string nomePrestador, string numeroArtigoPenal)
    {
        List<Processo> processoList = new List<Processo>();

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from processo, prestador
                            where processo.id_prestador = prestador.id";

            if (!string.IsNullOrWhiteSpace(nomePrestador))
            {
                sql += " and upper(prestador.nome) like upper(CONCAT('%', @nomeprestador, '%'))";
            }

            if (!string.IsNullOrWhiteSpace(numeroArtigoPenal))
            {
                sql += " and processo.numeroartigopenal = @numeroartigopenal";
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
                               nomeprestador = nomePrestador,
                               numeroartigopenal = numeroArtigoPenal
                           });

            for (int i = 0; i < processoList.Count; i++)
            {
                List<ProcessoEntidade> processoEntidadeList;

                sql = @"select *
                          from processo_entidade, entidade
                         where processo_entidade.id_entidade = entidade.id
                           and processo_entidade.id_processo = @id
                         order by processo_entidade.id_entidade";

                processoEntidadeList = (List<ProcessoEntidade>)connection.Query<ProcessoEntidade, Entidade, ProcessoEntidade>(sql,
                                       (processoentidade, entidade) =>
                                       {
                                           processoentidade.Entidade = entidade;
                                           return processoentidade;
                                       },
                                       splitOn: "Id",
                                       param: new
                                       {
                                           id = processoList[i].Id
                                       });

                for (int j = 0; j < processoEntidadeList.Count; j++)
                {
                    sql = @"select *
                          from frequencia
                         where id_processo = @id_processo
                           and id_entidade = @id_entidade
                         order by datafrequencia";

                    processoEntidadeList[j].FrequenciaList = (List<Frequencia>)connection.Query<Frequencia>(sql,
                                                             param: new
                                                             {
                                                                 id_processo = processoList[i].Id,
                                                                 id_entidade = processoEntidadeList[i].Entidade.Id
                                                             });
                }

                processoList[i].ProcessoEntidadeList = processoEntidadeList;
            }

            return processoList;
        }
    }

    public Processo RecuperarPorId(int idProcesso)
    {
        string sql;
        Processo processo;
        List<ProcessoEntidade> processoEntidadeList;

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            sql = @"select *
                      from processo, prestador
                     where processo.id_prestador = prestador.id
                       and processo.id = @id";

            processo = connection.Query<Processo, Prestador, Processo>(sql,
                       (processoRegistro, prestador) =>
                       {
                           processoRegistro.Prestador = prestador;
                           return processoRegistro;
                       },
                       splitOn: "Cpf",
                       param: new
                       {
                           id = idProcesso
                       }).Single();

            sql = @"select *
                      from processo_entidade, entidade
                     where processo_entidade.id_entidade = entidade.id
                       and processo_entidade.id_processo = @id
                     order by processo_entidade.id_entidade";

            processoEntidadeList = (List<ProcessoEntidade>)connection.Query<ProcessoEntidade, Entidade, ProcessoEntidade>(sql,
                                   (processoentidade, entidade) =>
                                   {
                                       processoentidade.Entidade = entidade;
                                       return processoentidade;
                                   },
                                   splitOn: "Id",
                                   param: new
                                   {
                                       id = idProcesso
                                   });

            for (int i = 0; i < processoEntidadeList.Count; i++)
            {
                sql = @"select *
                          from frequencia
                         where id_processo = @id_processo
                           and id_entidade = @id_entidade
                         order by datafrequencia";

                processoEntidadeList[i].FrequenciaList = (List<Frequencia>)connection.Query<Frequencia>(sql,
                                                         param: new
                                                         {
                                                             id_processo = idProcesso,
                                                             id_entidade = processoEntidadeList[i].Entidade.Id
                                                         });
            }

            processo.ProcessoEntidadeList = processoEntidadeList;

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

    public bool ExisteCnpjProcesso(string cnpjEntidade)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from processo_entidade, entidade
                            where processo_entidade.id_entidade = entidade.id
                              and entidade.cnpj = @cnpj";

            return connection.QuerySingle<bool>(sql, param: new
            {
                cnpj = cnpjEntidade
            });
        }
    }
}