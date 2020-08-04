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
        private readonly LibraryContext _context;
        public HomePageWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grdBooks.Visibility = Visibility.Visible;
            btnDashboard.Margin = new Thickness(20, 135, 20, 400);
            dbcontent.Visibility = Visibility.Hidden;
           addBook.Visibility = Visibility.Visible;
            btnİdareciler.Margin = new Thickness(20, 352, 19, 200);
            btnHesabatlar.Margin= new Thickness(20, 400, 19, 250);
        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            btnDashboard.Margin = new Thickness(20, 35, 19, 517);
            dbcontent.Visibility = Visibility.Visible;
            addBook.Visibility = Visibility.Hidden;
            grdBooks.Visibility = Visibility.Hidden;
          
        }
    }
}
