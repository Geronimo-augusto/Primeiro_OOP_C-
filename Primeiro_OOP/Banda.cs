class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    private List<Album> albuns = new List<Album>();
    public string Nome { get;}

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }
    public void ExibirAlbuns()
    {
        Console.WriteLine($"Exibindo álbuns da banda: {Nome}");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome}, Duração Total: {album.DuracaoTotal} segundos");
            album.ExibirMusicas();
            Console.WriteLine("-------------------");
        }
    }

    public void Exibir()
    {
        Console.WriteLine(Nome);
        ExibirAlbuns();
    }
} 