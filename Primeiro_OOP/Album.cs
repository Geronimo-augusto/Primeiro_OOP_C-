class Album
{

    public Album(string nome)
    {
        Nome = nome;
    }


    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; }


    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Exibindo musicas dos Album:");
        foreach(var musica in musicas)
        {
            musica.ExibirFIcha();
            Console.WriteLine("-------------------");
        }
    }
}