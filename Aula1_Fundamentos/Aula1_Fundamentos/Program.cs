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
            string formation = " matemática e escritora inglesa.";
            string contribuition = " primeiro algoritmo para ser processado por uma máquina, a máquina analítica de Charles Babbage. Durante o período em que esteve envolvida com o projeto de Babbage, ela desenvolveu os algoritmos que permitiriam à máquina computar os valores de funções matemáticas, além de publicar uma coleção de notas sobre a máquina analítica. Por esse trabalho é considerada a primeira programadora de toda a história.";

            Console.WriteLine($"Seu nome é {adalo}.\n\n Ela foi uma {formation} de mundo destaque mundial.\n\n Hoje, ela é reconhecida por ter " +
                $"escrito o {contribuition}.\n\n Viva {adalo} !!!");
            Console.ReadLine();

        }
    }
}