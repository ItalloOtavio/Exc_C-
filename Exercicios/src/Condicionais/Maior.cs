class Maior
{
    static public void Executar(){
        /*Faça um algoritmo para ler três valores a, b, e c, quaisquer e escrever o maior dos 3*/

        Console.WriteLine("Digite o valor de a:");
        int a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o valor de b:");
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o valor de c:");
        int c = int.Parse(Console.ReadLine()!);

        int maior = int.MaxValue;
        int menor = int.MinValue;
        if(a > b && a > c){
            maior = a;
        }
        else if(b > a & b > c){
            maior = b;
        }else{
            maior = c;
        }

        if(a < b && a < c){
            menor = a;
        }
        else if(b < a & b < c){
            menor = b;
        }else{
            menor = c;
        }

        Console.WriteLine($"Maior Valor é: {maior} e Menor valor é: {menor}");
    }
}