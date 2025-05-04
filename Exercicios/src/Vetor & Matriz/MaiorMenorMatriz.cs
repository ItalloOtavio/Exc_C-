class MaiorMenorMatriz
{
    static public void Executar(){
        /*Faça um programa que carregue urna matriz 6 x 3, calcule e mostre:
        o maior elemento da matriz e sua respectiva posição, ou seja, linha e coluna;
        o menor elemento da matriz e sua respectiva posição, ou seja, linha e coluna.*/
    
        int[,]matriz = new int [6,3];

        for(int i = 0; i < matriz.GetLength(0); i++){
            for(int j = 0; j < matriz.GetLength(1); j++){
                Console.WriteLine("Digite os valores:");
                matriz[i,j] = int.Parse(Console.ReadLine()!);
            }
        }

        int maior = int.MinValue;
        int menor = int.MaxValue;
        int posMaior = 0, posMenor = 0;
        int posMaiorC = 0, posMenorC = 0;
        
        for(int i = 0; i < matriz.GetLength(0); i++){
            for(int j = 0; j < matriz.GetLength(1); j++){
        
                if(matriz[i,j] > maior){
                    maior = matriz[i,j];
                    posMaior = i;
                    posMaiorC = j;
                }
                if(matriz[i,j] < menor){
                    menor = matriz[i,j];
                    posMenor = i;
                    posMenorC = j;
                }
            }
        } 

        Console.WriteLine($"Maior valor: {maior} || Linha: {posMaior}, Coluna: {posMaiorC}");
        Console.WriteLine($"Menor valor: {menor} || Linha: {posMenor}, Coluna: {posMenorC}");
    }
}