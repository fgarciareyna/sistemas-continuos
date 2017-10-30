using System;

namespace MetodosNumericos.Funciones
{
    public class FuncionTp6 : IFuncion
    {
        private readonly decimal _c;

        public FuncionTp6(decimal c)
        {
            _c = c;
        }

        public int Orden()
        {
            return 2;
        }

        public decimal CalcularDerivada(decimal y)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularDerivadaSegunda(decimal y, decimal yPrima)
        {
            return -2 * (decimal)Math.Sin((double)y) - Math.Sign(_c * y + yPrima);
        }
    }
}
