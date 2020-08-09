using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Managment.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int BarcodeId { get; set; }
        public int BookNameId { get; set; }
        public int AuthorId { get; set; }
        public string PriceId { get; set; }
        public int ReturnDate { get; set; }



    }
}
