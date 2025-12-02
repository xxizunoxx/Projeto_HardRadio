public class Playlist
{
    public string Nome { get; set; }
    //public Dictionary<string List<int>> Musicas { get; set; } = new List<string>();
    public Dictionary<string, List<int>> Musicas { get; set; } = new Dictionary<string, List<int>>();

    public Playlist(string nome)
    {
        Nome = nome;
    }
}
