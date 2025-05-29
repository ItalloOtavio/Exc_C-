class IdadeAlunos
{
    static public void Executar()
    {
        int[] idade = new int[40];

        for (int i = 0; i < idade.Length; i++)
        {
            Console.WriteLine("Digite sua idade");
            idade[i] = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine("Menores de 16:" + Menor(idade));
        Console.WriteLine("Entre 16 e 18 anos:" + Entre(idade));
        Console.WriteLine("Maiores de 18:" + Maior(idade));
        Console.WriteLine("Media:" + Media(idade));
        Console.WriteLine("Aluno Mais novo:" + MaisNovo(idade));
        Console.WriteLine("Aluno mais velho:" + MaisVelho(idade));
    }
    static int Menor(int[] idade)
    {
        int cont = 0;
        for (int i = 0; i < idade.Length; i++)
        {
            if (idade[i] < 16)
            {
                cont++;
            }
        }
        return cont;
    }

    static int Entre(int[] idade)
    {
        int cont = 0;
        for (int i = 0; i < idade.Length; i++)
        {
            if (idade[i] >= 16 && idade[i] <= 18)
            {
                cont++;
            }
        }
        return cont;
    }

    static int Maior(int[] idade)
    {
        int cont = 0;
        for (int i = 0; i < idade.Length; i++)
        {
            if (idade[i] >= 18)
            {
                cont++;
            }
        }
        return cont;
    }
    static int Media(int[] idade)
    {
        int soma = 0;
        int media = 0;
        for (int i = 0; i < idade.Length; i++)
        {
            soma = soma + idade[i];
        }
        media = soma / 40;
        return media;
    }
    static int MaisNovo(int[] idade)
    {
        int novo = idade[0];
        for (int i = 1; i < idade.Length; i++)
        {
            if (idade[i] < novo)
            {
                novo = idade[i];
            }
        }

        return novo;
    }
    static int MaisVelho(int[] idade)
    {
        int novo = idade[0];
        for (int i = 1; i < idade.Length; i++)
        {
            if (idade[i] > novo)
            {
                novo = idade[i];
            }
        }
        
        return novo;
    }
}
