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
    public partial class UpdateUser : Form
    {
        private readonly LMSdbContext _context;

        public UpdateUser()
        {
            _context = new LMSdbContext();
            InitializeComponent();
        }

        private void txtFindCost_TextChanged(object sender, EventArgs e)
        {
            if (txtFindUs.Text == "")
            {
               gvUsUp.Rows.Clear();
            }
            var Costmrs = _context.Users.Where(u => u.Email.Contains(txtFindUs.Text));
            foreach (var i in Costmrs)
            {
                gvUsUp.Rows.Clear();
                gvUsUp.Rows.Add(i.id,
                    i.Fullname,
                    i.Username,
                    i.Email,
                    i.Status,
                    i.Level);
            }
            if (txtFindUs.Text == "")
            {
                gvUsUp.Rows.Clear();
            }
        }


        private void btnUsUp_Click(object sender, EventArgs e)
        {
            if (gvUsUp.Rows[0] is null) 
            {
                MessageBox.Show("Update etmek ucun User cedvelde yoxdur");
                return;
            }
            string mail = gvUsUp.Rows[0].Cells[3].Value.ToString();
            User choosenUser = _context.Users.FirstOrDefault(u => u.Email ==mail);
            if (txtFullNam.Text != "")
            {
                choosenUser.Fullname = txtFullNam.Text;
                MessageBox.Show("FulName Yenilendi");
            }
            if (txtUsarNam.Text != "")
            {
                choosenUser.Username = txtUsarNam.Text;
                MessageBox.Show("UserName Yenilendi");
            }
            if (txtMail.Text != "")
            {
                choosenUser.Email = txtMail.Text;
                MessageBox.Show("Mail Yenilendi");
            }
            bool _status = (cmbStatus.Text == "active") ? true : false;
            userLevel _level = (cmbLaval.Text == "admin") ? userLevel.Admin : userLevel.Moderator;
            if (cmbLaval.Text != "")
            {
                choosenUser.Level = _level;
                MessageBox.Show("Level Yenilendi");
            }
            if(cmbStatus.Text != "")
            {
                choosenUser.Status = _status;
                MessageBox.Show("Status Yenilendi");
            }
            _context.SaveChanges();


        }

        private void cmbStatus_KeyUp(object sender, KeyEventArgs e)
        {
            cmbStatus.Text = "";
        }

        private void cmbLaval_KeyUp(object sender, KeyEventArgs e)
        {
            cmbLaval.Text = "";
        }
    }
}
