using System;
using System.Collections.Generic;
using System.Data;
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
            set { value = _klasseNavn; }
        }

        public DateTime SemesterStart
        {
            get { return _semesterStart; }
            set { value = _semesterStart; }
        }

             public List<Studerende> KlasseListe
        {
            get { return _klasseListe; }
            set { value = _klasseListe; }
        }





    }
}
