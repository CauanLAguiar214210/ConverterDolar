using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolar
{
    internal class ConvertorDeMoeda
    {
        public static double Contacao;
        public static double Quantia;
        public static double Iof = 6.0;


        public static double DolarParaReal(double Contacao, double Quantia)
        {
            double Total = Contacao * Quantia;
            return Total + Total * Iof / 100.00;
        }
    }
}
