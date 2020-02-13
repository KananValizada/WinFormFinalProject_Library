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
using LibraryFinalWinformProject.Forms;
using LibraryFinalWinformProject.Models;

namespace LibraryFinalWinformProject
{
    public partial class Login : Form
    {
        private readonly LMSdbContext _context;
        public Login()
        {

            _context = new LMSdbContext();
            InitializeComponent();
        }

        Register frm2 = new Register();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLgnUserName_Click(object sender, EventArgs e)
        {
            txtLgnUserName.Clear();
            IconName.Image = Properties.Resources.man2;
            txtLgnUserName.ForeColor = Color.FromArgb(78, 150, 206);
            pnlLoginName.BackColor = Color.FromArgb(78, 150, 206);
            pnlLoginPassword.BackColor = Color.FromArgb(255, 255, 255);
            IconPassword.Image = Properties.Resources.makefg;
           
        }

        private void txtLgnPassword_Click(object sender, EventArgs e)
        {
            txtLgnPassword.Clear();
            txtLgnPassword.PasswordChar = '*' ;
            IconPassword.Image = Properties.Resources.makefgsadsada;
            pnlLoginPassword.BackColor = Color.FromArgb(78, 150, 206);
            txtLgnPassword.ForeColor = Color.FromArgb(78, 150, 206);
            IconName.Image = Properties.Resources.man1;
            pnlLoginName.BackColor = Color.FromArgb(255, 255, 255);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLgnUserName.Text) )
            {
                MessageBox.Show("Nick daxil edin");
                return;
            }
            if (string.IsNullOrEmpty(txtLgnPassword.Text))
            {
                MessageBox.Show("Sifre daxil edin");
                return;
            }

            User user = _context.Users.FirstOrDefault(u => u.Status && u.Username == txtLgnUserName.Text && u.Password == txtLgnPassword.Text);

            if (user!=null)
            {
                if(user.Level == userLevel.Moderator)
                {
                    Dashboard dashboard = new Dashboard(this,txtLgnUserName.Text);
                         dashboard.Show();
                }
                else
                {
                    AdminPanel admin = new AdminPanel(this);
                    admin.Show();
                }
                return;
            }
            

            MessageBox.Show("E-poct ve ya Sifre yalnisdir");
        }
    }
}
