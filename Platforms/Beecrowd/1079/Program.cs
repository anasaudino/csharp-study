Console.WriteLine("Digite um numero de casos que serão lidos:");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Digite um numero:");
    double a = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite um numero:");
    double b = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite um numero:");
    double c = double.Parse(Console.ReadLine());

    double mediaPonderada = (a * 2 + b * 3 + c * 5) / 10;

    Console.WriteLine($"Media ponderada: {mediaPonderada:F2}");
}

