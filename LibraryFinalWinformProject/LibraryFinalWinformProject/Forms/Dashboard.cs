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

        public Dashboard()
        {

            InitializeComponent();
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
    }
}
