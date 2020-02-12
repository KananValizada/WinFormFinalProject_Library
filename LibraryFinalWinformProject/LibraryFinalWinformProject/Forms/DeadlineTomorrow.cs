using LibraryFinalWinformProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFinalWinformProject.Forms
{
    public partial class DeadlineTomorrow : Form
    {
        private readonly LMSdbContext _context;
        public DeadlineTomorrow()
        {
            _context = new LMSdbContext();
            InitializeComponent();
            FillGrTomorrow();
        }
        public void FillGrTomorrow()
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);

            var todayOrders = _context.Orders.Include("Person")
                .Include("Book")
                .Where(u =>u.Deadline.Year == tomorrow.Year
                        && u.Deadline.Month == tomorrow.Month
                        && u.Deadline.Day == tomorrow.Day);
            foreach (var i in todayOrders)
            {
                dgvTomorrowOrders.Rows.Add(i.Person.Id,
                    i.Person.Name, i.Person.Surname,i.Book.Name, i.Person.BooksHave);
            }
        }
    }
}
