List<Banda> bandas = new List<Banda>();
List<Album> albuns = new List<Album>();
List<Musica> musicas = new List<Musica>();
List<Podcast> podcasts = new List<Podcast>();
List<Episodio> episodios = new List<Episodio>();



void AdicionarBanda()
{
    Console.Clear();
    Console.WriteLine("Adicionando Banda");
    Console.Write("Digite o nome da banda a ser Adicionada: ");
    bandas.Add(new Banda(Console.ReadLine()));
    Console.WriteLine("Banda Adicionada com sucesso!");
    Console.WriteLine("Aperte enter pra continuar");
    Console.ReadLine();
    Console.Clear();
    return;
}

void AdicionarAlbum()
{
    Console.Clear();
    Console.WriteLine("Adicionando Album");
    Console.Write("Digite o nome da Album a ser Adicionada: ");
    albuns.Add(new Album(Console.ReadLine()));
    Console.WriteLine("Album Adicionada com sucesso!");
    Console.WriteLine("Aperte enter pra continuar");
    Console.ReadLine();
    Console.Clear();
    return;
} 

void ConfigMusica()
{
    Console.WriteLine("Digite o nome do album:");
    string nomeAlbum = Console.ReadLine();
    Album albumEncontrado = albuns.Find(a => a.Nome.Equals(nomeAlbum, StringComparison.OrdinalIgnoreCase));
    if (albumEncontrado != null)
    {
        Console.WriteLine("Digite a banda dessa musica");
        string banda = Console.ReadLine();
        Banda bandaEncontrada = bandas.Find(b => b.Nome.Equals(banda, StringComparison.OrdinalIgnoreCase));
        if (bandaEncontrada != null)
        {
            Console.Write("Digite o nome da Musica a ser Adicionada: ");
            string nomeMusica = Console.ReadLine();
            Musica novaMusica = new Musica(bandaEncontrada,nomeMusica);
            albumEncontrado.AdicionarMusica(novaMusica);
            musicas.Add(novaMusica);
            Console.WriteLine("Musica Adicionada ao album com sucesso!");
        }
        else
        {
            Console.WriteLine("Banda não encontrada. Crie ela primeiro");
            AdicionarBanda();
        }
    }
    else
    {
        Console.WriteLine("Album não encontrado. Crie ele primeiro");
        Console.ReadKey();
        AdicionarAlbum();
        
    }
}


void AdicionarMusica()
{
    Console.Clear();
    Console.WriteLine("Adicionando Musica");
    Console.WriteLine(@"Ela pertence a algum album?
                        S/N");
    string resposta = Console.ReadLine().ToUpper();
    if(resposta == "S")
    {
        ConfigMusica();
    }
    else
    {
        Console.WriteLine("Digite a banda dessa musica");
        string banda = Console.ReadLine();
        Banda bandaEncontrada = bandas.Find(b => b.Nome.Equals(banda, StringComparison.OrdinalIgnoreCase));
        if (bandaEncontrada != null)
        {
            Console.Write("Digite o nome da Musica a ser Adicionada: ");
            string nomeMusica = Console.ReadLine();
            Musica novaMusica = new Musica(bandaEncontrada, nomeMusica);
            Console.WriteLine("Musica Adicionada com sucesso!");
        }
        else
        {             
            Console.WriteLine("Banda não encontrada. Crie ela primeiro");
            Console.ReadKey();
            AdicionarBanda();
        }

    }
    Console.WriteLine("Aperte enter pra continuar");
    Console.ReadLine();
    Console.Clear();
    return;
} 

void AdicionarPodcast()
{
    Console.Clear();
    Console.WriteLine("Adicionando Podcast");
    Console.Write("Digite o nome do Podcast a ser Adicionado: ");
    string nome = Console.ReadLine();
    Console.Write("Digite o Host do Podcast a ser Adicionado: ");
    string host = Console.ReadLine();
    if (episodios.Count() != 0)
    {
        Console.WriteLine(@"Adicionar os Episodios em memoria?
                            S/N");
        string resposta = Console.ReadLine().ToUpper();
        if (resposta == "S")
        {
            Console.WriteLine("Finalizado Podcast...");
            podcasts.Add(new Podcast(nome, host, episodios));
        }
        else
        {
            Console.WriteLine("Finalizado Podcast...");
            podcasts.Add(new Podcast(nome, host));
        }
    }
    else 
    {
        Console.WriteLine("Nenhum episodio encontrado.");
        Console.WriteLine("Adicionar novos Episodios?\nS/N");
        string resposta = Console.ReadLine().ToUpper();
        if (resposta == "S")
        {
            AdcionarEpisodio();
            Console.WriteLine("Finalizado Podcast...");
            podcasts.Add(new Podcast(nome, host, episodios));
        }
        else
        {
            Console.WriteLine("Finalizado Podcast...");
            podcasts.Add(new Podcast(nome, host));
        }
    }


    Console.WriteLine("Podcast Adicionada com sucesso!");
    Console.WriteLine("Aperte enter pra continuar");
    Console.ReadLine();
    Console.Clear();
    return;
}   

void AdcionarEpisodio()
{
    Console.Clear();
    Console.WriteLine("Adicionando Episodio");
    Console.Write("Digite o nome do Episodio a ser Adicionado: ");
    string nome = Console.ReadLine();
    Console.Write("Digite a duraçao do Episodio a ser Adicionado: ");
    int duracao = int.Parse(Console.ReadLine());
    Console.Write("Digite a ordem desse Episodio a ser Adicionado: ");
    int ordem = int.Parse(Console.ReadLine());
    Console.Write("Digite o resumo Episodio a ser Adicionado: ");
    string resumo = Console.ReadLine();
    episodios.Add(new Episodio(nome, duracao, ordem, resumo));
    Console.WriteLine("Episodio Adicionada com sucesso!");
    Console.WriteLine("Aperte enter pra continuar");
    Console.ReadLine();
    Console.Clear();
    return;
}
void VerBandas()
{
    Console.WriteLine("Exibir Bandas:\n 1- Ver todasn\n 2- Ver especifica");
    int opcao = int.Parse(Console.ReadLine());
    if (opcao == 1)
    {
        Console.WriteLine("Exibindo todas as Bandas...");
        foreach (var banda in bandas)
        {
            banda.Exibir();
        }
    }
    else if (opcao == 2)
    {
        Console.Write("Digite o nome da Banda que deseja ver: ");
        string nomeBanda = Console.ReadLine();
        var bandaEncontrada = bandas.Find(b => b.Nome.Equals(nomeBanda, StringComparison.OrdinalIgnoreCase));
        if (bandaEncontrada != null)
        {
            bandaEncontrada.Exibir();
        }
        else
        {
            Console.WriteLine("Banda não encontrada.");
        }
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }

}   
void VerPodcasts()
{
    Console.WriteLine("Exibir Podcasts:\n 1- Ver todos\n 2- Ver especifico");
    int opcao = int.Parse(Console.ReadLine());
    if (opcao == 1)
    {
        Console.WriteLine("Exibindo todas as Podcasts...");
        foreach (var podcast in podcasts)
        {
            podcast.DisplayInfo();
        }
    }
    else if (opcao == 2)
    {
        Console.Write("Digite o nome da podcast que deseja ver: ");
        string nomepodcast = Console.ReadLine();
        var podcastEncontrada = podcasts.Find(b => b.Nome.Equals(nomepodcast, StringComparison.OrdinalIgnoreCase));
        if (podcastEncontrada != null)
        {
            podcastEncontrada.DisplayInfo();
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
    Console.ReadKey();
    Console.Clear();
}

bool rodando = true;
while (rodando)
{
    Console.WriteLine("Super sound muito foda, bem vindo!!!!!!!!!!!");
    Console.WriteLine(@"Escolha uma das Opçoes abaixo:
                        1- Adicionar Banda
                        2- Adicionar ALbum
                        3- Adicionar Musica
                        4- Adicionar Podcast
                        5- Ver Bandas
                        6- Ver Podcasts
                        -1 Sair");
    Console.Write("Escolha a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao) 
    {
        case -1: rodando = false; 
            break;
        case 1: AdicionarBanda();
            break;
        case 2: AdicionarAlbum();
            break;
        case 3: AdicionarMusica();
            break;
        case 4: AdicionarPodcast();
            break;
        case 5: VerBandas();
            break;
        case 6: VerPodcasts();
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}