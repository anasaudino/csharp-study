Console.WriteLine("Digite um numero:");
int x = int.Parse(Console.ReadLine());

int z = 20;
int contador = 0;

for (int i = x; i < z; i++)
{
    contador += i;
    Console.WriteLine(contador);

    if (contador > z)
    {
        break;
    }
}