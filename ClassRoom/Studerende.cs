using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Studerende
    {
        private int _fødselsmåned;
        private int _fødselsdag;
        private string _årstid;

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            _fødselsmåned = fødselsmåned;
            _fødselsdag = fødselsdag;
        }

        public string Navn { get; set; }

        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
            set { _fødselsmåned= value; }
        }


        public int Fødselsdag
        {
            get { return _fødselsdag; }
            set { _fødselsdag= value; }

        }

        public string Årstid
        {
            get { return _årstid; }
            set { _årstid = value; }

        }


        public string findårstid()
        {
            if (Fødselsmåned == 12 || Fødselsmåned == 1 || Fødselsmåned == 2)
            {
                Årstid = "Vinter";
          
            }

            else if (Fødselsmåned == 3 || Fødselsmåned == 4 || Fødselsmåned == 5)
            {
                Årstid = "Forår";
       
            }

            else if (Fødselsmåned == 6 || Fødselsmåned == 7 || Fødselsmåned == 8)
            {
                Årstid = "Sommer";
             
            }

            else if (Fødselsmåned == 9 || Fødselsmåned == 10 || Fødselsmåned == 11)
            {
                Årstid = "Efterår";
                
            }

            return Årstid;
        }





        public override string ToString()
        {
            return $"{Navn} {Fødselsdag} {Fødselsmåned}";
        }
    }
}
