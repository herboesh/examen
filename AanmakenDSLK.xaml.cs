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
using System.Windows.Shapes;

namespace Opvolging
{
    /// <summary>
    /// Interaction logic for AanmakenDSLK.xaml
    /// </summary>
    public partial class AanmakenDSLK : Window
    {
        public AanmakenDSLK()
        {
            InitializeComponent();
        }
        private void AanmakenLK_Click(object sender, RoutedEventArgs e)
        {
            using (Repos rep = new Repos())
            {
                //rep.ToevoegenLK(new Leerkracht { Naam = NaamLK.Text, Geslacht = ((ComboBoxItem)GeslachtLK.SelectedValue).Content.ToString(), Geboortedatum = (DateTime)GdLK.SelectedDate, Rijksregister = RrLK.Text, Adres = AdresLK.Text, Tel = TelLK.Text });

                rep.ToevoegenG(new Gebruiker() { GebruikersNaam = GnLK.Text, Wachtwoord = WwLK.Text, Leerkracht = new Leerkracht() { Naam = NaamLK.Text, Geslacht = ((ComboBoxItem)GeslachtLK.SelectedValue).Content.ToString(), Geboortedatum = (DateTime)GdLK.SelectedDate, Rijksregister = RrLK.Text, Adres = AdresLK.Text, Tel = TelLK.Text } });


                MessageBox.Show("Leerkracht toegevoegd.");
            }
        }

        private void TerugkerenLK_Click(object sender, RoutedEventArgs e)
        {
            { this.Close(); }
        }
    }
}
