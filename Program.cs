using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            ConvertorDeMoeda.Contacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            ConvertorDeMoeda.Quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Valor = ConvertorDeMoeda.DolarParaReal(ConvertorDeMoeda.Contacao, ConvertorDeMoeda.Quantia);

            Console.WriteLine("Valor a ser pago em reais = " + Valor.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
