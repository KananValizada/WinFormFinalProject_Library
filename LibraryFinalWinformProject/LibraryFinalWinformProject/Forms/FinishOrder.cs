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

namespace LibraryFinalWinformProject.Forms
{
    public partial class FinishOrder : Form
    {
        private readonly LMSdbContext _context;
        private readonly string _slcId;
        public FinishOrder(LMSdbContext context,string selectedId)
        {
            _context = context;
            _slcId = selectedId;
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
            string Name = _context.People.FirstOrDefault(u => u.Id.ToString() == _slcId).Name.ToString()+" "+
                _context.People.FirstOrDefault(u => u.Id.ToString() == _slcId).Surname.ToString();
            txtFoFullName.Text = Name;
            txtFoBookName.Text = gvBookSrc.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFoOrderDate.Value = DateTime.Today;
            
        }
    }
}
