class MaiorMenorPos
{
    static public void Executar(){
        /*Faça um programa que carregue um vetor com 15 posições, 
        calcule e mostre: o maior elemento do vetor e em que posição esse elemento se encontra; 
        o menor elemento do vetor e em que posição esse elemento se encontra.*/
    
        int[] v = new int [15];

        for(int i = 0; i < v.Length; i++){
            Console.WriteLine($"Digite o {i+1} valor:");
            v[i] = int.Parse(Console.ReadLine()!);
        }

        int posMaior=0, posMenor=0;
        int maior = int.MinValue;
        int menor = int.MaxValue;

        for(int i = 0; i < v.Length; i++){
            if(v[i] > maior){
                maior = v[i];
                posMaior = i;
            }
            if(v[i] < menor){
                menor = v[i];
                posMenor = i; 
            }
        }
            Console.WriteLine($"Maior valor: {maior} Posição: {posMaior + 1}");
            Console.WriteLine($"Menor valor: {menor} Posição: {posMenor + 1}");
    }
}