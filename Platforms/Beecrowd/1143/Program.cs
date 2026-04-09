Console.WriteLine("Digite seu numero:");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write(" " + Math.Pow(i, 2));
    Console.Write(" " + Math.Pow(i, 3));

    Console.WriteLine();
}