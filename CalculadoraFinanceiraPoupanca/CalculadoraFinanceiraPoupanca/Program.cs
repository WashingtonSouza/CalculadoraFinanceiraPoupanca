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
            Investimento investi = new Investimento();

            Console.WriteLine("Qual o valor que deseja investir? \n");
            investi.valorInvestimento = Convert.ToDouble(Console.ReadLine());
                      
            Console.WriteLine("Quatos meses deseja investir? \n");
            investi.qtdMes = Convert.ToInt32(Console.ReadLine());

            investi.ContaPoupanca();

            Console.ReadKey();
        }
    }
}
