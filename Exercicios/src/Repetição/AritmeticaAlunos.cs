using System.Net.Http.Headers;

class AritmeticaAlunos
{
    static public void Executar(){
        /*Faça um algoritmo para ler o número de alunos existentes em uma turma, 
        ler as notas destes alunos, e calcular a média aritmética destas notas.*/

        double nota;
        double soma = 0;
        Console.WriteLine("Digite a quantidade de alunos:");
        int alunos = int.Parse(Console.ReadLine()!);
        for(int i = 1; i <= alunos; i++){
            Console.WriteLine($"Digite a nota do {i} aluno:");
            nota = double.Parse(Console.ReadLine()!);

            soma += nota;
        }
        double media = soma / alunos;
        Console.WriteLine($"Media: {media:f2}");
    }
}