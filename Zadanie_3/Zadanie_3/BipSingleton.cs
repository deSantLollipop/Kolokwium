using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class BipSingleton
    {
        private static BipSingleton instancja;

        private BipSingleton() { } //ukryty konstruktor

        public static BipSingleton Instancja
        {
            get
            {
                if (instancja == null)
                    instancja = new BipSingleton();
                return instancja;
            }
        }

        private const string bipString = " BIP BIP ";
        
        public void BipBip()
        {
            Console.WriteLine(bipString);
        }
        

    }
}
