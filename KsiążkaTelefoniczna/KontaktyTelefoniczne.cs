using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

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
        public override string ToString() => $"Imię: {_imie}\nNazwisko: {_nazwisko}\nNrTel: {_nrTel}";

        public void Sprawdzanie(string imie, string nazwisko, string nrTel)
        {
            if (imie == null || nazwisko == null || nrTel == null)
            {
                MessageBox.Show("Pola nie mogą być puste!!");
            }
            else if (imie.Length < 3 || nazwisko.Length < 3 || nrTel.Length < 3)
            {
                MessageBox.Show("Proszę wprowadzić co najmniej 3 znaki dla każdego pola.");
            }
            
        }

        
    }




}
