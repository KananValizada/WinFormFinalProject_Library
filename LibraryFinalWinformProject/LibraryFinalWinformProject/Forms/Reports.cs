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
                dgvReports.Rows.Add(i.Id, i.Person.Name, i.Person.Surname, i.Person.PhoneNumber,i.Person.Email, i.Book.Name, i.Book.Prise);
                
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
                
            
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "OrderList";
            for(int i = 1; i < dgvReports.Columns.Count + 1; i++)
            {
                worksheet.Cells[1,i] = dgvReports.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvReports.Rows.Count-1; i++)
            {
                for(int j = 0; j < dgvReports.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvReports.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialogue = new SaveFileDialog();
            saveFileDialogue.FileName = "output";
            saveFileDialogue.DefaultExt = "xlsx";
            if (saveFileDialogue.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialogue.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
