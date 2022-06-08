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

            Console.WriteLine($"Legal! Vou te ligar {name}, para marcarmos um café e falarmos de negócios! =) ");
            Console.ReadLine();



           
            
        }
    }
}