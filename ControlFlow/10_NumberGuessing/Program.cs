Random aleatorio = new Random();
int numeroAleatorio = aleatorio.Next(1, 20);

while (true)
{
    Console.WriteLine("Digite um numero:");
    int n = int.Parse(Console.ReadLine());

    if (n < 1 || n > 20)
    {
        Console.WriteLine("Numero invalido! Digite um numero entre 1 e 20.");
        continue;
    }

    if (n == numeroAleatorio)
    {
        Console.WriteLine("Parabéns! Você acertou =)");
        break;
    }

    else if (n < numeroAleatorio)
    {
        Console.WriteLine("O número é menor que o numero aleatório");
    }

    else if (n > numeroAleatorio)
    {
        Console.WriteLine("O número é maior que o numero aleatório");
    }
}