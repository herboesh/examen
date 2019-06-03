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
using System.Windows.Threading;

namespace Opvolging
{
    /// <summary>
    /// Interaction logic for OpvragenDSLN.xaml
    /// </summary>
    public partial class OpvragenDSLN : Window
    {
        List<Leerling> Leerlingen;

        public OpvragenDSLN()
        {
            InitializeComponent();

            using (Repos rep = new Repos())
            {
                Leerlingen = rep.VindLeerlingen();
                GridLN.ItemsSource = Leerlingen;
            }
        }



        /*public Leerling Leerling()
        {
            using (Repos repo = new Repos())
            {
                GridLN.ItemsSource = repo.VindLeerlingen();

            }
        }*/

        private void TkLN_Click(object sender, RoutedEventArgs e)
        {
            { this.Close(); }
        }

        private void VerwijderenLN_Click(object sender, RoutedEventArgs e)
        {
            using (Repos rep = new Repos())
            {
                Leerling l = (Leerling)GridLN.SelectedItem;
                rep.VerwijderenLN(l);
            }
           

                MessageBox.Show("Leerling verwijderd.");
        }

        private void OpvragenOpmerking(object sender, MouseButtonEventArgs e)
        {
            if( GridLN.SelectedItem is Leerling l)
            {
                OpvragenOpmerking win = new OpvragenOpmerking(l);
                win.ShowDialog();
            }

        }
    }
}
