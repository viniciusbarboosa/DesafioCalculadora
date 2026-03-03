using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio.Calculadora
{
    interface ICalculadora
    {
        public double Somar(double x, double y);
        public double Subtrair(double x, double y);
        public double Multiplicacao(double x, double y);
        public double Divisao(double x, double y);
        
    }
}
