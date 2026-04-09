Console.WriteLine("Digite um numero:");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite um numero:");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Digite um numero:");
double c = double.Parse(Console.ReadLine());

double maior = (double)Math.Max(a, Math.Max(b, c));
double menor = (double)Math.Min(a, Math.Min(b, c));
double meio = (double)(a + b + c - maior - menor);

bool triangulo = maior < (meio + menor);

if (triangulo)
{
    Console.WriteLine("Forma um triângulo");

    if (maior * maior == meio * meio + menor * menor)
    {
        Console.WriteLine("Triângulo retângulo");
    }
    else if (maior * maior > meio * meio + menor * menor)
    {
        Console.WriteLine("Triângulo obtusângulo");
    }

    else
    {
        Console.WriteLine("Triângulo acutângulo");
    }

    if (a == b && b == c)
    {
        Console.WriteLine("Triângulo equilátero");
    }
    else if (a == b || a == c || b == c)
    {
        Console.WriteLine("Triângulo isósceles");
    }
}
else
{
    Console.WriteLine("Não forma um triângulo");
}  

