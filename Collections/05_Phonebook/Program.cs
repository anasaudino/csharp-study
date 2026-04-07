Dictionary<string, string> agenda = new Dictionary<string, string>();

agenda.Add("Ana", "14988401395");
agenda.Add("Matias", "141111111111");
agenda.Add("Felipe", "142222222222");

Console.WriteLine($"Qual numero você deseja buscar? Digite pelo nome da pessoa.");
string nome = Console.ReadLine();

if (agenda.ContainsKey(nome))
{
    Console.WriteLine(agenda[nome]);
}

else
{
    Console.WriteLine("Contato não encontrado!");
}

