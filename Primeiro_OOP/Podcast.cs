class Podcast
{
    public string Nome { get; set; }
    public string Host { get; set; }
    public List<Episodio> TotalEpisodios { get; set; }
    public Podcast(string title, string host)
    {
        Nome = title;
        Host = host;
    }
    public Podcast(string title, string host, List<Episodio> episodios)
    {
        Nome = title;
        Host = host;
        TotalEpisodios = episodios;
    }
    public void ExibirEps() 
    {
        foreach(Episodio ep in TotalEpisodios)
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