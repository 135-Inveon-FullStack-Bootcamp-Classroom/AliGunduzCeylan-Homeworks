using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1_2019
{
    class DoubleSort:Sorting
    {
        NoktaliSayi asArray = new NoktaliSayi();
        public DoubleSort(NoktaliSayi gelecek)
        {
            asArray = gelecek;
        }

        public override NoktaliSayi Sirala()
        {
            for (int i = 0; i < asArray.ElemanSayisi - 1; i++)
            {
                for (int j = i + 1; j < asArray.ElemanSayisi; j++)
                {
                    if (asArray.Dizi100[j].Deger < asArray.Dizi100[i].Deger)
                    {
                        double degistir = asArray.Dizi100[(j)].Deger;
                        asArray.Dizi100[j].Deger = asArray.Dizi100[i].Deger;
                        asArray.Dizi100[i].Deger = degistir;
                    }

                }
            }
            
            return asArray;


        }
        public override TamSayi Sirala1()
        {
            throw new NotImplementedException();
        }
    }
}
