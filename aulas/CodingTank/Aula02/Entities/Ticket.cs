namespace Aula02.Entities
{
    internal class Ticket
    {
        public double PesoDoPeixe { get; set; }
        public double ValorDaMulta { get; set; }

        public Ticket(double peso)
        {
            PesoDoPeixe = peso;

            if (peso > 50.0)
            {
                double excedente = peso - 50;
                ValorDaMulta = 4.00 * excedente;
            }
            else
            {
                ValorDaMulta = 0.0;
            }
        }
    }
}
