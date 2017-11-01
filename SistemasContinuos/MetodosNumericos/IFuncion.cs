namespace MetodosNumericos
{
    public interface IFuncion
    {
        int Orden();
        decimal CalcularDerivada(decimal y);
        decimal CalcularDerivadaSegunda(decimal y, decimal yPrima);
        bool Estable();
        bool Estable(decimal y);
        bool Estable(decimal y, decimal yPrima);
    }
}
