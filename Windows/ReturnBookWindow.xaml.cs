using Library_Managment.Controllers;
using Library_Managment.Data;
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
    /// Interaction logic for ReturnBookWindow.xaml
    /// </summary>
    public partial class ReturnBookWindow : Window
    {
        
        private ReturnBookController returnBookController;
        public ReturnBookWindow()
        {
            InitializeComponent();
            returnBookController = new ReturnBookController();
        }

        private void txtIssueCustomerId_TextChanged(object sender, TextChangedEventArgs e)
        {
            var item = returnBookController.GetCustomerById(int.Parse(txtIssueCustomerId.Text));
            if (item != null)
            {
                txtIssueCustomerCode.Text = item.CustomerCode;
                txtIssueCustomerName.Text = item.CustomerName;
                txtIssueCustomerSurname.Text = item.CustomerSurname;
                txtIssueCustomerEmail.Text = item.CustomerEmail;
                txtIssueCustomerTel.Text = item.CustomerTelNo;
            }
            else
                MessageBox.Show("User is not found.");
            if (string.IsNullOrEmpty(txtIssueCustomerId.Text))
            {
                txtIssueCustomerCode.Clear();
                txtIssueCustomerName.Clear();
                txtIssueCustomerSurname.Clear();
                txtIssueCustomerEmail.Clear();
                txtIssueCustomerTel.Clear();
            }
        }

        private void txtBookId_TextChanged(object sender, TextChangedEventArgs e)
        {
            var db = new LibraryContext();
            var model = db.Books.Where(x => x.Id.ToString() == txtBookId.Text).ToList();
            foreach (var item in model)
            {
                txtBookBarcode.Text = item.Barcode;
                txtBookAuthor.Text = item.Author;
                txtBookName.Text = item.BookName;
                txtBookPrice.Text = item.Price.ToString();
                //txtBookId.Text = item.Id.ToString();
            }
            if (string.IsNullOrEmpty(txtBookId.Text))
            {
                txtBookBarcode.Clear();
                txtBookAuthor.Clear();
                txtBookName.Clear();
                txtBookPrice.Clear();

            }
        }

        private void searchByCustomerId_Click(object sender, RoutedEventArgs e)
        {
            var result = returnBookController.GetCustomerBooks(txtIssueCustomerId)
        }
    }
}
