using Dapper;
using Npgsql;
using System.Collections.Generic;
using System.Linq;

public class PrestadorDAO
{
    public void Insert(Prestador prestador)
    {
        string sql;
        int i;

        prestador = VerificaEspacosEmBranco(prestador);

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            connection.Open();

            using (NpgsqlTransaction transaction = connection.BeginTransaction())
            {
                sql = @"insert into prestador values (@id, @cpf, @nome, @datanascimento, @naturalidade, @estadocivil, @foto, @telefone, @etnia, @sexo, @profissao, 
                                                      @rendafamiliar, @religiao, @grauinstrucao, @recebebeneficio, @usaalcool, @usadrogas, @observacao,
                                                      @logradouro, @numero, @complemento, @bairro, @municipio, @cep, @estado)";

                connection.Execute(sql, param: new
                {
                    id = prestador.Id,
                    cpf = prestador.Cpf,
                    nome = prestador.Nome,
                    datanascimento = prestador.DataNascimento,
                    naturalidade = prestador.Naturalidade,
                    estadocivil = prestador.EstadoCivil,
                    foto = prestador.Foto,
                    telefone = prestador.Telefone,
                    etnia = prestador.Etnia,
                    sexo = prestador.Sexo,
                    profissao = prestador.Profissao,
                    rendafamiliar = prestador.RendaFamiliar,
                    religiao = prestador.Religiao,
                    grauinstrucao = prestador.GrauInstrucao,
                    recebebeneficio = prestador.RecebeBeneficio,
                    usaalcool = prestador.UsaAlcool,
                    usadrogas = prestador.UsaDrogas,
                    observacao = prestador.Observacao,
                    logradouro = prestador.Endereco.Logradouro,
                    numero = prestador.Endereco.Numero,
                    complemento = prestador.Endereco.Complemento,
                    bairro = prestador.Endereco.Bairro,
                    municipio = prestador.Endereco.Municipio,
                    cep = prestador.Endereco.Cep,
                    estado = prestador.Endereco.Estado
                }, transaction: transaction);

                sql = "insert into parentesco values (@id_prestador, @nome, @grauparentesco)";

                for (i = 0; i < prestador.ParentescoList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_prestador = prestador.Id,
                        nome = prestador.ParentescoList[i].Nome,
                        grauparentesco = prestador.ParentescoList[i].GrauParentesco
                    }, transaction: transaction);
                }

                sql = "insert into habilidade values (@id_prestador, @descricao)";

                for (i = 0; i < prestador.HabilidadeList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_prestador = prestador.Id,
                        descricao = prestador.HabilidadeList[i].Descricao
                    }, transaction: transaction);
                }

                sql = "insert into deficiencia values (@id_prestador, @descricao)";

                for (i = 0; i < prestador.DeficienciaList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_prestador = prestador.Id,
                        descricao = prestador.DeficienciaList[i].Descricao
                    }, transaction: transaction);
                }

                sql = "insert into doenca values (@id_prestador, @descricao)";

                for (i = 0; i < prestador.DoencaList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_prestador = prestador.Id,
                        descricao = prestador.DoencaList[i].Descricao
                    }, transaction: transaction);
                }

                transaction.Commit();
            }
        }
    }

    public void Update(Prestador prestador)
    {
        string sql;
        int i;

        prestador = VerificaEspacosEmBranco(prestador);

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            connection.Open();

            using (NpgsqlTransaction transaction = connection.BeginTransaction())
            {
                sql = @"update prestador 
                           set cpf = @cpf,
                               nome = @nome,
                               datanascimento = @datanascimento, 
                               naturalidade = @naturalidade, 
                               estadocivil = @estadocivil, 
                               foto = @foto,
                               telefone = @telefone,
                               etnia = @etnia, 
                               sexo = @sexo,
                               profissao = @profissao, 
                               rendafamiliar = @rendafamiliar,
                               religiao = @religiao, 
                               grauinstrucao = @grauinstrucao, 
                               recebebeneficio = @recebebeneficio, 
                               usaalcool = @usaalcool,
                               usadrogas = @usadrogas,
                               observacao = @observacao,
                               logradouro = @logradouro, 
                               numero = @numero, 
                               complemento = @complemento, 
                               bairro = @bairro, 
                               municipio = @municipio, 
                               cep = @cep, 
                               estado = @estado
                         where id = @id";

                connection.Execute(sql, param: new
                {
                    cpf = prestador.Cpf,
                    nome = prestador.Nome,
                    datanascimento = prestador.DataNascimento,
                    naturalidade = prestador.Naturalidade,
                    estadocivil = prestador.EstadoCivil,
                    foto = prestador.Foto,
                    telefone = prestador.Telefone,
                    etnia = prestador.Etnia,
                    sexo = prestador.Sexo,
                    profissao = prestador.Profissao,
                    rendafamiliar = prestador.RendaFamiliar,
                    religiao = prestador.Religiao,
                    grauinstrucao = prestador.GrauInstrucao,
                    recebebeneficio = prestador.RecebeBeneficio,
                    usaalcool = prestador.UsaAlcool,
                    usadrogas = prestador.UsaDrogas,
                    observacao = prestador.Observacao,
                    logradouro = prestador.Endereco.Logradouro,
                    numero = prestador.Endereco.Numero,
                    complemento = prestador.Endereco.Complemento,
                    bairro = prestador.Endereco.Bairro,
                    municipio = prestador.Endereco.Municipio,
                    cep = prestador.Endereco.Cep,
                    estado = prestador.Endereco.Estado,
                    id = prestador.Id
                }, transaction: transaction);

                sql = @"delete from parentesco
                         where id_prestador = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = prestador.Id }, transaction: transaction);

                sql = @"delete from habilidade
                         where id_prestador = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = prestador.Id }, transaction: transaction);

                sql = @"delete from deficiencia
                         where id_prestador = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = prestador.Id }, transaction: transaction);

                sql = @"delete from doenca
                         where id_prestador = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = prestador.Id }, transaction: transaction);

                sql = "insert into parentesco values (@id_prestador, @nome, @grauparentesco)";

                for (i = 0; i < prestador.ParentescoList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_prestador = prestador.Id,
                        nome = prestador.ParentescoList[i].Nome,
                        grauparentesco = prestador.ParentescoList[i].GrauParentesco
                    }, transaction: transaction);
                }

                sql = "insert into habilidade values (@id_prestador, @descricao)";

                for (i = 0; i < prestador.HabilidadeList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_prestador = prestador.Id,
                        descricao = prestador.HabilidadeList[i].Descricao
                    }, transaction: transaction);
                }

                sql = "insert into deficiencia values (@id_prestador, @descricao)";

                for (i = 0; i < prestador.DeficienciaList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_prestador = prestador.Id,
                        descricao = prestador.DeficienciaList[i].Descricao
                    }, transaction: transaction);
                }

                sql = "insert into doenca values (@id_prestador, @descricao)";

                for (i = 0; i < prestador.DoencaList.Count; i++)
                {
                    connection.Execute(sql, param: new
                    {
                        id_prestador = prestador.Id,
                        descricao = prestador.DoencaList[i].Descricao
                    }, transaction: transaction);
                }

                transaction.Commit();
            }
        }
    }

    public void Delete(int idPrestador)
    {
        string sql;

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            connection.Open();

            using (NpgsqlTransaction transaction = connection.BeginTransaction())
            {
                sql = @"delete from parentesco
                         where id_prestador = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = idPrestador }, transaction: transaction);

                sql = @"delete from habilidade
                         where id_prestador = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = idPrestador }, transaction: transaction);

                sql = @"delete from deficiencia
                         where id_prestador = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = idPrestador }, transaction: transaction);

                sql = @"delete from doenca
                         where id_prestador = @id_prestador";

                connection.Execute(sql, param: new { id_prestador = idPrestador }, transaction: transaction);

                sql = @"delete from prestador
                         where id = @id";

                connection.Execute(sql, param: new { id = idPrestador }, transaction: transaction);

                transaction.Commit();
            }
        }
    }

    private Prestador VerificaEspacosEmBranco(Prestador prestador)
    {
        if (string.IsNullOrWhiteSpace(prestador.Observacao))
        {
            prestador.Observacao = null;
        }

        if (string.IsNullOrWhiteSpace(prestador.Endereco.Complemento))
        {
            prestador.Endereco.Complemento = null;
        }

        return prestador;
    }

    public IEnumerable<Prestador> RecuperarTodosFiltrado(string cpfPrestador, string nomePrestador)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from prestador
                            where 1 = 1";

            if (!string.IsNullOrWhiteSpace(cpfPrestador))
            {
                sql += " and cpf like CONCAT('%', @cpf, '%')";
            }

            if (!string.IsNullOrWhiteSpace(nomePrestador))
            {
                sql += " and upper(nome) like upper(CONCAT('%', @nome, '%'))";
            }

            sql += " order by id";

            return connection.Query<Prestador, Endereco, Prestador>(sql,
                   (entidade, endereco) =>
                   {
                       entidade.Endereco = endereco;
                       return entidade;
                   },
                   splitOn: "Logradouro",
                   param: new
                   {
                       cpf = cpfPrestador,
                       nome = nomePrestador
                   });
        }
    }

    public Prestador RecuperarPorId(int idPrestador)
    {
        string sql;
        Prestador prestadorRegistro;
        List<Parentesco> parentescoList;
        List<Habilidade> habilidadeList;
        List<Deficiencia> deficienciaList;
        List<Doenca> doencaList;

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            sql = @"select *
                      from prestador
                     where id = @id";

            prestadorRegistro = connection.Query<Prestador, Endereco, Prestador>(sql,
                                (prestador, endereco) =>
                                {
                                    prestador.Endereco = endereco;
                                    return prestador;
                                },
                                splitOn: "Logradouro",
                                param: new
                                {
                                    id = idPrestador
                                }).Single();

            sql = @"select nome, grauparentesco
                      from parentesco
                     where id_prestador = @id
                     order by nome";

            parentescoList = (List<Parentesco>)connection.Query<Parentesco>(sql,
                             param: new
                             {
                                 id = idPrestador
                             });

            sql = @"select descricao
                      from habilidade
                     where id_prestador = @id
                     order by descricao";

            habilidadeList = (List<Habilidade>)connection.Query<Habilidade>(sql,
                             param: new
                             {
                                 id = idPrestador
                             });

            sql = @"select descricao
                      from deficiencia
                     where id_prestador = @id
                     order by descricao";

            deficienciaList = (List<Deficiencia>)connection.Query<Deficiencia>(sql,
                              param: new
                              {
                                  id = idPrestador
                              });

            sql = @"select descricao
                      from doenca
                     where id_prestador = @id
                     order by descricao";

            doencaList = (List<Doenca>)connection.Query<Doenca>(sql,
                         param: new
                         {
                             id = idPrestador
                         });

            prestadorRegistro.ParentescoList = parentescoList;
            prestadorRegistro.HabilidadeList = habilidadeList;
            prestadorRegistro.DeficienciaList = deficienciaList;
            prestadorRegistro.DoencaList = doencaList;

            return prestadorRegistro;
        }
    }

    public int RetornaProximoId()
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select coalesce(max(id), 0) + 1
                             from prestador";

            return connection.QuerySingle<int>(sql);
        }
    }

    public bool ExisteCpf(string cpfPrestador)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from prestador
                            where cpf = @cpf";

            return connection.QuerySingle<bool>(sql, param: new
            {
                cpf = cpfPrestador
            });
        }
    }

    public bool ExisteCpfIdDiferente(int idPrestador, string cpfPrestador)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from prestador
                            where id <> @id
                              and cpf = @cpf";

            return connection.QuerySingle<bool>(sql, param: new
            {
                id = idPrestador,
                cpf = cpfPrestador
            });
        }
    }

    public Prestador RecuperarPorCpf(string cpfPrestador)
    {
        string sql;

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            sql = @"select *
                      from prestador
                     where cpf = @cpf";

            return connection.Query<Prestador>(sql,
                   param: new
                   {
                       cpf = cpfPrestador
                   }).SingleOrDefault();
        }
    }
}