﻿using OpvolgingLib;
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

    public partial class OpvragenResultaat : Window
    {
        List<Resultaat> Result;
        public OpvragenResultaat()
        {
            InitializeComponent();
            using (Repos rep = new Repos())
            {
                Result = rep.VindResultaten();
                GridLNR.ItemsSource = Result;

            }
        }

        private void TkLN_Click(object sender, RoutedEventArgs e)
        {
            { this.Close(); }
        }
    }
}
