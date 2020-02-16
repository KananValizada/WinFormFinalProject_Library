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
    public partial class Dashboard : Form
    {
        private readonly Login _login;
        private readonly string _username;
        private readonly LMSdbContext _context;
        
        public Dashboard( Login login,string username,LMSdbContext context)
        {
            _context = context;
            InitializeComponent();
            _login = login;
            _login.Hide();
            _username = username;
            lblUserName.Text = "Welcome! " + username;
            FillNumb();
            
        }

        private void FillNumb()
        {
            lblCustCount.Text = _context.People.Count(u => u.Id > 0).ToString();
            lblOrderCount.Text = _context.Orders.Count(u => u.Status == true ).ToString();
        }
        private void MenuAddBook_Click(object sender, EventArgs e)
        {
            AddBooks addBooks = 
                new AddBooks();
            addBooks.Show();
        }

        private void menuAddJanra_Click(object sender, EventArgs e)
        {
            AddJanra AjForm = new AddJanra();
            AjForm.Show();
        }

        private void menuAddAuthor_Click(object sender, EventArgs e)
        {
            AddBookAuthor AbForm = new AddBookAuthor();
            AbForm.Show();
        }

        private void bookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookList BlForm = new BookList();
            BlForm.Show();
        }

        private void menuAddNewCostumer_Click(object sender, EventArgs e)
        {
            AddCostumer AcForm = new AddCostumer();
            AcForm.Show();
        }

        private void menuCostumerList_Click(object sender, EventArgs e)
        {
            CostumerList ClForm = new CostumerList();
            ClForm.Show();
        }

        private void menuCreateAnOrder_Click(object sender, EventArgs e)
        {
            Create_Order CoForm = new Create_Order(_username);
            CoForm.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuDeadlineToday_Click(object sender, EventArgs e)
        {
            DeadlineTodayOrders DtForm = new DeadlineTodayOrders();
            DtForm.Show();
        }

        private void menuDeadlineTomorrow_Click(object sender, EventArgs e)
        {
            DeadlineTomorrow DTForm = new DeadlineTomorrow();
            DTForm.Show();
        }

        private void menuOverdue_Click(object sender, EventArgs e)
        {
            OverdueOrders OdForm = new OverdueOrders();
            OdForm.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookReturn BrForm = new BookReturn();
            BrForm.Show();
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            FillNumb();
        }

        private void menuUpdateBook_Click(object sender, EventArgs e)
        {
            UpdateBook UbForm = new UpdateBook();
            UbForm.Show();
        }

        private void mnuUpCust_Click(object sender, EventArgs e)
        {
            UpCustForm UcForm = new UpCustForm();
            UcForm.Show();
        }
    }
}
