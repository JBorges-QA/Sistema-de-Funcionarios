class Gerente: Funcionario
{
    public Gerente(string nome) :base(nome)
    {
        Nome = nome;
    }

    public string Nome {  get; }

    override
    public void CalcularSalarioTotal()
    {
        SalarioBase = 10000;
        Console.WriteLine($"{Nome} é um Gerente. O salário base de um Gerente é de R${SalarioBase} com um bonûs de 10% do salário base. Total de R${SalarioBase + (SalarioBase * 0.10)}");
    }
}