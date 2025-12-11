namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota) 
    {
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(string s)
    {
        try
        {
            int nota = int.Parse(s);
            return new Avaliacao(nota);
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor invalido");
            return null;
        }
    }
}
