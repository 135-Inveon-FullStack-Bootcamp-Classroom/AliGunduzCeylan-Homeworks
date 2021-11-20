using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\logs.txt";
            FileStream file = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter yazıcı = new StreamWriter(file);
            yazıcı.WriteLine("savas logları");
            Ermeydani ermeydani = new Ermeydani();
            Takim takim1 = new Takim(1, ermeydani, yazıcı);
            Takim takim2 = new Takim(2, ermeydani, yazıcı);
            ermeydani.Yazıcı = yazıcı;
            ermeydani.takım1 = takim1;
            ermeydani.takim2 = takim2;
            yazıcı.Flush();
            Random r = new Random();
            int karar, sıra = 0, taş;
            while (ermeydani.tamamMıDevamMı())
            {
                karar = r.Next(1, 3);
                taş = r.Next(0, 7);
                if (sıra % 2 == 0)
                {
                    if (takim1.Birlik[taş].HayattaMı)
                    {
                        if (karar == 1)
                        {
                            takim1.Birlik[taş].HaraketEt();
                        }
                        else
                        {
                            takim1.Birlik[taş].AtesEt();
                        }
                        sıra++;
                    }
                    else
                    {
                        if (!ermeydani.tamamMıDevamMı()) break;
                    }
                }

            }
            yazıcı.Close();
            file.Close();
            Console.ReadKey();
            

        }
    }
}
