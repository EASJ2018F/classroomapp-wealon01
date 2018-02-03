using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            KlasseRum kr= new KlasseRum();

            Studerende hassan= new Studerende("Hassan", 07, 09);
            Studerende nikolaj = new Studerende("Nikolaj", 02, 01);
            Studerende kasper = new Studerende("Kasper", 01, 02);


            kr.SemesterStart = DateTime.Parse("28-8-2017");
            kr.KlasseNavn = "3A";

            List<Studerende> elever = new List<Studerende>();
            elever.Add(hassan);
            elever.Add(nikolaj);
            elever.Add(kasper);

            foreach (var studerende in elever)
            {
                Console.WriteLine(studerende);
            }

         


            Console.ReadKey();






        }
    }
}
