using CalculadoraDesafio.Calculadora.Divisao;
using CalculadoraDesafio.Calculadora.Multiplicacao;
using CalculadoraDesafio.Calculadora.Soma;
using CalculadoraDesafio.Calculadora.Subtracao;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio.Calculadora
{
    class Calculadora:ICalculadora
    {
        private ISubtracao _subtracao;
        private ISoma _soma;
        private IMultiplicacao _multiplicacao;
        private IDivisao _divisao;

        //A MINHA IDEIA AQUI E POR QUE NO ASP QUEESTUDEI E FEITO ASSIM COM INJEÇÃO DE DEPENDENCIA E O ADDSCOPED<> ENTAO TENTEI FAZEZR ALGO PARECIDO
        public Calculadora(ISubtracao subtracao,ISoma soma,IMultiplicacao multiplicacao,IDivisao divisao) {
            _subtracao = subtracao;
            _soma = soma;
            _multiplicacao = multiplicacao;
            _divisao = divisao;
        }

        public double Somar(double x, double y)
        {
            return _soma.Somar(x, y);
        }

        public double Subtrair(double x, double y)
        {
            return _subtracao.Subtrair(x, y);
        }

        public double Multiplicacao(double x, double y)
        {
            return _multiplicacao.Multiplicar(x,y);
        }

        public double Divisao(double x, double y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException("Divisao por zero nao Disponivel");
            }
            var resultado = _divisao.Dividir(x, y);
            return resultado;
        }

    }
}
