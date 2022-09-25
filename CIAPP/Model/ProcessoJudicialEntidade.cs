using System;
using System.Collections.Generic;

public class ProcessoJudicialEntidade
{
    public int HorasCumprir { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
    public Entidade Entidade { get; set; }
    public List<Atividade> AtividadeList { get; set; }
    public List<Acesso> AcessoList { get; set; }
}