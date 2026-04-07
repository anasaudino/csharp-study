Console.WriteLine("Digite uma nota de 0 a 5");
int nota = int.Parse(Console.ReadLine());

switch (nota)
{
    case 1:
        Console.WriteLine("Insuficiente");
        break;

    case 2:
        Console.WriteLine("Regular");
        break;

    case 3:
        Console.WriteLine("Bom");
        break;

    case 4:
        Console.WriteLine("Muito bom");
        break;

    case 5:
        Console.WriteLine("Excelente");
        break;

    default:
        Console.WriteLine("Opção inválida!");
        break;
}