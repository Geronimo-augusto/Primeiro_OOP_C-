using ScreenSound.Modelos;

namespace ScreenSound.Utilits;

internal class ExibirPodcast : Menu
{

    public override void ExecutarPodcast(Dictionary<string, Podcast> podcastsRegistrados)
    {
        VerPodcasts(podcastsRegistrados);
        base.ExecutarPodcast(podcastsRegistrados);
    }
    public void VerPodcasts(Dictionary<string, Podcast> podcastsRegistrados)
    {
        Console.WriteLine("Exibir Podcasts:\n 1- Ver todos\n 2- Ver especifico");
        int opcao = int.Parse(Console.ReadLine());
        if (opcao == 1)
        {
            Console.WriteLine("Exibindo todas as Podcasts...");
            foreach (var podcast in podcastsRegistrados.Values)
            {
                podcast.DisplayInfo();
            }
        }
        else if (opcao == 2)
        {
            Console.Write("Digite o nome da podcast que deseja ver: ");
            string nomepodcast = Console.ReadLine();
            if (podcastsRegistrados.ContainsKey(nomepodcast))
            {
                podcastsRegistrados[nomepodcast].DisplayInfo();
            }
            else
            {
                Console.WriteLine("podcast não encontrada.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("Opção inválida.");
            Console.ReadKey();
        }
    }
}

