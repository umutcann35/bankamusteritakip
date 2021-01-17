using System;
using System.Collections.Generic;
using System.Text;

namespace bankamusteritakip
{
    class MusteriManager
    {
        public void Ekle(Musteriler musteriler)
        {

            Console.WriteLine("Musteri eklendi"+musteriler.isim);
        }

        public void Sil(Musteriler musteriler)
        {
            Console.WriteLine("musteri silindi "+musteriler.isim);

        }

        public void Guncelle(Musteriler musteriler)
        {
            Console.WriteLine("Musteri Guncellendi"+musteriler.isim);
        }

    }


}
}
