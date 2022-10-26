using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_switch_case_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bilet;
            int secim;
            int indirim;
            int ogrenci, gazi, ogretmen, polis;
            int ogrenci_indirim, gazi_indirim, ogretmen_indirim, polis_indirim;
            Console.Write("Bilet satış fiyatı giriniz: ");
            bilet = Convert.ToDouble(Console.ReadLine());
            Console.Write("1:Normal Bilet \n2:İndirimli Bilet \nSeçiminiz(1,2):");
            secim = Convert.ToInt16(Console.ReadLine());
            if (secim == 1)
            {
                Console.Write("Bilet Fiyatı:{0} İndirim Oranı: 0 İndirim Tutarı: 0 Bilet Türü: Normal Ödenecek Tutar:{0}", bilet);
            }
            else if (secim != 2 && secim != 1)
            {
                Console.Write("Hatalı Menü Seçimi");
            }
            else if (secim == 2)
            {
                Console.WriteLine("1:Öğrenci\n2:Gazi\n3:Öğretmen\n4:Polis\nSeçiminiz(1,2,3,4):");
                indirim = Convert.ToInt32(Console.ReadLine());

                switch (indirim)
                {
                    case 1:
                        ogrenci = Convert.ToInt32(bilet / 2);
                        ogrenci_indirim = Convert.ToInt32(bilet * 0.5);
                        Console.WriteLine("Bilet Fiyatı: {0}TL \nİndirim Oranı: %50 \nİndirim Tutarı: {2}TL \nBilet Türü: Öğrenci \nÖdenecek Tutar: {1}TL", bilet, ogrenci, ogrenci_indirim);
                        break;
                    case 2:
                        gazi = Convert.ToInt32(bilet * 0.6);
                        gazi_indirim = Convert.ToInt32(bilet * 0.4);
                        Console.WriteLine("Bilet Fiyatı:{0}TL \nİndirim Oranı: %40 \nİndirim Tutarı: {2}TL \nBilet Türü: Gazi \nÖdenecek Tutar: {1}TL", bilet, gazi, gazi_indirim);
                        break;
                    case 3:
                        ogretmen = Convert.ToInt32(bilet * 0.7);
                        ogretmen_indirim = Convert.ToInt32(bilet * 0.3);
                        Console.WriteLine("Bilet Fiyatı:{0}TL \nİndirim Oranı: %30 \nİndirim Tutarı: {2}TL \nBilet Türü: Öğretmen \nÖdenecek Tutar: {1}TL", bilet, ogretmen, ogretmen_indirim);
                        break;
                    case 4:
                        polis = Convert.ToInt32(bilet * 0.8);
                        polis_indirim = Convert.ToInt32(bilet * 0.2);
                        Console.WriteLine("Bilet Fiyatı:{0}TL \nİndirim Oranı: %20 \nİndirim Tutarı: {2}TL \nBilet Türü: Polis \nÖdenecek Tutar: {1}TL", bilet, polis, polis_indirim);
                        break;
                    default:
                        Console.Write("Hatalı İndirim Seçimi");
                        break;
                }
            }
            Console.Read();
        }
    }
}
