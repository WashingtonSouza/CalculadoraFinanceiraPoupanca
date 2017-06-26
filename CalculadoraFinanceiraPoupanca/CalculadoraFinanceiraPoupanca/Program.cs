using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinanceiraPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Investimento investimento = new Investimento();

            Console.WriteLine("Qual o valor que deseja investir? \n");
            investimento.ValorInvestimento = Convert.ToDouble(Console.ReadLine());
                      
            Console.WriteLine("Quatos meses deseja investir? \n");
            investimento.QtdMes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a taxa de juros? \n");
            investimento.TaxaJuros = Convert.ToDouble(Console.ReadLine());

            investimento.ContaPoupanca();

            var i = 0;
            foreach(var juros in investimento.JurosMensal)
            {
                i++;
                Console.WriteLine("juros do mes {0} é {1: 0.##}", i, juros);
            }

            Console.WriteLine("==============================================================================\n");
            Console.WriteLine("O investimento Total com a aplicação da Taxa de Juros é: {0: 0.##}", investimento.ValorTotal);

            Console.ReadKey();
        }
    }
}
