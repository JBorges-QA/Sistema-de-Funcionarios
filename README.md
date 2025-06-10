💼 Sistema de Funcionários em C#
Este projeto em C# demonstra os conceitos de herança, polimorfismo e sobrescrita de métodos, simulando um sistema simples de funcionários com diferentes cargos e regras de cálculo salarial.

📁 Estrutura do Projeto
less
Copiar
Editar
SistemaFuncionarios/
│
├── Main.cs             // Classe principal com execução do programa
├── Funcionario.cs      // Classe base Funcionario
├── Desenvolvedor.cs    // Subclasse Desenvolvedor
├── Gerente.cs          // Subclasse Gerente
└── README.md           // Documentação do projeto
📚 Descrição das Classes
Funcionario.cs
Classe base com um método virtual para calcular o salário total.

csharp
Copiar
Editar
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
Desenvolvedor.cs
Subclasse que recebe um bônus fixo de R$500.

csharp
Copiar
Editar
class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome) : base(nome)
    {
        Nome = nome;
    }

    public new string Nome { get; }

    public override void CalcularSalarioTotal()
    {
        SalarioBase = 6000;
        Console.WriteLine($"{Nome} é um Desenvolvedor. O salário base é R${SalarioBase} com bônus fixo de R$500. Total R${SalarioBase + 500}");
    }
}
Gerente.cs
Subclasse que recebe bônus de 10% sobre o salário base.

csharp
Copiar
Editar
class Gerente : Funcionario
{
    public Gerente(string nome) : base(nome)
    {
        Nome = nome;
    }

    public new string Nome { get; }

    public override void CalcularSalarioTotal()
    {
        SalarioBase = 10000;
        Console.WriteLine($"{Nome} é um Gerente. O salário base é R${SalarioBase} com bônus de 10%. Total R${SalarioBase + (SalarioBase * 0.10)}");
    }
}
🚀 Execução
Main.cs
csharp
Copiar
Editar
class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new("José");
        funcionario.CalcularSalarioTotal();

        Desenvolvedor dev = new("Zézinho");
        dev.CalcularSalarioTotal();

        Gerente gerente = new("Borges");
        gerente.CalcularSalarioTotal();
    }
}
Saída esperada:
bash
Copiar
Editar
José é um Funcionário. O salário base de um Funcionário é de R$4000
Zézinho é um Desenvolvedor. O salário base é R$6000 com bônus fixo de R$500. Total R$6500
Borges é um Gerente. O salário base é R$10000 com bônus de 10%. Total R$11000
🛠️ Como Compilar e Executar
Crie o projeto (se ainda não existir):

bash
Copiar
Editar
dotnet new console -n SistemaFuncionarios
cd SistemaFuncionarios
Adicione os arquivos Funcionario.cs, Desenvolvedor.cs, Gerente.cs e Main.cs à pasta do projeto.

Compile e execute:

bash
Copiar
Editar
dotnet run
💡 Conceitos Demonstrados
Herança com classes derivadas

Polimorfismo e sobrescrita de métodos (override)

Encapsulamento com propriedades

Organização de código em múltiplos arquivos
