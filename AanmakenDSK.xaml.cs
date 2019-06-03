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
    /// Interaction logic for AanmakenDSK.xaml
    /// </summary>
    public partial class AanmakenDSK : Window
    {
        public AanmakenDSK()
        {
            InitializeComponent();
        }

        private void VolgendeK_Click_1(object sender, RoutedEventArgs e)
        {
            using (Repos rep = new Repos())
            {
                rep.ToevoegenK(new Klas() { Naam = KlasNaam.Text });
            }

            MessageBox.Show("Klas toegevoegd.");
        }

        private void TerugkerenK_Click(object sender, RoutedEventArgs e)
        {
            { this.Close(); }
        }
    }
}
