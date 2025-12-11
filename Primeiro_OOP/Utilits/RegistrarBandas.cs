using ScreenSound.Modelos;

namespace ScreenSound.Utilits;

internal class RegistrarBandas : Menu
{

    public override void ExecutarMusica(Dictionary<string, Banda> bandasRegistradas)
    {
        AdicionarBanda(bandasRegistradas);
        base.ExecutarMusica(bandasRegistradas);
    }

    public void AdicionarBanda(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        Console.WriteLine("Adicionando Banda");
        Console.Write("Digite o nome da banda a ser Adicionada: ");
        string nomeBanda = Console.ReadLine()!;
        Console.WriteLine("registrando....");
        bandasRegistradas.Add(nomeBanda,new Banda(nomeBanda));      
        bandasRegistradas[nomeBanda].Resumo = OpenRouterAPI.ChamarAsync($"Resumo da banda {nomeBanda} em português, 3 linhas, objetivo e sem introduções.").GetAwaiter().GetResult();
        

    }
}
