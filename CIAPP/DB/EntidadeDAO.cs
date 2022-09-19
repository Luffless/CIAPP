using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

public class EntidadeDAO
{
    public void Insert(Entidade entidade)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql;

            entidade = VerificaEspacosEmBranco(entidade);

            if (entidade.DataDescredenciamento.Date == Convert.ToDateTime("01/01/0001").Date)
            {
                sql = @"insert into entidade (id, razaosocial, telefone, email, datacredenciamento, observacao,
                                              rua, numero, complemento, bairro, municipio, cep, estado) values 
                                             (@id, @razaosocial, @telefone, @email, @datacredenciamento, @observacao,
                                              @rua, @numero, @complemento, @bairro, @municipio, @cep, @estado)";

                connection.Query(sql, param: new
                {
                    id = entidade.Id,
                    razaosocial = entidade.RazaoSocial,
                    telefone = entidade.Telefone,
                    email = entidade.Email,
                    datacredenciamento = entidade.DataCredenciamento,
                    observacao = entidade.Observacao,
                    rua = entidade.Endereco.Rua,
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
                sql = @"insert into entidade (id, razaosocial, telefone, email, datacredenciamento, datadescredenciamento, observacao,
                                              rua, numero, complemento, bairro, municipio, cep, estado) values 
                                             (@id, @razaosocial, @telefone, @email, @datacredenciamento, @datadescredenciamento, @observacao,
                                              @rua, @numero, @complemento, @bairro, @municipio, @cep, @estado)";

                connection.Query(sql, param: new
                {
                    id = entidade.Id,
                    razaosocial = entidade.RazaoSocial,
                    telefone = entidade.Telefone,
                    email = entidade.Email,
                    datacredenciamento = entidade.DataCredenciamento,
                    datadescredenciamento = entidade.DataDescredenciamento,
                    observacao = entidade.Observacao,
                    rua = entidade.Endereco.Rua,
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
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql;

            entidade = VerificaEspacosEmBranco(entidade);

            if (entidade.DataDescredenciamento.Date == Convert.ToDateTime("01/01/0001").Date)
            {
                sql = @"update entidade
                           set razaosocial = @razaosocial,
                               telefone = @telefone,
                               email = @email,
                               datacredenciamento = @datacredenciamento,
                               datadescredenciamento = null,
                               observacao = @observacao,
                               rua = @rua,
                               numero = @numero,
                               complemento = @complemento,
                               bairro = @bairro,
                               municipio = @municipio,
                               cep = @cep,
                               estado = @estado
                         where id = @id";

                connection.Query(sql, param: new
                {
                    razaosocial = entidade.RazaoSocial,
                    telefone = entidade.Telefone,
                    email = entidade.Email,
                    datacredenciamento = entidade.DataCredenciamento,
                    observacao = entidade.Observacao,
                    rua = entidade.Endereco.Rua,
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
                           set razaosocial = @razaoSocial,
                               telefone = @telefone,
                               email = @email,
                               datacredenciamento = @dataCredenciamento,
                               datadescredenciamento = @dataDescredenciamento,
                               observacao = @observacao,
                               rua = @rua,
                               numero = @numero,
                               complemento = @complemento,
                               bairro = @bairro,
                               municipio = @municipio,
                               cep = @cep,
                               estado = @estado
                         where id = @id";

                connection.Query(sql, param: new
                {
                    razaosocial = entidade.RazaoSocial,
                    telefone = entidade.Telefone,
                    email = entidade.Email,
                    datacredenciamento = entidade.DataCredenciamento,
                    datadescredenciamento = entidade.DataDescredenciamento,
                    observacao = entidade.Observacao,
                    rua = entidade.Endereco.Rua,
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

    public void Delete(int idEntidade)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"delete from entidade
                            where id = @id";

            connection.Query(sql, param: new { id = idEntidade });
        }
    }

    public IEnumerable<Entidade> RecuperarTodosFiltrado(string razaoSocial, string dataCredenciamento)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select *
                             from entidade
                            where 1 = 1";

            if (!string.IsNullOrWhiteSpace(razaoSocial))
            {
                sql += " and upper(razaosocial) like upper(CONCAT('%', @razaosocial, '%'))";
            }

            if (!string.IsNullOrWhiteSpace(dataCredenciamento))
            {
                sql += " and datacredenciamento = date(@datacredenciamento)";
            }

            sql += " order by id";

            return connection.Query<Entidade, Endereco, Entidade>(sql,
                   (entidade, endereco) =>
                   {
                       entidade.Endereco = endereco;
                       return entidade;
                   },
                   splitOn: "Rua",
                   param: new 
                   {
                       razaosocial = razaoSocial,
                       datacredenciamento = dataCredenciamento
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
                   splitOn: "Rua",
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