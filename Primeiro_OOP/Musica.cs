class Musica
{

    public Musica(Banda artista, string nome)
    {
        this.Artista = artista;
        Nome = nome;
    }

    public string Nome { get;}
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string Descricao => $"{Nome} - {Artista}";  // usando lambda pra fazera atribuiçao de valor
    //{ 
    //get 
    //{
    //    return $"{Nome} - {artista}";
    //  }
    //}

    public void ExibirFIcha()
    {
        Console.WriteLine($"nome:{Nome}");
        Console.WriteLine($"Artista:{Artista.Nome}");
        Console.WriteLine($"Duração:{Duracao}");
        string d = Disponivel ? "Dispoinel no plano" : "Não disponivel no plano, assine o PLUS";
        Console.WriteLine(d);
    }


}

