Console.WriteLine("Digite um preço de um produto:");
double preco = double.Parse(Console.ReadLine());

Console.WriteLine("Digite um desconto desse produto:");
double desconto = double.Parse(Console.ReadLine());

double precoFinal = preco - (preco * desconto / 100);

Console.WriteLine($"O preço final ficou R${precoFinal:F2}");