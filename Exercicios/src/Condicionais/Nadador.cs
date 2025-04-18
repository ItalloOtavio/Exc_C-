class Nadador
{
    static public void Executar(){
        /*Faça um algoritmo que, dada a idade de um nadador, classifique-o em uma das seguintes categorias:
        Infantil A: 5 a 7 anos;
        Infantil B: 8 a 10 anos;
        Juvenil A: 11 a 13 anos;
        Juvenil B: 14 a 17 anos;
        Sênior: maiores de 18 anos.
        O algoritmo deve escrever a idade e a classificação do nadador.*/

        Console.WriteLine("Digite a idade:");
        int idade = int.Parse(Console.ReadLine()!);

        if(idade >= 5 && idade <=7){
            Console.WriteLine("Classificação: Infantil A");
        }
        else if(idade >= 8 && idade <=10){
            Console.WriteLine("Classificação: Infantil B");
        }
        else if(idade >= 11 && idade <= 13){
            Console.WriteLine("Classificação: Juvenil A");
        }
        else if(idade >= 17 && idade <=17){
            Console.WriteLine("Classificação: Juvenil B");
        }
        else if(idade >= 18){
            Console.WriteLine("Classificação: Senior");
        }
    }
}