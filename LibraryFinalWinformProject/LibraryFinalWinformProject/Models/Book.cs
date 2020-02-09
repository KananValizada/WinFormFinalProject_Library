using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryFinalWinformProject.Models
{
    public class Book
    {
        public int id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        [Required]
        [ForeignKey("Janra")]
        public int JanraId { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }
        [Required]
        public decimal Prise { get; set; }
        [Required]
        public int Quantity { get; set;}
        [Required]
        public int AvaliableQuantity { get; set; }
        public BookAuthor Author { get; set; }
        public BookJanra Janra { get; set; }

    }
}
