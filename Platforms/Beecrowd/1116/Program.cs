Console.WriteLine("Quantos casos (pares) vamos processar");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{ 
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());

    if (y ==0)
    {
        Console.WriteLine("divisao impossivel");
    }
    else
    {
        double resultado = x / y;
        Console.WriteLine($"RESULTADO: {resultado:F1}");
    }
}