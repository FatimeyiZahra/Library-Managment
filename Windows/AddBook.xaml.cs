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
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        private readonly LibraryContext _context;
        public AddBook()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillCategory();
            FillBook();
        }

        private void Reset()
        {
            TxtBookName.Clear();
            TxtAuthor.Clear();
            TxtEdition.Clear();
            TxtPrice.Clear();
            cmbCategory.SelectedItem = null;
            FillBook();
        }
        private void FillCategory()
        {
            cmbCategory.ItemsSource = _context.Categories.ToList();
        }

        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            Books books = new Books
            {
                BookName=TxtBookName.Text,
                Author=TxtAuthor.Text,
                Price=TxtPrice.Text, //tekrar baxacagam buna
                Edition=TxtEdition.Text,
                CategoryId=(int)cmbCategory.SelectedValue,

            };
            _context.Books.Add(books);
            _context.SaveChanges();
            //Reset();
            MessageBox.Show("Kitab elave edildi");
        }
        private void FillBook()
        {
            grdBooks.ItemsSource = _context.Books.ToList();
        }
    }
}
