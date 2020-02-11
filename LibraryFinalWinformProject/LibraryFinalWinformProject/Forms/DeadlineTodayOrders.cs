using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryFinalWinformProject.Data;


namespace LibraryFinalWinformProject.Forms
{
    
    public partial class DeadlineTodayOrders : Form
    {
        private readonly LMSdbContext _context;
        public DeadlineTodayOrders()
        {
            _context = new LMSdbContext();
            InitializeComponent();
            FillGrToday();
        }

        public void FillGrToday()
        {
            DateTime today = DateTime.Today;
          
            var todayOrders = _context.Orders.Include("Person")
                .Include("Book")
                .Where(u => u.Deadline.Year == today.Year
                        && u.Deadline.Month == today.Month
                        && u.Deadline.Day == today.Day);
            foreach(var i in todayOrders)
            {
                dgvTodayOrders.Rows.Add(i.Person.Id,
                    i.Person.Name, i.Person.Surname,i.Person.BooksHave);
            }
        }
    }
}
