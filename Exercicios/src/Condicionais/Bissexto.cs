class Bissexto
{
    static public void Executar(){
        /*No Calendário Gregoriano o ano é considerado como sendo de 365 + 97/400 dias (=365,2425 dias).
        Assim sendo, no Calendário Gregoriano, existem 97 anos de 366 dias (que chamamos de bissextos) 
        em cada período de 400 anos. Os anos bissextos são determinados pela seguinte regra:
        (a) Todo ano divisível por 4 é bissexto.
        (b) Todo ano divisível por 100 não é bissexto.
        (c) Todo ano divisível por 400 é bissexto.*/

       Console.WriteLine("Digite o Ano:");
        int ano = int.Parse(Console.ReadLine()!);

        if (ano % 400 == 0)
        {
            Console.WriteLine("Ano Bissexto");
        }
        else if (ano % 100 == 0)
        {
            Console.WriteLine("Ano não Bissexto");
        }
        else if (ano % 4 == 0)
        {
            Console.WriteLine("Ano Bissexto");
        }
        else
        {
            Console.WriteLine("Ano não Bissexto");
        }
    }
}