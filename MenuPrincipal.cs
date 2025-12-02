using System;
using System.Collections.Generic;
using System.Threading;

class MenuPrincipal
{
    public static List<Playlist> Playlists = new List<Playlist>();

    // ========== ESTILOS ==========

    public static void CorVerde() => Console.ForegroundColor = ConsoleColor.Green;
    public static void CorVermelha() => Console.ForegroundColor = ConsoleColor.Red;
    public static void CorAzul() => Console.ForegroundColor = ConsoleColor.Cyan;
    public static void ResetCor() => Console.ResetColor();

    public static void AnimarTexto(string texto, int velocidade = 15)
    {
        foreach (char c in texto)
        {
            Console.Write(c);
            Thread.Sleep(velocidade);
        }
        Console.WriteLine();
    }

    // ========== MENU PRINCIPAL ==========

    public static void Menu()
    {
        while (true)
        {
            Console.Clear();
            CorAzul();
            Console.WriteLine("🎧 HARD RADIO – SISTEMA DE PLAYLISTS");
            ResetCor();

            Console.WriteLine(@"
1 - Listar Playlists
2 - Criar Playlist
3 - Remover Playlist
4 - Gerenciar Músicas de uma Playlist
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
            case "1": ListarPlaylists(); break;
            case "2": CriarPlaylist(); break;
            case "3": RemoverPlaylist(); break;
            case "4": SelecionarPlaylistParaGerenciar(); break;
            case "0": Sair(); Environment.Exit(0); break;
            default:
                CorVermelha();
                Console.WriteLine("Opção inválida!");
                ResetCor();
                Thread.Sleep(1000);
                break;
        }
    }

    // ========== PLAYLISTS ==========

    public static void CriarPlaylist()
    {
        Console.Clear();
        AnimarTexto("Digite o nome da nova playlist:");
        string nome = Console.ReadLine()!;

        Playlists.Add(new Playlist(nome));

        CorVerde();
        AnimarTexto($"Playlist '{nome}' criada com sucesso!");
        ResetCor();

        Console.ReadKey();
    }

    public static void ListarPlaylists()
    {
        Console.Clear();
        AnimarTexto("Listando todas as playlists:\n");

        if (Playlists.Count == 0)
        {
            CorVermelha();
            AnimarTexto("Nenhuma playlist cadastrada.");
            ResetCor();
            Console.ReadKey();
            return;
        }

        foreach (var playlist in Playlists)
            Console.WriteLine($"- {playlist.Nome}");

        Console.ReadKey();
    }

    public static void RemoverPlaylist()
    {
        Console.Clear();
        ListarPlaylists();

        AnimarTexto("\nDigite o nome da playlist a remover:");
        string nome = Console.ReadLine()!;

        var pl = Playlists.Find(p => p.Nome == nome);

        if (pl == null)
        {
            CorVermelha();
            AnimarTexto("Playlist não encontrada.");
            ResetCor();
            Console.ReadKey();
            return;
        }

        Playlists.Remove(pl);
        CorVerde();
        AnimarTexto($"Playlist '{nome}' removida com sucesso!");
        ResetCor();

        Console.ReadKey();
    }

    // ========== GERENCIAMENTO DE MÚSICAS ==========

    public static void SelecionarPlaylistParaGerenciar()
    {
        Console.Clear();
        ListarPlaylists();

        AnimarTexto("\nDigite o nome da playlist que deseja gerenciar:");
        string nome = Console.ReadLine()!;

        var pl = Playlists.Find(p => p.Nome == nome);

        if (pl == null)
        {
            CorVermelha();
            AnimarTexto("Playlist não encontrada.");
            ResetCor();
            Console.ReadKey();
            return;
        }

        GerenciarMusicas(pl);
    }

    public static void GerenciarMusicas(Playlist playlist)
    {
        while (true)
        {
            Console.Clear();
            CorAzul();
            Console.WriteLine($"🎵 GERENCIANDO: {playlist.Nome}");
            ResetCor();

            Console.WriteLine(@"
1 - Listar Músicas
2 - Adicionar Música
3 - Remover Música
4 - Avaliar Música
0 - Voltar

Escolha a opção:");

            string opcao = Console.ReadLine()!;

            switch (opcao)
            {
                case "1": ListarMusicas(playlist); break;
                case "2": AdicionarMusica(playlist); break;
                case "3": RemoverMusica(playlist); break;
                case "4": AvaliarMusica(playlist); break;
                case "0": return;
                default:
                    CorVermelha();
                    AnimarTexto("Opção inválida!");
                    ResetCor();
                    Thread.Sleep(1000);
                    break;
            }
        }
    }

    public static void ListarMusicas(Playlist playlist)
    {
        Console.Clear();
        AnimarTexto($"Músicas da playlist '{playlist.Nome}':\n");

        if (playlist.Musicas.Count == 0)
        {
            CorVermelha();
            AnimarTexto("Nenhuma música cadastrada.");
            ResetCor();
            Console.ReadKey();
            return;
        }

        foreach (var musica in playlist.Musicas)
        {
            double media = musica.Value.Count > 0 ? musica.Value.Average() : 0;
            Console.WriteLine($"- {musica.Key} (Média: {media:F1})");
        }



        Console.ReadKey();
    }

    public static void AdicionarMusica(Playlist playlist)
    {
        Console.Clear();
        AnimarTexto("Digite o nome da música:");
        string nome = Console.ReadLine()!;

        //playlist.Musicas.Add(nome);
        playlist.Musicas.Add(nome, new List<int>());

        CorVerde();
        AnimarTexto($"Música '{nome}' adicionada!");
        ResetCor();
        Console.ReadKey();
    }

    public static void RemoverMusica(Playlist playlist)
    {
        Console.Clear();
        ListarMusicas(playlist);

        AnimarTexto("\nDigite o nome da música que deseja remover:");
        string nome = Console.ReadLine()!;

        //if (!playlist.Musicas.Contains(nome))
        if (!playlist.Musicas.ContainsKey(nome))
        {
            CorVermelha();
            AnimarTexto("Música não encontrada.");
            ResetCor();
            Console.ReadKey();
            return;
        }

        playlist.Musicas.Remove(nome);

        CorVerde();
        AnimarTexto($"Música '{nome}' removida com sucesso!");
        ResetCor();
        Console.ReadKey();
    }

    public static void AvaliarMusica(Playlist playlist)
    {
        Console.Clear();
        ListarMusicas(playlist);

        AnimarTexto("\nDigite o nome da música que deseja avaliar:");
        string nome = Console.ReadLine()!;

        //if (!playlist.Musicas.Contains(nome))
        if (!playlist.Musicas.ContainsKey(nome))
        {
            CorVermelha();
            AnimarTexto("Música não encontrada.");
            ResetCor();
            Console.ReadKey();
            return;
        }

        AnimarTexto("Digite a avaliação (1 a 5):");
        int avaliacao;
        while (!int.TryParse(Console.ReadLine()!, out avaliacao) || avaliacao < 1 || avaliacao > 5)
        {
            CorVermelha();
            AnimarTexto("Avaliação inválida. Digite um número entre 1 e 5:");
            ResetCor();
        }

        //playlist.Musicas[nome].Add(avaliacao);
        playlist.Musicas[nome].Add(avaliacao);

        CorVerde();
        AnimarTexto($"Música '{nome}' avaliada com {avaliacao} estrelas!");
        ResetCor();
        Console.ReadKey();
    }
    public static void Sair()
    {
        Console.Clear();
        AnimarTexto("Encerrando o Hard Radio...");
        Thread.Sleep(800);
    }
}
