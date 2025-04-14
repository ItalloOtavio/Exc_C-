class Ponderada
{
    static public void Executar(){
        /*Faça um programa que receba duas notas, calcule e mostre a média ponderada
        dessas notas, considerando peso 2 para a primeira nota e peso 3 para a segunda nota*/

        double nota1, nota2, resultado=0;

        Console.WriteLine("Digite a 1° nota:");
        nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a 2° nota:");
        nota2 = double.Parse(Console.ReadLine());

        resultado = (nota1 * 2) + (nota2 * 3);

        Console.WriteLine($"Media Ponderada: {resultado}");

    }
}