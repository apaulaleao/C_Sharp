using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*crie uma classe chamada Empregado que inclui os seguintes atributos; nome, cargo e salário mensal.
            Sua classe deve ter um construtor que inicializa os três atributos e também fornecer métodos que executem as seguintes ações:
            Se o salário mensal não for positivo, configure - o como 0.0.
            Conceder aumento de salários a seus funcionários de acordo com os dados abaixo: 
            Salário de 0 até 400.00 ganha 15 % 
            Salário de 400.01 até 800.00 ganha 12 % 
            Salário de 800.01 até 1200.00 ganha 10 % 
            Salário de 1200.01 até 2000.00 ganha 7 % 
            Acima de 2000.00 ganha 4 %
            Imprimir o salário de um funcionário.*/


namespace Exercicio_2___Gerenciando_salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string cargo;
            double salario;


            Console.WriteLine();
            Console.Write("Informe nome funcionario:");
            nome=Console.ReadLine();

            Console.Write("Informe cargo do funcionario");
            cargo=Console.ReadLine();

            Console.Write("Informe salario do funcionário");
            salario = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Empregado empregado = new Empregado(nome,cargo, salario);   
        }
    }
}