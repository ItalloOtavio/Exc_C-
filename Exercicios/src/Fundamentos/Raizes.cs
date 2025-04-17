class Raizes
{
    static public void Executar(){
        /*Fazer um programa que receba os três coeficientes de uma equação do segundo grau
        e calcule as suas raízes. Suponha que só serão informadas equações com raízes reais*/

        int a, b, c;
        double delta, r1, r2;

        Console.WriteLine("Digite o 1° coeficiente: ");
        a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o 2° coeficiente: ");
        b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o 3° coeficiente: ");
        c = int.Parse(Console.ReadLine()!);

        delta = Math.Pow(b,2) - 4 * a * c;
        r1 = (-b + Math.Sqrt(delta)) / (2 * a);
        r2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine($"1° raiz: {r1:f1}");
        Console.WriteLine($"2° raiz: {r2:f1}");
    }
}