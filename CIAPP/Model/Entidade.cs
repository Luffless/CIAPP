﻿using System;

public class Entidade
{
    public string RazaoSocial { get; set; }
    public long Telefone { get; set; }
    public string Email { get; set; }
    public DateTime DataCredenciamento { get; set; }
    public DateTime DataDescredenciamento { get; set; }
    public string Observacao { get; set; }
    public Endereco Endereco { get; set; }

    public Entidade() { }

    public Entidade(string razaoSocial, int telefone, string email, DateTime dataCredenciamento, DateTime dataDescredenciamento, string observacao, Endereco endereco)
    {
        RazaoSocial = razaoSocial;
        Telefone = telefone;
        Email = email;
        DataCredenciamento = dataCredenciamento;
        DataDescredenciamento = dataDescredenciamento;
        Observacao = observacao;
        Endereco = endereco;
    }
}