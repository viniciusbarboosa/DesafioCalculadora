using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio.Calculadora.Divisao
{
    internal class Divisao : IDivisao
    {
        public double Dividir(double valor1,double valor2)
        {
            return valor1 / valor2;
        }
    }
}
