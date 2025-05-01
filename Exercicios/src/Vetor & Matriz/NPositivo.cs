class NPositivo
{
    static public void Executar(){
        /*Faça um programa que leia um vetor de 50 posições de números inteiros e 
        mostre somente os números positivos.*/

        int[]v = new int [10];
        
        for(int i = 0; i < v.Length; i++){
            //Primeiro é feito a leitura dos valores
            Console.WriteLine($"Digite o valor da {i+1} posição");
            v[i] = int.Parse(Console.ReadLine()!);
        }
            //Segundo for para verificar se é positivo e imprimir
        for(int i = 0; i< v.Length; i++){
            if(v[i] > 0){
                Console.WriteLine(v[i]);
            }
        }

    }
}