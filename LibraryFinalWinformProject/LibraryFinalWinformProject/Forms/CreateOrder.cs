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
    public partial class Create_Order : Form
    {
        private readonly LMSdbContext _context;
        private readonly string _username;
        public Create_Order(string username)
        {
            _context = new LMSdbContext();
            InitializeComponent();
            _username = username;
        }

        private void txtFindCost_TextChanged(object sender, EventArgs e)
        {
            if (txtFindCost.Text == "")
            {
                dgvFindCtm.Rows.Clear();
            }
            var Costmrs = _context.People.Where(u=>u.Name.Contains(txtFindCost.Text));
            foreach(var i in Costmrs)
            {
                dgvFindCtm.Rows.Clear();
                dgvFindCtm.Rows.Add(i.Id,
                    i.Name,
                    i.Surname,
                    i.PhoneNumber,
                    i.Email,
                    i.BooksHave);
            }
            if (txtFindCost.Text == "")
            {
                dgvFindCtm.Rows.Clear();
            }
        }

        private void dgvFindCtm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _selectedId = dgvFindCtm.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (e.ColumnIndex == 6)
            {
                FinishOrder FoForm = new FinishOrder(_context,_selectedId,_username);
                FoForm.Show();
            }
        }
    }
}
