using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;

public class EntidadeDAO
{
    public void Insert(Entidade entidade)
    {
        entidade = VerificaEspacosEmBranco(entidade);

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql;

            if (entidade.DataDescredenciamento.Date == Convert.ToDateTime("01/01/0001").Date)
            {
                sql = @"insert into entidade (id, cnpj, razaosocial, telefone, email, datacredenciamento, observacao,
                                              logradouro, numero, complemento, bairro, municipio, cep, estado) values 
                                             (@id, @cnpj, @razaosocial, @telefone, @email, @datacredenciamento, @observacao,
                                              @logradouro, @numero, @complemento, @bairro, @municipio, @cep, @estado)";

                connection.Execute(sql, param: new
                {
                    id = entidade.Id,
                    cnpj = entidade.Cnpj,
                    razaosocial = entidade.RazaoSocial,
                    telefone = entidade.Telefone,
                    email = entidade.Email,
                    datacredenciamento = entidade.DataCredenciamento,
                    observacao = entidade.Observacao,
                    logradouro = entidade.Endereco.Logradouro,
                    numero = entidade.Endereco.Numero,
                    complemento = entidade.Endereco.Complemento,
                    bairro = entidade.Endereco.Bairro,
                    municipio = entidade.Endereco.Municipio,
                    cep = entidade.Endereco.Cep,
                    estado = entidade.Endereco.Estado
                });
            }
            else
            {
                sql = @"insert into entidade values (@id, @cnpj, @razaosocial, @telefone, @email, @datacredenciamento, @datadescredenciamento, @observacao,
                                                     @logradouro, @numero, @complemento, @bairro, @municipio, @cep, @estado)";

                connection.Execute(sql, param: new
                {
                    id = entidade.Id,
                    cnpj = entidade.Cnpj,
                    razaosocial = entidade.RazaoSocial,
                    telefone = entidade.Telefone,
                    email = entidade.Email,
                    datacredenciamento = entidade.DataCredenciamento,
                    datadescredenciamento = entidade.DataDescredenciamento,
                    observacao = entidade.Observacao,
                    logradouro = entidade.Endereco.Logradouro,
                    numero = entidade.Endereco.Numero,
                    complemento = entidade.Endereco.Complemento,
                    bairro = entidade.Endereco.Bairro,
                    municipio = entidade.Endereco.Municipio,
                    cep = entidade.Endereco.Cep,
                    estado = entidade.Endereco.Estado
                });
            }
        }
    }

    public void Update(Entidade entidade)
    {
        entidade = VerificaEspacosEmBranco(entidade);

        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql;

            if (entidade.DataDescredenciamento.Date == Convert.ToDateTime("01/01/0001").Date)
            {
                sql = @"update entidade
                           set cnpj = @cnpj,
                               razaosocial = @razaosocial,
                               telefone = @telefone,
                               email = @email,
                               datacredenciamento = @datacredenciamento,
                               datadescredenciamento = null,
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
                    cnpj = entidade.Cnpj,
                    razaosocial = entidade.RazaoSocial,
                    telefone = entidade.Telefone,
                    email = entidade.Email,
                    datacredenciamento = entidade.DataCredenciamento,
                    observacao = entidade.Observacao,
                    logradouro = entidade.Endereco.Logradouro,
                    numero = entidade.Endereco.Numero,
                    complemento = entidade.Endereco.Complemento,
                    bairro = entidade.Endereco.Bairro,
                    municipio = entidade.Endereco.Municipio,
                    cep = entidade.Endereco.Cep,
                    estado = entidade.Endereco.Estado,
                    id = entidade.Id
                });
            }
            else
            {
                sql = @"update entidade
                           set cnpj = @cnpj,
                               razaosocial = @razaoSocial,
                               telefone = @telefone,
                               email = @email,
                               datacredenciamento = @dataCredenciamento,
                               datadescredenciamento = @dataDescredenciamento,
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
                    cnpj = entidade.Cnpj,
                    razaosocial = entidade.RazaoSocial,
                    telefone = entidade.Telefone,
                    email = entidade.Email,
                    datacredenciamento = entidade.DataCredenciamento,
                    datadescredenciamento = entidade.DataDescredenciamento,
                    observacao = entidade.Observacao,
                    logradouro = entidade.Endereco.Logradouro,
                    numero = entidade.Endereco.Numero,
                    complemento = entidade.Endereco.Complemento,
                    bairro = entidade.Endereco.Bairro,
                    municipio = entidade.Endereco.Municipio,
                    cep = entidade.Endereco.Cep,
                    estado = entidade.Endereco.Estado,
                    id = entidade.Id
                });
            }
        }
    }

    public void Delete(int idEntidade)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"delete from entidade
                            where id = @id";

            connection.Execute(sql, param: new { id = idEntidade });
        }
    }

    private Entidade VerificaEspacosEmBranco(Entidade entidade)
    {
        if (string.IsNullOrWhiteSpace(entidade.Observacao))
        {
            entidade.Observacao = null;
        }

        if (string.IsNullOrWhiteSpace(entidade.Endereco.Complemento))
        {
            entidade.Endereco.Complemento = null;
        }

        return entidade;
    }

    public IEnumerable<Entidade> RecuperarTodosFiltrado(string cnpjEntidade, string razaoSocial)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from entidade
                            where 1 = 1";

            if (!string.IsNullOrWhiteSpace(cnpjEntidade))
            {
                sql += " and cnpj like CONCAT('%', @cnpj, '%')";
            }

            if (!string.IsNullOrWhiteSpace(razaoSocial))
            {
                sql += " and upper(razaosocial) like upper(CONCAT('%', @razaosocial, '%'))";
            }

            sql += " order by id";

            return connection.Query<Entidade, Endereco, Entidade>(sql,
                   (entidade, endereco) =>
                   {
                       entidade.Endereco = endereco;
                       return entidade;
                   },
                   splitOn: "Logradouro",
                   param: new 
                   {
                       cnpj = cnpjEntidade,
                       razaosocial = razaoSocial
                   });
        }
    }

    public Entidade RecuperarPorId(int idEntidade)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from entidade
                            where id = @id";

            return connection.Query<Entidade, Endereco, Entidade>(sql,
                   (entidade, endereco) =>
                   {
                       entidade.Endereco = endereco;
                       return entidade;
                   },
                   splitOn: "Logradouro",
                   param: new 
                   { 
                       id = idEntidade
                   }).Single();
        }
    }

    public int RetornaProximoId()
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select coalesce(max(id), 0) + 1
                             from entidade";

            return connection.QuerySingle<int>(sql);
        }
    }

    public bool ExisteCnpj(int idEntidade, string cnpjEntidade)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from entidade
                            where id <> @id
                              and cnpj = @cnpj";

            return connection.QuerySingle<bool>(sql, param: new
            {
                id = idEntidade,
                cnpj = cnpjEntidade
            });
        }
    }

    public bool ExisteEmail(int idEntidade, string emailEntidade)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select count(*)
                             from entidade
                            where id <> @id
                              and email = @email";

            return connection.QuerySingle<bool>(sql, param: new
                   {
                       id = idEntidade,
                       email = emailEntidade
                   });
        }
    }
}