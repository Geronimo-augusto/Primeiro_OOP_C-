
using ScreenSound.Modelos;

namespace ScreenSound.Utilits;

internal class Menu
{
    public virtual void ExecutarMusica(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Operaçao concluida com sucesso!");
        Console.WriteLine("Aperte enter pra continuar");
        Console.ReadLine();
        Console.Clear();
    }
    public virtual void ExecutarPodcast(Dictionary<string, Podcast> podcastsRegistrados)
    {
        Console.WriteLine("Operaçao concluida com sucesso!");
        Console.WriteLine("Aperte enter pra continuar");
        Console.ReadLine();
        Console.Clear();
    }
}
