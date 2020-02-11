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
    public partial class FinishOrder : Form
    {
        private readonly LMSdbContext _context;
        private readonly string _slcId;
        private readonly string _username;
        public FinishOrder(LMSdbContext context,string selectedId,string username)
        {
            _context = context;
            _slcId = selectedId;
            _username = username;
            InitializeComponent();
        }

        private void txtBookSrc_TextChanged(object sender, EventArgs e)
        {
            
            var Books = _context.Books.Where(u => u.Name.Contains(txtBookSrc.Text));
            foreach (var i in Books)
            {
                gvBookSrc.Rows.Clear();
                gvBookSrc.Rows.Add(i.id,
                    i.Name,
                    i.JanraId,
                    i.AuthorId,
                    i.Prise,
                    i.Quantity,
                    i.AvaliableQuantity);
            }
            if (txtBookSrc.Text == "")
            {
                gvBookSrc.Rows.Clear();
            }

        }
        
        private void gvBookSrc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7)
            {
            string Name = _context.People.FirstOrDefault(u => u.Id.ToString() == _slcId).Name.ToString()+" "+
                _context.People.FirstOrDefault(u => u.Id.ToString() == _slcId).Surname.ToString();
            txtFoFullName.Text = Name;
            txtFoBookName.Text = gvBookSrc.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFoOrderDate.Value = DateTime.Now;
                txtFoWhoCreated.Text = _username;
            
            }
            
        }

        private void BtnFOCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFoBookName.Text))
            {
                MessageBox.Show("Kitab Secilmeyib");
                return;
            }

            Book book = _context.Books.FirstOrDefault(u => u.Name == txtFoBookName.Text);
            User user = _context.Users.FirstOrDefault(u => u.Username == _username);
            Person person= _context.People.FirstOrDefault(u=>u.Id.ToString()==_slcId);
            Order order = new Order()
            {
                PersonId = Convert.ToInt32(_slcId),
                BookId = book.id,
                UserId = user.id,
                overdueDebt = 0,
                Date =txtFoOrderDate.Value,
                Deadline = txtFoDeadline.Value
            };
            _context.Orders.Add(order);
            if (book.AvaliableQuantity != 0)
            {
                book.AvaliableQuantity--;
                person.BooksHave++;
            }
            else
            {
                MessageBox.Show("Hazirda kitabxanada bu kitabdan qalmayib ");
                return;
            }
           
            _context.SaveChanges();
            MessageBox.Show("Sifaris ugurla yaradildi!!!");
            gvBookSrc.Rows.Clear();
            
        }
    }
}
