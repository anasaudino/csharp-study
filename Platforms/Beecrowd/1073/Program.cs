Console.WriteLine("Digite um numero:");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        double resultado = Math.Pow(i, 2);
        Console.WriteLine(resultado);
    }
}
