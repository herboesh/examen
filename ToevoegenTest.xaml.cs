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
    /// Interaction logic for ToevoegenTest.xaml
    /// </summary>
    public partial class ToevoegenTest : Window
    {
        List<string> Klassen = new List<string>();
        List<Klas> TempList;
        List<string> Vakken = new List<string>();
        List<Vak> TempList1;
        public ToevoegenTest()
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
            Cbt.ItemsSource = Klassen;

            //Vakken pas in combobox nadat klas ingegeven is. ( nog doen bij ingavepunten scherm. ) een klas linken aan vak , op wpf scherm knop bijmaken van welke klas je vakken en leerkrachten toevoegd.
        }
        private void Cbt2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (Repos rep = new Repos())
            {
                TempList1 = rep.Vakken();
                foreach (Vak v in TempList1)
                {
                    Vakken.Add(v.Naam);
                }

            }
            Cbt2.ItemsSource = Vakken;
        }

        private void VolgendeK_Click_1(object sender, RoutedEventArgs e)
        {
            using (Repos rep = new Repos())
            {
                rep.ToevoegenT(new Test() { TestNaam = Testnaam.Text });
            }

            MessageBox.Show("Test toegevoegd.");
        }

        private void TerugkerenK_Click(object sender, RoutedEventArgs e)
        {
            { this.Close(); }
        }
    }
}
