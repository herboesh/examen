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
    /// Interaction logic for DirSec.xaml
    /// </summary>
    public partial class DirSec : Window
    {
        public DirSec()
        {
            InitializeComponent();
        }

        private void AmLK_Click(object sender, RoutedEventArgs e)
        {
            AanmakenDSLK win = new AanmakenDSLK();
            win.ShowDialog();
        }

        private void AmLN_Click(object sender, RoutedEventArgs e)
        {
            AanmaakDSLN win = new AanmaakDSLN();
            win.ShowDialog();
        }

        private void AmK_Click(object sender, RoutedEventArgs e)
        {
            AanmakenDSK win = new AanmakenDSK();
            win.ShowDialog();
        }

        private void AmV_Click(object sender, RoutedEventArgs e)
        {
            AanmakenDSV win = new AanmakenDSV();
            win.ShowDialog();
        }

        private void OLK_Click(object sender, RoutedEventArgs e)
        {
            OpvragenLK win = new OpvragenLK();
            win.ShowDialog();
        }

        private void OLN_Click(object sender, RoutedEventArgs e)
        {
            OpvragenDSLN win = new OpvragenDSLN();
            win.ShowDialog();
        }

        private void OPunt_Click(object sender, RoutedEventArgs e)
        {
            OpvragenResultaat win = new OpvragenResultaat();
            win.ShowDialog();
        }
    }
}
