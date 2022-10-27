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

                sql = "insert into atividade values (@id_processo, @descricao)";

                for (int i = 0; i < processo.AtividadeList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_processo = processo.Id,
                        descricao = processo.AtividadeList[i].Descricao
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
}