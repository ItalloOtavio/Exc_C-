class Raio
{
    static public void Executar(){
        /*Faça um programa que receba o raio, calcule e mostre: 
        a) o comprimento de uma esfera, sabe-se que C = 2πR;
        b) a área de uma esfera, sabe-se que A = πR2;
        c) o volume de uma esfera, sabe-se que V = 4/3πR3.
        Obs: Para calcular o raio ao quadrado ou ao cubo você pode usar a função Pow() como abaixo:
        Z = Math.Pow(x, y) // calcula a potência: XY e coloca o resultado na
        variável Z.*/

        double raio, c, a, v;
        double pi = 3.14;

        Console.WriteLine("Digite o raio:");
        raio = int.Parse(Console.ReadLine()!);

        c = 2 * pi * raio;
        a = pi * Math.Pow(raio,2);
        v = (4.0 / 3.0) * pi * Math.Pow(raio,3);

        Console.WriteLine($"Cumprimento: {c}"); 
        Console.WriteLine($"Area: {a}");
        Console.WriteLine($"Volume: {v:f2}");
    }
}