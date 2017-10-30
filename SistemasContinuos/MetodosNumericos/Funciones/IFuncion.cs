namespace MetodosNumericos.Funciones
{
    public interface IFuncion
    {
        int Orden();
        decimal CalcularDerivada(decimal y);
        decimal CalcularDerivadaSegunda(decimal y, decimal yPrima);
    }
}
