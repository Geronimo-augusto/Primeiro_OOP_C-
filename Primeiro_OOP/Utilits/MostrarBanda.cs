
using ScreenSound.Modelos;

namespace ScreenSound.Utilits;

internal class MostrarBanda : Menu
{

    public override void ExecutarMusica(Dictionary<string, Banda> bandasRegistradas)
    {
        VerBandas(bandasRegistradas);
        base.ExecutarMusica(bandasRegistradas);
    }

    public static void VerBandas(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Exibir Bandas:\n 1- Ver todas\n 2- Ver especifica");
        int opcao = int.Parse(Console.ReadLine());
        if (opcao == 1)
        {
            Console.WriteLine("Exibindo todas as Bandas...");
            foreach (var banda in bandasRegistradas.Values)
            {
                banda.Exibir();
            }
        }
        else if (opcao == 2)
        {
            Console.Write("Digite o nome da Banda que deseja ver: ");
            string nomeBanda = Console.ReadLine();
            
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                bandasRegistradas[nomeBanda].Exibir();
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

}
