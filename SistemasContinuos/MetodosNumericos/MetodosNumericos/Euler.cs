using System;

namespace MetodosNumericos.MetodosNumericos
{
    public class Euler : IMetodoNumerico
    {
        private readonly decimal _h;
        private readonly IFuncion _funcion;
        private decimal _y;
        private decimal _yPrima;
        private decimal _ySegunda;

        public Euler(decimal h, IFuncion funcion, decimal y0)
        {
            if (h <= 0)
                throw new NotSupportedException("El valor de h debe ser positivo");

            if (funcion == null)
                throw new NotSupportedException("La función es requerida");

            if (funcion.Orden() != 1)
                throw new NotSupportedException("La función debe ser de primer orden");

            _h = h;
            _funcion = funcion;
            _y = y0;
            _yPrima = CalcularDerivada();
        }

        public Euler(decimal h, IFuncion funcion, decimal y0, decimal yPrima0)
        {
            if (h <= 0)
                throw new NotSupportedException("El valor de h debe ser positivo");

            if (funcion == null)
                throw new NotSupportedException("La función es requerida");

            if (funcion.Orden() != 2)
                throw new NotSupportedException("La función debe ser de segundo orden");

            _h = h;
            _funcion = funcion;
            _y = y0;
            _yPrima = yPrima0;
            _ySegunda = CalcularDerivadaSegunda();
        }

        public void CalcularSiguiente()
        {
            if (_funcion.Orden() == 1)
            {
                _y += _h * _yPrima;
                _yPrima = CalcularDerivada();
            }
            else
            {
                _y += _h * _yPrima;
                _yPrima += _h * _ySegunda;
                _ySegunda = CalcularDerivadaSegunda();
            }
        }

        private decimal CalcularDerivada()
        {
            return _funcion.CalcularDerivada(_y);
        }

        private decimal CalcularDerivadaSegunda()
        {
            return _funcion.CalcularDerivadaSegunda(_y, _yPrima);
        }

        public decimal Y()
        {
            return _y;
        }

        public decimal Yprima()
        {
            return _yPrima;
        }

        public decimal Ysegunda()
        {
            return _ySegunda;
        }
    }
}
