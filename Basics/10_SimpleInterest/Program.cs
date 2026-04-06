Console.WriteLine("Digite o valor inicial investido ou emprestado:");
double principal = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a taxa de juros (em %):");
double taxaJuros = double.Parse(Console.ReadLine());

taxaJuros /= 100;

Console.WriteLine("Qual foi o período em que o dinheiro ficou rendendo?");
double tempo = double.Parse(Console.ReadLine());

double montante = principal * (1 + taxaJuros * tempo);

Console.WriteLine($"Resultado final: {montante:C}");
