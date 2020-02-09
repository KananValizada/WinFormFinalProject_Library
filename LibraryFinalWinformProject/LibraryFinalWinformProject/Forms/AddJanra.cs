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
    public partial class AddJanra : Form
    {
        private LMSdbContext _context;
        public AddJanra()
        {
            _context = new LMSdbContext();
            InitializeComponent();
            FillJanras();
        }
        private void FillJanras()
        {
            var janras = _context.BookJanras;
            foreach(var item in janras)
            {
                dgvJanras.Rows.Add(item.Id, item.Name);
            }
        }

        private void btnJanraAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJanra.Text))
            {
                MessageBox.Show("Janr Elave Edin");
                return;
            }
            BookJanra bookJanra = new BookJanra
            {
                Name = txtJanra.Text
            };
            _context.BookJanras.Add(bookJanra);
            _context.SaveChanges();
            dgvJanras.Rows.Clear();
            FillJanras();
        }
    }
}
