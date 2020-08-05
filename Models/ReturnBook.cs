using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library_Managment.Models
{
    public class ReturnBook
    {
        public int Id { get; set; }
        public int? BookId { get; set; }

        public int? IssueId { get; set; }

        public int MemberId { get; set; }

        [Column(TypeName = "date")]
        public DateTime IssueDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        public double? Fine { get; set; }

        [MaxLength(10)]
        public byte[] FinePaid { get; set; }
    }
}

