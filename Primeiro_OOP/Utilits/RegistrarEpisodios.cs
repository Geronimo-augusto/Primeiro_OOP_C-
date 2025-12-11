using ScreenSound.Modelos;
namespace ScreenSound.Utilits;

internal class RegistrarEpisodios : Menu
{

    public override void ExecutarPodcast(Dictionary<string, Podcast> podcastsRegistrados)
    {
        AdcionarEpisodio(podcastsRegistrados);
        base.ExecutarPodcast(podcastsRegistrados);
    }

    public void AdcionarEpisodio(Dictionary<string, Podcast> podcastsRegistrados)
    {
        Console.Clear();
        Console.WriteLine("Adicionando Episodio");
        Console.Write("Mas primeiro informe o Podcast: ");
        string podcastNome = Console.ReadLine();

        if (podcastsRegistrados.ContainsKey(podcastNome))
        {
            Console.Write("Digite o nome do Episodio a ser Adicionado: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a duraçao do Episodio a ser Adicionado: ");
            int duracao = int.Parse(Console.ReadLine());
            Console.Write("Digite a ordem desse Episodio a ser Adicionado: ");
            int ordem = int.Parse(Console.ReadLine());
            Console.Write("Digite o resumo Episodio a ser Adicionado: ");
            string resumo = Console.ReadLine();

            podcastsRegistrados[podcastNome].AdicionarEpisodio(new Episodio(nome, duracao, ordem, resumo));
        }
        else 
        {
            Console.WriteLine("Podcast ainda nao registrado, registre-o primeiro");
            Console.ReadKey();
            new RegistrarPodcasts().AdicionarPodcast(podcastsRegistrados);
        }


    }
}
