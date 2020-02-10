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
    public partial class AddCostumer : Form
    {
        private readonly LMSdbContext _context;
        public AddCostumer()
        {
            _context = new LMSdbContext();
            InitializeComponent();
        }

        private void btnAddCostumer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCostumerName.Text))
            {
                MessageBox.Show("Musteri adi daxil edin");
                return;
            }
            if (string.IsNullOrEmpty(txtCostumerSName.Text))
            {
                MessageBox.Show("Musteri soyadi daxil edin");
                return;
            }
            if (string.IsNullOrEmpty(txtCostumerPhone.Text))
            {
                MessageBox.Show("Musteri nomresi daxil edin");
                return;
            }
            if (string.IsNullOrEmpty(txtCostumerMail.Text))
            {
                MessageBox.Show("Musteri elektron puctu daxil edin");
                return;
            }

            Person person = new Person()
            {
                Name = txtCostumerName.Text,
                Surname = txtCostumerSName.Text,
                Email = txtCostumerMail.Text,
                PhoneNumber = txtCostumerPhone.Text,
                BooksHave = 0
            };
            _context.People.Add(person);
            _context.SaveChanges();
            MessageBox.Show("Musteri Elave olundu");
            this.Close();
        }
    }
}
