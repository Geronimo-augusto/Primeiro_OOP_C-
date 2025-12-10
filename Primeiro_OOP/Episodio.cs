class Episodio
{
    public string Titulo { get; set; }
    public int Duracao { get; set; } // Duração em minutos
    public int Ordem { get; set; }
    public string Resumo { get; set; }

    public void Exibir()
    {
        Console.WriteLine(@$"Titulo: {Titulo}
                             Duracao: {Duracao}
                             Ordem: {Ordem}
                             Resumo: {Resumo}");
    }
    public Episodio(string titulo, int duracao, int ordem, string resumo)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
        Resumo = resumo;
    }
}