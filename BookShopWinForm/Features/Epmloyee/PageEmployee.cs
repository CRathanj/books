using Bogus.DataSets;
using BookShopClientShare.Services;
using System.Data;

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

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _employeeService = new EmployeeService();

            loadData();
        }
        private async void loadData()
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
            table.Columns.Add("HireDate", typeof(DateTime));
            table.Columns.Add("Active", typeof(string));

            foreach (var emp in list?.Data)
            {
                table.Rows.Add(emp.Id, emp.Name, emp.Gender, emp.Position, emp.Salary, emp.Address, emp.Contact, emp.HireDate, emp.Active);
            }

            dataGridView1.DataSource = table;
        }
    }
}
