using OpenAI;
using OpenAI.Chat;
using ScreenSound.Modelos;
using ScreenSound.Utilits;
using System.ClientModel;
Dictionary<string, Banda> bandasRegistradas = new();
Dictionary<string, Podcast> podcastsRegistrados = new();




Dictionary<string, Menu> opcoes = new();
opcoes.Add("1", new RegistrarBandas());
opcoes.Add("2", new RegistrarAlbuns());
opcoes.Add("3", new RegistrarMusicas());
opcoes.Add("4", new RegistrarPodcasts());
opcoes.Add("5", new RegistrarEpisodios());
opcoes.Add("6", new AvaliarBanda());
opcoes.Add("7", new AvaliarAlbum());
opcoes.Add("8", new MostrarBanda());
opcoes.Add("9", new ExibirPodcast());
opcoes.Add("-1", new Menu());

bool rodando = true;
while (rodando)
{
    Console.WriteLine("Super sound muito foda, bem vindo!!!!!!!!!!!");
    Console.WriteLine(@"Escolha uma das Opçoes abaixo:
                        1- Adicionar Banda
                        2- Adicionar Album
                        3- Adicionar Musica
                        4- Adicionar Podcast
                        5- Adicionar Epsodio
                        6- Avaliar Banda
                        7- Avaliar Album
                        8- Ver Bandas
                        9- Ver Podcasts
                        -1 Sair");
    Console.Write("Escolha a opção desejada: ");
    string opcao = Console.ReadLine()!;

    if (opcoes.ContainsKey(opcao))
    {
        rodando = opcao == "-1" ? false : true;
        if (new List<string>() { "4", "5", "9" }.Contains(opcao))
        {
            opcoes[opcao].ExecutarPodcast(podcastsRegistrados);
        }
        opcoes[opcao].ExecutarMusica(bandasRegistradas);
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Opção inválida");
    }
}