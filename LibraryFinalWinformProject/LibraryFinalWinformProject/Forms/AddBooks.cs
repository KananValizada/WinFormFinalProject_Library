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
    public partial class AddBooks : Form
    {
        private readonly LMSdbContext _context;
        public AddBooks()
        {
            _context = new LMSdbContext();
            InitializeComponent();
            FillCMB();
        }
        public void FillCMB()
        {
            var janras = _context.BookJanras;
            var authors = _context.BookAuthors;
            foreach(var item in janras)
            {
                cmbJanraBook.Items.Add(item.Name);
                
            }
            foreach (var item in authors)
            {
                cmbAuthorBook.Items.Add(item.Name);

            }
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameBook.Text))
            {
                MessageBox.Show("Kitab adi daxil edin");
                return;
            }
            if (txtPriceBook.Text=="0")
            {
                MessageBox.Show("Kitab Qiymetini daxil edin");
                return;
            }
            if(txtQuantityBook.Text=="0")
            {
                MessageBox.Show("Kitab sayi daxil edin");
                return;
            }
            if (string.IsNullOrEmpty(cmbJanraBook.Text))
            {
                MessageBox.Show("Janr secin");
                return;
            }
            if (string.IsNullOrEmpty(cmbAuthorBook.Text))
            {
                MessageBox.Show("Yazici secin");
                return;
            }
            if (string.IsNullOrEmpty(dtpDateBook.Text))
            {
                MessageBox.Show("Tarix secin");
                return;
            }
            BookJanra janraid = _context.BookJanras.FirstOrDefault(u=>u.Name == cmbJanraBook.Text);
            BookAuthor authorId = _context.BookAuthors.FirstOrDefault(u => u.Name == cmbAuthorBook.Text);
            Book book = new Book()
            {
                Name = txtNameBook.Text,
                AuthorId = Convert.ToInt32(authorId.Id),
                JanraId = Convert.ToInt32(janraid.Id),
                PurchaseDate = dtpDateBook.Value,
                Prise = txtPriceBook.Value,
                Quantity = Convert.ToInt32(txtQuantityBook.Value),
                AvaliableQuantity = Convert.ToInt32(txtQuantityBook.Value)
            };
            _context.Books.Add(book);
            _context.SaveChanges();
            MessageBox.Show("Kitab Elave olundu");

        }
    }
}
