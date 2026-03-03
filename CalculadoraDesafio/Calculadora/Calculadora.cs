using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio.Calculadora
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
            if(y == 0)
            {
                throw new Exception("Divisao por zero nao Disponivel");
            }
            var resultado = x / y;
            return resultado;
        }

    }
}
