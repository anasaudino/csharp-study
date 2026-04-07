List<int> numeros = new List<int>();

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Digite um numero:");
    int n = int.Parse(Console.ReadLine());

    numeros.Add(n);
}

Console.WriteLine($"Qual numero você deseja buscar?");
int n2 = int.Parse(Console.ReadLine());

if (numeros.Contains(n2))
{
    Console.WriteLine("Este número existe na lista!");
}

else
{
    Console.WriteLine("Este não número existe na lista!");
}
