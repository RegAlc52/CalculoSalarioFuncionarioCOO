using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do funcionário:");
        string nome = Console.ReadLine();

        double salarioBruto;
        do
        {
            Console.WriteLine("Digite o salário bruto do funcionário:");
        } while (!double.TryParse(Console.ReadLine(), out salarioBruto) || salarioBruto < 0);

        double impostoPercentual;
        do
        {
            Console.WriteLine("Digite a porcentagem do imposto (%):");
        } while (!double.TryParse(Console.ReadLine(), out impostoPercentual) || impostoPercentual < 0);

        Funcionario funcionario = new Funcionario(nome, salarioBruto, impostoPercentual);

        Console.WriteLine("Dados do funcionário:");
        funcionario.MostrarDados();

        double aumentoPercentual;
        do
        {
            Console.WriteLine("Digite a porcentagem de aumento do salário (%):");
        } while (!double.TryParse(Console.ReadLine(), out aumentoPercentual) || aumentoPercentual < 0);

        funcionario.AumentarSalario(aumentoPercentual);

        Console.WriteLine("Dados após o aumento salarial:");
        funcionario.MostrarDados();
    }
}

class Funcionario
{
    private string nome;
    private double salarioBruto;
    private double impostoPercentual;

    public Funcionario(string nome, double salarioBruto, double impostoPercentual)
    {
        this.nome = nome;
        this.salarioBruto = salarioBruto;
        this.impostoPercentual = impostoPercentual / 100;

    public double CalcularSalarioLiquido()
    {
        double valorImposto = salarioBruto * impostoPercentual;
        return salarioBruto - valorImposto;
    }

    public void AumentarSalario(double percentual)
    {
        salarioBruto *= (1 + percentual / 100);
    }

    public void MostrarDados()
    {
        double salarioLiquido = CalcularSalarioLiquido();
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Salário Bruto: {salarioBruto}");
        Console.WriteLine($"Salário Líquido: {salarioLiquido}");
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




