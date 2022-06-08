using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elabore um Programa que leia seu nome, seu endereço, seu bairro , o CEP e telefone em linhas separadas.
            Console.WriteLine("-------- Inicio do Programa------------"); 

            string name = "";
            string endereco = "";
            string bairro;
            string telefone;

            Console.WriteLine("Escreva seu nome:");
            name = Console.ReadLine();

            Console.WriteLine($"Qual seu endereço, {name}:");
            endereco = Console.ReadLine();

            Console.WriteLine("Qual seu bairro ? ");
            bairro = Console.ReadLine();

            Console.WriteLine($"Hummm, {bairro}. Próximo a minha casa. Você pode me passar seu telefone ?");
            telefone = Console.ReadLine();

            Console.WriteLine($"Legal! Vou te ligar {name}, para marcarmos um café e falarmos de negócios! =) \n\n\n ");
            Console.ReadLine();



            /*  2)  Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, 
           * sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.*/

            Console.WriteLine();
            Console.WriteLine("Agora, falaremos de uma mulher muito famosa na área de tecnologia. Vamos lá conhecer ?\n\n");

            string adalo = "Ada Lovelace";
            string formation = " Matemática e escritora inglesa.";
            string contribuition = " Primeiro algoritmo para ser processado por uma máquina, a máquina analítica de Charles Babbage. Durante o período em que esteve envolvida com o projeto de Babbage, ela desenvolveu os algoritmos que permitiriam à máquina computar os valores de funções matemáticas, além de publicar uma coleção de notas sobre a máquina analítica. Por esse trabalho é considerada a primeira programadora de toda a história.";

            Console.WriteLine($"Seu nome é {adalo}.\n\n Ela foi uma {formation} de mundo destaque mundial.\n\n Hoje, ela é reconhecida por ter " +
                $"escrito o {contribuition}.\n\nViva {adalo} !!! \n\n\n ");
            Console.ReadLine();





            /*  3)  Elabore um programa que mostre na tela uma letra de musica que voce gosta, o compositor  
                 e o genero musical.*/

            Console.WriteLine();
            Console.WriteLine("Mostre na tela uma musica que voce gosta, o compositor e o genero musical \n\n" );

            string song = "Con te Partiró";
            string single = "Andrea Bocceli";
            string musical_genre = "Música Clássica";
            string music = "Quando sono solo Sogno all'orizzonte E mancan le parole Si lo so che non c'è luce " +
                " In una stanza quando manca il sole Se non ci sei tu con me, con me Su le finestre Mostra a tutti il mio cuore" +
                "Che hai acceso Chiudi dentro me La luce che Hai incontrato per strada Con te partirò Paesi che non ho mai " +
                 "con te Adesso si li vivrò Con te partirò Su navi per mari Che io lo so No no non esistono più Con te io li vivrò" +
                 "Quando sei lontana Sogna all'orizzonte E mancan le parole E io si lo so Che sei con me, con me";


            Console.WriteLine($"Nome da música : {song} \n\nNome do artista : {single} \n\nGênero musical : {musical_genre} \n\nLetra da sua musica favorita: {music}.\n\n");
            Console.ReadLine();




            /* 4) Elabore um programa que exibe uma mensagem que incentive outras mulheres a entrar na tecnologia */

            Console.WriteLine();
            Console.WriteLine(" Exiba uma mensagem de incentivo para mulheres entrarem na área de Tecnologia. \n\n");
            Console.ReadLine();

            string meu_nome="";

            Console.WriteLine("Digite seu nome?");
            meu_nome=Console.ReadLine();

            Console.WriteLine($"Olá,{meu_nome} Seja muito bem vinda!");
            Console.WriteLine($"Este é o biscoito da sorte,{meu_nome}.Quebre-o  e encontre uma mensagem especial para você! ");
            Console.ReadLine();

            Console.WriteLine("Digite 1 para: Estou com sorte ou Digite 2 para : Estou com MUITA sorte!");
            
            int res = int.Parse(Console.ReadLine());

            if(res ==1 )
            {
                Console.WriteLine("Você é uma mulher inteligente e não perca a oportunidade que o mundo está te oferecendo!");

            }
            else
            {
                Console.WriteLine("Você é uma mulher IN CRI VEL e não pensou 2x em arriscar tudo para voar. A Programação vai mudar sua história!!");
            }

            Console.ReadLine();




        }
    }
}