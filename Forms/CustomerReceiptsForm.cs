using Jul.Entities;
using Jul.Services;
using Microsoft.EntityFrameworkCore;
using static Jul.Form1;

namespace Jul.Forms;

public partial class CustomerReceiptsForm : Form
{
    private readonly Dictionary<int, Customers> _customerMap;
    private readonly string _customerId;
    private readonly UnitOfWork _uow;

    public CustomerReceiptsForm(Dictionary<int, Books> booksMap, Dictionary<int, Customers> customerMap, string CustomerId, UnitOfWork uow)
    {
        _customerMap = customerMap;
        _customerId = CustomerId;
        _uow = uow;
        InitializeComponent();
        _booksMap = booksMap;
    }

    private Dictionary<int, Books> _booksMap { get; }

    private async void CustomerReceiptsForm_Load(object sender, EventArgs e)
    {
        var columns = new[]
        {
            "Id",
            "Title",
            "Author",
            "Genre",
            "Year",
            "Publisher",
            "Price",
            "Date sold",
        };

        await ListViewConfigure(booksListView, columns);
        FillBooksListView(booksListView);

        var customerName = _customerMap[int.Parse(_customerId)].Name;
        customerNameLabel.Text += customerName;
    }

    private async Task ListViewConfigure(ListView listView, string[] listViewColumns)
    {
        listView.FullRowSelect = true;
        listView.GridLines = true;
        listView.View = View.Details;
        listView.FullRowSelect = true;

        RenderListViewColumns(listView, listViewColumns);
    }

    private void RenderListViewColumns(ListView listView, string[] columns)
    {
        listView.Columns.Clear();

        var columnHeaders = columns.Select(c =>
        {
            return new ColumnHeader
            {
                Text = c,
                TextAlign = HorizontalAlignment.Center,
                Width = c.Length > 10 ? 150 : 100,
            };
        }).ToArray();

        columnHeaders.First().Width = 0;

        listView.Columns.AddRange(columnHeaders);
    }

    private async Task FillBooksListView(ListView listView)
    {
        listView.Items.Clear();

        var receiptBooks = await _uow.DbContext.Receipts
            .Where(e => e.CustomerId.ToString() == _customerId)
            .Include(e => e.Book)
            .ToListAsync();

        var rows = receiptBooks.Select(entry =>
            {
                var book = entry.Book;
                return new ListViewItem(new[]
                {
                    book.Id.ToString(),
                    book.BookTitle,
                    book.Author.AuthorName,
                    book.Genres.GenreName,
                    book.Year.ToString(),
                    book.Publisher.PublisherName,
                    book.Price.ToString(),
                    entry.DateSold.ToString(),
                });
            })
            .ToArray();

        listView.Items.AddRange(rows);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }
}