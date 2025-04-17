class Crescente
{
    static public void Executar(){
        /*Faça um algoritmo para ler três valores a, b, e c, 
        quaisquer e escrever os três valores em ordem crescente.*/

        Console.WriteLine("Digite o valor de a:");
        int a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o valor de b:");
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o valor de c:");
        int c = int.Parse(Console.ReadLine()!);

        int maior = int.MaxValue;
        int meio;
        int menor = int.MaxValue;

        // maior
        if(a > b && a > c){
            maior = a;
        }else if(b > a && b > c){
            maior = b;
        }else{
            maior = c;
        }
        //meio
        if(a > b && a < c){
            meio = a;
        }else if(b > a && b > c){
            meio = b;
        }else{
            meio = b;
        }
        //menor
        if(a < b && a < c){
            menor = a;
        }else if(b < a && b < c){
            menor = b;
        }else{
            menor = c;
        }
        Console.WriteLine($"{menor} , {meio} , {maior}");
    }
}