

Console.WriteLine("Leia um valor com 2 casas decimais.Calcule o menor numero de notas e moedas \n\n "+
    "possiveis no qual o valor pode ser decomposto.\n\n");
Console.Write("Insira o valor:");

float n1 = 100;
float n2 = 50;
float n3 = 20;
float n4 = 10;
float n5 = 5;
float n6 = 2;
float n7 = 1;
float money;
float rest;

money = float.Parse(Console.ReadLine());

if(money >= 100.00)
{
    n1 = money / 100;
    rest = money % 100;
    Console.WriteLine($" Você recebeu:\n {(int)n1} notas de 100.00");
    n2 = rest / 50;
    rest = rest % 50;
    Console.WriteLine($" {(int)n2} notas de 50.00");
    n3 = rest / 20;
    rest = rest % 20;
    Console.WriteLine($" {(int)n3} notas de 20.00");
    n4 = rest / 10;
    rest = rest % 10;
    Console.WriteLine($" {(int)n4} notas de 10.00");
    n5 = rest / 5;
    rest = rest % 5;
    Console.WriteLine($" {(int)n5} notas de 5.00");
    n6 = rest / 2;
    rest = rest % 2;
    Console.WriteLine($" {(int)n6} notas de 2.00");
    n7 = rest / 1;
    rest = rest % 1;
    Console.WriteLine($" {(int)n7} notas de 1.00");
    Console.ReadLine();

}



  




    //2.) 2. Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “x é o maior”.

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
    

    //3.Leia 3 valores que são as três notas de um aluno.
    //A seguir, calcule a média do aluno. Considere que cada nota pode ir de 0 até 10.0,
    //sempre com uma casa decimal. Imprima se o aluno foi aprovado ou reprovado considerando a média 7.*/

    string name;
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
    


    /* 4 - Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
    Se a nota for menor que 6.0, deve exibir a nota F.
    Se a nota for de 6.0 até 7.0, deve exibir a nota D.
    Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
    Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
    Se a nota fot entre 9.0 e 10.0, deve exibir um belo de um A 
    */

    Console.WriteLine("Leia 03 valores que são as 03 notas de um aluno. Calcule a média.\n ");

    float not1;
    float not2;
    float not3;


    Console.Write(" Digite sua 1ª nota:");
    not1 = float.Parse (Console.ReadLine());

    Console.Write(" Digite sua 2ª nota:");
    not2 = float.Parse (Console.ReadLine());

    Console.Write(" Digite sua 3ª nota:");
    not3 = float.Parse (Console.ReadLine());

    float medias = (not1+not2 + not3)/3;

    Console.Write($"Sua média é : {medias}");

    if (medias >= 9.01 && medias <= 10.0)
    {
        Console.WriteLine($" Sua média é {medias}. Você tirou A. Excelente! Você tá fera! ");
    }
    else if (medias >= 8.01 && medias <= 9.0)
    {
        Console.WriteLine($" Sua média é {medias}. Você tirou B. Parabéns");
    }
    else if (medias >= 7.01 && medias <= 8.00)
        {
        Console.WriteLine($" Sua média é {medias}. Você tirou C. Vamos melhorar");
        }
    else if (medias >= 6.01 && medias <= 7.00)
    {
        Console.WriteLine($" Sua média é {medias}. Você tirou D. Nada satisfeita com você!");
    }
    else if (medias <=6.0)
    {
        Console.WriteLine($" Sua média é {medias}. Você tirou F. Você tá péssimo!");
    }
    Console.ReadLine();
    


    // 5 - A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
    //Salário de 0 até 400.00 ganha 15% Salário de 400.01 até 800.00 ganha 12% Salário de 800.01 até 1200.00 ganha 10% Salário de 1200.01 até 2000.00 ganha 7% Acima de 2000.00 ganha 4%

    
    float salario;
    string nome = "";
    int matricula;

    Console.WriteLine("Teremos um aumento de salário e vamos ver quanto você vai ganhar.\n");

    Console.Write(" Digite sua matricula:");
    matricula = int.Parse(Console.ReadLine());

    Console.Write(" Digite seu nome:");
    nome= Console.ReadLine();

    Console.Write(" Digite seu salario:");
    salario = float.Parse (Console.ReadLine());

    if (salario >= 0 && salario <= 400.00)
    {
        Console.WriteLine($"{nome} - Matricula nº:{matricula} - Seu salário era de R$ {salario.ToString("F2")}, e terá um reajuste de 15% somando R${(salario*0.15).ToString("F2")} ficando" +
            $" em R$ {(salario * 1.15).ToString("F2")}.");
    }
    else if (salario >= 401.00 && salario <= 800.00)
    {
        Console.WriteLine($"{nome} - Matricula nº:{matricula} - Seu salário era de R$ {salario.ToString("F2")}, e terá um reajuste de 12% somando R$ {(salario * 0.12).ToString("F2")} ficando" +
            $" em {(salario * 1.12).ToString("F2")}");
    }
    else if (salario >= 801.00 && salario <= 1200.00)
    {
        Console.WriteLine($"{nome} - Matricula nº:{matricula} - Seu salário era de R$ {salario.ToString("F2")}, e terá um reajuste de 10% somando R$ {(salario * 0.10).ToString("F2")} ficando" +
            $" em {(salario * 1.10).ToString("F2")}");
    }
    else if (salario >= 1200.00 && salario <= 2000.00)
    {
        Console.WriteLine($"{nome} - Matricula nº:{matricula} - Seu salário era de R$ {salario.ToString("F2")}, e terá um reajuste de 7% somando R$ {(salario * 0.07).ToString("F2")} ficando" +
            $" em {(salario * 1.07).ToString("F2")}");
    }
    else if (salario >= 2000.00)

        Console.WriteLine($"{nome} - Matricula nº:{matricula} - Seu salário era de R$ {salario.ToString("F2")}, e terá um reajuste de 4% somando R$ {(salario * 0.04).ToString("F2")} ficando" +
            $" em {(salario * 1.04).ToString("F2")}");
    
   Console.ReadLine();


