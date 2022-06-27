using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*crie uma classe chamada Empregado que inclui os seguintes atributos; nome, cargo e salário mensal.
            Sua classe deve ter um construtor que inicializa os três atributos e também fornecer métodos que executem as seguintes ações:
            Se o salário mensal não for positivo, configure - o como 0.0.
            Conceder aumento de salários a seus funcionários de acordo com os dados abaixo: 

            1.Salário de 0 até 400.00 ganha 15 % 
            2.Salário de 400.01 até 800.00 ganha 12 % 
            3.Salário de 800.01 até 1200.00 ganha 10 % 
            4.Salário de 1200.01 até 2000.00 ganha 7 % 
            5.Acima de 2000.00 ganha 4 %
            Imprimir o salário de um funcionário.*/


namespace Exercicio_2___Gerenciando_salarios
{
    internal class Empregado
    {
        public string nome;
        public string cargo;
        public double salarioMensal;

        public Empregado (string nome, string cargo, double salarioMensal)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salarioMensal = salarioMensal;
        }
        public void SalarioMensal()
        {
            double meusalario = this.salarioMensal;
            double reajusteSalarial;

            if (meusalario < 0)
            {
                meusalario = 0.0;
            }
            else if (meusalario >= 0 && meusalario <= 400.00)
            {
                reajusteSalarial = meusalario *1.15;
               // Console.WriteLine($"Parabéns. Seu salário reajustado é {reajusteSalarial}");
            }
            else if (meusalario >= 401.00 && meusalario <= 800.00)
            {
                reajusteSalarial = meusalario *1.12;
               // Console.WriteLine($"Parabens. Seu salario reajustado é {reajusteSalarial}");
            }
            else if (meusalario >= 800.01 && meusalario <= 12.000)
            {
                reajusteSalarial = meusalario * 1.10;
               // Console.WriteLine($"Parabens.Seu salario reajustado é {reajusteSalarial}");
            }
            else if (meusalario >=12.001 && meusalario <= 20.000)
            {
                reajusteSalarial = meusalario * 1.07;
               // Console.WriteLine($"Parabens.Seu salario reajustado é {reajusteSalarial}");
            }
            else 
            {

                reajusteSalarial = meusalario * 1.04;
                //Console.WriteLine($"Parabens.Seu salario reajustado é{reajusteSalarial}");

            }
            //return ReajusteSalarial;

        }
        public void ReajusteSalario()
        {
            Console.WriteLine($"Nome do funcionário:{nome}");
            Console.WriteLine($"Cargo do funcioario:{cargo}");
            Console.WriteLine($"Seu novo salario:{salarioMensal}");
        }

    }
}
