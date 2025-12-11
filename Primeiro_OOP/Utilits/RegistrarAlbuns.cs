using ScreenSound.Modelos;

namespace ScreenSound.Utilits;

internal class RegistrarAlbuns : Menu
{

    public override void ExecutarMusica(Dictionary<string, Banda> bandasRegistradas)
    {
        AdicionarAlbum(bandasRegistradas);
        base.ExecutarMusica(bandasRegistradas);
    }
    public Album EncontrarAlbum(List<Album> albuns, string nomeAlbum)
    {
       return albuns.Find(a => a.Nome.Equals(nomeAlbum, StringComparison.OrdinalIgnoreCase));
    }

    public void AdicionarAlbum(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        Console.WriteLine("Adicionando Album");
        Console.Write("Mas primeiro digite de qual banda ele pertence: ");
        string bandaNome  = Console.ReadLine();
        if (bandasRegistradas.ContainsKey(bandaNome))
        {
            Console.Write("Digite o nome da Album a ser Adicionada: ");
            bandasRegistradas[bandaNome].AdicionarAlbum(new Album(Console.ReadLine()));
        }
        else
        {
            Console.WriteLine("Ainda nao tem essa banda resgistrada, registre-a primeiro");
            Console.ReadKey();
            new RegistrarBandas().AdicionarBanda(bandasRegistradas);
        }
    }
}
