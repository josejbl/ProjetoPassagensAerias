using System;

namespace Progetos_pasagens_aérias
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];

            //menu
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("---- Progeto passagens Aérias ----");
            Console.WriteLine("----------------------------------");

            bool senhaValida;
            do
            {
                Console.WriteLine("Digite sua senha");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
                
            } while (!senhaValida);
             Console.Clear();
             //Criar menu
            int escolha;
            int contador = 0;
            do
            {

                Console.WriteLine("Menu inicial");
                Console.WriteLine("Selecionar uma opção");
                Console.WriteLine("[1] - Cadrastar Passagens");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[3] - Sair");
                escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        //Cadastrar a Passagem
                            string resposta;

                            do
                            {
                                if(contador<5)
                                {
                                    Console.WriteLine($"Digite o nome do {contador+1}°Passageiro");
                                    nomes[contador] = Console.ReadLine();
                                    Console.WriteLine($"Digite a origem do {contador+1}°Passageiro");
                                    origem[contador] = Console.ReadLine();
                                    Console.WriteLine($"Digite o destino do {contador+1}°Passageiro");
                                    destino[contador] = Console.ReadLine();
                                    Console.WriteLine($"Digite a data do vôo do {contador+1}°Passageiro");
                                    data[contador] = Console.ReadLine();
                                    contador++;
                                    
                                }else{
                                    Console.WriteLine("Limite exedido de passagens");
                                    break;

                                }
                                Console.WriteLine("Gostaria de cadastrar um novo paasageiro?/n");
                                resposta = Console.ReadLine();
                            } while (resposta == "s");
                        break;
                    case 2:
                        //listar as passagens
                                for (var i = 0; i < 5; i++)
                                {
                                    Console.WriteLine($"Passageiros {nomes[i]}");
                                  
                                };
                                break;
                    case 0:
                        //Sair
                        Console.WriteLine("Obrigado Volte sempre!");
                        break;
                    default:
                         Console.WriteLine("Opção invalida");
                        break;
                }
                
            } while (escolha != 0 );


            //funções
            bool EfetuarLogin(string senha){

                if(senha == "123456"){
                    return true;
                }else{
                    Console.WriteLine("senha incorreta");
                    return false;
                }
                //fim efetuar login
            }



        }
    }
}
