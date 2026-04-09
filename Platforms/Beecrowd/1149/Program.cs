Console.WriteLine("Digite um numero:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um outro numero:");
int n = int.Parse(Console.ReadLine());

for (int i = a; i < n; i++)
{
    Console.WriteLine(i += 1);
}