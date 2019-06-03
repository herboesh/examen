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
    /// Interaction logic for AanmakenDSLN.xaml
    /// </summary>
    public partial class AanmaakDSLN : Window
    {
        List<string> Klassen = new List<string>();
        List<Klas> TempList;
        public AanmaakDSLN()
        {
            InitializeComponent();

            using (Repos rep = new Repos())
            {
                TempList = rep.Klassen();
                foreach (Klas k in TempList)
                {
                    Klassen.Add(k.Naam);
                }
            }
            KlasLN.ItemsSource = Klassen;

        }

        private void AanmakenLN_Click(object sender, RoutedEventArgs e)
        {
            using (Repos rep = new Repos())
            {
                Klas klas = rep.PakKlas(TempList[KlasLN.SelectedIndex]);

                rep.ToevoegenLN(new Leerling() { Naam = NaamLN.Text, Geslacht = ((ComboBoxItem)GeslachtLN.SelectedValue).Content.ToString(), Geboortedatum = (DateTime)GdLN.SelectedDate, Opmerking = new List<Opmerking>() { new Opmerking() { Tekst = OpmerkingenLN.Text } }, Rijksregister = RrLN.Text, Adres = AdresLN.Text, TelOuders = TelLN.Text }, klas);
            }
            MessageBox.Show("Leerling toegevoegd.");
        }

        private void TerugkerenLN_Click(object sender, RoutedEventArgs e)
        {
            { this.Close(); }
        }
    }
}
