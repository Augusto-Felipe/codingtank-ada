namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1
            /*
            try
            {
                Console.Write("Digite o valor inicial: ");
                int inicial = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor final: ");
                int final = int.Parse(Console.ReadLine());

                int soma = 0;

                for (int i = inicial; i <= final; i++)
                {
                    if (i % 2 == 0)
                    {
                        soma += i;
                    }
                }

                Console.WriteLine("SOMA = " + soma);
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERRO = " + ex.Message);
            }
            */
            #endregion

            #region Exercicio 2
            /*
            Console.Write("Digite o valor de N para a sequência de Fibonacci: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("N deve ser um número positivo.");
            }
            else
            {
                Console.WriteLine("Os primeiros " + n + " termos da sequência de Fibonacci são:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(Fibonacci(i) + " ");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region Exercicio 3
            /*
            Console.Write("Adivinhe um número secreto entre 1 e 100: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Random random = new Random();

                int numeroAleatorio = random.Next(1, 100);

                Console.WriteLine(numeroAleatorio);

                while (numeroAleatorio != n)
                {
                    if (n > numeroAleatorio)
                    {
                        Console.WriteLine("MENOR");
                        n = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("MAIOR");
                        n = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("ACERTOU!!! Número aleatório: " + numeroAleatorio);
            }
            */
            #endregion
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                int a = 0;
                int b = 1;
                int result = 0;
                for (int i = 2; i <= n; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }
                return result;
            }
        }
    }
}