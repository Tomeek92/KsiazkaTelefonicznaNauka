using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiążkaTelefoniczna
{
    public class KontaktyTelefoniczne 
    {
        private string _imie;
        private string _nazwisko;
        private string _nrTel;

        public KontaktyTelefoniczne(string imie,string nazwisko,string nrTel)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            nrTel = _nrTel;
        }
        public override string ToString()=> $"Imię: {_imie}\nNazwisko: {_nazwisko}\nNrTel: {_nrTel}";

    }
}
