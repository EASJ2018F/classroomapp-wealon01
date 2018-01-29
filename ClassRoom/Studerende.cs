using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Studerende
    {
        private string _navn;
        private int _fødselsmåned;
        private int _fødselsdag;

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            _navn = navn;
            _fødselsmåned = fødselsmåned;
            _fødselsdag = fødselsdag;


        }

        public string Navn
        {
            get { return _navn; }
            set { value = _navn; }

        }

        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
            set { value = _fødselsmåned; }
        }


        public int Fødselsdag
        {
            get { return _fødselsdag; }
            set { value = _fødselsdag; }
        }

    




    }
}
