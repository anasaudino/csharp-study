Console.WriteLine("Digite um valor em segundos:");
int segundos = int.Parse(Console.ReadLine());

int horas = segundos / 3600;
int minutos = (segundos % 3600) / 60;
int segundosRestantes = segundos % 60;

Console.WriteLine($"O valor convertido é: {horas} horas, {minutos} minutos e {segundosRestantes} segundos.");
