class Preco
{
    static public void Executar(){
        /*Faça um programa que receba o preço de um produto, calcule e mostre o novo preço,
        sabendo-se que este sofreu um desconto de 10%.*/

        Console.WriteLine("Digite o Preço do produto:");
        double produto = double.Parse(Console.ReadLine());
        
        double preco, desconto=0;

        preco = produto * 0.10;
        desconto = produto - preco;

        Console.WriteLine($"Valor do produto: {desconto:f2}");
    }
}