using BookShopClientShare.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopWinForm.Features.Reports
{
    public partial class PageReport : Form
    {
        private readonly ReportService _reportService;
        
        public PageReport()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _reportService = new ReportService();
            loadData();
        }

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private async void loadData()
        {
            var list = await _reportService.GetAllReport();
            DataTable table = new DataTable();

            table.Columns.Add("ISBN", typeof(string));
            table.Columns.Add("CustomerId", typeof(string));
            table.Columns.Add("EmployeeId", typeof(string));
            table.Columns.Add("CustomerName", typeof(string));
            table.Columns.Add("EmployeeName", typeof(string));
            table.Columns.Add("Contact", typeof(string));
            table.Columns.Add("BookTitle", typeof(string));
            table.Columns.Add("Quantity", typeof(string));
            table.Columns.Add("Amount", typeof(decimal));
            table.Columns.Add("SaleDate", typeof(DateTime));

            foreach (var bk in list.Data ?? [])
            {
                table.Rows.Add(bk.ISBN, bk.CustomerId, bk.EmployeeId, bk.CustomerName, bk.EmployeeName, bk.Contact, bk.BookTitle, bk.Quantity, bk.Amount, bk.SaleDate);
            }

            dataGridView1.DataSource = table;

        }
    }
}
