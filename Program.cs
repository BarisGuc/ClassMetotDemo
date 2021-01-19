using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.No = 1;
            musteri1.Isim = "Ali";
            musteri1.Yas = 29;

            Musteri musteri2 = new Musteri();
            musteri2.No = 2;
            musteri2.Isim = "Veli";
            musteri2.Yas = 39;

            Musteri musteri3 = new Musteri();
            musteri3.No = 3;
            musteri3.Isim = "Ayşe";
            musteri3.Yas = 26;
            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };
            MusteriYonetim musteriYonetim = new MusteriYonetim();
            musteriYonetim.musteriEkle(musteri1);
            musteriYonetim.musteriEkle(musteri2);
            musteriYonetim.musteriEkle(musteri3);

            musteriYonetim.musteriSil(musteri1);
            musteriYonetim.musteriSil(musteri2);
            musteriYonetim.musteriSil(musteri3);

            musteriYonetim.musteriListele(musteriler);
            Console.ReadKey();

        }
    }
}
