using System.ComponentModel;

class Iguais
{
    static public void Executar(){
        /*Faça um algoritmo para ler dois números. 
        Se os números forem iguais imprimir a mensagem: "NÚME-ROS IGUAIS"e encerrar a execução; 
        caso contrário, imprimir o de maior valor.*/

        Console.WriteLine("Digite o 1° numero:");
        int n1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o 2° numero:");
        int n2 = int.Parse(Console.ReadLine()!);

        int maior = int.MaxValue;
        int menor = int.MaxValue;

        if(n1 == n2){
            Console.WriteLine("NÚME-ROS IGUAIS");
        }else{
        
        if(n1 > n2){
            maior = n1;
        }else{
            maior = n2;
        }

        if(n1 < n2){
            menor = n1;
        }else{
            menor = n2;
        }
        Console.WriteLine($"Maior:{maior}");
        Console.WriteLine($"Menor:{menor}");
        }
    }
}