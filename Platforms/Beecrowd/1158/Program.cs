//Ler varios casos (rodadas)
//para cada caso, ler 2 numeros inteiros (X e Y)
//para cada caso, imprimir a soma do y numeros impares consecutivos a partir do x
//se x for par, o primeiro numero impar é x + 1

Console.WriteLine("Quantos casos de teste deseja realizar?");
int casos = int.Parse(Console.ReadLine());

int soma = 0;

for (int i = 0; i < casos; i++)
{
    Console.WriteLine("Digite um numero inteiro:");
    int x = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite um outro numero inteiro:");
    int y = int.Parse(Console.ReadLine());

    for (int j = x; j < y; j++)
    {
        if (j % 2 != 0)
        {
            soma += j;
        }

        else
        {
            j += 1;
        }
    }
}
