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
    public partial class BookReturn : Form
    {
        private readonly LMSdbContext _context;
        public BookReturn()
        {
            _context = new LMSdbContext();
            InitializeComponent();
        }


        private void btnrtnSrc_Click(object sender, EventArgs e)
        {
            if (txtSearchCostumerName.Text == "")
            {
                MessageBox.Show("Adi daxil edin");
                return;
            }
            dgvRtrn.Rows.Clear();
            var Costmrs = _context.Orders.Include("Person").Include("Book").Where(u => u.Person.Name.Contains(txtSearchCostumerName.Text));
            foreach (var i in Costmrs)
            {
                double dfrnce = 0;
                double totalprise = Convert.ToDouble(i.Book.Prise);
                DateTime now = DateTime.Today;
                if (i.Deadline < now)
                {
                    dfrnce = (now - i.Deadline).TotalDays;
                    for (var a = 0; a < dfrnce; a++)
                    {
                        totalprise = totalprise + (Convert.ToDouble(i.Book.Prise) * 0.5 / 100);
                    }
                }

                dgvRtrn.Rows.Add(i.Id,
                    i.Person.Name,
                    i.Person.Surname,
                    i.Book.Name,
                    i.Deadline,
                    i.Book.Prise,
                    totalprise);
            }
        }
    }
}
