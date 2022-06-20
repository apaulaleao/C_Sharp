using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. 
Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 
2 notas de prova e 1 nota de trabalho. Escreva os seguintes métodos para esta classe:
Calcular média: calcula e exibe a média final do aluno com base em suas notas;
Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado.
 */
namespace Classroom
{
    public class Classroom
    {
        public int matricula;
        public string nome;
        public double n1;
        public double n2;
        public double nota_trabalho;

        public double media()
        {
            return (n1 + n2 + nota_trabalho) / 4;

        }
        public double notaFinal()
        {
            double media media();
            if (media < 1 || media >=7)
                return 0;
            else
            {
                return 10;
            }

        }


       // public Classroom()
        //{
          //  Console.WriteLine("Nota do aluno");
            //ApresentarMenu();
       // }

        //private void ApresentarMenu()
        //{
          //  Console.Clear();
            //Console.WriteLine("Digite sua matricula");


        //}
        // Console.ReadLine();
    }

}
