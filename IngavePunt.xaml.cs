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
    /// Interaction logic for IngavePunt.xaml
    /// </summary>
    public partial class IngavePunt : Window
    {
        List<string> Testen = new List<string>();
        List<Test> TempList3;
        List<string> Klassen = new List<string>();
        List<Klas> TempList;
        List<string> Leerlingen = new List<string>();
        List<Leerling> TempList1;
        List<string> Vakken = new List<string>();
        List<Vak> TempList2;
        public IngavePunt()
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
            using (Repos rep = new Repos())
            {
                TempList1 = rep.Leerlingen();
                foreach (Leerling l in TempList1)
                {
                    Leerlingen.Add(l.Naam);
                }
            }
            using (Repos rep = new Repos())
            {
                TempList2 = rep.Vakken();
                foreach (Vak v in TempList2)
                {
                    Vakken.Add(v.Naam);
                }
            }
            using (Repos rep = new Repos())
            {
                TempList3 = rep.Testen();
                foreach (Test t in TempList3)
                {
                    Testen.Add(t.TestNaam);
                }
            }
            Cb1.ItemsSource = Klassen;
            Cb2.ItemsSource = Leerlingen;
            Cb3.ItemsSource = Vakken;
            Cb4.ItemsSource = Testen;
        }

        private void UitvoerenPunt_Click(object sender, RoutedEventArgs e)
        {
            using (Repos rep = new Repos())
            {
                int result;
                Resultaat resultaat = new Resultaat() { Result = Int32.Parse(Resultaat1.Text), Leerling = rep.VindLeerling(TempList1[Cb2.SelectedIndex])};

                rep.ToevoegenR(resultaat, TempList3[Cb4.SelectedIndex]);
            }

            MessageBox.Show("Resultaat toegevoegd.");

        }

        private void TerugkerenILN_Click(object sender, RoutedEventArgs e)
        {
            { this.Close(); }
        }
    }
}
