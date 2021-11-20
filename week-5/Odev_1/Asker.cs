using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Odev_1
{
    abstract class Asker
    {
        private Bolge koordinat;
        private bool hayattaMı = true;//askerin hayatta olup olmadığını kontrol eden bool
        private int takım;//hangi takımda olduğunu tutuan string
        private int sağlık = 100;//ne kadar canının kaldığını tutan integer
        private int guc;
        private StreamWriter yazıcı;
        private Ermeydani ermeydani;
        public StreamWriter Yazıcı
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
        public Asker(int guc,int takım)
        {
            this.guc = guc;
            this.takım = takım;
        }
        public bool HayattaMı
        {
            get
            {
                return hayattaMı;
            }
            set
            {
                hayattaMı = value;
            }
        }
        public int Sağlık
        {
            get
            {
                return sağlık;
            }
            set
            {
                sağlık = value;
            }
        }
        public int Guc
        {
            get
            {
                return guc;
            }
        }
        public int Takım
        {
            get
            {
                return takım;
            }
        }
        public Bolge Koordinat
        {
            get
            {
                return koordinat;
            }
            set
            {
                koordinat = value;
            }
        }
        public Ermeydani Alan
        {
            get
            {
                return ermeydani;
            }
            set
            {
                ermeydani = value;  
            }
        }
        public abstract void HaraketEt();
        public abstract void Bekle();
        public abstract void AtesEt();
        
    }
}
