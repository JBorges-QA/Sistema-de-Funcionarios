# 💼 Sistema de Funcionários em C#

Este projeto em **C#** demonstra os conceitos de **herança**, **polimorfismo** e **sobrescrita de métodos**, simulando um sistema simples de funcionários com diferentes cargos e regras de cálculo salarial.

---

## 📁 Estrutura do Projeto
````bash
SistemaFuncionarios/
│
├── Main.cs // Classe principal com execução do programa
├── Funcionario.cs // Classe base Funcionario
├── Desenvolvedor.cs // Subclasse Desenvolvedor
├── Gerente.cs // Subclasse Gerente
└── README.md // Documentação do projeto

````
---

## 📚 Descrição das Classes

### `Funcionario.cs`

Classe base com um método virtual para calcular o salário total.

```csharp
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
````
### `Desenvolvedor.cs`
````csharp
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
````
### `Gerente.cs`
````csharp
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
````
### `Program.cs ou Main.cs`

````csharp
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
````
## 💡 Conceitos Demonstrados
- Herança com classes derivadas
- Polimorfismo e sobrescrita de métodos (override)
- Encapsulamento com propriedades
- Organização de código em múltiplos arquivos
