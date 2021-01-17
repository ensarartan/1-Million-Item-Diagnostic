using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[1000000];

            DateTime ilk = DateTime.Now;
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = i;
            }
            DateTime son = DateTime.Now;
            Console.WriteLine("Dizi Başlatma süresi: " + Convert.ToString(son - ilk));
            Console.WriteLine("******************************************************\n");

            ilk = DateTime.Now;
            for (int i = 999999; i > 0; i--)
            {
                sayilar[i] = sayilar[i - 1];
            }

            sayilar[0] = -1;

            son = DateTime.Now;

            Console.WriteLine("1. nesne ekleme süresi: " + Convert.ToString(son - ilk));

            ilk = DateTime.Now;
            for (int i = 0; i < 999999; i++)
            {
                sayilar[i] = sayilar[i + 1];
            }
            son = DateTime.Now;
            Console.WriteLine("1. nesne çıkarma süresi: " + Convert.ToString(son - ilk));
            Console.WriteLine("******************************************************\n");

            ilk = DateTime.Now;
            for (int i = 999999; i > 500000; i--)
            {
                sayilar[i] = sayilar[i - 1];
            }
            sayilar[500000] = -1;

            son = DateTime.Now;

            Console.WriteLine("ortaya ekleme  süresi: " + Convert.ToString(son - ilk));

            ilk = DateTime.Now;
            for (int i = 500000; i < 999999; i++)
            {
                sayilar[i] = sayilar[i + 1];
            }
            son = DateTime.Now;
            Console.WriteLine("Ortadan çıkarma süresi: " + Convert.ToString(son - ilk));
            Console.WriteLine("******************************************************\n");
            ilk = DateTime.Now;

           
            ilk = DateTime.Now;
            Array.Resize(ref sayilar, sayilar.Length + 1);
            son = DateTime.Now;
            Console.WriteLine("Son nesne ekleme süresi: " + Convert.ToString(son - ilk));
           
            ilk = DateTime.Now;
            Array.Resize(ref sayilar, sayilar.Length - 1);
            son = DateTime.Now;
            Console.WriteLine("Son nesne çıkarma süresi: " + Convert.ToString(son - ilk));
            
            Console.ReadLine();
        }
    }
}
