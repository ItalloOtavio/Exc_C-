class AlunoAprovado
{
    static public void Executar(){
        /*Faça um algoritmo que leia o código de identificação de um aluno e as suas quatro notas 
        (3 provas + 1 nota referente aos exercícios). 
        Calcular para cada aluno a média usando a fórmula: média = ( N1 + N2 * 2 + N3 * 3 + NE )/7. 
        O algoritmo deve escrever o código do aluno, suas notas, a média e o conceito
        correspondente (ver tabela) e a mensagem "APROVADO"(conceito = A, B ou C) ou "REPROVADO".
*/
        Console.WriteLine("Digite o codigo de aluno:");
        int cod = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a nota da 1° prova:");
        double p1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a nota da 2° prova:");
        double p2 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a nota da 3° prova:");
        double p3 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a nota dos exercicios:");
        double exc = double.Parse(Console.ReadLine()!);

        double m = (p1 + p2 * 2 + p3 * 3 + exc) / 7;

        if(m >= 9.0){
            Console.WriteLine($"Aluno {cod}: APROVADO");
            Console.WriteLine($"{m:f2}");
            Console.WriteLine("Conceito = A");
        }
        else if(m >= 7.5 && m < 9.0){
            Console.WriteLine($"Aluno {cod}: APROVADO");
            Console.WriteLine($"{m:f2}");
            Console.WriteLine("Conceito = B");
        }
        else if(m > 6.0 && m < 7.5){
            Console.WriteLine($"Aluno {cod}: APROVADO");
            Console.WriteLine($"{m:f2}");
            Console.WriteLine("Conceito = C");
        }
        else if(m > 4.0 && m < 6.0){
            Console.WriteLine($"Aluno {cod}: REPROVADO");
            Console.WriteLine($"{m:f2}");
            Console.WriteLine("Conceito = D");
        }
        else if(m < 4.0){
            Console.WriteLine($"Aluno {cod}: REPROVADO");
            Console.WriteLine($"{m:f2}");
            Console.WriteLine("Conceito = E");
        }
    }
}