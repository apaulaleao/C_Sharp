using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.

            
             int idade;
             int anoAtual;
             int anoNasc;

             Console.WriteLine("Vou descobrir sua idade, vamos tentar?");
             Console.ReadLine();

             Console.WriteLine("Qual o ano atual?\n\n");
             anoAtual = Convert.ToInt32(Console.ReadLine());


             Console.WriteLine("Qual o ano do seu nascimento?\n\n");
             anoNasc = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Você tem:\n\n");
             idade = anoAtual - anoNasc;
             Console.WriteLine($"{idade} anos");

             // 2) Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números


             Console.WriteLine("Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números");
             Console.ReadLine();

             int a, b, c, d, e, f, g, h, i, j;
             int soma;

             Console.WriteLine("Digite o 1 num");
             a = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Digite o 2 num");
             b = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Digite o 3 num");
             c = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Digite o 4 num");
             d = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Digite o 5 num");
             e = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Digite o 6 num");
             f = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Digite o 7 num");
             g = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Digite o 8 num");
             h = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Digite o 9 num");
             i = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Digite o 10 num");
             j = Convert.ToInt16(Console.ReadLine());



             soma = (a + b + c + d + e + f + g + h + i + j);
             soma=Convert.ToInt16(Console.ReadLine());
             Console.WriteLine($"A soma dos números é {soma}. =)");
            Console.ReadLine();
         

            // Exercicio 3 - Escreva um programa que leia o número de horas trabalhadas e um funcionário, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
            Console.WriteLine("-------- Escreva um programa que leia o número de horas trabalhadas\n\n" +
                " de um funcionário, o valor que recebe por hora e calcula o salário desse funcionário. \n\n" +
                "A seguir, mostre o número e o salário do funcionário, com duas casas decimais.\n\n------");
            Console.ReadLine();

            int horas_trabalhadas;
            float valor_hora;

            Console.WriteLine("Qual valor por hora trabalhada do funcionário?\n\n");
            valor_hora= float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de horas trabalhadas?\n\n");
            horas_trabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine($"Quantidade de horas trabalhadas: {horas_trabalhadas}\nSeu salário  recebido: R$ {(horas_trabalhadas * valor_hora).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
           



            //Exercicio 4 

           Console.WriteLine(" Leia um valor inteiro que correspondente a idade de uma pessoa e mostre-a em anos, meses, dias e horas");
            
            Console.WriteLine("Digite seu nome, por favor");
            string nomes = Console.ReadLine();

            Console.WriteLine("Digite sua idade\n");
            
            int age= int.Parse(Console.ReadLine());

            int month = 12 * age;

            int days = month * 30;

            int hours = days * 60;



            Console.WriteLine($" Olá {nomes} sua idade é {age} anos.\n Representando {age * 12} meses ou\n {age * 365} dias de idade ou\n {hours} horas de idade! ");

            Console.ReadLine(); 
            

            //Exercicio 5  - Construa um conversor de moedas//

            Console.WriteLine("--- Construa um conversor de moedas ---");
            Console.ReadLine();

            Console.WriteLine(" Crie um programa que solicite um valor em real ao usuário e converta esse valor para: \n\n " +
                "dolar,\n\n euro,\n\n libra esterlina,\n\n dolar canadense,\n\n peso argentino,\n\n peso chileno.\n\n");


            Console.ReadLine();

            float real;
            float dolar = 5.49f;
            float euro = 6.00f;
            float libra_esterlina = 2.50f;
            float dolar_canadense= 2.0f;
            float peso_argentino=2.0f;
            float peso_chileno = 2.0f;

            Console.WriteLine(" Digite um valor em R$ para conversão:\n\n");
               real = float.Parse(Console.ReadLine());

            float x = real / dolar;
            Console.WriteLine($"O valor em dolar é {x.ToString("F2")}");
            Console.ReadLine();            

        }


    }
    
}