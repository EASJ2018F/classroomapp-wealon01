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
        
            kr._klasseListe.Add(hassan);
            kr.KlasseListe.Add(nikolaj);
            kr.KlasseListe.Add(kasper);

            kr.SemesterStart = DateTime.Parse("28-8-2017");
            kr.KlasseNavn = "3A";


            foreach (var studerende in kr._klasseListe)
            {
                Console.WriteLine(studerende);
            }


            var vinter = (from Studerende in kr._klasseListe
                where Studerende.Fødselsmåned == 01||Studerende.Fødselsmåned==02||Studerende.Fødselsmåned==03
                select Studerende.Navn).Count();

            var forår = (from Studerende in kr._klasseListe
                where Studerende.Fødselsmåned == 04 || Studerende.Fødselsmåned == 05 || Studerende.Fødselsmåned == 06
                select Studerende.Navn).Count();

            var sommer = (from Studerende in kr._klasseListe
                where Studerende.Fødselsmåned == 07 || Studerende.Fødselsmåned == 08 || Studerende.Fødselsmåned == 09
                select Studerende.Navn).Count();

            var efterår = (from Studerende in kr._klasseListe
                where Studerende.Fødselsmåned == 04 || Studerende.Fødselsmåned == 05 || Studerende.Fødselsmåned == 06
                select Studerende.Navn).Count();

            Console.WriteLine(vinter+" har fødseldag i vinter");
            Console.WriteLine(forår + " har fødseldag i forår");
            Console.WriteLine(sommer + " har fødseldag i sommer");
            Console.WriteLine(efterår + " har fødseldag i efterår");


            Console.ReadKey();

        }
    }
}
