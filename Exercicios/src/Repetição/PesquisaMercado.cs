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
        string resposta = "";
        char sexo;
        int sim = 0, nao = 0;
        int mas = 0, fem = 0;
        for(int i = 0; i < 10; i++){  
            Console.WriteLine("Digite o seu sexo : (M/F)");
            sexo = char.Parse(Console.ReadLine()!);
        if(sexo == 'M'){
            mas++;
        }else if(sexo == 'F'){
            fem++;
        }
            Console.WriteLine("Voce gostou do novo produto? (S/N)");
            resposta = (Console.ReadLine()!);
        
        if(resposta == "S"){
            sim++;
        }else if(resposta == "N"){
            nao++;
        }
        }
            double porcentagemM = mas * 100.0 / 2000;
            double porcentagemF = fem * 100.0 / 2000;
            Console.WriteLine($"Sexo Maculino: {porcentagemM}");
            Console.WriteLine($"Sexo Feminino: {porcentagemF}");
            Console.WriteLine($"Respostas SIM: {sim}");
            Console.WriteLine($"Respostas NAO: {nao}");
    }
}