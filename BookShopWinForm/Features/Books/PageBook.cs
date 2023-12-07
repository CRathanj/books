namespace BookShopWinForm.Features.Books
{
    public partial class PageBook : Form
    {
        private readonly BookService _bookService;

        public PageBook()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;

            // services
            _bookService = new BookService();

            // default load data
            loadDate();
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

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            loadDate();
        }
        private async void loadDate()
        {
            var list = await _bookService.GetAllBooks();
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("NAME", typeof(string));
            table.Columns.Add("ISBN", typeof(string));
            table.Columns.Add("AUTHOR", typeof(decimal));
            table.Columns.Add("GENRES", typeof(string));
            table.Columns.Add("PRICE", typeof(decimal));

            foreach (var bk in list.Data)
            {
                table.Rows.Add(bk.Id, bk.Name, bk.ISBN, bk.Author, bk.Genres, bk.Price);
            }

            /**
         string Id 
         string ISBN 
         string Name 
         decimal Price 
         string? Description 
         string Author 
         string? Genres 
         DateTime? CreatedOn 
         DateTime? LastUpdatedOn 
         DateTime PublishDate 
            */

            dataGridView1.DataSource = table;
        }
    }
}
