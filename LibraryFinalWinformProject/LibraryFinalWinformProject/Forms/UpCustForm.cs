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
    public partial class UpCustForm : Form
    {
        private readonly LMSdbContext _context;
        public UpCustForm()
        {
            _context = new LMSdbContext();
            InitializeComponent();
        }

        private void txtFindCust_TextChanged(object sender, EventArgs e)
        {
            if (txtFindCust.Text == "")
            {
                dgvFindCtm.Rows.Clear();
            }
            var Costmrs = _context.People.Where(u => u.PhoneNumber.Contains(txtFindCust.Text));
            foreach (var i in Costmrs)
            {
                dgvFindCtm.Rows.Clear();
                dgvFindCtm.Rows.Add(i.Id,
                    i.Name,
                    i.Surname,
                    i.PhoneNumber,
                    i.Email,
                    i.BooksHave);
            }
            if (txtFindCust.Text == "")
            {
                dgvFindCtm.Rows.Clear();
            }
        }

        private void btnBookUp_Click(object sender, EventArgs e)
        {
            if (dgvFindCtm.Rows[0] is null || dgvFindCtm.Rows[0].Cells[0].Value is null)
            {
                MessageBox.Show("Update etmek ucun Musteri cedvelde yoxdur");
                return;
            }
            string phone = dgvFindCtm.Rows[0].Cells[3].Value.ToString();
            Person choosenCust = _context.People.FirstOrDefault(u => u.PhoneNumber == phone);
            if (txtMail.Text != "")
            {
                choosenCust.Email = txtMail.Text;
                MessageBox.Show("Mail Yenilendi");
            }
            if (txtPhone.Text != "")
            { 
                choosenCust.PhoneNumber =txtPhone.Text;
                MessageBox.Show("Mobil Nomre Yenilendi");
            }
            _context.SaveChanges();
            txtFindCust.Clear();
            dgvFindCtm.Rows.Clear();
        }
    }
}
