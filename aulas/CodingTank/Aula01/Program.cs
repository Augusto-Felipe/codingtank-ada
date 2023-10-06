using System.Globalization;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Console.Write("Digite o seu nome: ");
            //string nome = Console.ReadLine();
            //Console.WriteLine($"Olá, {nome}! Bem-vindo ao Coding Tank.");

            //string idadeString = Console.ReadLine();

            //// TRY CATCH
            //try
            //{
            //    int idade = int.Parse(Console.ReadLine());  
            //}
            //catch
            //{
            //    Console.WriteLine("Não foi possível coverter.");
            //}


            //// TRY PARSE
            //if (int.TryParse(idadeString, out int numero))
            //{
            //    Console.WriteLine($"Voce digitou um número {numero}");
            //}
            //else
            //{
            //    Console.WriteLine("Voce nao digitou um número.");
            //}

            #region Desafio 1

            //double numero1;
            //double numero2;

            //try
            //{
            //    Console.Write("Digite um numero inteiro: ");
            //    numero1 = double.Parse(Console.ReadLine());

            //    Console.Write("Digite um numero inteiro: ");
            //    numero2 = double.Parse(Console.ReadLine());

            //    double soma = numero1 + numero2;
            //    double subtração = numero1 - numero2;
            //    double multiplicacao = numero1 * numero2;

            //    Console.WriteLine("SOMA = " + soma);
            //    Console.WriteLine("SUBTRAÇÃO = " + subtração);
            //    Console.WriteLine("MULTIPLICAÇÃO = " + multiplicacao);

            //    Console.WriteLine("-------------------------------------");

            //    if (numero2 == 0)
            //    {
            //        Console.WriteLine("Não é possível dividir, denominador igual a 0");
            //    }
            //    else
            //    {
            //        double divisao = numero1 / numero2;
            //        Console.WriteLine("Divisão = " + divisao);
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Entrada inválida de dados, você não digitou um número!");
            //}
            #endregion

            #region Desafio 2

            int anoAtual;
            int dataNascimento;
            int idade;

            try
            {
                Console.Write("Digite o ano atual: ");
                anoAtual = int.Parse(Console.ReadLine());

                Console.Write("Digite seu ano de nascimento: ");
                dataNascimento = int.Parse(Console.ReadLine());

                if (dataNascimento < anoAtual)
                {
                    idade = anoAtual - dataNascimento;
                    Console.WriteLine($"Você tem {idade} anos.");
                }
                else
                {
                    Console.WriteLine("Sua data de nascimento deve ser menor que o ano atual.");
                }
            }
            catch
            {
                Console.WriteLine("Entrada inválida de dados, você não digitou um número!");
            }
            #endregion

            #region Desafio 3
            /*
            double valorConta;
            double porcentagem;
            double valorGorjeta;
            double valorTotal;

            try
            {
                Console.Write("Insira o valor total da conta: ");
                valorConta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Insira a porcentagem da gorjeta: ");
                porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                valorGorjeta = valorConta * (porcentagem / 100);
                valorTotal = valorConta + valorGorjeta;

                Console.WriteLine("GORJETA: R$" + valorGorjeta.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("CONTA: R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch
            {
                Console.WriteLine("Voce não digitou um número.");
            }
            */
            #endregion

            #region Desafio 4
            /*
            double valorReal;
            double valorEuro;
            double valorDolar;

            try
            {
                Console.Write("Digite um valor em reais: ");
                valorReal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                valorEuro = valorReal / 5.45;
                valorDolar = valorReal / 5.18;

                Console.WriteLine("VALOR EM DOLAR: $" + valorDolar.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("VALOR EM EURO: " + valorEuro.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch
            {
                Console.WriteLine("Voce nao digitou um número.");
            }
            */
            #endregion
        }
    }
}