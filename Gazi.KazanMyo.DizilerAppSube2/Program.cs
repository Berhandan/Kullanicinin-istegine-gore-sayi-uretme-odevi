using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.DizilerAppSube2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayının yazılmasını istiyorsunuz?");
            int adet = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[] sayilar = new int[adet];

            for (int i = 0; i < sayilar.Length; i++)
            {
               
                sayilar[i] = rnd.Next(0, 1000000000);
            }

            Array.Sort(sayilar);

             for (int i = 0; i < sayilar.Length; i++)
            {
              Console.WriteLine(sayilar[i]);
            }
            Console.ReadKey();

        }   
    }
}
