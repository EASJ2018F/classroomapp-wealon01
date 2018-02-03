using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            KlasseRum kr= new KlasseRum();
        
            Studerende hassan= new Studerende("Hassan", 7, 09);
            Studerende nikolaj = new Studerende("Nikolaj", 2, 01);
            Studerende kasper = new Studerende("Kasper", 1, 02);
        
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
                where Studerende.Fødselsmåned == 1||Studerende.Fødselsmåned==2||Studerende.Fødselsmåned==3
                select Studerende.Navn).Count();

            var forår = (from Studerende in kr._klasseListe
                where Studerende.Fødselsmåned == 4 || Studerende.Fødselsmåned == 5 || Studerende.Fødselsmåned == 6
                select Studerende.Navn).Count();

            var sommer = (from Studerende in kr._klasseListe
                where Studerende.Fødselsmåned == 7 || Studerende.Fødselsmåned == 8 || Studerende.Fødselsmåned == 9
                select Studerende.Navn).Count();

            var efterår = (from Studerende in kr._klasseListe
                where Studerende.Fødselsmåned == 4 || Studerende.Fødselsmåned == 5 || Studerende.Fødselsmåned == 6
                select Studerende.Navn).Count();

            var forkertmåned = (from Studerende in kr._klasseListe
                where Studerende.Fødselsmåned <0 || Studerende.Fødselsmåned >12
                select Studerende.Navn).Count();

            Console.WriteLine(vinter+" har fødseldag i vinter");
            Console.WriteLine(forår + " har fødseldag i forår");
            Console.WriteLine(sommer + " har fødseldag i sommer");
            Console.WriteLine(efterår + " har fødseldag i efterår");
            Console.WriteLine(forkertmåned + " studerende har valg en forket måned ude for intervallet 1-12");

            Console.ReadKey();

        }
    }
}
