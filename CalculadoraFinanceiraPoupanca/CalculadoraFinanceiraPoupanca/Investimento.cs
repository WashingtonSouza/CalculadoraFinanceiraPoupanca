using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinanceiraPoupanca
{
    class Investimento
    {
        public double valorInvestimento;
        public int qtdMes;
        public double taxaJuros = 1.005;
        public double valorTotal;

        public void ContaPoupanca()
        {
            valorTotal = valorInvestimento;

            for (int i = 1; i <= qtdMes; i++)
            {
                valorTotal = valorTotal * taxaJuros;
                Console.WriteLine("juros do mes é {0: 0.##}", valorTotal - valorInvestimento);
            }

            Console.WriteLine("==============================================================================\n");
            Console.WriteLine("O investimento Total com a aplicação da Taxa de Juros é: {0: 0.##}", valorTotal);
        }
    }
}
