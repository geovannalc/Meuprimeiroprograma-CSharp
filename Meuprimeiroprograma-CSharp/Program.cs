string nomejogador;

Console.WriteLine("Bem-vindos ao torneio de Poker Devaria!");

Console.WriteLine("Qual o nome do jogador?");

nomejogador = Console.ReadLine().ToString();

switch (nomejogador)
{
    case "Daniel":
    case "Rafael":
    case "Adriano":
    case "Douglas":
    case "Victor":
    case "Kaique":
    case "Fulano":
    case "Siclano":
        Console.WriteLine("Jogador autorizado para o torneio de Poker");
        break;
    default: 
        Console.WriteLine("Jogador não autorizado");
        break ;
}

    

    

