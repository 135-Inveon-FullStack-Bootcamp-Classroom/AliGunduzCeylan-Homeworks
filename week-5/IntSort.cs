using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1_2019
{
    class IntSort:Sorting
    {
        TamSayi asArray = new TamSayi();
        public IntSort(TamSayi array)
        {
            asArray = array;
        }

        public override NoktaliSayi Sirala()
        {
            throw new NotImplementedException();
        }


        public override TamSayi Sirala1()
        {
            for (int i = 0; i < asArray.ElemanSayisi - 1; i++)
            {
                for (int j = i + 1; j < asArray.ElemanSayisi; j++)
                {
                    if (asArray.Array1[j].Deger1 < asArray.Array1[i].Deger1)
                    {
                        int degistir = asArray.Array1[j].Deger1;
                        asArray.Array1[j].Deger1 = asArray.Array1[i].Deger1;
                        asArray.Array1[i].Deger1 = degistir;
                    }

                }
            }

            return asArray;
        }


    }
}
