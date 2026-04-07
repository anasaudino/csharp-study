Console.WriteLine("Digite um numero");
int n = int.Parse(Console.ReadLine());

bool primo = true;

if (n <= 1)
{
    primo = false;
}

else
{
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            primo = false;
            break;
        }
    }
}

if (primo)
{
    Console.WriteLine("É primo");
}

else
{
    Console.WriteLine("Não é primo");
}
