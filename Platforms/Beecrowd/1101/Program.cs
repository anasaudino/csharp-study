while (true)
{

    Console.WriteLine("Digite um numero par:");
    int m = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite um outro numero par:");
    int n = int.Parse(Console.ReadLine());

    if (m < 0 || m == 0 || n < 0 || n == 0)
    {
        Console.WriteLine("Numero invalido!");
        break;
    }

    if (m % 2 == 0 && n % 2 == 0)
    {
        if (m > 0 && n > 0)
        {
            if (m > n)
            {
                Console.WriteLine($"{m} & {n}");
            }

            else
            {
                Console.WriteLine($"{n} & {m}");
            }
        }

    }

}
