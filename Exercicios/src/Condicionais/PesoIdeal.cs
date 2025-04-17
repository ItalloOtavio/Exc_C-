class PesoIdeal
{
    static public void Executar(){
        /*Tendo como dados de entrada a altura e o sexo (M ou F) de uma pessoa, 
        Faça um algoritmo para calcular seu peso ideal, utilizando as seguintes fórmulas:
        Para Homens: ( 72.7 * altura ) - 58;
        Para Mulheres: ( 62.1 * altura) - 44.7.*/

        double peso;

        Console.WriteLine("Digite sua altura:");
        double altura = double.Parse(Console.ReadLine()!);
        Console.WriteLine("1 - M");
        Console.WriteLine("2 - F");
        int op = int.Parse(Console.ReadLine()!);

        switch(op){
            case 1: 
                peso = (72.7 * altura) - 58;
                Console.WriteLine($"Peso ideal para o sexo Masculino: {peso:f2}");
            break;
            case 2:
                peso = (62.1 * altura) - 44.7;
                Console.WriteLine($"Peso ideal para o sexo Fefimino: {peso:f2}");
            break;
            default:
                Console.WriteLine("Sexo Invalido.");
            break;
        }
    }
}