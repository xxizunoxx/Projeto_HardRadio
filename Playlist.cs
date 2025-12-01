public class Playlist
{
    public string Nome { get; set; }
    public List<string> Musicas { get; set; } = new List<string>();

    public Playlist(string nome)
    {
        Nome = nome;
    }
}
