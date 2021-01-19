using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriYonetim
    {
        public void musteriEkle(Musteri kisi)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Müsteri Eklediniz. No:"+kisi.No+" adı:"+kisi.Isim+" yaşı:"+kisi.Yas);
        }
        public void musteriSil(Musteri kisi)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Müsteri Sildiniz. No:" + kisi.No + " adı:" + kisi.Isim+" yaşı:" + kisi.Yas);
        }
        public void musteriListele(Musteri[] kisiler)
        {
            Console.WriteLine("Müşteri listelediniz!!!!!");
            foreach (Musteri kisi in kisiler)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("No:" + kisi.No + " adı:" + kisi.Isim+ " yaşı:" + kisi.Yas);
            }   
        }

    }
}
