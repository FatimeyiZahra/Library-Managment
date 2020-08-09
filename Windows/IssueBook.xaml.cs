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
    /// Interaction logic for IssueBook.xaml
    /// </summary>
    public partial class IssueBook : Window
    {
        private readonly LibraryContext _context;

        public IssueBook()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillBook();
        }

        private void btnIssueCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtIssueCustomerCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            var db = new LibraryContext();
            var model = db.Customers.Where(x => x.CustomerCode == txtIssueCustomerCode.Text).ToList();
            foreach (var item in model)
            {
                txtIssueCustomerName.Text = item.CustomerName;
                txtIssueCustomerSurname.Text = item.CustomerSurname;
                txtIssueCustomerEmail.Text = item.CustomerEmail;
                txtIssueCustomerTel.Text = item.CustomerTelNo;
            }
            if (string.IsNullOrEmpty(txtIssueCustomerCode.Text))
            {
                txtIssueCustomerName.Clear();
                txtIssueCustomerSurname.Clear();
                txtIssueCustomerEmail.Clear();
                txtIssueCustomerTel.Clear();
            }
        }

        private void txtBookBarcode_TextChanged(object sender, TextChangedEventArgs e)
        {
            var db = new LibraryContext();
            var model = db.Books.Where(x => x.Barcode == txtBookBarcode.Text).ToList();
            foreach (var item in model)
            {
               txtBookAuthor.Text = item.Author;
                txtBookName.Text = item.BookName;
                txtBookPrice.Text = item.Price;
            }
            if (string.IsNullOrEmpty(txtBookBarcode.Text))
            {
                txtBookAuthor.Clear();
                txtBookName.Clear();
                txtBookPrice.Clear();
                
            }
        }

        private void btnIssueAddBook_Click(object sender, RoutedEventArgs e)
        {
            Basket basket = new Basket
            {
                BarcodeId = (int)txtBookBarcode.CaretIndex,
                BookNameId=(int)txtBookName.CaretIndex,
                AuthorId=(int)txtBookAuthor.CaretIndex,
                //PriceId=(int)txtBookPrice.CaretIndex,
                //ReturnDate=(DateTime)txtReturnDate.SelectedDate,

            };
            _context.Baskets.Add(basket);
            _context.SaveChanges();
            MessageBox.Show("sebete elave edildi");
        }
        private void FillBook()
        {
            grdBasket.ItemsSource = _context.Baskets.ToList();
        }
    }
}
