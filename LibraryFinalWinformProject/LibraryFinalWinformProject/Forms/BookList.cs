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
    
    public partial class BookList : Form
    {
        private readonly LMSdbContext _context;
        public BookList()
        {
            _context = new LMSdbContext();
            InitializeComponent();
            FillBooks();
        }
        public void FillBooks()
        {
            var book = _context.Books.Include("Author").Include("Janra");
            foreach(var i in book)
            {
                dgvBooks.Rows.Add(i.id,
                    i.Name,
                    i.Author.Name,
                    i.Janra.Name,
                    i.PurchaseDate,
                    i.Prise,
                    i.Quantity,
                    i.AvaliableQuantity);
            }
        }

        private void btnBListClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
