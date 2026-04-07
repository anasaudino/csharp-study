Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

if (idade < 16)
{
    Console.WriteLine("Você ainda não tem idade para votar.");
}
else if ((idade >= 16 && idade < 18) || idade > 70)
{
    Console.WriteLine("O seu voto é opcional/facultativo.");
}
else
{
    Console.WriteLine("O seu voto é obrigatório!");
}