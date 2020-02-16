using LibraryFinalWinformProject.Data;
using LibraryFinalWinformProject.Models;
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
            var Costmrs = _context.Orders.Include("Person").Include("Book").Where(u => u.Person.Name.Contains(txtSearchCostumerName.Text) && u.Status ==true);
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
                        i.overdueDebt= Convert.ToDecimal(i.Book.Prise)-Convert.ToDecimal(totalprise + (Convert.ToDouble(i.Book.Prise) * 0.5 / 100));
                    }
                }

                dgvRtrn.Rows.Add(i.Id,
                    i.Person.Name,
                    i.Person.Surname,
                    i.Book.Name,
                    i.Deadline,
                    i.Book.Prise,
                    i.overdueDebt);
            }
        }

        private void DgvRtrn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7 && !(dgvRtrn.Rows[e.RowIndex].Cells[6].Value is null))
            {
              
               string row = dgvRtrn.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                Order returnedOrder = _context.Orders.Include("Book").Include("Person").FirstOrDefault(u => u.Id.ToString() ==row && u.Status == true);
                returnedOrder.Person.BooksHave--;
                returnedOrder.Book.AvaliableQuantity++;
                returnedOrder.Status = false;
                _context.SaveChanges();
                MessageBox.Show("Kitab Qaytarildi");
                txtSearchCostumerName.Clear();
                dgvRtrn.Rows.Clear();
            }
        }
    }
}
