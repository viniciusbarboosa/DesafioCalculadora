using CalculadoraDesafio.Calculadora;
using CalculadoraDesafio.Calculadora.Divisao;
using CalculadoraDesafio.Calculadora.Multiplicacao;
using CalculadoraDesafio.Calculadora.Soma;
using CalculadoraDesafio.Calculadora.Subtracao;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio.Services
{
    class CalculadoraService
    {
        private ICalculadora _calculadora;
        private List<string> historico = new List<string>();

        public CalculadoraService(ICalculadora calculadora)
        {
            _calculadora = calculadora;
        }

        private void MostrarInterfaceCalculadora()
        {
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("[1] Soma");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Multiplicação");
            Console.WriteLine("[4] Divisao");
            Console.WriteLine("[5] Sair");
        }

        private void MostrarHistorico()
        {
            Console.WriteLine("Historico de Consultas");
            foreach (var item in historico)
            {
                Console.WriteLine(item);
            }
        }

        public void IniciarCalculadora()
        {
            string sairLoop = "N";
            while (sairLoop.ToUpper() != "S")
            {

                this.MostrarInterfaceCalculadora();

                int escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    Console.WriteLine("Digite o Primeiro número da Soma");
                    double numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo número da Soma");
                    double numero2 = double.Parse(Console.ReadLine());
                    try
                    {
                        double resultado = _calculadora.Somar(numero1, numero2);
                        Console.WriteLine("Soma = " + resultado);
                        historico.Add("Soma = " + resultado);
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Erro na Soma");
                    }

                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Digite o Primeiro número da Subtração");
                    double numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo número da Subtração");
                    double numero2 = double.Parse(Console.ReadLine());

                    try
                    {
                        double resultado = _calculadora.Subtrair(numero1, numero2);
                        Console.WriteLine("Subtracao = " + resultado);
                        historico.Add("Subtracao = " + resultado);
                    }
                    catch
                    {
                        Console.WriteLine("Erro na subtração");
                    }

                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Digite o Primeiro número da Multiplicação");
                    double numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo número da Subtração");
                    double numero2 = double.Parse(Console.ReadLine());

                    try
                    {
                        double resultado = _calculadora.Multiplicacao(numero1, numero2);
                        Console.WriteLine("Multiplicação = " + resultado);
                        historico.Add("Multiplicação = " + resultado);
                    }
                    catch
                    {
                        Console.WriteLine("Erro na Multiplicação");
                    }

                }
                else if (escolha == 4)
                {
                    Console.WriteLine("Digite o Primeiro número da Subtração");
                    double numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo número da Subtração");
                    double numero2 = double.Parse(Console.ReadLine());

                    try
                    {
                        double resultado = _calculadora.Divisao(numero1, numero2);
                        Console.WriteLine("Divisão = " + resultado);
                        historico.Add("Divisão = " + resultado);
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Divisão não pode ser por ZERO");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
                else if (escolha == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Escolha Invalida");
                }

                Console.WriteLine("Deseja Encerrar o Programa Digite 'S' ");
                Console.WriteLine("Caso queria continuar Digite qualquer tecla");
                sairLoop = Console.ReadLine();
                Console.Clear();

            }

            this.MostrarHistorico();
        }

    }
}
