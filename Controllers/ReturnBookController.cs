using Library_Managment.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Linq;
using Microsoft.VisualBasic;
using Library_Managment.Models;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Library_Managment.Controllers
{
    public class ReturnBookController
    {
        LibraryContext _context;

        public ReturnBookController()
        {
            _context = new LibraryContext();
        }

        private double GetTotalPrice(DateTime d1, DateTime d2, double price)
        {
            var totalPrice = price;
            if (d1 > d2)
            {
                totalPrice += ((price * 0.5 / 100) * (double)((d1 - d2).Days));
            }
            return totalPrice;
        }

        public List<ReturnBooksTable> GetCustomerBooks(int id)
        {
            var returnBooksTables = (from order in _context.Issues.ToList()
                                     join customer in _context.Customers.ToList() on order.CustomerId equals customer.Id
                                     join book in _context.Books.ToList() on order.BooksId equals book.Id
                                     join category in _context.Categories.ToList() on book.CategoryId equals category.Id
                                     where customer.Id == id && order.IssueStatusType == 1
                                     select new ReturnBooksTable(
                                         order.Id,
                                         customer.Id,
                                         book.Id,
                                         order.ReturnDate,
                                         book.Price,
                                         GetTotalPrice(DateTime.Now, order.ReturnDate, book.Price)
                                     )).ToList();
            if (returnBooksTables != null && returnBooksTables?.Count != 0)
                return returnBooksTables;
            else return new List<ReturnBooksTable>();
        }

        public void RemoveCustomerIssue(int Id)
        {
            var order = _context.Issues.FirstOrDefault(x => x.Id == Id);
            if (order != null)
            {
                order.IssueStatusType = 2;
                order.GivedDate = DateTime.Now;
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Order tapilmadi");
            }
        }

        private bool ReturnDateCheck(DateTime returnDate, EnumDate enumDate)
        {
            switch (enumDate)
            {
                case EnumDate.NEEDSTOGIVE:
                    return (returnDate - DateTime.Now).Days < 0;
                case EnumDate.TODAY:
                    return returnDate.DayOfYear == DateTime.Now.DayOfYear;
                case EnumDate.TOMORROW:
                    return (returnDate - DateTime.Now).Days == 1;
                default: return false;
            }
        }

        public List<ReturnBooksCustomersTable> GetOrdersByDate(EnumDate enumDate)
        {
            var todayReturnBookTable = (from order in _context.Issues.ToList()
                                        where ReturnDateCheck(order.ReturnDate, enumDate)
                                        group order by order.CustomerId into orderGrouped
                                        join customer in _context.Customers.ToList() on orderGrouped.Key equals customer.Id
                                        select new ReturnBooksCustomersTable
                                        (
                                            customer.CustomerName,
                                            customer.CustomerTelNo,
                                            orderGrouped.Count()
                                        )).ToList();
            if (todayReturnBookTable != null && todayReturnBookTable.Count != 0)
                return todayReturnBookTable;
            else
                return new List<ReturnBooksCustomersTable>();
        }

        public Customer GetCustomerById(int id)
        {
            var result = _context.Customers.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
