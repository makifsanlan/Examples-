﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Akif";
            int yas = 36;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Emre Yldız";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 90;
            //Console.WriteLine(kurs1.KursAdi + "  " + kurs1.Egitmen); bu uzun iş

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 }; //array kullanndık...

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " "+ kurs.Egitmen);


            }
            Console.ReadLine();
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public  string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
    
}
