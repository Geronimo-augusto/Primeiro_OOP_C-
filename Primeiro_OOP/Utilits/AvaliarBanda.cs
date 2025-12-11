
using ScreenSound.Modelos;

namespace ScreenSound.Utilits;

internal class AvaliarBanda : Menu
{

    public override void ExecutarMusica(Dictionary<string, Banda> bandasRegistradas)
    {
        AvaliaBanda(bandasRegistradas);
        base.ExecutarMusica(bandasRegistradas);
    }
    public void AvaliaBanda(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Write("Digite a banda que quer avaliar: ");
        string banda = Console.ReadLine();
        
        if (bandasRegistradas.ContainsKey(banda))
        {
            Console.WriteLine($"Qual a sa nota para a banda: {bandasRegistradas[banda].Nome}");
            bandasRegistradas[banda].AdicionarAvaliacao(Avaliacao.Parse(Console.ReadLine()!));
        }
        else
        {
            Console.WriteLine("Banda não encontrada. crie uma primeiro: ");
            Console.ReadKey();
            new RegistrarBandas().AdicionarBanda(bandasRegistradas);
        }
    }

}
