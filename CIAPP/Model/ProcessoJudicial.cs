using System;

public class ProcessoJudicial
{
    public int Id { get; set; }
    public string Origem { get; set; }
    public bool Acordo { get; set; }
    public string PenaOriginaria { get; set; }
    public int HorasCumprir { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
}