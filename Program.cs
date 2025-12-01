using System;

// Screen Sound
string msgDeBoasVindas = "Bem-vindo ao Screen Sound!";

void TelaDeBoasVindas()
{
    Console.WriteLine(@"
╔╗─╔╗──────╔╗╔═══╗────╔╗
║║─║║──────║║║╔═╗║────║║
║╚═╝╠══╦═╦═╝║║╚═╝╠══╦═╝╠╦══╗
║╔═╗║╔╗║╔╣╔╗║║╔╗╔╣╔╗║╔╗╠╣╔╗║
║║─║║╔╗║║║╚╝║║║║╚╣╔╗║╚╝║║╚╝║
╚╝─╚╩╝╚╩╝╚══╝╚╝╚═╩╝╚╩══╩╩══╝");
}

TelaDeBoasVindas();
Console.WriteLine(msgDeBoasVindas);

// =============================
// MENU PRINCIPAL
// =============================

MenuPrincipal.Menu();
MenuPrincipal.Opcoes();


class MenuPrincipal
{
    public static void Menu()
    {
        Console.WriteLine(@"
Menu Principal
1 - Listar Playlists
2 - Adicionar Playlist
3 - Remover Playlist
4 - Listar Músicas
5 - Adicionar Música
6 - Remover Música
0 - Sair
Digite a opção desejada:");
    }

    public static void Opcoes()
    {
        string opcao = Console.ReadLine()!;

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Listando Playlists...");
                    
                break;
            case "2":
                Console.WriteLine("Adicionando Playlist...");
                break;
            case "3":
                Console.WriteLine("Removendo Playlist...");
                break;
            case "4":
                Console.WriteLine("Listando Músicas...");
                break;
            case "5":
                Console.WriteLine("Adicionando Música...");
                break;
            case "6":
                Console.WriteLine("Removendo Música...");
                break;
            case "0":
                Console.WriteLine("Saindo do programa...");
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
}
