using System;
using System.Collections.Generic;

public class Processo
{
    public int Id { get; set; }
    public string VaraOrigem { get; set; }
    public bool AcordoPersecucaoPenal { get; set; }
    public string PenaOriginaria { get; set; }
    public int HorasCumprir { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
    public Prestador Prestador { get; set; }
    public List<Crime> CrimeList { get; set; }
    public List<ProcessoEntidade> ProcessoEntidadeList { get; set; }
}