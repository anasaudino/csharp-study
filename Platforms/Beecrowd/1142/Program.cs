using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Digite um numero:");
int n = int.Parse(Console.ReadLine());

int numero = 1;

for (int i = 0; i < n; i++)
{
    Console.Write(numero + " ");
    numero++;

    Console.Write(numero + " ");
    numero++;

    Console.Write(numero + " ");
    numero++;

    Console.WriteLine("PUM");

    numero++;
}