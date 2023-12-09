using BookShopClientShare.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopWinForm.Features.Sale
{
    public partial class PageSale : Form
    {
        private readonly SaleService _saleService;
        public PageSale()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd create = new FormAdd();
            create.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate update = new FormUpdate();
            update.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete");
        }
        private async void loadData()
        {
            var list = await _saleService.GetAllSale();
            DataTable table = new DataTable();

            table.Columns.Add("ISBN", typeof(string));
            table.Columns.Add("NAME", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Position", typeof(string));
            table.Columns.Add("Salary", typeof(decimal));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Contact", typeof(string));
            table.Columns.Add("HireDate", typeof(DateTime));
            table.Columns.Add("Active", typeof(string));

            foreach (var emp in list.Data ?? [])
            {
                //table.Rows.Add(emp.Id, emp.SaleId, emp.Sale, emp.BookId, emp.Book, emp.Quantity, emp.Amount);
            }
          
        dataGridView1.DataSource = table;
        }

    }
}
