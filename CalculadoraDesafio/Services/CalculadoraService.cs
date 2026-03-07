using CalculadoraDesafio.Calculadora;
using CalculadoraDesafio.Calculadora.Divisao;
using CalculadoraDesafio.Calculadora.Multiplicacao;
using CalculadoraDesafio.Calculadora.Soma;
using CalculadoraDesafio.Calculadora.Subtracao;
using CalculadoraDesafio.Entities;
using CalculadoraDesafio.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio.Services
{
    class CalculadoraService
    {
        private ICalculadora _calculadora;
        private IHistorico _historico;

        public CalculadoraService(ICalculadora calculadora,IHistorico historico)
        {
            _calculadora = calculadora;
            _historico = historico;
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
                        _historico.Salvar(new Operacao {
                            Tipo = "Soma",
                            Simbolo = "+",
                            Numero1 = numero1,
                            Numero2 = numero2,
                            Resultado = resultado
                        });
                    }
                    catch (Exception e)
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
                        _historico.Salvar(new Operacao {
                            Tipo = "Subtracao",
                            Simbolo = "-",
                            Numero1 = numero1,
                            Numero2 = numero2,
                            Resultado = resultado
                        });
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
                    Console.WriteLine("Digite o Segundo número da Multiplicação");
                    double numero2 = double.Parse(Console.ReadLine());

                    try
                    {
                        double resultado = _calculadora.Multiplicacao(numero1, numero2);
                        Console.WriteLine("Multiplicação = " + resultado);
                        _historico.Salvar(new Operacao {
                            Tipo = "Multiplicação",
                            Simbolo = "*",
                            Numero1 = numero1,
                            Numero2 = numero2,
                            Resultado = resultado
                        });
                    }
                    catch
                    {
                        Console.WriteLine("Erro na Multiplicação");
                    }

                }
                else if (escolha == 4)
                {
                    Console.WriteLine("Digite o Primeiro número da Divisão");
                    double numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo número da Divisão");
                    double numero2 = double.Parse(Console.ReadLine());

                    try
                    {
                        double resultado = _calculadora.Divisao(numero1, numero2);
                        Console.WriteLine("Divisão = " + resultado);
                        _historico.Salvar(new Operacao
                        {
                            Tipo = "Divisão",
                            Simbolo = "/",
                            Numero1 = numero1,
                            Numero2 = numero2,
                            Resultado = resultado
                        });
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Divisão não pode ser por ZERO");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro ao fazer divisão");
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

            var historico = _historico.MostrarHistorico();
            foreach (var item in historico)
            {
                Console.WriteLine($"{item.Tipo}: {item.Numero1} {item.Simbolo} {item.Numero2} = {item.Resultado}");
            }

        }

    }
}
