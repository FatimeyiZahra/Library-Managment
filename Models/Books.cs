using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library_Managment.Models
{
   public class Books
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Author { get; set; }
        public int Edition { get; set; }
        [Column(TypeName = "money")]
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
