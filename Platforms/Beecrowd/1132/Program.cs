Console.WriteLine("Digite um numero:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um outro numero:");
int y = int.Parse(Console.ReadLine());

int soma = 0;

for (int i = x; i <= y; i++)
{
    if (i % 13 == 0 && y % 13 == 0)
    {
        Console.WriteLine("divisao impossivel");
    }

    else
    {
        soma = soma + i;
    }
}

Console.WriteLine("O resultado da soma é: " + soma);
