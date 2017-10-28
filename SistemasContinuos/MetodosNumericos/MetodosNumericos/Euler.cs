using System;
using MetodosNumericos.Funciones;

namespace MetodosNumericos.MetodosNumericos
{
    public class Euler : IMetodoNumerico
    {
        private readonly decimal _h;
        private readonly IFuncion _funcion;

        public Euler(decimal h, IFuncion funcion, decimal y0)
        {
            if (h <= 0)
                throw new NotSupportedException("El valor de h debe ser positivo");

            if (funcion == null)
                throw new NotSupportedException("La función es requerida");

            _h = h;
            _funcion = funcion;
            Y = y0;
        }

        public void CalcularSiguiente()
        {
            Yprima = _funcion.Calcular(Y);

            Y += _h * Yprima;
        }

        public decimal Y { get; protected set; }
        public decimal Yprima { get; protected set; }
    }
}
