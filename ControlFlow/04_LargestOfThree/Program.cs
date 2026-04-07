Console.WriteLine("Digite um numero:");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um outro numero:");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um último numero:");
int n3 = int.Parse(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"O numero {n1} é o maior");
}

else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"O numero {n2} é o maior");
}

else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine($"O numero {n3} é o maior");
}