class Segundos
{
    static public void Executar(){
        /*Fazer um programa que leia a quantidade de segundos passados desde o início do dia
        e transforme em: horas, minutos e segundos
        */

        int segundos;

        Console.WriteLine("Segundos do dia:");
        segundos = int.Parse(Console.ReadLine()!);

        // 1 hora tem 3600 segundos.
        int horas = segundos / 3600;
        // pegando o resto da div
        int minutos = (segundos % 3600) / 60;
        int s = segundos % 60;
        Console.WriteLine($"Horas: {horas}, Minutos: {minutos}, Segundos: {s}");
    }
}