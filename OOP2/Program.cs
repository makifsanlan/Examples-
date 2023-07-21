using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12332323";
            musteri1.Adi = "Akif";
            musteri1.SoyAdi = "Sanlan";
            musteri1.TcNo = "123434";
            musteri1.Id=1;


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "34766494";
            musteri2.SirketAdi = "Sanlan Market";
            musteri2.VergiNo = "845385834508";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager mn = new MusteriManager();
            mn.Add(musteri1);
            mn.Add(musteri2);
            // temel(miras veren) class referans tutucudur.

        }
    }
}
