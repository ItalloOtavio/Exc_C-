class DataDiasMesesAnos
{
    static public void Executar(){
        /*Desenvolva um algoritmo que receba a data atual e a data
        de nascimento do usuário e informa a sua idade em:dias,semanas,meses e ano
*/
        Console.WriteLine("Digite o dia atual:");
        int DiaAtual = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o mes atual:");
        int MesAtual = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o ano atual:");
        int AnoAtual = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite sua data de nascimento.");
        Console.WriteLine("Digite o dia: ");
        int Dia = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o mes: ");
        int Mes = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o ano:");
        int Ano = int.Parse(Console.ReadLine()!);

        int TotalAtual = AnoAtual * 365 + MesAtual * 30 + DiaAtual;
        int Total = Ano * 365 + Mes * 30 + Dia;

        int totalDias = TotalAtual - Total;
        int totalMeses = totalDias / 30;
        int totalSemanas = totalDias / 7;
        int totalano = totalDias / 365;

        Console.WriteLine($"Dias:{totalDias}");
        Console.WriteLine($"Semanas:{totalSemanas}");
        Console.WriteLine($"Meses:{totalMeses}");
        Console.WriteLine($"Anos:{totalano}");
    }
}