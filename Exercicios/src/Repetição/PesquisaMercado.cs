class PesquisaMercado
{
    static public void Executar(){
        /*Uma certa firma fez uma pesquisa de mercado para saber se as pessoas gostaram ou não 
        de um novo produto lançado no mercado. 
        Para isso, forneceu o sexo do entrevistado e sua resposta (sim ou não).
        Sabendo-se que foram entrevistadas 2.000 pessoas, faça um algoritmo que calcule e escreva:
        o número de pessoas que responderam sim;
        o número de pessoas que responderam não;
        a porcentagem de pessoas do sexo feminino que responderam sim;
        a porcentagem de pessoas do sexo masculino que responderam não.
*/
        int op = 0, sexo;
        int sim = 0, nao = 0;
        for(int i = 0; i < 2000; i++){
            Console.WriteLine("10 - Masculino");
            Console.WriteLine("11 - Feminino");
            sexo = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Voce gostou do novo produto?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Nao");
            op = int.Parse(Console.ReadLine()!);
        }
        if(op == 1){
            sim++;
        }else{
            nao++;
        }

    }
}