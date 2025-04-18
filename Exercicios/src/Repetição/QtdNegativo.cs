class QtdNegativo
{
    static public void Executar(){
        /*Faça um algoritmo para ler 10 números e ao final escrever 
        quantos destes valores são negativos.*/

        int num;
        int neg = 0;
        for(int i = 0; i < 10; i++){
            Console.WriteLine("Digite um numero:");
            num = int.Parse(Console.ReadLine()!);
            if(num < 0){
                neg++;
            }
        }
        Console.WriteLine($"Numeros negativos: {neg}");
    }
}