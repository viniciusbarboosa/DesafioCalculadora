using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio.Calculadora.Soma
{
    public class Soma:ISoma
    {
        public double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
    }
}
