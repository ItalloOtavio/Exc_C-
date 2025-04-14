class Trapezio
{
    static public void Executar(){
        /*Faça um programa que calcule e mostre a área de um trapézio. */

        Console.WriteLine("Digite a Base Maior:");
        double baseMaior = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Digite a Base Menor:");
        double baseMenor = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura");
        double altura = int.Parse(Console.ReadLine());
        
        double area = ((baseMaior + baseMenor) * altura) / 2;

        Console.WriteLine($"Area do Trapezio: {area}");
    }
}