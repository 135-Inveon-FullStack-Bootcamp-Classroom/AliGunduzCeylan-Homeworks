using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Tegmen : Asker
    {
        public Tegmen(int takım,Bolge bolge) : base(2, takım)
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
            int rastgele = r.Next(1, 6);
            switch (rastgele)
            {
                case 1:
                    if (Alan.sinirKontrol(this))
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
                case 3:
                    if (Alan.sinirKontrol(this))
                    {
                        if (Alan.bosMu(Alan.Harita[this.Koordinat.X+1, this.Koordinat.Y]))
                        {
                            this.Koordinat = Alan.Harita[this.Koordinat.X+1, this.Koordinat.Y];
                        }
                    }
                    
                    break;
                case 4:
                    if (Alan.sinirKontrol(this))
                    {
                        if (Alan.bosMu(Alan.Harita[this.Koordinat.X - 1, this.Koordinat.Y]))
                        {
                            this.Koordinat = Alan.Harita[this.Koordinat.X - 1, this.Koordinat.Y];
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
                Alan.ates(this, 10);

            }
            else if (5 < rastgele && rastgele <= 8)
            {
                Alan.ates(this, 20);
            }
            else if (8 < rastgele && rastgele <= 10)
            {
                Alan.ates(this, 30);
            }
        }
    }
    
}
