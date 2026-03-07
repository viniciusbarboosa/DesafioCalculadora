using CalculadoraDesafio.Calculadora;
using CalculadoraDesafio.Calculadora.Divisao;
using CalculadoraDesafio.Calculadora.Multiplicacao;
using CalculadoraDesafio.Calculadora.Soma;
using CalculadoraDesafio.Calculadora.Subtracao;
using CalculadoraDesafio.Repositories;
using CalculadoraDesafio.Services;

class Program
{
    public static void Main(string[] args)
    {
        //AQUI SO VOU CRIAR A CALCULADORA COM METODOS QUE QUERO E INICIAR 
        //E VOU CRIAR O REPOSITORY DO HISTORICO QUE VAI SERVE COMO SE TIVESSE PEGANDO DA TABELA OPERACAO E INICIAR NO SERVICE
        Soma soma = new Soma();
        Subtracao subtracao = new Subtracao();
        Multiplicacao multiplicacao = new Multiplicacao();
        Divisao divisao = new Divisao();
        Calculadora calculadora = new Calculadora(subtracao,soma,multiplicacao,divisao);

        Historico historico = new Historico();

        CalculadoraService calculadoraService = new CalculadoraService(calculadora,historico);
        calculadoraService.IniciarCalculadora();



    }

}