using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFinalWinformProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm2.Left += 10;
            if(frm2.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm2.Left -= 10;
            if (frm2.Left <= 625)
            {
                
                timer2.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm2.Show();
        }
    }
}
