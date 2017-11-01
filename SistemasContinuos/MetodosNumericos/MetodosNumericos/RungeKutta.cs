using System;

namespace MetodosNumericos.MetodosNumericos
{
    public class RungeKutta : IMetodoNumerico
    {
        private readonly decimal _h;
        private readonly IFuncion _funcion;
        private decimal _y;
        private decimal _yPrima;
        private decimal _ySegunda;

        public RungeKutta(decimal h, IFuncion funcion, decimal y0)
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

        public RungeKutta(decimal h, IFuncion funcion, decimal y0, decimal yPrima0)
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
            var k1 = _funcion.CalcularDerivada(_y);
            var k2 = _funcion.CalcularDerivada(_y + _h / 2 * k1);
            var k3 = _funcion.CalcularDerivada(_y + _h / 2 * k2);
            var k4 = _funcion.CalcularDerivada(_y + _h * k3);

            return (k1 + 2 * k2 + 2 * k3 + k4) / 6;
        }

        private decimal CalcularDerivadaSegunda()
        {
            var k1 = _funcion.CalcularDerivadaSegunda(_y, _yPrima);

            var yPrima1 = _yPrima + _h /2 * k1;
            var y1 = _y + _h / 2* yPrima1;
            var k2 = _funcion.CalcularDerivadaSegunda(y1, yPrima1);

            var yPrima2 = _yPrima + _h / 2 * k2;
            var y2 = _y + _h / 2 * yPrima2;
            var k3 = _funcion.CalcularDerivadaSegunda(y2, yPrima2);

            var yPrima3 = _yPrima + _h * k3;
            var y3 = _y + _h * yPrima3;
            var k4 = _funcion.CalcularDerivadaSegunda(y3, yPrima3);

            return (k1 + 2 * k2 + 2 * k3 + k4) / 6;
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
