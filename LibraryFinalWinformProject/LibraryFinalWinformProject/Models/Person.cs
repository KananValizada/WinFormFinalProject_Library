
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LibraryFinalWinformProject.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        public int BooksHave { get; set; }
        public List<Order> Orders { set; get; }

    }
}
