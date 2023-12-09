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

namespace BookShopWinForm.Features.Sale
{
    public partial class FormAdd : Form
    {
        private readonly DataTable dataTable = new DataTable();

        public FormAdd()
        {
            InitializeComponent();

            dgvSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InitDataTableHeader();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }
        private void InitDataTableHeader ()
        {
            dataTable.Columns.Add("No", typeof(string));
            dataTable.Columns.Add("ISBN", typeof(string));
            dataTable.Columns.Add("Title", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(string));
            dataTable.Columns.Add("Price", typeof(decimal));
            dataTable.Columns.Add("Total", typeof(decimal));

            dgvSale.DataSource = dataTable;

        }

    }
}
