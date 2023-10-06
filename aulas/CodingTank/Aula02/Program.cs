using Aula02.Entities;
using System.Globalization;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aula
            //string minhaString;
            //string minhaString2;
            //minhaString = "Isso é uma string ";
            //minhaString2 = "Isso é uma string 2";
            //string resultado = minhaString + minhaString2;
            //string resultado2 = $"{minhaString} {minhaString2}";
            //string resultado3 = string.Format("{0} {1}", minhaString, minhaString2);
            //string resultadoConcat = string.Concat(minhaString, minhaString2);
            //Console.WriteLine(resultado);
            //Console.WriteLine(resultado2);
            //Console.WriteLine(resultado3);
            //Console.WriteLine(resultadoConcat);            //string minhaString;
            //string minhaString2;
            //minhaString = "Isso é uma string ";
            //minhaString2 = "Isso é uma string 2";
            //string resultado = minhaString + minhaString2;
            //string resultado2 = $"{minhaString} {minhaString2}";
            //string resultado3 = string.Format("{0} {1}", minhaString, minhaString2);
            //string resultadoConcat = string.Concat(minhaString, minhaString2);
            //Console.WriteLine(resultado);
            //Console.WriteLine(resultado2);
            //Console.WriteLine(resultado3);
            //Console.WriteLine(resultadoConcat);

            //string texto2 = "Exemplo de texto";
            //int comprimento = texto2.Length;
            //Console.WriteLine(comprimento);
            //string maiusculas = texto2.ToUpper();
            //Console.WriteLine(maiusculas);
            //string minusculas = texto2.ToLower();
            //Console.WriteLine(minusculas);
            //string semEspacos = texto2.Trim();
            //Console.WriteLine(semEspacos);
            //string semEspaco = texto2.Replace(" ", "");
            //Console.WriteLine(semEspaco);
            //int comprimeiro2 = semEspaco.Length;
            //Console.WriteLine(comprimeiro2);
            //int comprimento3 = texto2.Replace(" ", "").Length;
            //Console.WriteLine(comprimento3);

            //string parte = texto2.Substring(0, 9);
            //Console.WriteLine(parte);

            //string texto2 = "exemplo de texto";
            //Console.WriteLine(char.ToUpper(texto2[0]) + texto2.Substring(1));

            //Console.WriteLine("Digite o seu nome:");
            //string nome = Console.ReadLine().ToLower();
            //Console.WriteLine(nome);


            //Console.WriteLine("Digite sim ou não:");
            //string input = Console.ReadLine();
            ////string pattern = @"^Não";
            ////(31) 92345-2356
            //string pattern = @"\(\d{2}\) \d{5}-\d{4}";

            //bool isMatch = Regex.IsMatch(input, pattern);

            //if (isMatch)
            //{
            //    Console.WriteLine("A string corresponde ao padrão.");
            //}
            //else
            //{
            //    Console.WriteLine("A string não corresponde ao padrão.");
            //}

            //int inteiro = 42;
            //double Numdecimal = inteiro;

            //double numDecimal2 = 42.5;
            //int inteiro2 = (int)numDecimal2;

            //int numero = 10;
            //string resultado = (numero % 2 == 0) ? "Par" : null;

            //string resultado2 = numero > 0 ? "Maior que Zero" :
            //    numero < 0 ? "Menor que zero" : "Igual a zero";

            //double numero = 123456.67;
            //CultureInfo CI = CultureInfo.GetCultureInfo("en-US");
            //string numeroFormatado = numero.ToString("N", CI);
            //Console.WriteLine(numeroFormatado);



            //string texto = "Isso é uma string";
            //string novoTexto = texto.Replace("string", "bola");
            //Console.WriteLine(texto);
            //Console.WriteLine(novoTexto);

            //Console.Write("Insira o seu ultimo nome, idade e altura (mesma linha): ");
            //string[] vet = Console.ReadLine().Split(' ');

            //string ultNome = vet[0];
            //int idade = int.Parse(vet[1]);
            //double altura = double.Parse(vet[2]);

            //Console.WriteLine(ultNome);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2"));

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Hello, ");
            //stringBuilder.Append("world!");

            //string resultado = stringBuilder.ToString();
            //string resultado = stringBuilder;
            //Console.WriteLine(stringBuilder);
            #endregion

            #region Desafio 5
            /*
            Console.WriteLine("Bem vindo!: ");
            Console.WriteLine("1- Digitar peso do peixe");
            Console.WriteLine("2- SAIR");

            int option = int.Parse(Console.ReadLine());

            List<Ticket> tickets = new List<Ticket>();

            double valorTotalMulta = 0.0;

            while (option == 1)
            {
                Console.Write("Quantos peixes serão pesados? ");
                int quantidade = int.Parse(Console.ReadLine());

                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write("Entre com o peso do peixe (kg): ");
                    double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    tickets.Add(new Ticket(peso));
                }

                Console.WriteLine();
                Console.WriteLine();

                foreach (var ticket in tickets)
                {
                    Console.WriteLine("PESO DO PEIXE: " + ticket.PesoDoPeixe.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("VALOR DA MULTA: " + ticket.ValorDaMulta.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine();
                }

                foreach (var ticket in tickets)
                {
                    valorTotalMulta += ticket.ValorDaMulta;
                }

                Console.WriteLine("VALOR TOTAL DA MULTA = " + valorTotalMulta.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine();

                Console.WriteLine("Bem vindo!: ");
                Console.WriteLine("1- Digitar peso do peixe:");
                Console.WriteLine("2- SAIR");

                option = int.Parse(Console.ReadLine());
            }
            */
            #endregion

            #region Desafio 6
            /*
            Console.WriteLine("Bem vindo!: ");
            Console.WriteLine("1- Digitar sua idade:");
            Console.WriteLine("2- SAIR");

            int option = int.Parse(Console.ReadLine());

            while (option == 1)
            {
                Console.Write("Digite sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Infantil A = 5 A 7 anos.");
                }
                else if (idade >= 8 && idade <= 11)
                {
                    Console.WriteLine("Infantil B = 8 A 11 anos.");
                }
                else if (idade >= 12 && idade <= 13)
                {
                    Console.WriteLine("Juvenil A = 12 A 13 anos.");
                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Juvenil B = 14 A 17 anos.");
                }
                else
                {
                    Console.WriteLine("Maiores de 18 anos.");
                }

                Console.WriteLine("1- Digitar sua idade:");
                Console.WriteLine("2- SAIR");
                option = int.Parse(Console.ReadLine());
            }
            */
            #endregion

            #region Desafio 7

            #endregion

            #region Desafio 8
            /*
            Console.Write("Nota da primeira prova: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota da segunda prova: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota da terceira prova: ");
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7.0)
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.Write("Digita a nota do exame de recuperação: ");
                double exame = double.Parse(Console.ReadLine());

                double final = (media + exame) / 2;

                if (final >= 5.0)
                {
                    Console.WriteLine("APROVADO");
                }
                else
                {
                    Console.WriteLine("REPROVADO");
                }
            }
            */
            #endregion

            #region Desafio 9
            /*
            Console.WriteLine("Escolha um curso:");
            Console.WriteLine("1 - Banco de Dados");
            Console.WriteLine("2 - Análise e Desenvolvimento de Sistemas");
            Console.WriteLine("3 - Engenharia da Computação");
            Console.WriteLine("4 - Sistemas de Informação");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Você escolheu o curso de Banco de Dados.");
                    Console.WriteLine("Turmas disponíveis:");
                    Console.WriteLine("1- A101");
                    Console.WriteLine("2- B202");
                    Console.WriteLine("3- C303");
                    int curso = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    if (curso == 1)
                    {
                        Console.WriteLine("CURSO: BANCO DE DADOS");
                        Console.WriteLine("TURMA A101");
                    }
                    else if (curso == 2)
                    {
                        Console.WriteLine("CURSO: BANCO DE DADOS");
                        Console.WriteLine("TURMA B202");
                    } else if (curso == 3)
                    {
                        Console.WriteLine("CURSO: BANCO DE DADOS");
                        Console.WriteLine("TURMA C303");
                    }
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Você escolheu o curso de Análise e Desenvolvimento de Sistemas.");
                    Console.WriteLine("Turmas disponíveis:");
                    Console.WriteLine("1- X101");
                    Console.WriteLine("2- Y202");
                    Console.WriteLine("3- Z303");

                    curso = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    if (curso == 1)
                    {
                        Console.WriteLine("CURSO: ANÁLISE E DESENVOLVIMENTO DE SISTEMAS");
                        Console.WriteLine("TURMA X101");
                    }
                    else if (curso == 2)
                    {
                        Console.WriteLine("CURSO: ANÁLISE E DESENVOLVIMENTO DE SISTEMAS");
                        Console.WriteLine("TURMA Y202");
                    }
                    else if (curso == 3)
                    {
                        Console.WriteLine("CURSO: ANÁLISE E DESENVOLVIMENTO DE SISTEMAS");
                        Console.WriteLine("TURMA Z303");
                    }
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Você escolheu o curso de Engenharia da Computação.");
                    Console.WriteLine("Turmas disponíveis:");
                    Console.WriteLine("1- H101");
                    Console.WriteLine("2- H202");
                    Console.WriteLine("3- H303");

                    curso = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    if (curso == 1)
                    {
                        Console.WriteLine("CURSO: ENGENHARIA DA COMPUTAÇÃO");
                        Console.WriteLine("TURMA H101");
                    }
                    else if (curso == 2)
                    {
                        Console.WriteLine("CURSO: ENGENHARIA DA COMPUTAÇÃO");
                        Console.WriteLine("TURMA H202");
                    }
                    else if (curso == 3)
                    {
                        Console.WriteLine("CURSO: ENGENHARIA DA COMPUTAÇÃO");
                        Console.WriteLine("TURMA H303");
                    }
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Você escolheu o curso de Sistemas de Informação.");
                    Console.WriteLine("Turmas disponíveis:");
                    Console.WriteLine("1- I101");
                    Console.WriteLine("2- I202");
                    Console.WriteLine("3- I303");

                    curso = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    if (curso == 1)
                    {
                        Console.WriteLine("CURSO: SISTEMAS DE INFORMAÇÃO");
                        Console.WriteLine("TURMA I101");
                    }
                    else if (curso == 2)
                    {
                        Console.WriteLine("CURSO: SISTEMAS DE INFORMAÇÃO");
                        Console.WriteLine("TURMA I202");
                    }
                    else if (curso == 3)
                    {
                        Console.WriteLine("CURSO: SISTEMAS DE INFORMAÇÃO");
                        Console.WriteLine("TURMA I303");
                    }

                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            */
            #endregion

            #region Desafio 10

            #endregion

            #region Desafio 11

            Console.Write("Digite seu salario: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario func1 = new Funcionario(salario);
            Console.WriteLine();
            Console.WriteLine(func1);

            #endregion
        }
    }
}
