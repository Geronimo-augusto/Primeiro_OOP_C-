namespace ScreenSound.Modelos;

internal class Podcast
{
    public string Nome { get; }
    public string Host { get; }
    private List<Episodio> totalEpisodios = new List<Episodio>();

    public void AdicionarEpisodio(Episodio episodio)
    {
        totalEpisodios.Add(episodio);
    }
    public Podcast(string title, string host)
    {
        Nome = title;
        Host = host;
    }
    public Podcast(string title, string host, List<Episodio> episodios)
    {
        Nome = title;
        Host = host;
        totalEpisodios = episodios;
    }
    public void ExibirEps() 
    {
        foreach(Episodio ep in totalEpisodios)
        {
            ep.Exibir();
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Podcast: {Nome}, Host: {Host}, Episodes:");
        ExibirEps();
    }

}