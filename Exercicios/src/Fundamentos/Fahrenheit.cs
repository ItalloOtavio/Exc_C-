class Fahrenheit
{
    static public void Executar(){
        /*Faça um algoritmo que receba a temperatura em graus Celsius e apresente-as 
        em graus Fahrenheit, de acordo com a fórmula °F = (1.8 °C) + 32*/

        Console.WriteLine("Digite a temperatura em graus celsius:");
        int c = int.Parse(Console.ReadLine()!);

        double Fahrenheit = (1.8 * c) + 32;

        Console.WriteLine($"Temperatura em Graus Fahrenheit: {Fahrenheit}");
    }
}