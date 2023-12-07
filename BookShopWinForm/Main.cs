using BookShopClientShare.Services;
using BookShopWinForm.Features.Books;
using BookShopWinForm.Features.Customers;
using BookShopWinForm.Features.Reports;
using BookShopWinForm.Features.Sale;

namespace BookShopWinForm;

public partial class Main : Form
{
    private BindingSource bs = new BindingSource();
    private PageSale sale = new();
    public Main()
    {
        InitializeComponent();
        menuItemSale.ClickItem += menuItemSale_Click;
        menuItemBook.ClickItem += menuItemBook_Click;
        menuItemCustomer.ClickItem += menuItemCustomer_Click;
        menuItemEmployee.ClickItem += menuItemEmployee_Click;
        menuItemReport.ClickItem += menuItemReport_Click;

        // Default page
        lblTitle.Text = sale.Text;
        panelMainPage.Controls.Add(sale);
        sale.Show();
    }

    private void menuItemEmployee_Click(object? sender, EventArgs e)
    {
        panelMainPage.Controls.Clear();
        
    }

    private async void GetProduct_Clicked(object sender, EventArgs e)
    {
        BookService bookService = new BookService();
        var result = await bookService.GetAllBooks();
        var all = result?.Data ?? new();
        var count = all.Count;

        MessageBox.Show(count.ToString());
    }

    private void menuItemSale_Click(object sender, EventArgs e)
    {   panelMainPage.Controls.Clear();
        PageSale sale = new PageSale();
        lblTitle.Text = sale.Text;
        panelMainPage.Controls.Add(sale);
        sale.Show() ;
        
    }

    private void menuItemBook_Click(object sender, EventArgs e)
    {
        panelMainPage.Controls.Clear();
        PageBook book = new PageBook();
        lblTitle.Text = book.Text;
        panelMainPage.Controls.Add(book);
        book.Show();
    }

    private void menuItemCustomer_Click(object sender, EventArgs e)
    {
        panelMainPage.Controls.Clear();
        PageCustomer customer = new PageCustomer();
        lblTitle.Text = customer.Text;
        panelMainPage.Controls.Add(customer);
        customer.Show();
    }

    private void menuItemReport_Click(object sender, EventArgs e)
    {
        panelMainPage.Controls.Clear();
        PageReport report = new PageReport();
        lblTitle.Text = report.Text;
        panelMainPage.Controls.Add(report);
        report.Show();
    }

 
}
