using ScreenSound.Modelos;
using ScreenSound.Utilits;

namespace ScreenSound.Utilits;

internal class RegistrarMusicas : Menu
{

    public override void ExecutarMusica(Dictionary<string, Banda> bandasRegistradas)
    {
        AdicionarMusica(bandasRegistradas);
        base.ExecutarMusica(bandasRegistradas);
    }
    public void AdicionarMusica(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        Console.WriteLine("Adicionando Musica");
        Console.WriteLine("Digite a banda dessa musica");
        string bandaNome = Console.ReadLine();

        if (bandasRegistradas.ContainsKey(bandaNome))
        {
            

            Console.WriteLine("Ela pertence a algum album?\nS/N");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                AdicionarMusicaComAlbum(bandasRegistradas, bandaNome);
            }
            else
            {
                Console.Write("Digite o nome da Musica a ser Adicionada: ");
                string nomeMusica = Console.ReadLine();

                Banda banda = bandasRegistradas[bandaNome];
                banda.AdicionarMusicaSolo(new Musica(banda, nomeMusica));
            }
        }
        else
        {
            Console.WriteLine("Banda não encontrada. Crie ela primeiro");
            Console.ReadKey();
            new RegistrarBandas().AdicionarBanda(bandasRegistradas);
        }
    }
    public void AdicionarMusicaComAlbum(Dictionary<string, Banda> bandasRegistradas, string nomeBanda)
    {
        Banda banda = bandasRegistradas[nomeBanda];
        Console.WriteLine("Digite o nome do album:");
        RegistrarAlbuns RAlbum = new RegistrarAlbuns();
        Album albumEncontrado = RAlbum.EncontrarAlbum(banda.Albums, Console.ReadLine());
        if (albumEncontrado != null)
        {
            Console.Write("Digite o nome da Musica a ser Adicionada: ");
            string nomeMusica = Console.ReadLine();
            albumEncontrado.AdicionarMusica(new Musica(banda, nomeMusica));
            banda.AdicionarAlbum(albumEncontrado);
        }
        else
        {
            Console.WriteLine("Album não encontrado. Crie ele primeiro");
            Console.ReadKey();
            RAlbum.AdicionarAlbum(bandasRegistradas);

        }
    }
}
