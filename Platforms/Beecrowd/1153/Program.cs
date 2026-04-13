Console.WriteLine("Digite um numero:");
int x = int.Parse(Console.ReadLine());

int resultado = 1;

for (int i = x; i >= 1; i--)
{
    resultado = resultado * i;  
}

Console.WriteLine($"Fatorial de {x} = {resultado}");
