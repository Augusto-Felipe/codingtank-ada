namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! Bem-vindo ao Coding Tank.");

            string idadeString = Console.ReadLine();

            // TRY CATCH
            try
            {
                int idade = int.Parse(Console.ReadLine());  
            }
            catch
            {
                Console.WriteLine("Não foi possível coverter.");
            }


            // TRY PARSE
            if (int.TryParse(idadeString, out int numero))
            {
                Console.WriteLine($"Voce digitou um número {numero}");
            }
            else
            {
                Console.WriteLine("Voce nao digitou um número.");
            }
        }
    }
}