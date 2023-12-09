using BookShopClientShare.Models;
using BookShopClientShare.Models.Responses;


namespace BookShopWinForm.Features.Books
{
    public partial class FormUpdate : Form
    {
        private BindingSource bs = new();
        public FormUpdate()
        {
            InitializeComponent();
            DataGridView.CheckForIllegalCrossThreadCalls = false;
            //cbGenres.DataSource = Enum.GetValues<Genres>();
            bs.DataSource = new List<BookResponse>();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textId.Clear();
            textISBN.Clear();
            tbName.Clear();
            cbGenres.Text = "";
            tbAuthor.Clear();
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            tbPrice.Clear();
            tbDescription.Clear();
        }
    }
}
