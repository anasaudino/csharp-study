// ControlFlow - Ex03: Loops
// for, while, do-while, foreach

Console.WriteLine("=== for ===");
for (int i = 1; i <= 5; i++)
    Console.Write($"{i} ");

Console.WriteLine("\n=== while ===");
int n = 1;
while (n <= 5)
{
    Console.Write($"{n} ");
    n++;
}

Console.WriteLine("\n=== foreach ===");
int[] pares = { 2, 4, 6, 8, 10 };
foreach (int par in pares)
    Console.Write($"{par} ");

Console.WriteLine();
