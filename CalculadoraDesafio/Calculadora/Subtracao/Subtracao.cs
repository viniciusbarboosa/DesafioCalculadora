using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio.Calculadora.Subtracao
{
    public class Subtracao:ISubtracao
    {
        public double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

    }
}
