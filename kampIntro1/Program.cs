using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.45;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar düşüşte...");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar yükselişe geçti...");
            }
            else 
            {
                Console.WriteLine("Dolar aynı seyirde devam ediyor...");

            }
        }
    }
}
