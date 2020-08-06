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
        private Books _selectedBook;
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
            addBook.Visibility = Visibility.Visible;
            bookDelete.Visibility = Visibility.Hidden;
            bookEdit.Visibility = Visibility.Hidden;
        }
        private void FillCategory()
        {
            cmbCategory.ItemsSource = _context.Categories.ToList();
        }

        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("qirmizi olan yerleri doldurmalısınız");
                return;
            }
            Books books = new Books
            {
                BookName = TxtBookName.Text,
                Author = TxtAuthor.Text,
                Price = TxtPrice.Text, //tekrar baxacagam buna
                Edition = TxtEdition.Text,
                CategoryId = (int)cmbCategory.SelectedValue,

            };
            _context.Books.Add(books);
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Kitab elave edildi");

        }
        private void FillBook()
        {
            grdBooks.ItemsSource = _context.Books.ToList();
        }

        private void grdBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grdBooks.SelectedItem == null) return;
            _selectedBook = (Books)grdBooks.SelectedItem;
            TxtAuthor.Text = _selectedBook.Author;
            TxtBookName.Text = _selectedBook.BookName;
            TxtEdition.Text = _selectedBook.Edition;
            TxtPrice.Text = _selectedBook.Price;
            cmbCategory.SelectedValue = _selectedBook.CategoryId;

            addBook.Visibility = Visibility.Hidden;
            bookDelete.Visibility = Visibility.Visible;
            bookEdit.Visibility = Visibility.Visible;
        }

        private void bookDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Əminsiniz mi?", _selectedBook.ToString(), MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _context.Books.Remove(_selectedBook);
                _context.SaveChanges();
                Reset();
                MessageBox.Show("kitab silindi");
            }
        }

        private void bookEdit_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("qirmizi olan yerleri doldurmalısınız");
                return;
            }
            _selectedBook.Author = TxtAuthor.Text;
            _selectedBook.BookName = TxtBookName.Text;
            _selectedBook.CategoryId = (int)cmbCategory.SelectedValue;
            _selectedBook.Edition = TxtEdition.Text;
            _selectedBook.Price = TxtPrice.Text;
            _context.SaveChanges();
            Reset();
            MessageBox.Show("deyistirildi");

        }
        private bool FormValidation()
        {
            bool hasError = false;

            if (string.IsNullOrEmpty(TxtAuthor.Text))
            {
                TxtAuthor.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtAuthor.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtBookName.Text))
            {
                TxtBookName.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtBookName.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtEdition.Text))
            {
                TxtEdition.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtEdition.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtPrice.Text))
            {
                TxtPrice.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtPrice.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (cmbCategory.SelectedValue == null)
            {
                cmbCategory.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                cmbCategory.Foreground = new SolidColorBrush(Colors.Black);
            }
            return hasError;
        }
    }
}

