class NegativoNulo
{
    static public void Executar(){
        /*Faça um programa que leia um vetor de dez posições. 
        Em seguida, compacte o vetor, retirando os valores nulos e negativos. 
        Coloque o resultado no vetor B, mostrando o vetor resultante.*/

        int[]v = new int[10];

        for(int i = 0; i < v.Length; i++){
            Console.WriteLine($"Digite o {i+1} valor:");
            v[i] = int.Parse(Console.ReadLine()!);
        }

        int pos = 0;

        for(int i = 0; i < v.Length; i++){
            if(v[i] > 0){
                pos++;
            }
        }

        int[]b = new int[pos];
        int ind = 0;

        for(int i = 0; i < v.Length; i++){
            if(v[i] > 0){
                b[ind] = v[i];
                ind++;
            }
        }
        Console.WriteLine("Valores:");
        for(int i = 0; i < b.Length; i++){
            Console.WriteLine(b[i]);
        }

    }
}