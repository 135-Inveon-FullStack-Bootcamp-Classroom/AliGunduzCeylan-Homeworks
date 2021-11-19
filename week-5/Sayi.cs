using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1_2019
{
    abstract class Sayi
    {

        //NoktaliSayi ve TamSayi class larının kullanacağı metotları oluşturuyoruz
        public abstract NoktaliSayi okuma();
        public abstract TamSayi okuma1();
        public abstract void yazdir();
        

        

    }
}
