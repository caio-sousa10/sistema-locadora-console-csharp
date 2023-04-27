// menu inicial
Console.WriteLine("Bem-vindo(a) a locadora de filmes!");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("A - Alugar filme");
Console.WriteLine("S - Sair do sistema");
Console.WriteLine("");
Console.Write("Digite a opção desejada: ");
char escolha = Convert.ToChar(Console.ReadLine());

if (escolha == 'A' || escolha == 'a')
{
    // alugando filme
    Console.WriteLine("");
    Console.WriteLine("1 - O Poderoso Chefão (1972)");
    Console.WriteLine("2 - Pulp Fiction - Tempo de Violência (1994)");
    Console.WriteLine("3 - Taxi Driver - Motorista de Táxi (1976)");
    Console.WriteLine("");
    Console.Write("Digite o filme desejado: ");
    int escolhaFilme = Convert.ToInt32(Console.ReadLine());

    // usando switch para variavel escolhaFilme
    switch (escolhaFilme)
    {
        case 1:
            Console.WriteLine("");
            Console.WriteLine("Ótima escolha!");
            Console.WriteLine("Você alugou : O Poderoso Chefão (1972)");
            break;
        case 2:
            Console.WriteLine("");
            Console.WriteLine("Ótima escolha!");
            Console.WriteLine("Você alugou : Pulp Fiction - Tempo de Violência (1994)");
            break;
        case 3:
            Console.WriteLine("");
            Console.WriteLine("Ótima escolha!");
            Console.WriteLine("Você alugou : Taxi Driver - Motorista de Táxi (1976)");
            break;
        default:
            Console.WriteLine("");
            Console.WriteLine("Opção inválida...");
            break;
    }
}

else if (escolha == 'S' || escolha == 's')
{
    // saindo do sistema
    Console.WriteLine("");
    Console.WriteLine("Muito obrigado, volte sempre!");
    Thread.Sleep(200);
    Console.WriteLine("Saindo do sistema...");
}

else
{
    // tratando a possibilidade de digitar outra tecla
    Console.WriteLine("");
    Console.WriteLine("Opção inválida...");
}

Console.WriteLine("");
Console.WriteLine("Pressione qualquer tecla para encerrar");
Console.ReadKey(true); // ocultando a tecla selecionada para encerrar