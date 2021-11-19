using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proje1_2019
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double toplamGirdi=0;
            double hataliOrani=0 ;
            double gecerliOrani=0;
            

            //OBJELER OLUSTURULUP AYRI AYRI DEGERLER 1 DOSYADAN ÇEKİLİYOR
            NoktaliSayi z = new NoktaliSayi();
            z = z.okuma();
            for(int i=0;i<z.ElemanSayisi;i++)
            {
                Console.WriteLine(z.Dizi100[i].Deger+" "+z.HataliSayisi);
            }
            TamSayi t = new TamSayi();
            t = t.okuma1();
            for(int i=0;i<t.ElemanSayisi;i++)
            {
                Console.WriteLine(t.Array1[i].Deger1+" "+t.HataliSayisi);
                
            }


            //BU OBJELER AYRI SORT CLASSLARINA GONDERİLİP SİRALANIYOR (console writeline lar debug içindir!!!!!)
            DoubleSort d = new DoubleSort(z);
            z = d.Sirala();
            for(int i=0;i<z.ElemanSayisi;i++)
            {
                Console.WriteLine(z.Dizi100[i].Deger);
            }
            z.yazdir();

            IntSort test = new IntSort(t);
            t = test.Sirala1();
            for(int i=0;i<t.ElemanSayisi;i++)
            {
                Console.WriteLine(t.Array1[i].Deger1);
            }
            t.yazdir();


            //Son çıktı için işlemler
            toplamGirdi = t.HataliSayisi + t.ElemanSayisi + z.ElemanSayisi;//sadece t nin hatali sayisini aldik cunku iki objede hatali girdiyi eşit şekilde tutuyor

            hataliOrani = t.HataliSayisi / toplamGirdi;
            gecerliOrani = (t.ElemanSayisi + z.ElemanSayisi) / toplamGirdi;

            Console.WriteLine("\n"+"ToplamSatir= "+toplamGirdi+"\n"+"Gecerli sayisi= "+(t.ElemanSayisi+z.ElemanSayisi)+"\n"
                +"HataliSayisi= "+z.HataliSayisi
                +Environment.NewLine+"Hata Orani= " + hataliOrani+Environment.NewLine+
                "Gecerli Orani= "+gecerliOrani);
           




                        







        }
    }
}
