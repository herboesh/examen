using OpvolgingLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Opvolging
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //hardcoded directie en 3-4 secretariaat nodig die dan accounts kunnen aanmaken voor leerkrachten en dan linken met juiste scherm
        //voor leerkrachten ook direct linken aan juiste scherm.
        //Gebruiker user = new Gebruiker() { GebruikersNaam = "Directeur", Wachtwoord = "Directeur", Functie = "Directie" };
        //Gebruiker user1 = new Gebruiker() { GebruikersNaam = "Secretariaat", Wachtwoord = "Secretariaat", Functie = "Secretariaat" };
        //Gebruiker user2 = new Gebruiker() { GebruikersNaam = "Secretariaat1", Wachtwoord = "Secretariaat1", Functie = "Secretariaat" };
        //Gebruiker user3 = new Gebruiker() { GebruikersNaam = "Secretariaat2", Wachtwoord = "Secretariaat2", Functie = "Secretariaat" };
        //Gebruiker user4 = new Gebruiker() { GebruikersNaam = "Secretariaat3", Wachtwoord = "Secretariaat3", Functie = "Secretariaat" };
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Aanmelden_Click(object sender, RoutedEventArgs e)
        {
            using (Repos rep = new Repos())
            {
                //rep.ToevoegenG(user);
                //rep.ToevoegenG(user1);
                //rep.ToevoegenG(user2);
                //rep.ToevoegenG(user3);
                //rep.ToevoegenG(user4);

                Gebruiker gebruiker = rep.PakGebruiker(Gebruikersnaam.Text, Wachtwoord.Text);
                if (gebruiker != null)
                {
                    if (gebruiker.Functie == "Directie")
                    {
                        DirSec win = new DirSec();
                        win.ShowDialog();
                    }
                    else if (gebruiker.Functie == "Secretariaat")
                    {
                        DirSec win = new DirSec();
                        win.ShowDialog();
                    }
                    else 
                    {
                        KeuzeDSLKLN win = new KeuzeDSLKLN();
                        win.ShowDialog();
                    }
                } else
                {
                    MessageBox.Show("Fout Gebruikersnaam of Wachtwoord", "Foutmelding.");
                }
            }
        }
    }
}
