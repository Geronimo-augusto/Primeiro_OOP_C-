using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenSound.Utilits;

internal class AvaliarAlbum : Menu
{

    public override void ExecutarMusica(Dictionary<string, Banda> bandasRegistradas)
    {
        AvaliaBanda(bandasRegistradas);
        base.ExecutarMusica(bandasRegistradas);
    }
    public void AvaliaBanda(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Write("Digite a banda que quer avaliar: ");
        string bandaNome = Console.ReadLine();

        if (bandasRegistradas.ContainsKey(bandaNome))
        {
            Banda banda = bandasRegistradas[bandaNome];
            Console.WriteLine("Digite o nome do album: ");

            Album albumEncontrado = new RegistrarAlbuns().EncontrarAlbum(banda.Albums, Console.ReadLine());
            if(albumEncontrado != null)
            {
                Console.Write("Digite sua nota para esse album: ");
                albumEncontrado.AdicionarAvaliacao(Avaliacao.Parse(Console.ReadLine()!));
            }
            else
            {
                Console.WriteLine("Album nao encontrada. Crie-o primeiro");
                Console.ReadKey();
                new RegistrarAlbuns().AdicionarAlbum(bandasRegistradas);
            }
        }
        else
        {
            Console.WriteLine("Banda não encontrada. crie uma primeiro: ");
            Console.ReadKey();
            new RegistrarBandas().AdicionarBanda(bandasRegistradas);
        }
    }
}
