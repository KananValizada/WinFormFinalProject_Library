using LibraryFinalWinformProject.Forms;
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

namespace LibraryFinalWinformProject
{
    public partial class Register : Form
    {
        private readonly LMSdbContext _context;
        public Register()
        {

            _context = new LMSdbContext();
            InitializeComponent();
        }

        private void txtLgnUserName_Click(object sender, EventArgs e)
        {
            txtRgsUserName.Clear();
            IconName.Image = Properties.Resources.man2;
            pnlLoginName.BackColor = Color.FromArgb(78, 150, 206);
            pnlLoginPassword.BackColor = Color.FromArgb(255, 255, 255);
            plnFln.BackColor = Color.FromArgb(255, 255, 255);
            pnlMail.BackColor = Color.FromArgb(255, 255, 255);
            txtRgsUserName.ForeColor = Color.FromArgb(78, 150, 206);
            IconPassword.Image = Properties.Resources.makefg;
            FlnIcon.Image = Properties.Resources.man1;
            IconMail.Image = Properties.Resources.whitLtr;
        }

        private void txtLgnPassword_Click(object sender, EventArgs e)
        {
            txtLgnPassword.Clear();
            txtLgnPassword.PasswordChar = '*';
            IconName.Image = Properties.Resources.man1;
            pnlLoginPassword.BackColor = Color.FromArgb(78, 150, 206);
            txtLgnPassword.ForeColor = Color.FromArgb(78, 150, 206);
            pnlLoginName.BackColor = Color.FromArgb(255, 255, 255);
            plnFln.BackColor = Color.FromArgb(255, 255, 255);
            pnlMail.BackColor = Color.FromArgb(255, 255, 255);
            IconPassword.Image = Properties.Resources.makefgsadsada;
            FlnIcon.Image = Properties.Resources.man1;
            IconMail.Image = Properties.Resources.whitLtr;
        }

        private void FullNamClick(object sender, EventArgs e)
        {
            txtFullNam.Clear();
            FlnIcon.Image = Properties.Resources.man2;
            plnFln.BackColor = Color.FromArgb(78, 150, 206);
            pnlLoginPassword.BackColor = Color.FromArgb(255, 255, 255);
            pnlLoginName.BackColor = Color.FromArgb(255, 255, 255);
            pnlMail.BackColor = Color.FromArgb(255, 255, 255);
            txtFullNam.ForeColor = Color.FromArgb(78, 150, 206);
            IconPassword.Image = Properties.Resources.makefg;
            IconName.Image = Properties.Resources.man1;
            IconMail.Image = Properties.Resources.whitLtr;
        }

        private void txtMailClick(object sender, EventArgs e)
        {
            txtMail.Clear();
            IconMail.Image = Properties.Resources.okaLtr;
            pnlMail.BackColor = Color.FromArgb(78, 150, 206);
            pnlLoginPassword.BackColor = Color.FromArgb(255, 255, 255);
            pnlLoginName.BackColor = Color.FromArgb(255, 255, 255);
            plnFln.BackColor = Color.FromArgb(255, 255, 255);
            txtMail.ForeColor = Color.FromArgb(78, 150, 206);
            IconPassword.Image = Properties.Resources.makefg;
            IconName.Image = Properties.Resources.man1;
            FlnIcon.Image = Properties.Resources.man1;
        }

        private void btnRgsRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullNam.Text))
            {
                MessageBox.Show("Ad ve soyadizi yazin");
               return;
            }

            if (string.IsNullOrEmpty(txtRgsUserName.Text)) 
            {
                MessageBox.Show("Nick daxil edin");
                return;
            }
            if (string.IsNullOrEmpty(txtLgnPassword.Text))
            {
                MessageBox.Show("Sifre daxil edin");
                return;
            }
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("Elektron unvaninizi daxil edin");
                return;
            }
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Level secin");
                return;
            }
            if(cmbStatus.Text =="Admin" || cmbStatus.Text == "Moderator")
            {
                User user = new User()
                {
                    Fullname = txtFullNam.Text,
                    Username = txtRgsUserName.Text,
                    Password = txtLgnPassword.Text,
                    Email = txtMail.Text,
                    Level = (cmbStatus.Text == "Admin") ? userLevel.Admin : userLevel.Moderator,
                    Status = true
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                MessageBox.Show("Qeydiyyat ugurla aparildi");
            }
            else
            {
                MessageBox.Show("Level Duzgun Secilmeyib");
                return;
            }
    
            this.Close();
          
        }

        private void CmbStatus_KeyUp(object sender, KeyEventArgs e)
        {
            cmbStatus.Text = "";
        }
    }
}
