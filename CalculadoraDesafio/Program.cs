using CalculadoraDesafio.Calculadora;

class Program
{
    public static void Main(string[] args)
    {
        string sairLoop = "N";
        List<string> historico = new List<string>();

        while (sairLoop.ToUpper() != "S")
        {

            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Escolha a operação");

            Console.WriteLine("[1] Soma");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Multiplicação");
            Console.WriteLine("[4] Divisao");
            Console.WriteLine("[5] Sair");

            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.WriteLine("Escolha o numero 1");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o numero 2");
                double numero2 = double.Parse(Console.ReadLine());
                try{
                    double resultado = calculadora.somar(numero1, numero2);
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
                Console.WriteLine("Escolha o numero 1");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o numero 2");
                double numero2 = double.Parse(Console.ReadLine());

                try
                {
                    double resultado = calculadora.subtrair(numero1, numero2);
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
                Console.WriteLine("Escolha o numero 1");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o numero 2");
                double numero2 = double.Parse(Console.ReadLine());

                try
                {
                    double resultado = calculadora.multiplicacao(numero1, numero2);
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
                Console.WriteLine("Escolha o numero 1");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o numero 2");
                double numero2 = double.Parse(Console.ReadLine());

                try
                {
                    double resultado = calculadora.divisao(numero1, numero2);
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

        Console.Clear();

        Console.WriteLine("Historico de Consultas");
        foreach (var item in historico)
        {
            Console.WriteLine(item);
        }

    }

}