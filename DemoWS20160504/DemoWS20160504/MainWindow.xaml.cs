﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoWS20160504
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLuoAutot_Click(object sender, RoutedEventArgs e)
        {
            Car Auto1 = new Car();
            Auto1.Merkki = "Ford";
            Auto1.Malli = "Galaxy";
            Auto1.MaxSpeed = 200;

            Car Auto2 = new Car();
            Auto2.Merkki = "Ford";
            Auto2.Malli = "Mustang";
            Auto2.MaxSpeed = 300;

        }
    }
}
