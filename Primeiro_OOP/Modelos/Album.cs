namespace ScreenSound.Modelos;

internal class Album : IAvaliacao
{

    public Album(string nome)
    {
        Nome = nome;
    }


    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> avaliacaos = new List<Avaliacao>();

    public string Nome { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public double Media
    {
        get
        {
            if (avaliacaos.Count == 0) return 0;
            else return avaliacaos.Average(a => a.Nota);
        }

    }

    public void AdicionarAvaliacao(Avaliacao avaliacao)
    {
        avaliacaos.Add(avaliacao);
    }

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