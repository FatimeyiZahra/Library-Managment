using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library_Managment.Models
{
    public class Issue
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime IssueDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReturnDateId { get; set; }

        public int BookId { get; set; }
        public string BarcodeId { get; set; }

        //public double Fine { get; set; }
        public ICollection<Books> Books { get; set; }

    }
}
