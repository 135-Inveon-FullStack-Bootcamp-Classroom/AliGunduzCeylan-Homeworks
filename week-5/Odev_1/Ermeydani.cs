using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Odev_1
{
    class Ermeydani
    {
        Bolge[,] harita = new Bolge[16, 16];

        public Bolge[,] Harita
        {
            get
            {
                return harita;
            }
            set
            {
                harita = value;
            }
        }
        private Takim a, b;
        private StreamWriter yazıcı;
        public  StreamWriter Yazıcı
        {
            get
            {
                return yazıcı;
            }
            set
            {
                yazıcı = value;
            }
        }
        public Takim takım1
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public Takim takim2
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public Ermeydani()
        {
            for(int i = 0; i < 16; i++)
            {
                for (int j =0; j < 16; j++)
                {
                    harita[i, j] = new Bolge(i, j);
                }
            }
        }
        public bool bosMu(Bolge bolge)
        {
            foreach(Asker k in takım1.Birlik)
            {
                if(k.Koordinat==bolge && k.HayattaMı)
                {
                    return false;
                }
            }
            foreach(Asker k in takim2.Birlik)
            {
                if(k.Koordinat==bolge && k.HayattaMı)
                {
                    return false;
                }
            }
            return true;
        }
        public bool sinirKontrol(Asker k)
        {
            if (k.Koordinat.Y <= 0)
            {
                return false;
            }
            else if (k.Koordinat.Y >= 15)
            {
                return false;
            }
            else if (k.Koordinat.X <= 0)
            {
                return false;
            }
            else if (k.Koordinat.X >= 15)
            {
                return false;
            }
            else return true;
        }
        public void ates(Asker k,int vuruş)
        {
            switch (k.Takım)
            {
                case 1:
                    foreach(Asker t in takim2.Birlik)
                    {
                        if ((Math.Abs(t.Koordinat.X - k.Koordinat.X) <= k.Guc && Math.Abs(t.Koordinat.Y - k.Koordinat.Y) <= k.Guc) && t.HayattaMı)
                        {
                            t.Sağlık -= vuruş;
                            if (t.Sağlık <= 0)
                            {
                                t.HayattaMı = false;
                                t.Sağlık = 0;
                                Console.WriteLine(t.Takım + ". takımdaki(" + t.Koordinat.X + ", " + t.Koordinat.Y + ")bölgesindeki asker " + vuruş + " hasar aldı ve öldü");
                                yazıcı.WriteLine(t.Takım + ". takımdaki(" + t.Koordinat.X + ", " + t.Koordinat.Y + ")bölgesindeki asker " + vuruş + " hasar aldı ve öldü");
                                yazıcı.Flush();
                            }
                            else
                            {
                                Console.WriteLine(t.Takım + ". takımındaki(" + t.Koordinat.X + ", " + t.Koordinat.Y + ")bölgesindeki asker " + vuruş + " hasar aldı ve canı " + t.Sağlık+" kaldı");
                                yazıcı.WriteLine(t.Takım + ". takımdaki(" + t.Koordinat.X + ", " + t.Koordinat.Y + ")bölgesindeki asker " + vuruş + " hasar aldı ve öldü"); ;
                                yazıcı.Flush();
                            }
                        }
                    }
                    break;
                case 2:
                    foreach(Asker t in takım1.Birlik)
                    {
                        if ((Math.Abs(t.Koordinat.X - k.Koordinat.X) <= k.Guc && Math.Abs(t.Koordinat.Y - k.Koordinat.Y) <= k.Guc) && t.HayattaMı)
                        {
                            t.Sağlık -= vuruş;
                            if (t.Sağlık <= 0)
                            {
                                t.HayattaMı = false;
                                t.Sağlık = 0;
                                Console.WriteLine(t.Takım + ". takımdaki(" + t.Koordinat.X + ", " + t.Koordinat.Y + ")bölgesindeki asker " + vuruş + " hasar aldı ve öldü");
                                yazıcı.WriteLine(t.Takım + ". takımdaki(" + t.Koordinat.X + ", " + t.Koordinat.Y + ")bölgesindeki asker " + vuruş + " hasar aldı ve öldü");
                                yazıcı.Flush();
                            }
                            else
                            {
                                Console.WriteLine(t.Takım + ". takımındaki(" + t.Koordinat.X + ", " + t.Koordinat.Y + ")bölgesindeki asker " + vuruş + " hasar aldı ve canı " + t.Sağlık+" kaldı");
                                yazıcı.WriteLine(t.Takım + ". takımdaki(" + t.Koordinat.X + ", " + t.Koordinat.Y + ")bölgesindeki asker " + vuruş + " hasar aldı ve öldü"); ;
                                yazıcı.Flush();
                            }
                        }
                    }
                    break;
            }
        }
        public bool tamamMıDevamMı()
        {
            int teamHealt=0;
            foreach(Asker k in takım1.Birlik)
            {
                teamHealt += k.Sağlık;
            }
            if (teamHealt == 0)
            {
                Console.WriteLine("Takım 1 kaybetti");
                Yazıcı.WriteLine("Takım 1 kaybetti");
                Yazıcı.Flush();
                return false;
            }
            teamHealt = 0;
            foreach(Asker k in takim2.Birlik)
            {
                teamHealt += k.Sağlık;
            }
            if (teamHealt == 0)
            {
                Console.WriteLine("Takım 2 kaybetti");
                Yazıcı.WriteLine("Takım 2 kaybetti");
                Yazıcı.Flush();
                return false;
            }
            teamHealt = 0;
            return true;
        }
        
        
        
        

    }
}
