while (true)
{
    Console.WriteLine("Digite sua senha:");
    string senha = Console.ReadLine();

    if (senha == "1234admin")
    {
        Console.WriteLine("Logado com SUCESSO!");
        break;
    }

    else if (senha != "1234admin")
    {
        Console.WriteLine("Senha inválida, tente novamente.");
        continue;
    }

    else
    {
        Console.WriteLine("Senha inválida, tente novamente.");
        continue;
    }
}
