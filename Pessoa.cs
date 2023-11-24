using System;

public class Pessoa{


    //Atributos
    public string? Nome;

    public string? Sobrenome;

    public DateTime DataNascimento;
    public int CPF;
    public decimal Peso;
    public decimal Altura;
    
    //Constructor
    public Pessoa (string? nome, string? sobrenome, DateTime dataNascimento, int cpf, decimal peso, decimal altura)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        DataNascimento = dataNascimento;
        CPF = cpf;
        Peso = peso;
        Altura = altura;
    }

    //Metodos

    public int CalcularIdade()
    
    {
    DateTime dataAtual = DateTime.Now;
    int Idade = dataAtual.Year - DataNascimento.Year;
    return Idade;
    }

    public decimal CalculaIMC()
    {
        decimal peso = (decimal)Peso;
        decimal altura = Altura;

        decimal imc = peso / (altura * altura);

        return imc;
    }

    public bool Maioridade()
    {
        int idade = CalcularIdade();
        return idade >=18;
    }
}

