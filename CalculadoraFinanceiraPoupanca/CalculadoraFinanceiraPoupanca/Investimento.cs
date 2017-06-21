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
        public double taxaJuros;
        public double valorTotal;

        public void ContaPoupanca(Investimento investimento)
        {
            investimento.valorTotal = investimento.valorInvestimento;

            for (int i = 1; i <= investimento.qtdMes; i++)
            {
                double valor = (investimento.valorTotal * investimento.taxaJuros) / 100;

                Console.WriteLine("No mês " + i + " O rendimento é de " + valor.ToString("0.##"));

                investimento.valorTotal += Convert.ToDouble(valor.ToString("0.##"));
            }

            Console.WriteLine("O investimento Total com a aplicação da Taxa de Juros é: " + investimento.valorTotal);
        }
    }
}
