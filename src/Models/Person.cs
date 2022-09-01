using System.Collections.Generic;

namespace pottencial_dev_week.src.Models;

public class Person
{
    public int id { get; set; }
    public string Nome {get; set;}
    public int Idade {get; set;}
    public string Cpf {get; set;}
    public bool Ativado {get; set;}

    public List<Contract> Contracts { get; set; }

    public Person () 
    {
        this.Nome = "";
        this.Idade = 0;
        this.Cpf = "";
        this.Ativado = true;
        this.Contracts = new List<Contract>();
    }

    public Person(string nome, int idade, string cpf)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Cpf = cpf;
        this.Ativado = true;
        this.Contracts = new List<Contract>();
    }
}