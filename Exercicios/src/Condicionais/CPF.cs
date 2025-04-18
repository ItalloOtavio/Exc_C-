class CPF
{
    static public void Executar(){
    /*Regras para o cálculo dos dígitos verificadores do CPF. 
    É utilizado como exemplo o número: 123456789.
    (a) Calcule a soma dos produtos dos nove dígitos utilizando peso dois para unidade, 
    peso 3 para dezena, peso 4 para centena e assim sucessivamente. 
    Exemplo: 9*2+8*3+7*4+6*5+5*6+4*7+3*8+2*9+1*10 = 210
    (b) A dezena do número verificador é 0 caso o resto da divisão por 11 da soma dos produtos seja 0
    ou 1; caso contrário a dezena corresponde a subtrair de 11 o resto da divisão por 11 da soma dos
    produtos. Exemplo: resto da divisão de 210 por 11 é 1 então a dezena do número verificador é 0.
    (c) Calcule a soma dos produtos dos dez dígitos, onde o digito menos significativo passa a ser a
    dezena dos dígitos verificadores, utilizando os seguintes pesos: 2, 3, 4, 5, 6, 7, 8, 9, 10, 11;
    Exemplo: 2*0+3*9+4*8+5*7+6*6+7*5+8*4+9*3+10*2+11*1=255.
    (d) A unidade do número verificador é 0 caso o resto da divisão da soma dos produtos seja 0 ou 1;
    caso contrário a unidade corresponde a 11 menos o resto da divisão por 11 da soma dos produtos.
    Exemplo: resto da divisão de 255 por 11 é 2 então a unidade do número verificador é 11-2=9.
    Faça um algoritmo que recebe um número inteiro com 9 algarismos correspondente a um CPF e calcula
    os dígitos verificadores.
*/
    
    Console.WriteLine("Digite o primeiro numero do cpf:");
    int d1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Digite o segundo numero do cpf:");
    int d2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Digite o terceiro numero do cpf:");
    int d3 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Digite o quarto numero do cpf:");
    int d4 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Digite o quinto numero do cpf:");
    int d5 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Digite o sexto numero do cpf:");
    int d6 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Digite o setimo numero do cpf:");
    int d7 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Digite o oitavo numero do cpf:");
    int d8 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Digite o nono numero do cpf:");
    int d9 = int.Parse(Console.ReadLine()!);

    int soma = d1 * 10 + d2 * 9 + d3 * 8 + d4 * 7 + d5 * 6 + d6 * 5 + d7 * 4 + d8 * 3 + d9 * 2;
    
    }
}