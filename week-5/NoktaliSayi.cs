using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proje1_2019
{
    class NoktaliSayi:Sayi
    {
        double deger;
        int elemanSayisi;
        int hataliSayisi;
        NoktaliSayi[] dizi100 = new NoktaliSayi[100];
        
        public NoktaliSayi()
        {

        }

        public  double Deger
        {
            get
            {
                return deger;
            }
            set
            {
                deger = value;
            }
        }

        public int ElemanSayisi
        {
            get
            {
                return elemanSayisi;
            }
            set
            {
                elemanSayisi = value;
            }
        }
        public int HataliSayisi
        {
            get
            {
                return hataliSayisi;
            }
            set
            {
                hataliSayisi = value;
            }
        }

        public NoktaliSayi[] Dizi100 { get => dizi100; set => dizi100 = value; }


        public override NoktaliSayi okuma()
        {
            char[] hatalilar = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'Y', 'Z'
            , 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'y', 'z'
            , '"', ' ', '^', '+', '%', '&', '/', '(', ')', '=', '?', '*','-', '|', '_', '}', ']', '[', '{', '$', '#', 'é', '@', '<', '>', '.', ':', ';', '`', '´', '!'};
            //Hatalı sayılacak girdiler
            /*Hocam '.' kullandığımızda double değerler console da noktasız olarak (birleşik) yazılıyordu bu yüzden 
            bu hatayı almadığımız ',' ü geçerli değer olarak ayarladık  */

            NoktaliSayi a = new NoktaliSayi();

            //Dosya okuma işlemleri
            string line;
            FileStream akis;
            StreamReader Okuma;
            string Yol = "sunnyboy.txt";
            akis = new FileStream(Yol, FileMode.Open, FileAccess.Read);
            Okuma = new StreamReader(akis);
            line = Okuma.ReadLine();
            string deneme;
            bool control = true;
            bool noktalidir = false;
            int eleman = 0;
            bool negatifmi = false;//  '-' DEGERİNİN GİRDİNİN BAŞINDA OLUP OLMADIĞINA GÖRE İŞLEM YAPMAK İÇİN 

            while (line != null)
            {
                control = true;

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == ',')
                    {
                        noktalidir = true;
                    }
                    if(line[0]=='-')
                    {
                        negatifmi = true;
                    }
                    
                    for (int j = 0; j < hatalilar.Length; j++)
                    {
                        if(negatifmi==true)
                        {
                            negatifmi = false;
                            break;
                        }
                        if (line[i].Equals(hatalilar[j]))//Hatalı bir girdi varsa
                        {
                            a.HataliSayisi++;
                            control = false;
                            break;
                        }
                        

                    }
                    if (control == false)
                    {
                        break;
                    }
                }
                if (control != false && noktalidir == true)//hatalı değilse ve noktalıysa
                {
                    a.Dizi100[eleman] = new NoktaliSayi();
                    a.Dizi100[eleman].Deger = Convert.ToDouble(line);


                    eleman++;//buradaki algoritma için gerekli
                    
                    a.ElemanSayisi++;//program cs te ki length in null değerlerle uğraşmaması için
                }



                noktalidir = false;

                line = Okuma.ReadLine();//bir sonraki line

            }
            
            akis.Close();
            return a;
        }

        public override TamSayi okuma1()
        {
            throw new NotImplementedException();
        }
        public override void yazdir()
        {
            
            StreamWriter yaz = new StreamWriter("SiralanmisNoktaliSayilar.txt");
            
            for(int i=0;i<this.ElemanSayisi;i++)
            {
                yaz.WriteLine(this.Dizi100[i].Deger.ToString());
            }
            yaz.Close();
        }
        
    }
    
}
