using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            KlasseRum Kr= new KlasseRum();

            Kr.KlasseNavn = "3A";
            Kr.SemesterStart = new DateTime(28-8-2017);

            Studerende Hassan= new Studerende("Hassan", 07, 09);
            Studerende Nikolaj = new Studerende("Nikolaj", 02, 01);
            Studerende Kasper = new Studerende("Kasper", 01, 02);




        }
    }
}
