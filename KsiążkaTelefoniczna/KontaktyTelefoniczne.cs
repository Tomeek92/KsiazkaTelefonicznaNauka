using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiążkaTelefoniczna
{
    public class KontaktyTelefoniczne 
    {
        public string _imie;
        public string _nazwisko;
        public string _nrTel;

        public KontaktyTelefoniczne(string imie,string nazwisko,string nrTel)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            nrTel = _nrTel;
        }
        public override string ToString()=> $"Imię: {_imie}\nNazwisko: {_nazwisko}\nNrTel: {_nrTel}";

    }
}
