using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KsiążkaTelefoniczna
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            KontaktyTelefoniczne kontakty = new KontaktyTelefoniczne(" ", " ", " ");
            TextBox2.Text = kontakty.ToString();
            TextBox2.FontFamily = new FontFamily("Arial");
            TextBox2.FontSize = 24;


            DodawanieKontaktow nowyKontakt = new DodawanieKontaktow(" ", " ", " ");
            nowyKontakt.ZapiszDane(TextBox2.Text);




        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string kontakt = TextBox2.Text;

            TextBox1.Text += kontakt + "\n" + "\n";
            TextBox1.FontFamily = new FontFamily("Arial");
            TextBox1.FontSize = 24;

            TextBox2.Text = "Imię:\nNazwisko:\nNrTel:";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {



            Random rand = new Random();
            byte r = (byte)rand.Next(256);
            byte g = (byte)rand.Next(256);
            byte b = (byte)rand.Next(256);
            Color randomColor = Color.FromRgb(r, g, b);

            // Zmień kolor czcionki TextBox2 na losowy kolor
            TextBox2.Foreground = new SolidColorBrush(randomColor);
        }




        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            TextBox1.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {


        }
    }
}

    





