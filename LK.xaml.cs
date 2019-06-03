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
    /// Interaction logic for LK.xaml
    /// </summary>
    public partial class KeuzeDSLKLN : Window
    {
        public KeuzeDSLKLN()
        {
            InitializeComponent();
        }

        private void LKingaveVolgende_Click(object sender, RoutedEventArgs e)
        {
            IngavePunt win = new IngavePunt();
            win.ShowDialog();
        }

        private void LKopvragenVolgende_Click(object sender, RoutedEventArgs e)
        {
            OpvragenResultaat win = new OpvragenResultaat();
            win.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ToevoegenTest win = new ToevoegenTest();
            win.ShowDialog();
        }
    }
}
