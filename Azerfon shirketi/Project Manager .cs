using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azerfon_shirketi
{
    class Project_Manager
    {
        private string ms_sertifikati;
        public string ad;
        public string soyad;
        public int yas;
        private string yer;
        public string hara
        {
            get { return yer; }
            set
            {
                if (value == "zoom")
                {
                    Console.WriteLine("Saat 12.00-da size zoom ucun mail gonderilecek ");
                }
                else if (value == "ofis")
                {
                    Console.WriteLine("Saat 15.00-da sizi ofisde gozleyirik");
                }
            }

        }

        public string ms
        {
            get { return ms_sertifikati; }
            set
            {
                if (value == "var")
                {
                    Console.WriteLine("Intervyuya qebul olundunuz!");
                }
                else
                {
                    Console.WriteLine("Bu interbyuda istirak ede bilmezsinin!!!");
                }
            }
        }
    }
}
