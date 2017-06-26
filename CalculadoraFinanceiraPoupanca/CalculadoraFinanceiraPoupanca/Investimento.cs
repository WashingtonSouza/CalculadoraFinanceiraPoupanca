using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinanceiraPoupanca
{
    class Investimento
    {
        public double ValorInvestimento;
        public int QtdMes;
        public double TaxaJuros;
        public double ValorTotal;
        public List<double> JurosMensal = new List<double>();
        private double Juros;


        public void ContaPoupanca()
        {
            ValorTotal = ValorInvestimento;

            for (int i = 1; i <= QtdMes; i++)
            {
                Juros = (ValorTotal * TaxaJuros) / 100;
                JurosMensal.Add(Juros);
                ValorTotal = ValorTotal + Juros;
            }
        }
    }
}
