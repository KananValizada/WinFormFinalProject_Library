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
    public partial class AdminPanel : Form
    {
        private readonly Login _login;
        public AdminPanel(Login login)
        {
            _login = login;
            login.Hide();
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdminCreateUser_Click(object sender, EventArgs e)
        {
            Register rgst = new Register();
            rgst.Show();
        }

        private void BtnAdminHesabat_Click(object sender, EventArgs e)
        {
            Reports rpts = new Reports();
            rpts.Show();
        }
    }
}
