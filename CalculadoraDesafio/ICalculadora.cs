using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio
{
    interface ICalculadora
    {
        public double somar(double x, double y);
        public double subtrair(double x, double y);
        public double multiplicacao(double x, double y);
        public double divisao(double x, double y);
        
    }
}
