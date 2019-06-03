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
    /// Interaction logic for OpvragenOpmerking.xaml
    /// </summary>
    public partial class OpvragenOpmerking : Window
    {
        Leerling leerling;
        public OpvragenOpmerking(Leerling l)
        {
            InitializeComponent();
            leerling = l;
            using (Repos rep = new Repos())
            {
                List<Opmerking> opm = rep.VindOpmerking(leerling);
                GridO.ItemsSource = opm;

            }
        }

        private void TkLK_Click(object sender, RoutedEventArgs e)
        {
            { this.Close(); }
        }
    }
}
