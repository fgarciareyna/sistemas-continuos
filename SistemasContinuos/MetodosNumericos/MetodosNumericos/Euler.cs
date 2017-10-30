﻿using System;
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

            if (funcion.Orden() != 1)
                throw new NotSupportedException("La función debe ser de primer orden");

            _h = h;
            _funcion = funcion;
            Y = y0;
            Yprima = CalcularDerivada();
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
            return _funcion.CalcularDerivada(Y);
        }

        private decimal CalcularDerivadaSegunda()
        {
            return _funcion.CalcularDerivadaSegunda(Y, Yprima);
        }

        public decimal Y { get; protected set; }
        public decimal Yprima { get; protected set; }
        public decimal Ysegunda { get; protected set; }
    }
}
