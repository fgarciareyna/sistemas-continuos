using System;
using MetodosNumericos.Funciones;

namespace MetodosNumericos.MetodosNumericos
{
    public class RungeKutta : IMetodoNumerico
    {
        private readonly decimal _h;
        private readonly IFuncion _funcion;

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
            Y = y0;
            Yprima = CalcularDerivada();
        }

        public RungeKutta(decimal h, IFuncion funcion, decimal y0, decimal yPrima0)
        {
            if (h <= 0)
                throw new NotSupportedException("El valor de h debe ser positivo");

            if (funcion == null)
                throw new NotSupportedException("La función es requerida");

            if (funcion.Orden() != 1)
                throw new NotSupportedException("La función debe ser de segundo orden");

            _h = h;
            _funcion = funcion;
            Y = y0;
            Yprima = yPrima0;
            Ysegunda = CalcularDerivadaSegunda();
        }

        public void CalcularSiguiente()
        {
            if (_funcion.Orden() == 1)
            {
                Y += _h * Yprima;
                Yprima = CalcularDerivada();
            }
            else
            {
                Y += _h * Yprima;
                Yprima += _h * Ysegunda;
                Ysegunda = CalcularDerivadaSegunda();
            }
        }

        private decimal CalcularDerivada()
        {
            var k1 = _funcion.CalcularDerivada(Y);
            var k2 = _funcion.CalcularDerivada(Y + _h / 2 * k1);
            var k3 = _funcion.CalcularDerivada(Y + _h / 2 * k2);
            var k4 = _funcion.CalcularDerivada(Y + _h * k3);

            return (k1 + 2 * k2 + 2 * k3 + k4) / 6;
        }

        private decimal CalcularDerivadaSegunda()
        {
            var k1 = _funcion.CalcularDerivadaSegunda(Y, Yprima);

            var yPrima1 = Yprima + _h /2 * k1;
            var y1 = Y + _h / 2* yPrima1;
            var k2 = _funcion.CalcularDerivadaSegunda(y1, yPrima1);

            var yPrima2 = Yprima + _h / 2 * k2;
            var y2 = Y + _h / 2 * yPrima2;
            var k3 = _funcion.CalcularDerivadaSegunda(y2, yPrima2);

            var yPrima3 = Yprima + _h * k3;
            var y3 = Y + _h * yPrima3;
            var k4 = _funcion.CalcularDerivadaSegunda(y3, yPrima3);

            return (k1 + 2 * k2 + 2 * k3 + k4) / 6;
        }

        public decimal Y { get; protected set; }
        public decimal Yprima { get; protected set; }
        public decimal Ysegunda { get; protected set; }
    }
}
