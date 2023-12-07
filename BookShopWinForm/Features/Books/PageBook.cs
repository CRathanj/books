namespace BookShopWinForm.Features.Books
{
    public partial class PageBook : Form
    {

        public PageBook()
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
            var isSave = create.Proccess();
            if (isSave)
            {
                MessageBox.Show("need to get data from server");
            }
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

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FormDetail detail = new FormDetail();
            detail.ShowDialog();
        }
    }
}
