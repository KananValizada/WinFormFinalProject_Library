using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFinalWinformProject.Models
{
    public enum userLevel
    {
        Admin,
        Moderator
    }
    public class User
    {
        public int id { set; get; }
        [Required]
        public bool Status { set; get; }
        [Required]
        [MaxLength(50)]
        public string Fullname { set; get; }
        [Required]
        [MaxLength(50)]
        public string Username { set; get; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { set; get; }
        [Required]
        public userLevel Level { set; get; }
        public List<Order> Orders { set; get; }

    }
}
