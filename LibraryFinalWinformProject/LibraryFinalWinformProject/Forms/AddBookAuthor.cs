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
    public partial class AddBookAuthor : Form
    {
        private LMSdbContext _context;
        public AddBookAuthor()
        {
            _context = new LMSdbContext();
            InitializeComponent();
            FillAuthors();
        }
        private void FillAuthors()
        {
            var authors = _context.BookAuthors;
            foreach (var item in authors)
            {
                dgvAuthors.Rows.Add(item.Id, item.Name);
            }
        }

        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                MessageBox.Show("Yazici Elave Edin");
                return;
            }
            BookAuthor bookAuthor = new BookAuthor
            {
                Name = txtAuthor.Text
            };
            _context.BookAuthors.Add(bookAuthor);
            _context.SaveChanges();
            dgvAuthors.Rows.Clear();
            FillAuthors();
        }
    }
}
