using CalculadoraDesafio.Calculadora;
using CalculadoraDesafio.Calculadora.Divisao;
using CalculadoraDesafio.Calculadora.Multiplicacao;
using CalculadoraDesafio.Calculadora.Soma;
using CalculadoraDesafio.Calculadora.Subtracao;
using CalculadoraDesafio.Services;

class Program
{
    public static void Main(string[] args)
    {
        //AQUI SO VOU CRIAR A CALCULADORA COM METODOS E QUERO E INICIAR
        Soma soma = new Soma();
        Subtracao subtracao = new Subtracao();
        Multiplicacao multiplicacao = new Multiplicacao();
        Divisao divisao = new Divisao();
        Calculadora calculadora = new Calculadora(subtracao,soma,multiplicacao,divisao);

        CalculadoraService calculadoraService = new CalculadoraService(calculadora);
        calculadoraService.IniciarCalculadora();



    }

}