using Library_Managment.Data;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for HomePageWindow.xaml
    /// </summary>
    public partial class HomePageWindow : Window
    {
        public HomePageWindow()
        {
            InitializeComponent();
        }


        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            btnDashboard.Margin = new Thickness(20, 35, 19, 517);
            dbcontent.Visibility = Visibility.Visible;
            addBook.Visibility = Visibility.Hidden;
          
        }

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            btnDashboard.Margin = new Thickness(20, 135, 20, 400);
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();  
            dbcontent.Visibility = Visibility.Hidden;
            addBook.Visibility = Visibility.Hidden;

        }

        private void books_Click(object sender, RoutedEventArgs e)
        {
            //grdBooks.Visibility = Visibility.Visible;
            btnDashboard.Margin = new Thickness(20, 135, 20, 400);
            dbcontent.Visibility = Visibility.Hidden;
            addBook.Visibility = Visibility.Visible;
            btnİdareciler.Margin = new Thickness(20, 352, 19, 200);
            btnHesabatlar.Margin = new Thickness(19, 450, 20, 139);
        }

        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void btnİdareciler_Click(object sender, RoutedEventArgs e)
        {
            dbcontent.Visibility = Visibility.Hidden;
            btnDashboard.Margin = new Thickness(20, 135, 20, 400);

            AddUser addUser = new AddUser();
            addUser.Show();
        }
    }
}
