// ControlFlow - Ex01: If / Else
// Tomada de decisão com if, else if, else

int nota = 75;

if (nota >= 90)
    Console.WriteLine("Aprovado com excelência");
else if (nota >= 70)
    Console.WriteLine("Aprovado");
else if (nota >= 50)
    Console.WriteLine("Recuperação");
else
    Console.WriteLine("Reprovado");

// Operador ternário
string resultado = nota >= 70 ? "Passou!" : "Não passou";
Console.WriteLine(resultado);
