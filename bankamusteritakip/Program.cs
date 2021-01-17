using System;

namespace bankamusteritakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteri1 = new Musteriler();
            musteri1.Id = 3;
            musteri1.isim = "Umut";
            musteri1.isim = "Erturk";
            musteri1.telNo = 1555314616;



            Musteriler musteri2 = new Musteriler();
            musteri2.Id = 2;
            musteri2.isim = "Hakan";
            musteri2.soyİsim = "Bolat";
            musteri2.telNo = 564216511;



            Musteriler musteri3 = new Musteriler();
            musteri3.Id = 5;
            musteri3.isim = "Yunus";
            musteri3.soyİsim = "Koc";
            musteri3.telNo = 654564564;


            Musteriler[] musteri = new Musteriler[] { musteri1, musteri2, musteri3 };

            foreach (Musteriler müst in musteri) 
            {
                Console.WriteLine(müst.Id);
                Console.WriteLine(müst.isim);
                Console.WriteLine(müst.soyİsim);
                Console.WriteLine(müst.telNo);



            }

            }







        }
    }
}
