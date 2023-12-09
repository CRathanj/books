using Bogus.DataSets;
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

namespace BookShopWinForm.Features.Epmloyee
{
    public partial class PageEmployee : Form
    {
        private readonly EmployeeService _employeeService;
        public PageEmployee()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            loadDate();
        }
        private async void loadDate()
        {
            var list = await _employeeService.GetAllEmployee();
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("NAME", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Position", typeof(string));
            table.Columns.Add("Salary", typeof(decimal));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Contact", typeof(string));
            table.Columns.Add("HireDate", typeof(Date));
            table.Columns.Add("Active", typeof(string));

            foreach (var emp in list?.Data)
            {
                table.Rows.Add(emp.Id, emp.Name, emp.Gender, emp.Position, emp.Salary, emp.Address, emp.Contact, emp.HireDate, emp.Active);
            }

            dataGridView1.DataSource = table;
        }
    }
}
