using System;
using System.Collections.Generic;

public class ProcessoJudicial
{
    public int Id { get; set; }
    public string Origem { get; set; }
    public int HorasCumprir { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
    public Prestador Prestador { get; set; }
    public List<Crime> CrimeList { get; set; }
    public List<ProcessoJudicialEntidade> ProcessoJudicialEntidadeList { get; set; }
}