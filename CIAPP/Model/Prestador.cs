using System;
using System.Collections.Generic;

public class Prestador
{
    public int Id { get; set; }
    public string NomeMae { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Naturalidade { get; set; }
    public string EstadoCivil { get; set; }
    public byte Foto { get; set; }
    public string Profissao { get; set; }
    public List<Parentesco> ParentescoList { get; set; }
    public long Telefone { get; set; }
    public string Etnia { get; set; }
    public string GrauInstrucao { get; set; }
    public string Religiao { get; set; }
    public bool RecebeBeneficio { get; set; }
    public string Deficiencia { get; set; }
    public bool UsaAlcool { get; set; }
    public bool UsaDrogras { get; set; }
    public string Observacao { get; set; }
    public Endereco Endereco { get; set; }
    public List<Habilidade> HabilidadeList { get; set; }
    public List<Doenca> DoencaList { get; set; }
}