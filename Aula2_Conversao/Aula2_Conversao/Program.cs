
namespace Program
{
    class Programs
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
            //soma=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"A soma dos números é {soma}. =)");
            






        }
    }
}



