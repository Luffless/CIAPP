using System;
using System.Collections.Generic;

public class Prestador
{
    public int Id { get; set; }
    public string Cpf { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Naturalidade { get; set; }
    public string EstadoCivil { get; set; }
    public long Telefone { get; set; }
    public string Etnia { get; set; }
    public string Sexo { get; set; }
    public string Profissao { get; set; }
    public decimal RendaFamiliar { get; set; }
    public string Religiao { get; set; }
    public string GrauInstrucao { get; set; }
    public bool RecebeBeneficio { get; set; }
    public bool UsaAlcool { get; set; }
    public bool UsaDrogas { get; set; }
    public string Observacao { get; set; }
    public Endereco Endereco { get; set; }
    public List<Parentesco> ParentescoList { get; set; }
    public List<Habilidade> HabilidadeList { get; set; }
    public List<Deficiencia> DeficienciaList { get; set; }
    public List<Doenca> DoencaList { get; set; }
}