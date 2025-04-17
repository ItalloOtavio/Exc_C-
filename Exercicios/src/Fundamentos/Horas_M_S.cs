using System.Diagnostics.Tracing;

class Horas_M_S
{
    static public void Executar(){
        /*Fazer um programa que leia a hora, minutos e segundos e exiba a quantidade de
        segundos decorridos desde o início do dia*/

        int hora, minutos, segundos;

        Console.WriteLine("Digite a hora:");
        hora = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite os minutos:");
        minutos = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite os segundos:");
        segundos = int.Parse(Console.ReadLine()!);
        // para trasformar a hora em segundos 
        int shora = hora * 60 * 60;
        // para transformar minutos em segundos
        int smin = minutos * 60;
        // somando os segundos do dia
        int sdia = shora + smin + segundos;
        Console.WriteLine($"Segundos do dia: {sdia}");    
    }
}