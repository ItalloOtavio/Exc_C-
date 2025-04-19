class Lucro
{
    static public void Executar()
    {
        /*Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. 
        Para isto, mandou digitar uma linha para cada mercadoria com o código, 
        preço de compra e preço de venda das mesmas. 
        Faça um algoritmo que determine e escreva quantas mercadorias proporcionam lucro < 10%,
        10% <= lucro <= 20% e lucro > 20%. Determine também e escreva o valor total de compra e de
        venda de todas as mercadorias, assim como o lucro total.*/

        int cod, qtd;
        double compra, venda, lucroPercentual;
        double totalCompra = 0, totalVenda = 0, lucroTotal = 0;
        int lucroMenor10 = 0, lucroEntre10e20 = 0, lucroMaior20 = 0;

        Console.WriteLine("Digite a quantidade de produtos:");
        qtd = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < qtd; i++)
        {
            Console.Write("Digite o código do produto: ");
            cod = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o preço de compra: ");
            compra = double.Parse(Console.ReadLine()!);

            Console.Write("Digite o preço de venda: ");
            venda = double.Parse(Console.ReadLine()!);

            // Calcula o lucro percentual
            lucroPercentual = ((venda - compra) / compra) * 100;

            // Soma os valores totais de compra e venda
            totalCompra += compra;
            totalVenda += venda;

            // Soma o lucro total em dinheiro
            lucroTotal += (venda - compra);

            // Classifica o lucro em faixas
            if (lucroPercentual < 10)
            {
                lucroMenor10++;
            }
            else if (lucroPercentual <= 20)
            {
                lucroEntre10e20++;
            }
            else // lucroPercentual > 20
            {
                lucroMaior20++;

            }
        }
        Console.WriteLine($"Quantidade com lucro < 10%: {lucroMenor10}");
        Console.WriteLine($"Quantidade com lucro entre 10% e 20%: {lucroEntre10e20}");
        Console.WriteLine($"Quantidade com lucro > 20%: {lucroMaior20}");
        Console.WriteLine($"Valor total de compra: R$ {totalCompra:F2}");
        Console.WriteLine($"Valor total de venda: R$ {totalVenda:F2}");
        Console.WriteLine($"Lucro total: R$ {lucroTotal:F2}");
    }
}