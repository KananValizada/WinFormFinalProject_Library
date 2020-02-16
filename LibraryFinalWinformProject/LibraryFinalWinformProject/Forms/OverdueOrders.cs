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
    public partial class OverdueOrders : Form
    {
        private readonly LMSdbContext _context;
        public OverdueOrders()
        {
            _context = new LMSdbContext();
            InitializeComponent();
            FillGrOverdue();
        }
        public void FillGrOverdue()
        {
            DateTime today = DateTime.Today;

            var todayOrders = _context.Orders.Include("Person")
                .Include("Book")
                .Where(u => u.Deadline<today && u.Status ==true);
            foreach (var i in todayOrders)
            {
                dgvOverdueOrders.Rows.Add(i.Person.Id,
                    i.Person.Name, i.Person.Surname, i.Book.Name, i.Person.BooksHave);
            }
        }
    }
}
