Console.WriteLine("Digite um numero:");
int n = int.Parse(Console.ReadLine());

bool primo = true;

for (int i = 2; i < n; i++)
{ 
    if (n % i == 0)
    {
        primo = false;
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