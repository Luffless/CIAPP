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

            using (var transaction = connection.BeginTransaction())
            {
                sql = @"insert into prestador values (@id, @nome, @datanascimento, @naturalidade, @estadocivil, @foto, @etnia, @profissao, 
                                                      @telefone, @religiao, @grauinstrucao, @recebebeneficio, @usaalcool, @usadrogas, @observacao,
                                                      @rua, @numero, @complemento, @bairro, @municipio, @cep, @estado)";

                connection.Execute(sql, param: new
                {
                    id = prestador.Id,
                    nome = prestador.Nome,
                    datanascimento = prestador.DataNascimento,
                    naturalidade = prestador.Naturalidade,
                    estadocivil = prestador.EstadoCivil,
                    foto = prestador.Foto,
                    etnia = prestador.Etnia,
                    profissao = prestador.Profissao,
                    telefone = prestador.Telefone,
                    religiao = prestador.Religiao,
                    grauinstrucao = prestador.GrauInstrucao,
                    recebebeneficio = prestador.RecebeBeneficio,
                    usaalcool = prestador.UsaAlcool,
                    usadrogas = prestador.UsaDrogas,
                    observacao = prestador.Observacao,
                    rua = prestador.Endereco.Rua,
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

            using (var transaction = connection.BeginTransaction())
            {
                sql = @"update prestador 
                           set nome = @nome, 
                               datanascimento = @datanascimento, 
                               naturalidade = @naturalidade, 
                               estadocivil = @estadocivil, 
                               foto = @foto, 
                               etnia = @etnia, 
                               profissao = @profissao, 
                               telefone = @telefone, 
                               religiao = @religiao, 
                               grauinstrucao = @grauinstrucao, 
                               recebebeneficio = @recebebeneficio, 
                               usaalcool = @usaalcool,
                               usadrogas = @usadrogas,
                               observacao = @observacao,
                               rua = @rua, 
                               numero = @numero, 
                               complemento = @complemento, 
                               bairro = @bairro, 
                               municipio = @municipio, 
                               cep = @cep, 
                               estado = @estado
                         where id = @id";

                connection.Execute(sql, param: new
                {
                    nome = prestador.Nome,
                    datanascimento = prestador.DataNascimento,
                    naturalidade = prestador.Naturalidade,
                    estadocivil = prestador.EstadoCivil,
                    foto = prestador.Foto,
                    etnia = prestador.Etnia,
                    profissao = prestador.Profissao,
                    telefone = prestador.Telefone,
                    religiao = prestador.Religiao,
                    grauinstrucao = prestador.GrauInstrucao,
                    recebebeneficio = prestador.RecebeBeneficio,
                    usaalcool = prestador.UsaAlcool,
                    usadrogas = prestador.UsaDrogas,
                    observacao = prestador.Observacao,
                    rua = prestador.Endereco.Rua,
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

            using (var transaction = connection.BeginTransaction())
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

    public IEnumerable<Prestador> RecuperarTodosFiltrado(string nomePrestador, string dataNascimento)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from prestador
                            where 1 = 1";

            if (!string.IsNullOrWhiteSpace(nomePrestador))
            {
                sql += " and upper(nome) like upper(CONCAT('%', @nome, '%'))";
            }

            if (!string.IsNullOrWhiteSpace(dataNascimento))
            {
                sql += " and datanascimento = date(@datanascimento)";
            }

            sql += " order by id";

            return connection.Query<Prestador, Endereco, Prestador>(sql,
                   (entidade, endereco) =>
                   {
                       entidade.Endereco = endereco;
                       return entidade;
                   },
                   splitOn: "Rua",
                   param: new
                   {
                       nome = nomePrestador,
                       datanascimento = dataNascimento
                   });
        }
    }

    public Prestador RecuperarPorId(int idPrestador)
    {
        string sql;
        Prestador prestador;
        List<Parentesco> parentescoList;
        List<Habilidade> habilidadeList;
        List<Deficiencia> deficienciaList;
        List<Doenca> doencaList;

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            sql = @"select *
                      from prestador
                     where id = @id";

            prestador = connection.Query<Prestador, Endereco, Prestador>(sql,
                        (entidade, endereco) =>
                        {
                            entidade.Endereco = endereco;
                            return entidade;
                        },
                        splitOn: "Rua",
                        param: new
                        {
                            id = idPrestador
                        }).Single();

            sql = @"select nome, grauparentesco
                      from parentesco
                     where id_prestador = @id";

            parentescoList = (List<Parentesco>)connection.Query<Parentesco>(sql,
                             param: new
                             {
                                 id = idPrestador
                             });

            sql = @"select descricao
                      from habilidade
                     where id_prestador = @id";

            habilidadeList = (List<Habilidade>)connection.Query<Habilidade>(sql,
                             param: new
                             {
                                 id = idPrestador
                             });

            sql = @"select descricao
                      from deficiencia
                     where id_prestador = @id";

            deficienciaList = (List<Deficiencia>)connection.Query<Deficiencia>(sql,
                              param: new
                              {
                                  id = idPrestador
                              });

            sql = @"select descricao
                      from doenca
                     where id_prestador = @id";

            doencaList = (List<Doenca>)connection.Query<Doenca>(sql,
                         param: new
                         {
                             id = idPrestador
                         });

            prestador.ParentescoList = parentescoList;
            prestador.HabilidadeList = habilidadeList;
            prestador.DeficienciaList = deficienciaList;
            prestador.DoencaList = doencaList;

            return prestador;
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
}