using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryFinalWinformProject.Data;

namespace LibraryFinalWinformProject.Forms
{
    public partial class Reports : Form
    {
        private readonly LMSdbContext _context;
        public Reports()
        {
            _context = new LMSdbContext();
            InitializeComponent();
        }

        private void BtnFindOrders_Click(object sender, EventArgs e)
        {
            if (rportsStartDate.Value > rportsEndDate.Value)
            {
                MessageBox.Show("Baslangic tarixi bitme tarixinden qabaq olmalidir");
                return;
            }
            var orders = _context.Orders.Include("Book").Include("Person").Where(u => u.Date >= rportsStartDate.Value &&u.Date<=rportsEndDate.Value);
            dgvReports.Rows.Clear();
            decimal sum = 0;
            foreach (var i in orders)
            {
                sum = sum + i.Book.Prise;
                dgvReports.Rows.Add(i.Id, i.Person.Name, i.Person.Surname, i.Person.PhoneNumber,i.Person.Email, i.Book.Name, i.Book.Prise,i.Status);
                
            }
            txtTotalEarn.Text = sum.ToString();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
           if(dgvReports.Rows.Count < 2)
            {
                 MessageBox.Show("Cedvelde melumat yoxdur");
                return;
            }

                //Export to excel at selected location
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "export.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    ToCsV(dgvReports, sfd.FileName);
                }

            }

            //Make en excel file
            private void ToCsV(DataGridView dGV, string filename)
            {
                string stOutput = "";
                // Export titles:
                string sHeaders = "";

                for (int j = 0; j < dGV.Columns.Count; j++)
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
                stOutput += sHeaders + "\r\n";
                // Export data.
                for (int i = 0; i < dGV.RowCount - 1; i++)
                {
                    string stLine = "";
                    for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                        stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                    stOutput += stLine + "\r\n";
                }

                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(output, 0, output.Length); //write the encoded file
                bw.Flush();
                bw.Close();
                fs.Close();
            
        }
    }
}
