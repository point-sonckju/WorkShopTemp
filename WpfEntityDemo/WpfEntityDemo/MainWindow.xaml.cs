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
            var finnishCustomers = from c in entities.Customers
                                   where c.Country == "Finland"
                                   select c;
            //var data new CustRow { sarake1 = "sarake1", sarake2 = "sarake2", sarake3 = "sarake3" };
            foreach (var cust in finnishCustomers)
            {
                MessageBox.Show(cust.CompanyName + " " + cust.ContactName + " " + cust.Address);
                //dgCustomers.Items.Add(data);
                //dgCustomers.Items.Add(new { sarake1 = "sarake1", sarake2 = "sarake2", sarake3 = "sarake3" });
            }


        }
    }
}
