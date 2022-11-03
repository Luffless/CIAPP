using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

public class ProcessoDAO
{
    public void Insert(Processo processo)
    {
        int i;
        string sql;
        processo = VerificaEspacosEmBranco(processo);

        using (SQLiteConnection connection = new SQLiteConnection(StringConexao.stringConexao))
        {
            connection.Open();

            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                sql = @"insert into prestador values (@id, @cpf, @nome, @datanascimento, @naturalidade, @estadocivil, @foto, @telefone, @etnia, @sexo, @profissao, 
                                                      @rendafamiliar, @religiao, @grauinstrucao, @recebebeneficio, @usaalcool, @usadrogas, @observacao,
                                                      @logradouro, @numero, @complemento, @bairro, @municipio, @cep, @estado)";

                connection.Execute(sql, param: new
                {
                    id = processo.Prestador.Id,
                    cpf = processo.Prestador.Cpf,
                    nome = processo.Prestador.Nome,
                    datanascimento = processo.Prestador.DataNascimento,
                    naturalidade = processo.Prestador.Naturalidade,
                    estadocivil = processo.Prestador.EstadoCivil,
                    foto = processo.Prestador.Foto,
                    telefone = processo.Prestador.Telefone,
                    etnia = processo.Prestador.Etnia,
                    sexo = processo.Prestador.Sexo,
                    profissao = processo.Prestador.Profissao,
                    rendafamiliar = processo.Prestador.RendaFamiliar,
                    religiao = processo.Prestador.Religiao,
                    grauinstrucao = processo.Prestador.GrauInstrucao,
                    recebebeneficio = processo.Prestador.RecebeBeneficio,
                    usaalcool = processo.Prestador.UsaAlcool,
                    usadrogas = processo.Prestador.UsaDrogas,
                    observacao = processo.Prestador.Observacao,
                    logradouro = processo.Prestador.Endereco.Logradouro,
                    numero = processo.Prestador.Endereco.Numero,
                    complemento = processo.Prestador.Endereco.Complemento,
                    bairro = processo.Prestador.Endereco.Bairro,
                    municipio = processo.Prestador.Endereco.Municipio,
                    cep = processo.Prestador.Endereco.Cep,
                    estado = processo.Prestador.Endereco.Estado
                }, transaction: transaction);

                sql = "insert into parentesco values (@id_prestador, @nome, @grauparentesco)";

                for (i = 0; i < processo.Prestador.ParentescoList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_prestador = processo.Prestador.Id,
                        nome = processo.Prestador.ParentescoList[i].Nome,
                        grauparentesco = processo.Prestador.ParentescoList[i].GrauParentesco
                    }, transaction: transaction);
                }

                sql = "insert into habilidade values (@id_prestador, @descricao)";

                for (i = 0; i < processo.Prestador.HabilidadeList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_prestador = processo.Prestador.Id,
                        descricao = processo.Prestador.HabilidadeList[i].Descricao
                    }, transaction: transaction);
                }

                sql = "insert into deficiencia values (@id_prestador, @descricao)";

                for (i = 0; i < processo.Prestador.DeficienciaList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_prestador = processo.Prestador.Id,
                        descricao = processo.Prestador.DeficienciaList[i].Descricao
                    }, transaction: transaction);
                }

                sql = "insert into doenca values (@id_prestador, @descricao)";

                for (i = 0; i < processo.Prestador.DoencaList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_prestador = processo.Prestador.Id,
                        descricao = processo.Prestador.DoencaList[i].Descricao
                    }, transaction: transaction);
                }

                sql = "insert into processo values (@id, @varaorigem, @numeroartigopenal, @penaoriginaria, @horascumprir, @acordopersecucaopenal, @id_prestador)";

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

    public void Delete(Processo processo)
    {
        string sql;

        using (SQLiteConnection connection = new SQLiteConnection(StringConexao.stringConexao))
        {
            connection.Open();

            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                sql = @"delete from frequencia
                         where id_processo = @id_processo";

                connection.Execute(sql, param: new { id_processo = processo.Id }, transaction: transaction);

                sql = @"delete from atividade
                         where id_processo = @id_processo";

                connection.Execute(sql, param: new { id_processo = processo.Id }, transaction: transaction);

                sql = @"delete from processo
                         where id = @id_processo";

                connection.Execute(sql, param: new { id_processo = processo.Id }, transaction: transaction);

                sql = @"delete from doenca
                         where id_prestador = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = processo.Prestador.Id }, transaction: transaction);

                sql = @"delete from deficiencia
                         where id_prestador = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = processo.Prestador.Id }, transaction: transaction);

                sql = @"delete from habilidade
                         where id_prestador = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = processo.Prestador.Id }, transaction: transaction);

                sql = @"delete from parentesco
                         where id_prestador = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = processo.Prestador.Id }, transaction: transaction);

                sql = @"delete from prestador
                         where id = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = processo.Prestador.Id }, transaction: transaction);

                transaction.Commit();
            }
        }
    }

    public void DeletaInsereFrequencia(int idProcesso, List<Frequencia> frequenciaList)
    {
        string sql;

        using (SQLiteConnection connection = new SQLiteConnection(StringConexao.stringConexao))
        {
            connection.Open();

            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                sql = @"delete from frequencia
                         where id_processo = @id_processo";

                connection.Execute(sql, param: new { id_processo = idProcesso }, transaction: transaction);

                sql = "insert into frequencia values (@id_processo, @datafrequencia, @horascumpridas, @observacao)";

                for (int i = 0; i < frequenciaList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_processo = idProcesso,
                        datafrequencia = frequenciaList[i].DataFrequencia,
                        horascumpridas = frequenciaList[i].HorasCumpridas,
                        observacao = frequenciaList[i].Observacao
                    }, transaction: transaction);
                }

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

        using (SQLiteConnection connection = new SQLiteConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from processo, prestador
                            where processo.id_prestador = prestador.id";

            if (!string.IsNullOrWhiteSpace(cpfPrestador))
            {
                sql += " and prestador.cpf like '%' || @cpf || '%'";
            }

            if (!string.IsNullOrWhiteSpace(nomePrestador))
            {
                sql += " and upper(prestador.nome) like upper('%' || @nome || '%')";
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
        List<Parentesco> parentescoList;
        List<Habilidade> habilidadeList;
        List<Deficiencia> deficienciaList;
        List<Doenca> doencaList;
        List<Atividade> atividadeList;
        List<Frequencia> frequenciaList;

        using (SQLiteConnection connection = new SQLiteConnection(StringConexao.stringConexao))
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

            sql = @"select nome, grauparentesco
                      from parentesco
                     where id_prestador = @id
                     order by nome";

            parentescoList = (List<Parentesco>)connection.Query<Parentesco>(sql,
                             param: new
                             {
                                 id = processo.Prestador.Id
                             });

            sql = @"select descricao
                      from habilidade
                     where id_prestador = @id
                     order by descricao";

            habilidadeList = (List<Habilidade>)connection.Query<Habilidade>(sql,
                             param: new
                             {
                                 id = processo.Prestador.Id
                             });

            sql = @"select descricao
                      from deficiencia
                     where id_prestador = @id
                     order by descricao";

            deficienciaList = (List<Deficiencia>)connection.Query<Deficiencia>(sql,
                              param: new
                              {
                                  id = processo.Prestador.Id
                              });

            sql = @"select descricao
                      from doenca
                     where id_prestador = @id
                     order by descricao";

            doencaList = (List<Doenca>)connection.Query<Doenca>(sql,
                         param: new
                         {
                             id = processo.Prestador.Id
                         });

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

            processo.Prestador.ParentescoList = parentescoList;
            processo.Prestador.HabilidadeList = habilidadeList;
            processo.Prestador.DeficienciaList = deficienciaList;
            processo.Prestador.DoencaList = doencaList;
            processo.AtividadeList = atividadeList;
            processo.FrequenciaList = frequenciaList;

            return processo;
        }
    }
}