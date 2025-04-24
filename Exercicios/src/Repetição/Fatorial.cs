class Fatorial
{
    static public void Executar(){
        // Fatorial de um numero

        Console.WriteLine("Digite um numero:");
        int num = int.Parse(Console.ReadLine()!);

        int Fatorial = 1;

        for(int i = num; i > 0; i--){
            Fatorial*=i;
        }
        Console.WriteLine($"Fatorail:{Fatorial}");
    }
}