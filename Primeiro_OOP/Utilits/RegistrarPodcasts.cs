
using ScreenSound.Modelos;
using System.Collections.Generic;

namespace ScreenSound.Utilits;

internal class RegistrarPodcasts : Menu
{

    public override void ExecutarPodcast(Dictionary<string, Podcast> podcastsRegistrados)
    {
        AdicionarPodcast(podcastsRegistrados);
        base.ExecutarPodcast(podcastsRegistrados);
    }

    public void AdicionarPodcast(Dictionary<string, Podcast> podcastsRegistrados)
    {
        Console.Clear();
        Console.WriteLine("Adicionando Podcast");
        Console.Write("Digite o nome do Podcast a ser Adicionado: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o Host do Podcast a ser Adicionado: ");
        string host = Console.ReadLine();
        Console.WriteLine("Finalizado Podcast...");
        podcastsRegistrados.Add(nome ,new Podcast(nome, host));
    }
}
