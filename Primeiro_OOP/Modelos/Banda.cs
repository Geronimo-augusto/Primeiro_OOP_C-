namespace ScreenSound.Modelos;


internal class Banda : IAvaliacao
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    private List<Album> albuns = new List<Album>();
    private List<Musica> musicasSolo = new List<Musica>();
    private List<Avaliacao> avaliacaos = new List<Avaliacao>();
    public double Media
    {
        get
        {
            if (avaliacaos.Count == 0) return 0;
            else return avaliacaos.Average(a => a.Nota);
        }
           
    }
    public string Nome { get;}
    public List<Album> Albums => albuns;

    public string? Resumo { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void AdicionarMusicaSolo(Musica musica)
    {
        musicasSolo.Add(musica);
    }

    public void AdicionarAvaliacao(Avaliacao avaliacao)
    {
        avaliacaos.Add(avaliacao);
    }
    public void ExibirAlbuns()
    {
        
        foreach (var album in albuns)
        {
            Console.WriteLine(@$"
                                Álbum: {album.Nome}
                                Duração Total: {album.DuracaoTotal} segundos
                                Media do Album: {album.Media}");
            album.ExibirMusicas();
            Console.WriteLine("-------------------");
        }
    }
    
    public void Exibir()
    {
        Console.WriteLine(Nome);
        Console.WriteLine($"Nota: {Media}");
        Console.WriteLine($"Resumo: {Resumo}");
        Console.WriteLine("Albuns: ");
        ExibirAlbuns();
    }
} 