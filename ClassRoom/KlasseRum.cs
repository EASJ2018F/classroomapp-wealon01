using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class KlasseRum
    {
        
        private string _klasseNavn;
        private DateTime _semesterStart;
        private List<Studerende> _klasseListe;


        public string KlasseNavn
        {
            get { return _klasseNavn; }
            set { _klasseNavn=value; }
        }

        public DateTime SemesterStart
        {
            get { return _semesterStart; }
            set { _semesterStart=value; }
        }

             public List<Studerende> KlasseListe
        {
            get { return _klasseListe; }
            set { _klasseListe=value; }
        }

        



        public override string ToString()
        {
            return $"{KlasseNavn} {SemesterStart} {KlasseListe}";
        }
    
    }
}
