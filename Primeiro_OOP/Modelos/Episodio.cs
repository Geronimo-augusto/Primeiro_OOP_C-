namespace ScreenSound.Modelos;

internal class Episodio
{
    public string Titulo { get;   }
    public int Duracao { get;   } // Duração em minutos
    public int Ordem { get;   }
    public string Resumo { get;   }

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