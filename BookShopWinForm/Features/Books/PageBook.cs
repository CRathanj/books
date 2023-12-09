
using BookShopClientShare.Models.Responses;
using BookShopClientShare.Services;
using System.Data;

namespace BookShopWinForm.Features.Books
{
    public partial class PageBook : Form
    {
        private readonly BookService _bookService;
        private readonly GenresService _genresService;

        private List<GenresResponse> _genres;

        public PageBook()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // services
            _bookService = new BookService();
            _genresService = new GenresService();

            // default load data
            loadDate();
            loadGenres();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd create = new(_genres);
            var isSave = create.Proccess();
            if (isSave)
            {
                loadDate();
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
            table.Columns.Add("AUTHOR", typeof(string));
            table.Columns.Add("GENRES", typeof(string));
            table.Columns.Add("PRICE", typeof(decimal));

            foreach (var bk in list?.Data)
            {
                table.Rows.Add(bk.Id, bk.Name, bk.ISBN, bk.Author, bk.Genres, bk.Price);
            }

            dataGridView1.DataSource = table;
        }

        private async void loadGenres()
        {
            _genres = (await _genresService.GetAllGenres()).Data ?? [];
        }
    }
}
