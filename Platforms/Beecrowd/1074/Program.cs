Console.WriteLine("Digite um numero:");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i <= n; i++) 
{
    Console.WriteLine("");

    Console.WriteLine("Digite um outro numero:");
    int x = int.Parse(Console.ReadLine());

    Console.WriteLine("");

    if (x == 0)
    {
        Console.WriteLine("NULL!");
    }

    else
    {
        if (x % 2 == 0)
        {
            Console.WriteLine("EVEN!");
        }

        else
        {   
            Console.WriteLine("ODD!");
        }

        if (x > 0)
        {
            Console.WriteLine("POSITIVE!");
        }

        else
        {
            Console.WriteLine("NEGATIVE!");
        }
    }

}