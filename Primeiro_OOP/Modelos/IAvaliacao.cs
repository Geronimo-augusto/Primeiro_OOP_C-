namespace ScreenSound.Modelos;

internal interface IAvaliacao
{
    double Media { get; }
    void AdicionarAvaliacao(Avaliacao avaliacao);
}
