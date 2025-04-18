class NegPos
{
    static public void Executar(){
    /*Faça um algoritmo para repetir a leitura de um número enquanto o valor fornecido for diferente de 0.
        Para cada número fornecido, imprimir se ele é NEGATIVO ou POSITIVO. Quando o número 0 for
        fornecido a repetição deve ser encerrada sem imprimir mensagem alguma.*/
    
    int cont = 0;
    int num;
    do{
        Console.WriteLine("Digite um numero:");
        num = int.Parse(Console.ReadLine()!);

        if(num >= 1){
            Console.WriteLine("Numero Positivo");
        }else if(num <= -1){
            Console.WriteLine("Numero Negativo");
        }
    }while(cont !=0);
    }
}