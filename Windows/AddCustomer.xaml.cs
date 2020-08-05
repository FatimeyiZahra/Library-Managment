using Library_Managment.Data;
using Library_Managment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library_Managment.Windows
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        private readonly LibraryContext _context;
        public AddCustomer()
        {
            InitializeComponent();
           _context = new LibraryContext();
            FillCustomer();
        }
        private void Reset()
        {
            TxtCsurname.Clear();
            TxtCusername.Clear();
            TxtCphone.Clear();
            TxtCemail.Clear();
            FillCustomer();
        }
        private void addCustomers_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer
            {
                CustomerName = TxtCusername.Text,
                CustomerSurname = TxtCsurname.Text,
                CustomerEmail = TxtCemail.Text,
                CustomerTelNo = TxtCphone.Text,

            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
            Reset();
            MessageBox.Show("musteri elave edildi");
        }
        private void FillCustomer()
        {
            grdCustomer.ItemsSource = _context.Customers.ToList();
        }
    }
}
