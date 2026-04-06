// Beecrowd - 1002: Area of a Circle
// https://www.beecrowd.com.br/judge/en/problems/view/1002
// Leia o raio R e calcule a área do círculo (pi = 3.14159).

double r = double.Parse(Console.ReadLine()!, System.Globalization.CultureInfo.InvariantCulture);
double area = 3.14159 * r * r;

Console.WriteLine($"A={area:F4}");
