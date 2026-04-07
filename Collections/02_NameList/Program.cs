List<string> nomes = new List<string>();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite um nome que ficará na posição {i}");
    string nome = Console.ReadLine();

    nomes.Add(nome);
    nomes.Sort();
}


foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}