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

namespace BookShopWinForm.Features.Customers
{
    public partial class PageCustomer : Form
    {
        private readonly CustomerService _customerService;
        public PageCustomer()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // services
            _customerService = new CustomerService();

            // default load data
            loadData();
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
            var list = await _customerService.GetAllCustomer();
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("NAME", typeof(string));
            table.Columns.Add("Contact", typeof(string));
            table.Columns.Add("Address", typeof(string));

            foreach (var emp in list?.Data)
            {
                table.Rows.Add(emp.Id, emp.Name, emp.Contact, emp.Address);
            }

        dataGridView1.DataSource = table;
        }
    }
}
