
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



        }
    }
}



