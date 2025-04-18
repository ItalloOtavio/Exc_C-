class RepetindoNumero
{
    static public void Executar(){
        /*Faça um algoritmo para ler um número inteiro e escrevê-lo na tela 10 vezes utilizando uma repetição.*/
        int cont = 1;
        int num;
        Console.WriteLine("Digite um numero:");
        num = int.Parse(Console.ReadLine()!);
        while(cont < 10){
            Console.WriteLine(num);
            cont ++;
        }
    }
}