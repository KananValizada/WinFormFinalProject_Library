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
using LibraryFinalWinformProject.Models;

namespace LibraryFinalWinformProject.Forms
{
    public partial class UpdateBook : Form
    {
        private readonly LMSdbContext _context;
        public UpdateBook()
        {
            _context = new LMSdbContext();
            InitializeComponent();
        }

        private void txtFindBook_TextChanged(object sender, EventArgs e)
        {
            if (txtFindBook.Text == "")
            {
                gvBookUp.Rows.Clear();
            }
            var Costmrs = _context.Books.Include("Author").Include("Janra").Where(u => u.Name.Contains(txtFindBook.Text));
            foreach (var i in Costmrs)
            {
                gvBookUp.Rows.Clear();
                gvBookUp.Rows.Add(i.id,
                    i.Name,
                    i.Janra.Name,
                    i.Author.Name,
                    i.Prise,
                    i.Quantity);
            }
            if (txtFindBook.Text == "")
            {
                gvBookUp.Rows.Clear();
            }
        }

        private void btnBookUp_Click(object sender, EventArgs e)
        {
            if (gvBookUp.Rows[0] is null || gvBookUp.Rows[0].Cells[0].Value is null)
            {
                MessageBox.Show("Update etmek ucun Kitab cedvelde yoxdur");
                return;
            }
            string name = gvBookUp.Rows[0].Cells[1].Value.ToString();
            Book choosenBook = _context.Books.FirstOrDefault(u => u.Name == name);
            if (nmbPric.Text != "")
            {
                choosenBook.Prise = Convert.ToDecimal(nmbPric.Text);
                MessageBox.Show("Qiymet Yenilendi");
            }
            if (nmbCount.Text != "")
            {
                int diff = Convert.ToInt32(nmbCount.Text) - choosenBook.Quantity;
                choosenBook.Quantity = Convert.ToInt32(nmbCount.Text);
                choosenBook.AvaliableQuantity = choosenBook.AvaliableQuantity + diff;
                MessageBox.Show("Kitab Sayi Yenilendi");
            }
            _context.SaveChanges();
            txtFindBook.Clear();
            gvBookUp.Rows.Clear();
        }
    }
}
