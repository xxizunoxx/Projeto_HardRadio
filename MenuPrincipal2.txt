// Hard Radio - Um aplicativo de console para gerenciar playlists de música.

// =============================
// MENU PRINCIPAL
// =============================

class MenuPrincipal
{
    public static List<string> Playlists = new List<string>();
    public static List<string> Musicas = new List<string>();
    public static void Menu()
        {
            while (true)
            {
                Console.Clear();

                string msgDeBoasVindas = "Bem-vindo ao Hard Radio!";
                Console.WriteLine(@"
                    ╔╗─╔╗──────╔╗╔═══╗────╔╗
                    ║║─║║──────║║║╔═╗║────║║
                    ║╚═╝╠══╦═╦═╝║║╚═╝╠══╦═╝╠╦══╗
                    ║╔═╗║╔╗║╔╣╔╗║║╔╗╔╣╔╗║╔╗╠╣╔╗║
                    ║║─║║╔╗║║║╚╝║║║║╚╣╔╗║╚╝║║╚╝║
                    ╚╝─╚╩╝╚╩╝╚══╝╚╝╚═╩╝╚╩══╩╩══╝");

                Console.WriteLine(msgDeBoasVindas);
                Console.Write(@"
                    Menu Principal
                    1 - Listar Playlists
                    2 - Adicionar Playlist
                    3 - Remover Playlist
                    4 - Listar Músicas
                    5 - Adicionar Música
                    6 - Remover Música
                    0 - Sair
                    Digite a opção desejada:");
                OpcoesMenu();
            }
        }
    public static void OpcoesMenu()
        {
            string opcao = Console.ReadLine()!;

            switch (opcao)
            {
                case "1":
                    ListarPlaylists();
                    break;
                case "2":
                    AdicionarPlaylist();
                    break;
                case "3":
                    RemovendoPlaylist();
                    break;
                case "4":
                    ListarMusicas();
                    break;
                case "5":
                    AdicionandoMusica();
                    break;
                case "6":
                    RemoverMusica();
                    break;
                case "0":
                    Sair();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }

    public static void AdicionarPlaylist()
        {
            Console.Clear();
            Console.Write("Digite o nome da nova playlist:");
            string nomePlaylist = Console.ReadLine()!;
            Playlists.Add(nomePlaylist);
            // Lógica para adicionar a playlist
            Console.WriteLine($"Playlist '{nomePlaylist}' adicionada com sucesso!");
            Console.ReadKey();
        }
    public static void ListarPlaylists()
        {
            Console.Clear();
            Console.WriteLine("Listando todas as playlists:");

            if(Playlists.Count == 0)
            {
                Console.WriteLine("Nenhuma playlist encontrada.");
                Console.ReadKey();
                return;
            }

            foreach (var playlist in Playlists)
            {
                Console.WriteLine("- " + playlist);
            }
            
            Console.ReadKey();
        }
    public static void RemovendoPlaylist()
        {
            Console.Clear();

            if (Playlists.Count == 0)
            {
                Console.WriteLine("Nenhuma playlist cadastrada para remover.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Playlists existentes:");
            foreach (var playlist in Playlists)
            {
                Console.WriteLine($"- {playlist}");
            }

            Console.Write("\nDigite o nome da playlist a ser removida: ");
            string nomePlaylist = Console.ReadLine()!;

            if (!Playlists.Contains(nomePlaylist))
            {
                Console.WriteLine("Playlist não encontrada. Tente novamente.");
                Console.ReadKey();
                return;
            }
            else
            {
                Playlists.Remove(nomePlaylist);
                Console.WriteLine($"Playlist '{nomePlaylist}' removida com sucesso!");
            }

            Console.ReadKey();
        }
    public static void ListarMusicas()
        {
            Console.Clear();
            Console.WriteLine("Listando todas as músicas:");

            if (Musicas.Count == 0)
            {
                Console.WriteLine("Nenhuma música encontrada.");
            }
            else
            {
                foreach (var item in Musicas)
                {
                    Console.WriteLine("- " + item);
                }
            }
            Console.ReadKey();
        }
    public static void AdicionandoMusica()
        {
            Console.Clear();
            Console.Write("Digite o nome da música: ");
            string musica = Console.ReadLine()!;
            Musicas.Add(musica);
            Console.WriteLine($"Música '{musica}' adicionada com sucesso!");
            Console.ReadKey();
        }
    public static void RemoverMusica()
    {
        Console.Clear();

        if (Musicas.Count == 0)
        {
            Console.WriteLine("Nenhuma música cadastrada.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Músicas existentes:");
        foreach (var item in Musicas)
        {
            Console.WriteLine("- " + item);
        }

        Console.Write("\nDigite o nome da música a remover: ");
        string nome = Console.ReadLine()!;

        if (!Musicas.Contains(nome))
        {
            Console.WriteLine("Música não encontrada.");
        }
        else
        {
            Musicas.Remove(nome);
            Console.WriteLine($"Música '{nome}' removida com sucesso!");
        }

        Console.ReadKey();
    }
    public static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por usar o Hard Radio! Até a próxima.");
            Console.ReadKey();
        }
}
// =============================