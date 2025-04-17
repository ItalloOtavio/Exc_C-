class OrigemProduto
{
    static public void Executar(){
        /*Faça um algoritmo que tendo como dados de entrada o preço de um produto e um código de origem
        emita o preço junto de sua procedência. Caso o código não seja nenhum dos especificados o produto
        é considerado importado. Os códigos de origem são os seguintes:
        Cód. Origem
            1 Sul
            2 Norte
            3 Leste
            4 Oeste
            5 ou 6 Nordeste
            7, 8 ou 9 Sudeste
            10 até 20 Centro Oeste
            25 até 50 Noroeste*/

        Console.WriteLine("Codigo de Origem do Produto");
        Console.WriteLine("1 - SUL");
        Console.WriteLine("2 - NORTE");
        Console.WriteLine("3 - LESTE");
        Console.WriteLine("4 - OESTE");
        Console.WriteLine("5 ou 6 - NORDESTE");
        Console.WriteLine("7,8 ou 9 - SUDESTE");
        Console.WriteLine("10 até 20 - CENTRO OESTE");
        Console.WriteLine("25 até 50 - NOROESTE"    );
        int op = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o preço do produto");
        double produto = double.Parse(Console.ReadLine()!);

        if(op == 1){
            Console.WriteLine("Origem do Produto: Sul");
            Console.WriteLine($"Preço do produto: {produto}");
        }
        else if(op == 2){
            Console.WriteLine("Origem do Produto: Norte");
            Console.WriteLine($"Preço do produto: {produto}");
        }
        else if(op == 3){
            Console.WriteLine("Origem do Produto: Leste");
            Console.WriteLine($"Preço do produto: {produto}");
        }
        else if(op == 4){
            Console.WriteLine("Origem do Produto: Oeste");
            Console.WriteLine($"Preço do produto: {produto}");
        }
        else if(op == 5 || op == 6){
            Console.WriteLine("Origem do Produto: Nordeste");
            Console.WriteLine($"Preço do produto: {produto}");
        }
        else if(op == 7 || op == 8 || op == 9){
            Console.WriteLine("Origem do Produto: Sudeste");
            Console.WriteLine($"Preço do produto: {produto}");
        }
        else if(op >= 10 && op <= 20){
            Console.WriteLine("Origem do Produto: Centro Oeste");
            Console.WriteLine($"Preço do produto: {produto}");
        }
        else if(op >= 25 && op <= 50){
            Console.WriteLine("Origem do Produto: Noroeste");
            Console.WriteLine($"Preço do produto: {produto}");
        }else{
            Console.WriteLine("Produto Importado");
        }

    }
}