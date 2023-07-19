using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string Kurs1 = " Yazılım gelişirici yetiştirme kursu";
            string Kurs2 = " Programlamaya başlangıç için temel kurs.";
            string Kurs3 = " java";
            // Bunu yapmak epey zamanımızı alır, bu yüzden Array formatında yazacaz...

            string[] kurslar = new string[] { "Yazılım gelişirici yetiştirme kursu", " Programlamaya başlangıç için temel kurs.", " java", "C#" };





            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
               

            }
            Console.WriteLine("For bitti.");
            foreach (string kurs in kurslar)
            {

                Console.WriteLine(kurs);


            }
            {

            }
            Console.WriteLine("Sayfa sonu");
            Console.ReadLine();
        }
    }
}
