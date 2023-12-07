using BookShopClientShare.Models.Requests;
using BookShopClientShare.Models.Responses;
using BookShopClientShare.Services;

namespace BookShopWinForm.Features.Books
{
    public partial class FormAdd : Form
    {
        private BindingSource bs = new();

        private bool _isSave { get; set; } = false;
        private BookService _bookService { get; }

        public DataGridView DGV { get; set; }
        public FormAdd()
        {
            InitializeComponent();
            DataGridView.CheckForIllegalCrossThreadCalls = false;
            //cbGenres.DataSource = Enum.GetValues<Genres>();
            //bs.DataSource = new List<BookResponse>();


            _bookService = new BookService();
            //DGV.DataSource = bs;
            //DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtCreateCode.Clear();
            //txtCreateName.Clear();
            //cboCreateCat.SelectedItem = Category.None;
            
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            var req = new BookCreateRequest
            {
                ISBN = tbISBN.Text,
                Name = tbName.Text,
                Genres = cbGenres.Text,
                Author =  tbAuthor.Text,
                PublishDate = dateTimePicker1.Value,
                Price = tbPrice.Text,
                Description = tbDescription.Text
            };


            var response = await _bookService.Create(req);

            if (response.Succeed)
            {
                _isSave = true;
                this.Close();
                MessageBox.Show(response.Message);
            }
            else
            {
                MessageBox.Show(response.Message);
            }

        }

        public bool Proccess()
        {
            this.ShowDialog();
            return _isSave;
        }
    }
}
