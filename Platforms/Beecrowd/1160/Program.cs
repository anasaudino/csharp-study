Console.WriteLine("Digite a população de uma cidade:");
double popA = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a taxa de crescimento da população:");
double taxaA = double.Parse(Console.ReadLine()) / 100;

Console.WriteLine("Digite a população de uma outra cidade:");
double popB = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a taxa de crescimento da população:");
double taxaB = double.Parse(Console.ReadLine()) / 100;

int anos = 0;

while (popA < popB)
{
    popA += popA * taxaA;
    popB += popB * taxaB;
    anos++;

    if (anos > 100)
    {
        Console.WriteLine("Mais de 1 século");
        break;
    }
}

Console.WriteLine($"{anos} anos");