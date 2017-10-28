using System;

namespace MetodosNumericos.MetodosNumericos
{
    public class RoungeKutta : IMetodoNumerico
    {
        private readonly decimal _h;

        public RoungeKutta(decimal h)
        {
            if (h <= 0)
                throw new NotSupportedException("El valor de h debe ser positivo");

            _h = h;
        }
        public void CalcularSiguiente()
        {
            throw new NotImplementedException();
        }
    }
}
