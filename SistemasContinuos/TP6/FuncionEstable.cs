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
            throw new System.NotImplementedException();
        }

        public decimal CalcularDerivadaSegunda(decimal y, decimal yPrima)
        {
            throw new System.NotImplementedException();
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
