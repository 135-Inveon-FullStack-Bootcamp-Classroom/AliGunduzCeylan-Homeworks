using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Odev_1
{
    class Takim
    {
        Asker[] birlik = new Asker[7];
        
        public Asker[] Birlik { get { return birlik; } set { birlik = value; } }
        public Takim(int takim,Ermeydani alan,StreamWriter yazıcı)
        {
            int i;
            if (takim == 1)
            {
                for(i=0 ; i < 4; i++)
                {
                    birlik[i] = new Er(takim, alan.Harita[i,0]);
                }
                birlik[4] = new Tegmen(takim, alan.Harita[4, 0]);
                birlik[5] = new Tegmen(takim, alan.Harita[5, 0]);
                birlik[6] = new Yuzbasi(takim, alan.Harita[6, 0]);
                for(i=0 ; i < birlik.Length; i++)
                {
                    birlik[i].Alan = alan;
                    birlik[i].Yazıcı = yazıcı;
                }
            }
            else
            {
                for(i = 0; i < 4; i++)
                {
                    birlik[i] = new Er(takim, alan.Harita[i, 15]);
                }
                birlik[4] = new Tegmen(takim, alan.Harita[4, 15]);
                birlik[5] = new Tegmen(takim, alan.Harita[5, 15]);
                birlik[6] = new Yuzbasi(takim, alan.Harita[6, 15]);
                for(i=0 ; i < birlik.Length; i++)
                {
                    birlik[i].Alan = alan;
                    birlik[i].Yazıcı = yazıcı;
                }
            }
        }
        
    }
}
