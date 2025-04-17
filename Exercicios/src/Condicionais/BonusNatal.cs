class BonusNatal
{
    static public void Executar(){
        /*Uma empresa deseja presentear seus funcionários com um bônus de Natal, cujo valor é definido 
        do seguinte modo:
        Funcionários do sexo masculino com tempo de casa superior a 15 anos terão direito 
        a um bônus de 20% do seu salário;
        As funcionárias com tempo de casa superior a 10 anos terão direito a um bônus de 25% do seu
        salário; e os demais funcionários terão direito a um bônus de R$ 100,00.
        Faça um algoritmo que leia o código do funcionário, o sexo, o tempo de trabalho (em anos) e o salário.
        O algoritmo deve calcular o valor do bônus.*/
    
        Console.WriteLine("Codigo do Funcionario:");
        int cod = int.Parse(Console.ReadLine()!);
        Console.WriteLine("1 - Masculino");
        Console.WriteLine("2 - Feminino");
        int op = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o tempo de serviço");
        int funcionarios = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o seu salario:");
        double salario = double.Parse(Console.ReadLine()!);

        double bonus, total;
        switch(op){
            case 1: 
                if(funcionarios > 15){
                    bonus = salario * 0.20;
                    total = salario + bonus;
                Console.WriteLine($"Funcionario: {cod}");
                Console.WriteLine($"bonificação:{bonus}");
                Console.WriteLine($"Salario + bonificação:{total}");
                }else{
                    total = salario + 100;
                    Console.WriteLine($"Funcionario: {cod}, com tempo inferior a 15 anos");
                    Console.WriteLine("Bonificação de R$100,00");
                    Console.WriteLine($"Salario + bonificação: {total}");
                }
            break;
            case 2:
                if(funcionarios > 10){
                    bonus = salario * 0.25;
                    total = salario + bonus;
                Console.WriteLine($"Funcionaria: {cod}");
                Console.WriteLine($"bonificação:{bonus}");
                Console.WriteLine($"Salario + bonificação:{total}");
                }else{
                    total = salario + 100;
                    Console.WriteLine($"Funcionaria: {cod}, com tempo inferior a 15 anos");
                    Console.WriteLine("Bonificação de R$100,00");
                    Console.WriteLine($"Salario + bonificação: {total}");
                }
            break;
        }

    }
}