// ControlFlow - Ex02: Switch
// switch expression (C# 8+) e switch statement clássico

int diaSemana = 3;

// switch expression (moderno)
string nome = diaSemana switch
{
    1 => "Segunda",
    2 => "Terça",
    3 => "Quarta",
    4 => "Quinta",
    5 => "Sexta",
    6 or 7 => "Fim de semana",
    _ => "Inválido"
};

Console.WriteLine($"Dia {diaSemana}: {nome}");
