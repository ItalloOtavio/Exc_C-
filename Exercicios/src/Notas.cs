class Notas
{
    static public void Executar(){
        /*Fazer um programa que leia o valor de um salário a ser pago e informe a quantidade
        mínima de notas que precisarão ser sacadas no banco para pagar o funcionário. As
        notas disponíveis são: 200, 100, 50, 20, 10, 5, 2 reais e 1 real*/

        int salario;

        Console.WriteLine("Salario:");
        salario = int.Parse(Console.ReadLine()!);

        int n200 = salario / 200;
        // Atualiza o valor do salario para a proxima operacao
        salario = salario % 200;
        int n100 = salario / 100;
        salario = salario % 100;
        // Atualiza o valor do salario para a proxima operacao
        int n50 = salario / 50;
        salario = salario % 50;
        // Atualiza o valor do salario para a proxima operacao
        int n20 = salario / 20;
        salario = salario % 20;
        // Atualiza o valor do salario para a proxima operacao
        int n10 = salario / 10;
        salario = salario % 10;
        // Atualiza o valor do salario para a proxima operacao
        int n5 = salario / 5;
        salario = salario % 5;
        // Atualiza o valor do salario para a proxima operacao
        int n2 = salario / 2;
        salario = salario % 2; 
        // Atualiza o valor do salario para a proxima operacao
        int n1 = salario / 1;
        salario = salario % 1;

        Console.WriteLine($"Notas de 200: {n200}");
        Console.WriteLine($"Notas de 100: {n100}");
        Console.WriteLine($"Notas de 50: {n50}");
        Console.WriteLine($"Notas de 20: {n20}");
        Console.WriteLine($"Notas de 10: {n10}");
        Console.WriteLine($"Notas de 5: {n5}");
        Console.WriteLine($"Notas de 2: {n2}");
        Console.WriteLine($"Notas de 1: {n1}");
        
    }
}