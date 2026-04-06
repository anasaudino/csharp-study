// Collections - Ex01: Lists
// List<T>: tamanho dinâmico, adicionar/remover elementos facilmente

var frutas = new List<string> { "Maçã", "Banana", "Laranja" };

frutas.Add("Uva");
frutas.Remove("Banana");

Console.WriteLine($"Total: {frutas.Count} frutas");

foreach (var fruta in frutas)
    Console.WriteLine($"  - {fruta}");
