using System.Globalization;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercicio 1
            /*
            int[] vetor1 = new int[9];
            int[] vetor2 = new int[9];
            int[] vetor3 = new int[9];

            Console.WriteLine("PRIMEIRO VETOR");
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write($"Digite o {i+1} número: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("SEGUNDO VETOR");
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write($"Digite o {i + 1} número: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor3.Length; i++)
            {
                vetor3[i] = vetor1[i] + vetor2[i];  
            }

            Console.WriteLine();
            Console.WriteLine("VALOR DA SOMA DOS VETORES:");
            for (int i = 0; i < vetor3.Length; i++)
            {
                Console.WriteLine($"Valor da posicao {i+1}: {vetor3[i]}");
            }
            */
            #endregion

            #region Exercicio 2
            /*
            int[] vetor = new int[10];
            double media = 0.0;
            double menor = int.MaxValue;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite um numero para a posição {i+1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
                media += vetor[i];
            }

            foreach (var numero in vetor)
            {
                if (numero < menor)
                {
                    menor = numero;
                }
            }

            Console.WriteLine();

            Console.WriteLine("SOMA = " + media.ToString("F2", CultureInfo.InvariantCulture));

            media = media / (double)vetor.Length;

            Console.WriteLine("MEDIA = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("MENOR = " + menor.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Exercicio 3
            /*
            int soma = 0;

            for (int i = 0; i <= 100; i++)
            {
                soma += i;
            }

            Console.WriteLine("SOMA = " + soma);
            */
            #endregion

            #region Exercicio 4
            List<int> lista = new List<int>();
            int soma = 0;
            int pares = 0;

            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                Console.Write("Digite um número: ");
                lista.Add(numero);

                numero = int.Parse(Console.ReadLine());
            }

            foreach (var n in lista)
            {
                soma += n;

                if (n % 2 == 0)
                {
                    pares++;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Quantidade de numeros lidos: " + lista.Count);
            Console.WriteLine("Soma = " + soma);
            Console.WriteLine("Quantiade de pares = " + pares);
            #endregion

            static void Dic()
            {
                //Dicionario => vetor de 2 dimenções com chave e valor de tipos diferentes
                //Analogo Json, Map
                //É tipo um banco de dados

                //Warnning => verificar exemplos
                Dictionary<string, double> dic = new Dictionary<string, double>
            {
                { "Produto1", 2 },
                { "Produto2", 5.0 },
                { "Produto3", 3.0 }
            };

                string chave = "Produto1";
                Console.WriteLine($"valor: {dic[chave]}");

                //Busca
                dic.TryGetValue("Produto1", out double valor);

                foreach (var item in dic)
                {
                    Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
                }

                //List<string> keys = new List<string>(dic.Keys);
                //for (int i = 0; i < keys.Count; i++)
                //{
                //    var key = keys[i];
                //    var valor = dic[key];
                //}
            }

            static void Matriz()
            {
                //Matriz => vetor de 2 dimenções
                int[,] matriz = new int[2, 3];
                matriz[0, 0] = 1;
                matriz[0, 1] = 2;
                matriz[0, 2] = 4;

                int[,] matriz2 = new int[2, 3]
                {
                {1, 2, 3},
                {4, 5, 6}
                };

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int valor = matriz2[i, j];
                        Console.WriteLine($"linha: {i}, Coluna: {j} => valor:  {valor}");
                    }
                }

                int[,,] matriz3 = new int[2, 3, 4];
            }

            static void RunArray()
            {
                //Vetor => coleção de algo de mesmo tipo
                //exemplo: Vetor de tamanho 5
                int[] vetorInteiros = new int[5];

                //Vetor sempre começa com o indice 0
                vetorInteiros[0] = 1;
                vetorInteiros[1] = 2200;
                vetorInteiros[2] = 30;
                vetorInteiros[3] = 130;
                vetorInteiros[4] = 1130;

                Console.WriteLine(string.Join(',', vetorInteiros));

                int tamanhoAtual = vetorInteiros.Length;

                //Resize => aumentar o array
                Array.Resize(ref vetorInteiros, tamanhoAtual + 5);
                vetorInteiros[6] = 1131;

                //Uma outra forma de inicializar
                int[] vetorInteiros2 = new int[5] { 1, 22, 33, 54, 6 };

                //para Percorrer uma coleção/array/list
                //for, while, foreach, do While

                //1 - for
                for (int i = 0; i < vetorInteiros2.Length; i++)
                {
                    Console.WriteLine($"indice {i} e valor: {vetorInteiros[i]}");
                }

                //2 - while => enquanto tiver a condição faça algo
                int contador = 0;
                while (contador < vetorInteiros2.Length)
                {
                    Console.WriteLine($"contador: {contador} e valor: {vetorInteiros[contador]}");

                    if (contador == 3)
                    {
                        //Interrompe o Laço
                        break;
                    }

                    //A cada laço eu mudo/adiciono 1 ao contador
                    contador = contador + 1;
                }

                //bool condicao = true;
                //while (condicao)
                //{
                //    Console.WriteLine("Informe seu time");
                //    string time = Console.ReadLine();

                //    if (time == "juventus")
                //    {
                //        //ele continua, mas não sai
                //        //volta para o começo do while
                //        continue;
                //    }

                //    if (time == "pontepreta")
                //    {
                //        //sair
                //        break;
                //    }

                //    Console.WriteLine($"Seu time é: {time}");
                //}

                //Para cada item no array
                //O bom dele é que ele é mais simples

                int[] vetorInteiros3 = new int[2] { 34, 40 };

                foreach (int item in vetorInteiros3)
                {
                    int valorDoArray = item;
                    Console.WriteLine(valorDoArray);
                }

                Console.ReadKey();
            }

            static void Exercicio10_aula2()
            {
                string texto = "ana";
                int tamanho = texto.Length;
                string textoInvertido = "";

                for (int i = tamanho; i >= 0; i--)
                {
                    string letraInvetida = texto[i].ToString();
                    textoInvertido = textoInvertido + letraInvetida;
                    Console.WriteLine(letraInvetida);
                }

                //ToUpper() => Transforma letra minuscula em maiuscula, por exmplo: abc => ABC 
                if (texto.ToUpper() == textoInvertido.ToUpper())
                {
                    Console.WriteLine("É um palindromo");
                }
                else
                {
                    Console.WriteLine("Não é um palindromo");
                }
            }
        }
    }
}