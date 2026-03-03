using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio.Calculadora.Multiplicacao
{
    public class Multiplicacao : IMultiplicacao
    {
        public double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

    }
}
