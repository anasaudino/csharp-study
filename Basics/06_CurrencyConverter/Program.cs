Console.WriteLine("Digite um valor em R$:");
double reais = double.Parse(Console.ReadLine());

double cotacaoDolar = 5.14;
double valorConvertido = reais / cotacaoDolar;

Console.WriteLine($"O valor convertido em dolar é: {valorConvertido:F2}");
