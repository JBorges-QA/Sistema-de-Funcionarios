class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome) :base(nome)
    {
        Nome = nome;
    }

    public string Nome {  get; }

    override
    public void CalcularSalarioTotal()
    {
        SalarioBase = 6000;
        Console.WriteLine($"{Nome} é um Desenvolvedor. O salário base de um Desenvolvedor é de R${SalarioBase} com um bonûs fixo de R$500. Total R${SalarioBase + 500}");
    }
}