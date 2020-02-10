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
    public partial class CostumerList : Form
    {
        private LMSdbContext _context;
        public CostumerList()
        {
            _context = new LMSdbContext();
            InitializeComponent();
            FillCostumer();
        }
        public void FillCostumer()
        {
            var costumers = _context.People;
            foreach(var item in costumers)
            {
                dgvCostumers.Rows.Add(item.Id,
                    item.Name,
                    item.Surname,
                    item.PhoneNumber,
                    item.Email,
                    item.BooksHave);
            }
        }
    }
}
