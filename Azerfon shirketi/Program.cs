using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azerfon_shirketi
{
    class Program
    {
        static void Main(string[] args)
        {
            Software_Developer ilk = new Software_Developer();
            ilk.ad = "Samir";
            ilk.soyad = "Kerimov";
            ilk.yas = 30;
         

            Console.WriteLine("Vakansiya ucun bas vuran adamin ad:"+ilk.ad);
            Console.WriteLine("Vakansiya ucun bas vuran adamin soyadi:" + ilk.soyad);
            Console.WriteLine("Vakansiya ucun bas vuran adamin yasi:" + ilk.yas);
            
            ilk.ms = "yox";
            
            ilk.hara = "ofis";
            Console.ReadLine();

        }
    }
}
