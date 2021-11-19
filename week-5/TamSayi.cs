using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proje1_2019
{
    class TamSayi:Sayi
    {
        TamSayi[] Array= new TamSayi[100];
        int deger1;
        int elemanSayisi;
        int hataliSayisi;
        public TamSayi()
        {

        }
        public int Deger1
        {
            get
            {
                return deger1;
            }
            set
            {
                deger1 = value;
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
        
        public TamSayi[] Array1{ get => Array; set => Array = value; }




        public override NoktaliSayi okuma()
        {
            throw new NotImplementedException();
        }

        
        public override void yazdir()
        {
            StreamWriter yaz = new StreamWriter("SiralanmisTamSayilar.txt");

            for (int i = 0; i < this.ElemanSayisi; i++)
            {
                yaz.WriteLine(this.Array1[i].Deger1.ToString());
            }
            yaz.Close();
        }

        public override TamSayi okuma1()
        {
            char[] hatalilar = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'Y', 'Z'
            , 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'y', 'z'
            , '"', ' ', '^', '+', '%', '&', '/', '(', ')', '=', '?', '*', '-', '|', '_', '}', ']', '[', '{', '$', '#', 'é', '@', '<', '>', '.', ':', ';', '`', '´', '!'};//Hatalı sayılacak girdiler

            TamSayi a = new TamSayi();
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

            while (line != null)
            {
                control = true;
                noktalidir = false;
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == ',')
                    {
                        noktalidir = true;
                    }
                    for (int j = 0; j < hatalilar.Length; j++)
                    {
                        if (line[i].Equals(hatalilar[j]))
                        {
                            a.HataliSayisi++;
                            control = false;
                            break;
                        }
                    }
                    if(control==false)
                    {
                        break;
                    }
                }
                if (control != false && noktalidir == false)
                {
                    a.Array1[eleman] = new TamSayi();
                    a.Array1[eleman].Deger1 = Convert.ToInt32(line);


                    eleman++;
                    a.elemanSayisi++;
                }



                line = Okuma.ReadLine();

            }
            akis.Close();
            return a;
        }
    }
}
