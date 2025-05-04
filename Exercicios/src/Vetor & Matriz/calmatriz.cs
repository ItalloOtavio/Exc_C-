class calmatriz
{
    static public void Executar(){
        /*Faça um programa que leia uma matriz 3 x 5 de inteiro, 
        calcule e mostre a quantidade de elementos lidos entre 15 e 20.*/
    
        int[,]m = new int[3,5];
        int cont = 0;

        for(int i = 0; i < m.GetLength(0); i++){
            for(int j = 0; j < m.GetLength(1); j++){
                Console.WriteLine($"Digite um numero");
                m[i,j] = int.Parse(Console.ReadLine()!);

                if(m[i,j] >= 15 && m[i,j]<= 20){
                    cont++;  
                }
            }
        }
            Console.WriteLine("Quantidade de Elementos:");
            Console.WriteLine(cont);
}
}