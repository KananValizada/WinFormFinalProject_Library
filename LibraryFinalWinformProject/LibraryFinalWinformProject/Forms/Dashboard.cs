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
    public partial class Dashboard : Form
    {
        private readonly Login _login;
        private readonly string _username;
        
        public Dashboard( Login login,string username)
        {

            InitializeComponent();
            _login = login;
            _login.Hide();
            _username = username;
        }

        private void MenuAddBook_Click(object sender, EventArgs e)
        {
            AddBooks addBooks = new AddBooks();
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
    }
}
