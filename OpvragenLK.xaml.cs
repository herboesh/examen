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
    /// Interaction logic for OpvragenLK.xaml
    /// </summary>
    public partial class OpvragenLK : Window
    {
        List<Leerkracht> Leerkrachten;
        public OpvragenLK()
        {
            InitializeComponent();

            using (Repos rep = new Repos())
            {
                Leerkrachten = rep.VindLeerkrachten();
                GridLK.ItemsSource = Leerkrachten;

            }
        }

        private void TkLK_Click(object sender, RoutedEventArgs e)
        {
            { this.Close(); }
        }

        private void VerwijderenLK_Click(object sender, RoutedEventArgs e)
        {
            using (Repos rep = new Repos())
            {
                Leerkracht l = (Leerkracht)GridLK.SelectedItem;
                rep.VerwijderenLK(l);
            }
            MessageBox.Show("Leerkracht verwijderd.");
        }
    }
}
