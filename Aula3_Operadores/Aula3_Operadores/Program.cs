
/*
Console.WriteLine("Leia um valor com 2 casas decimais.Calcule o menor numero de notas e moedas \n\n "+
    "possiveis no qual o valor pode ser decomposto.\n\n");
Console.ReadKey();

float n1 = 100;
float n2 = 50;
float n3 = 20;
float n4 = 10;
float n5 = 5;
float n6 = 2;

float money;

Console.WriteLine("Insira um valor");
money = float.Parse(Console.ReadLine());

n1 = money / 100;
Console.ReadLine(n1);
*/

/*2.) 2. Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “x é o maior”.

Console.WriteLine("Digite 03 valores e vou te apresentar o de maior dos 3 valores e exibir a mensagem 'x é o maior.'Vamos tentar?\n\n");

int number1;
int number2;
int number3; 

Console.WriteLine(" Digite o 1º numero");
number1=int.Parse(Console.ReadLine());

Console.WriteLine(" Digite o 2º numero");
number2=int.Parse(Console.ReadLine());

Console.WriteLine(" Digite o 3º numero");
number3=int.Parse(Console.ReadLine());

if (number1 > number2 && number1 > number3)
    Console.WriteLine($" O {number1} é o maior!");
else if (number2 > number3)
    Console.WriteLine($" O {number2} é o maior!");
else
    Console.WriteLine($" O {number3} é o maior!");

Console.ReadLine();
*/

/*3.Leia 3 valores que são as três notas de um aluno.
A seguir, calcule a média do aluno. Considere que cada nota pode ir de 0 até 10.0,
sempre com uma casa decimal. Imprima se o aluno foi aprovado ou reprovado considerando a média 7.*/

/*string name;
float nota1;
float nota2;
float nota3;

Console.WriteLine("------- Média do Aluno-------");
Console.ReadLine();
Console.WriteLine("Digite seu nome");
name= Console.ReadLine();
Console.WriteLine($"{name}, Digite suas notas. Vamos ver se voce passou ou nao.Estamos torcendo por você!");
Console.ReadLine();

Console.WriteLine("Digite sua 1ª nota:");
nota1=float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua 2ª nota:");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua 3ª nota:");
nota3 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3) / 3;


if (nota1 > 10 || nota2 > 10 || nota3 > 10 || nota1 < 0 || nota2 < 0 || nota3 < 0)
    {
        Console.WriteLine(" Nota inválida!\n Não foi possível calcular a média do aluno, pois há nota(s) inválidas!");
    }
    else if (media >= 7)
    {
        Console.WriteLine($" {name}, você foi APROVADO(A) com nota {media.ToString("F1")}");
    }
    else
        Console.WriteLine($" {name}, Infelizmente você foi REPROVADO(A) com nota {media.ToString("F1")}");


Console.ReadLine();
*/


/*4 - Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
Se a nota for menor que 6.0, deve exibir a nota F.
Se a nota for de 6.0 até 7.0, deve exibir a nota D.
Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
Se a nota fot entre 9.0 e 10.0, deve exibir um belo de um A
*/
Console.WriteLine("Leia 03 valores que são as 03 notas de um aluno. Calcule a média.\n ");

float nota1;
float nota2;
float nota3;


Console.WriteLine(" Digite sua 1ª nota\n");
nota1 = float.Parse (Console.ReadLine());

Console.WriteLine(" Digite sua 2ª nota\n");
nota2 = float.Parse (Console.ReadLine());

Console.WriteLine(" Digite sua 3ª nota\n");
nota3 = float.Parse (Console.ReadLine());

float media = (nota1+nota2 + nota3)/3;

//Console.WriteLine($"Sua média é {media}");

if (media >= 9.01 && media <= 10.0)
{
    Console.WriteLine($" Sua média é {media}. Você tirou A. Excelente! Você tá fera!");
}
else if (media >= 8.01 && media <= 9.0)
{
    Console.WriteLine($" Sua média é {media}. Você tirou B. Parabéns");
}
else if (media >= 7.01 && media <= 8.00)
    {
    Console.WriteLine($" Sua média é {media}. Você tirou C. Vamos melhorar");
    }
else if (media >= 6.01 && media <= 7.00)
{
    Console.WriteLine($" Sua média é {media}. Você tirou D. Nada satisfeita com você!");
}
else if (media <=6.0)
{
    Console.WriteLine($" Sua média é {media}. Você tirou F. Você tá péssimo!");
}
Console.ReadLine();
