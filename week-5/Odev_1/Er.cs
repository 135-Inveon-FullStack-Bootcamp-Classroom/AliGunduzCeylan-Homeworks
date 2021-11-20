using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Er : Asker
    {
        public Er(int takim,Bolge bolge) : base(1, takim)
        {
            this.Koordinat = bolge; 
        }
        public override void Bekle()
        {
            throw new NotImplementedException();
        }

        public override void HaraketEt()
        {
            Random r = new Random();
            int random = r.Next(1, 4);
            switch (random)
            {
                case 1: if (Alan.sinirKontrol(this))
                    {
                        if (Alan.bosMu(Alan.Harita[this.Koordinat.X, this.Koordinat.Y + 1]))
                        {
                            this.Koordinat = Alan.Harita[this.Koordinat.X, this.Koordinat.Y + 1];
                        }
                    }
                    
                    break;
                case 2:
                    if (Alan.sinirKontrol(this))
                    {
                        if (Alan.bosMu(Alan.Harita[this.Koordinat.X, this.Koordinat.Y - 1]))
                        {
                            this.Koordinat = Alan.Harita[this.Koordinat.X, this.Koordinat.Y - 1];
                        }
                    }
                    
                    break;
                
            }
            
        }
        public override void AtesEt()
        {
            Console.WriteLine(Takım + ". takımın eri ateş etti!");
            Yazıcı.WriteLine("\n " + Takım + ". takımın eri ateş etti");
            Yazıcı.Flush();
            Random r = new Random();
            int rastgele = r.Next(1, 11);
            if (rastgele <= 5)
            {
                Alan.ates(this, 5);

            }
            else if(5<rastgele && rastgele <= 8)
            {
                Alan.ates(this, 10);
            }
            else if(8<rastgele && rastgele <= 10)
            {
                Alan.ates(this, 15);
            }
        }
        
    }
}
