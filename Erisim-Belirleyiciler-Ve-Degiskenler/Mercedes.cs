using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim_Belirleyiciler_Ve_Degiskenler
{
   
    
         class Mercedes : IAracHareketleri
        {
            public void Git()
            {
                Console.WriteLine("mercedes çok hızlı gidiyor");
            }
            public void Yuz()
            {
                Console.WriteLine("mercedes suda yüzebiliyor");
            }
            public void Uc()
            {
                Console.WriteLine("mercedes havada uçabiliyor");
            }

        }
    }
