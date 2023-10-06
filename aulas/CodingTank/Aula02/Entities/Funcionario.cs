using System.Globalization;

namespace Aula02.Entities
{
    internal class Funcionario
    {
        public double Salario { get; set; }
        public double PercentualDeAumento { get; set; }

        public Funcionario(double salario)
        {

            if (salario <= 280.00)
            {
                PercentualDeAumento = 0.20;
            }
            else if (salario >= 280.00 && salario <= 700.00)
            {
                PercentualDeAumento = 0.15;
            }
            else if (salario >= 700.00 && salario <= 1500.00)
            {
                PercentualDeAumento = 0.10;
            }
            else
            {
                PercentualDeAumento = 0.05;
            }

            Salario = salario;
        }

        public double SalarioReajustado()
        {
            return Salario += (Salario * PercentualDeAumento);
        }

        public double ValorAumento()
        { 
            return Salario * PercentualDeAumento;
        }

        public override string ToString()
        {
            return $"Salario antes do reajuste: R$ {Salario.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Percentual de aumento = {PercentualDeAumento * 100}% \n" +
                $"Valor do Aumento = R$ {ValorAumento().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Novo salário = R$ {SalarioReajustado().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
