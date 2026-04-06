// Collections - Ex03: Dictionaries
// Dictionary<TKey, TValue>: pares chave-valor, busca O(1)

var capitais = new Dictionary<string, string>
{
    { "Brasil", "Brasília" },
    { "Argentina", "Buenos Aires" },
    { "Portugal", "Lisboa" }
};

capitais["Japão"] = "Tóquio"; // adiciona nova entrada

foreach (var (pais, capital) in capitais)
    Console.WriteLine($"{pais} → {capital}");

// verificar existência antes de acessar
if (capitais.TryGetValue("Brasil", out var cap))
    Console.WriteLine($"\nCapital do Brasil: {cap}");
