class Fibonacci
{
    static public void Executar(){
        // Sequencia de fibonacci

        Console.WriteLine("Digite a quantidade de termos");
        int qtd = int.Parse(Console.ReadLine()!);

        int a = 0;
        int b = 1;
        int proximo;

        for(int  i = 0; i < qtd; i++){
            Console.WriteLine($"{a}");
            proximo = a + b;
            a = b;
            b = proximo;    
        }
    }
}