using System.Collections.Generic;

public class ProcessoEntidade
{
    public int HorasCumprir { get; set; }
    public string Atividade { get; set; }
    public Entidade Entidade { get; set; }
    public List<Frequencia> FrequenciaList { get; set; }
}