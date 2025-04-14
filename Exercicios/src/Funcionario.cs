class Funcionario
{
    static public void Executar(){
        /*Faça um programa que receba o valor do salário mínimo atual e o valor do salário de
        um funcionário, calcule e mostre a quantidade de salários mínimos que ganha esse
        funcionário.*/

        double salariominimo = 0, funcionario = 0, qtd;

        Console.WriteLine("Digite o salario minimo atual:");
        salariominimo = double.Parse(Console.ReadLine());
        Console.WriteLine("Salario do Funcionario:");
        funcionario = double.Parse(Console.ReadLine());

        qtd = funcionario / salariominimo;

        Console.WriteLine($"Quantidade de salarios minimos: {qtd}");
    }
}