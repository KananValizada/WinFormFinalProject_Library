using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryFinalWinformProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime Deadline { get; set; }
        public Person Person { get; set; }
        public User User { get; set; }
    }
}
