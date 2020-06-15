using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    //component
    public abstract class Kolokwium
    {
        public abstract decimal Ocena();
    }

    //concrete components
    class MojKolokwium : Kolokwium
    {
        public override decimal Ocena()
        {
            return 1M;
        }
    }

    //dekorator
    abstract class KolokwiumzZadaniami : Kolokwium
    {
        protected Kolokwium kolokwium;

        public KolokwiumzZadaniami(Kolokwium kolokwium)
        {
            this.kolokwium = kolokwium;
        }
    }

    class KolokwiumzZadanie1 : KolokwiumzZadaniami
    {
        public KolokwiumzZadanie1(Kolokwium kolokwium)
            : base(kolokwium)
        { }

        public override decimal Ocena()
        {
            return kolokwium.Ocena() + 1M;
        }
    }

    class KolokwiumzZadanie2 : KolokwiumzZadaniami
    {
        public KolokwiumzZadanie2(Kolokwium kolokwium)
            : base(kolokwium)
        { }

        public override decimal Ocena()
        {
            return kolokwium.Ocena() + 1M;
        }
    }
    class KolokwiumzZadanie3 : KolokwiumzZadaniami
    {
        public KolokwiumzZadanie3(Kolokwium kolokwium)
            : base(kolokwium)
        { }

        public override decimal Ocena()
        {
            return kolokwium.Ocena() + 1M;
        }
    }


}
