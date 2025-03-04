using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim_Belirleyiciler_Ve_Degiskenler
{
     class Bmw :IAracHareketleri
    {
        public void Git()
        {
            Console.WriteLine("bmw çok hızlı gidiyor");
        }
        public void Yuz()
        {
            Console.WriteLine("bmw suda yüzebiliyor");
        }
        public void Uc()
        {
            Console.WriteLine("Bmw havada uçabiliyor");
        }

    }
}
