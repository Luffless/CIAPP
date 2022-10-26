﻿using System.Collections.Generic;

public class Processo
{
    public int Id { get; set; }
    public string VaraOrigem { get; set; }
    public int NumeroArtigoPenal { get; set; }
    public string PenaOriginaria { get; set; }
    public int HorasCumprir { get; set; }
    public bool AcordoPersecucaoPenal { get; set; }
    public Prestador Prestador { get; set; }
    public List<ProcessoEntidade> ProcessoEntidadeList { get; set; }
    public string EmailCentral { get; set; }
}