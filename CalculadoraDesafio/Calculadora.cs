using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio
{
    class Calculadora:ICalculadora
    {
        public double somar(double x, double y)
        {
            return x + y; 
        }

        public double subtrair(double x, double y)
        {
            return x - y;
        }

        public double multiplicacao(double x, double y)
        {
            return (x * y);
        }

        public double divisao(double x, double y)
        {
            var resultado = x / y;
            return resultado;
        }

    }
}
