class Funcionario
{
    public Funcionario(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int SalarioBase { get; set; }

   public virtual void CalcularSalarioTotal()
    {
        SalarioBase = 4000;
        Console.WriteLine($"{Nome} é um Funcionário. O salário base de um Funcionário é de R${SalarioBase}");
    }
}