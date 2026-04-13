Console.WriteLine("Digite o valor de A:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de N:");
int n = int.Parse(Console.ReadLine());

int soma = 0;

for (int i = 0; i < n; i++)
{
    soma += a + i;

    Console.WriteLine(soma);
}