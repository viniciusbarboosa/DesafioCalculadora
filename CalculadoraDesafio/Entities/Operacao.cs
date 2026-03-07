using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio.Entities
{
    public class Operacao
    {
        public string Tipo { get; set; } = "";
        public string Simbolo { get; set; } = "";
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Resultado { get; set; }

    }
}
