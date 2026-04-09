int maior = int.MinValue;
int menor = int.MaxValue;

int posicaoMaior = 0;
int posicaoMenor = 0;

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine("Digite um numero:");
    int n = int.Parse(Console.ReadLine());

    if (n > maior)
    {
        maior = n;
        posicaoMaior = i;
    }
    if (n < menor)
    {
        menor = n;
        posicaoMenor = i;
    }
}
Console.WriteLine($"Maior: {maior} | Posição: {posicaoMaior}");
Console.WriteLine($"Menor: {menor} | Posição: {posicaoMenor}");