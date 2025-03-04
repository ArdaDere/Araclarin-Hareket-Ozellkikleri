using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim_Belirleyiciler_Ve_Degiskenler
{
   
        class Porsche : IAracHareketleri
        {
            public void Git()
            {
                Console.WriteLine("porsche çok hızlı gidiyor");
            }
            public void Yuz()
            {
                Console.WriteLine("porsche suda yüzmez");
            }
            public void Uc()
            {
                Console.WriteLine("porsche havada uçabiliyor");
            }

        }

    }

