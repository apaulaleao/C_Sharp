
Console.WriteLine("Escolha qual operação voce deseja realizar");
Console.Write("1- Somar\n");
Console.Write("2- Subtrair\n");
Console.Write("3- Multiplicar\n");
Console.Write("4- Dividir\n");
Console.Write("5- Zerar Calculadora\n");

int opcao = Convert.ToInt32(Console.ReadLine());

double resultado = 0;


switch (opcao)
{
    case 1:
        Console.WriteLine("Qual valor voce deseja que seja somado");
        int valor = Convert.ToInt32(Console.ReadLine());
        break;

    case 2:
        Console.WriteLine("Qual valor voce deseja que seja somado");
        valor = Convert.ToInt32(Console.ReadLine());
        break;

    default:
        Console.WriteLine("Teste");
        break;

        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

}
