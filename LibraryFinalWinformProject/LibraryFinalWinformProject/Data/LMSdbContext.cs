using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibraryFinalWinformProject.Models;

namespace LibraryFinalWinformProject.Data
{
    public class LMSdbContext:DbContext
    {
        public LMSdbContext() : base(@"Server=CACER6\SQLEXPRESS;Database=LMS;Trusted_Connection=True;MultipleActiveResultSets=true") 
        { 
        
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookJanra> BookJanras { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
