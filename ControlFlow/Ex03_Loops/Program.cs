Console.WriteLine("Digite um numero:");
int numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine(numero + "X" + i + "=" + resultado);
}