using System.Text;
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
            
            KontaktyTelefoniczne kontakty = new KontaktyTelefoniczne(" "," "," ");
            TextBox2.Text = kontakty.ToString();
            DodawanieKontaktow nowyKontakt = new DodawanieKontaktow(" "," "," ");
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

                TextBox1.Text += kontakt + "\n"+ "\n";

                TextBox2.Text = "Imię:\nNazwisko:\nNrTel:";
             }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox2.Text = "Imię:\nNazwisko:\nNrTel:";
        }
    }
        
    
}