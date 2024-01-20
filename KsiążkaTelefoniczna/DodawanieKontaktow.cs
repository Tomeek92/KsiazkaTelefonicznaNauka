using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiążkaTelefoniczna
{
    public class DodawanieKontaktow
    {
        private KontaktyTelefoniczne _kontakty; //stworzenie prywatnego pola _kontakty typu KontaktyTelefoniczne

        public DodawanieKontaktow(string name, string nazwisko, string nrTel) //tworzenie konstruktora 
        {
            _kontakty = new KontaktyTelefoniczne(name, nazwisko, nrTel); //tworzenie nowej instancji KontaktyTelefoniczne i przypisuje ja do pola _kontakty
        }
        public void ZapiszDane(string daneUzytkownika)
        {
            string[] dane = daneUzytkownika.Split(' '); // Rozdziela dane wprowadzone przez użytkownika na podstawie spacji
            if (dane.Length == 3) // Sprawdza, czy użytkownik wprowadził trzy elementy (imie, nazwisko, nr telefonu)
            {
                _kontakty = new KontaktyTelefoniczne(dane[0], dane[1], dane[2]);
            }
        }
       
    }
}
