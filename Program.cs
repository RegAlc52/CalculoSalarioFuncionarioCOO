using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do funcionário:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o salário bruto do funcionário:");
        double salarioBruto = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do imposto:");
        double imposto = double.Parse(Console.ReadLine());

        Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);

        Console.WriteLine("Dados do funcionário:");
        funcionario.MostrarDados();

        Console.WriteLine("Digite a porcentagem de aumento do salário:");
        double aumentoPercentual = double.Parse(Console.ReadLine());
        funcionario.AumentarSalario(aumentoPercentual);

        Console.WriteLine("Dados atualizados do funcionário:");
        funcionario.MostrarDados();
    }
}

class Funcionario
{
    private string nome;
    private double salarioBruto;
    private double imposto;

    public Funcionario(string nome, double salarioBruto, double imposto)
    {
        this.nome = nome;
        this.salarioBruto = salarioBruto;
        this.imposto = imposto;
    }

    public double CalcularSalarioLiquido()
    {
        return salarioBruto - imposto;
    }

    public void AumentarSalario(double percentual)
    {
        salarioBruto += salarioBruto * (percentual / 100);
    }

    public void MostrarDados()
    {
        double salarioLiquido = CalcularSalarioLiquido();
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Salário bruto: " + salarioBruto);
        Console.WriteLine("Salário líquido: " + salarioLiquido);
    }
}



//CalculoSalarioFuncionarioCOO
//Fazer um programa para ler dados de um funcionário
//nome
//salário
//bruto
//imposto
//mostrar em tela os dados do funcionário
//nome
//salário
//líquido
//Em seguida aumentar
//o salário do funcionário com base em % fornecida pelo usuario
//aumento % incidira somente no salário bruto
//mostrar novamente os dados do funcionário. 
//Classe para esta atividade deve conter os atributos
//Nome
//SalarioBruto
//Imposto
//O codigo deve conter os métodos
//CalcularSalarioLiquido() : double e
//AumentarSalario(): void
//Com orientação a objetos




