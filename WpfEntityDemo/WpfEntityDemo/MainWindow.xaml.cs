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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEntityDemo
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

        private void btnHae_Click(object sender, RoutedEventArgs e)
        {
            northwindEntities entities = new northwindEntities();
            var finnishCustomers = from fff in entities.Customers
                                   where fff.Country == "Finland"
                                   select fff;

            foreach (var cust in finnishCustomers)
            {
                MessageBox.Show(cust.CompanyName + " " + cust.ContactName + " " + cust.Address + " " + cust.Country );

            }


        }

        private void btnHaeLista_Click(object sender, RoutedEventArgs e)
        {
            string[] numerot = { "3","6", "100","1","8","9","12","66","44"};

            var suuretnumerot = from n in numerot
                              orderby n
                              select n;
            int laskuri = 0;
            foreach (var pöllö in suuretnumerot)
            {
                MessageBox.Show(pöllö.ToString());
               // laskuri = laskuri + int.Parse(numero);
               // MessageBox.Show(laskuri.ToString());
            }
        }
    }
}
