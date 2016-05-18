using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace SQLDemoSovellusB
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

        private void btnTiedot_Click(object sender, RoutedEventArgs e)
        {
            string connStr = "Server=WIN-TSG39S9NORT\\SQLEXJUHASO;Database=northwind;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(connStr);

            string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string companyName = reader.GetString(1);
                string contactName = reader.GetString(2);
                MessageBox.Show("Löytyi rivi: " + companyName + " " + contactName);
            }
            reader.Close();
            cmd.Dispose();
            conn.Dispose();
        }
    }
}
