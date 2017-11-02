using MetodosNumericos;

namespace TP6
{
    public class FuncionEstable : IFuncion
    {
        public int Orden()
        {
            return 2;
        }

        public decimal CalcularDerivada(decimal y)
        {
            return 0;
        }

        public decimal CalcularDerivadaSegunda(decimal y, decimal yPrima)
        {
            return 0;
        }

        public bool Estable(decimal y, decimal yPrima)
        {
            return true;
        }

        public bool Estable()
        {
            return true;
        }

        public bool Estable(decimal y)
        {
            return true;
        }
    }
}
