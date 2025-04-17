class Angulo
{
    static public void Executar(){
        /*Faça um programa que receba a medida de dois ângulos de um triângulo, calcule e
        mostre a medida do terceiro ângulo. Sabe-se que a soma dos ângulos de um triângulo
        é 180.*/

        int a1, a2, a3;
        int triangulo = 180;

        Console.WriteLine("Angulo 1:");
        a1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Angulo 2:");
        a2 = int.Parse(Console.ReadLine()!);

        a3 = triangulo - a1 - a2;

        Console.WriteLine($"Terceiro lado: {a3}");
    }
}