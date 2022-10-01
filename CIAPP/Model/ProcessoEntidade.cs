using System;
using System.Collections.Generic;

public class ProcessoEntidade
{
    public int HorasCumprir { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
    public Entidade Entidade { get; set; }
    public List<Atividade> AtividadeList { get; set; }
    public List<Frequencia> FrequenciaList { get; set; }
}