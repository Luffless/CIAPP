using Dapper;
using Npgsql;
using System.Collections.Generic;

public class ProcessoDAO
{
    public IEnumerable<Processo> RecuperarTodosFiltrado(string nomePrestador, string numeroArtigoPenal)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(StringConexao.stringConexao))
        {
            string sql = @"select processo.*
                             from processo, prestador
                            where 1 = 1";

            if (!string.IsNullOrWhiteSpace(nomePrestador))
            {
                sql += " and upper(prestador.nome) like upper(CONCAT('%', @nomeprestador, '%'))";
            }

            if (!string.IsNullOrWhiteSpace(numeroArtigoPenal))
            {
                sql += " and processo.numeroartigopenal = @numeroartigopenal";
            }

            sql += @" and processo.id_prestador = prestador.id
                    order by processo.datainicio desc";

            return connection.Query<Processo>(sql,
                   param: new
                   {
                       nomeprestador = nomePrestador,
                       numeroartigopenal = numeroArtigoPenal
                   });
        }
    }
}