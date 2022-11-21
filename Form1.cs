using Jul.Entities;
using Jul.Extensions;
using Jul.Forms;
using Jul.Services;
using Microsoft.EntityFrameworkCore;

namespace Jul;

public partial class Form1 : Form
{
    private readonly UnitOfWork _uow;
    private Dictionary<int, Books> _booksMap;
    private Dictionary<int, Customers> _customersMap;
    private int lastSortedColumn;
    private bool sortAsc = true;

    public Form1()
    {
        InitializeComponent();
        _uow = UnitOfWork.Create();
        appTabs.DrawItem += CustomTabRender.tabControl1_DrawItem;
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        await DbInitializer.SeedDbAsync();
        _booksMap = await _uow.DbContext.Books
            .Include(e => e.Author)
            .Include(e => e.Publisher)
            .Include(e => e.Genres)
            .ToDictionaryAsync(e => e.Id);
        _customersMap = await _uow.DbContext.Customers
            .Include(e => e.City)
            .Include(e => e.Country)
            .ToDictionaryAsync(e => e.Id);

        var booksColumns = new[]
        {
            "Id",
            "Title",
            "Author",
            "Genre",
            "Year",
            "Publisher",
            "Price",
            "Count",
        };
        await ListViewConfigure(listView1, booksColumns);
        FillBooksListView();

        var customersColumns = new[]
        {
            "Id",
            "Name",
            "Country",
            "City",
        };
        await ListViewConfigure(listView2, customersColumns);
        FillCustomersListView();

        listView1.ColumnClick += ColumnSortEventHandler;
    }

    private void ColumnSortEventHandler(object sender, ColumnClickEventArgs e)
    {
        //var listView = sender as ListView;

        //foreach (var item in listView.Items)
        //{

        //}
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

    private void FillBooksListView()
    {
        listView1.Items.Clear();

        var rows = _booksMap
            .Where(e => e.Value.Count > 0)
            .Select(entry =>
            {
                var book = entry.Value;
                return new ListViewItem(new[]
                {
                    book.Id.ToString(),
                    book.BookTitle,
                    book.Author.AuthorName,
                    book.Genres.GenreName,
                    book.Year.ToString(),
                    book.Publisher.PublisherName,
                    book.Price.ToString(),
                    book.Count.ToString(),
                });
            })
            .ToArray();

        listView1.Items.AddRange(rows);
    }

    private void FillCustomersListView()
    {
        listView2.Items.Clear();

        var rows = _customersMap.Select(entry =>
            {
                var customer = entry.Value;
                return new ListViewItem(new[]
                {
                    customer.Id.ToString(),
                    customer.Name,
                    customer.Country.CountryName,
                    customer.City.CityName,
                });
            })
            .ToArray();

        listView2.Items.AddRange(rows);
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        var createBookForm = new CreateBookForm(listView1, _booksMap, _uow);
        createBookForm.Show();
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("You should select books to sell", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
        
        var sellBooksForm = new SellBookForm(listView1, _customersMap, _booksMap, _uow);
        sellBooksForm.Show();
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
        var customerCreateForm = new CreateCustomerForm(listView2, _customersMap, _uow);
        customerCreateForm.Show();
    }

    private void toolStripButton5_Click(object sender, EventArgs e)
    {
        var selectedItems = listView2.SelectedItems;

        if (selectedItems.Count == 0)
        {
            MessageBox.Show("You should select a customer!", "Warning", MessageBoxButtons.OK);
            return;
        }

        var customerId = listView2.SelectedItems[0].SubItems[0].Text;

        if (string.IsNullOrEmpty(customerId))
        {
            MessageBox.Show("customer id is null or empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var customerReceiptsForm = new CustomerReceiptsForm(_booksMap, _customersMap, customerId, _uow);
        customerReceiptsForm.Show();
    }

    private async void removeBookButton_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("You should select items to delete!", "Warning!", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            return;
        }

        var result = MessageBox.Show("Are you shure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        if (result == DialogResult.No)
        {
            return;
        }

        var selectedItemsId = new List<string>();
        foreach (ListViewItem listViewSelectedItem in listView1.SelectedItems)
        {
            selectedItemsId.Add(listViewSelectedItem.SubItems[0].Text);
        }

        var books = selectedItemsId
            .Select(e => _booksMap[int.Parse(e)])
            .ToList();

        _uow.DbContext.RemoveRange(books);
        books.ForEach(e => _booksMap.Remove(e.Id));
        listView1.BooksListViewRefresh(_booksMap);
        await _uow.SaveChangesAsync();
    }

    private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
    {
        var searchValue = booksSearchBar.Text;
        var searchedBooks = _booksMap
            .Where(b => b.Value.BookTitle.Contains(searchValue, StringComparison.CurrentCultureIgnoreCase))
            .Select(e => e.Value)
            .ToDictionary(e => e.Id);

        listView1.BooksListViewRefresh(searchedBooks);
    }

    private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        if (e.Column == 0)
        {
        }
    }

    private void SortBooksByColumn(BooksColumns column)
    {
        if (column == BooksColumns.Id)
        {
            var books = _booksMap.Select(e => e.Value);
            books = lastSortedColumn == (int) column
                ? books.OrderByDescending(e => e.Id)
                : books.OrderBy(e => e.Id);

            var dict = books.ToDictionary(e => e.Id);
        }
        
            
    }

    private async void removeCustomersButton_Click(object sender, EventArgs e)
    {
        if (listView2.SelectedItems.Count == 0)
        {
            MessageBox.Show("You should select items to delete!", "Warning!", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            return;
        }

        var result = MessageBox.Show("Are you shure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        if (result == DialogResult.No)
        {
            return;
        }

        var selectedItemsId = new List<string>();
        foreach (ListViewItem listViewSelectedItem in listView2.SelectedItems)
        {
            selectedItemsId.Add(listViewSelectedItem.SubItems[0].Text);
        }

        var customers = selectedItemsId
            .Select(e => _customersMap[int.Parse(e)])
            .ToList();

        _uow.DbContext.Customers.RemoveRange(customers);
        customers.ForEach(e => _customersMap.Remove(e.Id));
        listView2.CustomersListViewRefresh(_customersMap);
        await _uow.SaveChangesAsync();
    }

    private void customersSearchbox_TextChanged(object sender, EventArgs e)
    {
        var searchValue = customersSearchbox.Text;
        var searchedCustomers = _customersMap
            .Where(e => e.Value.Name.Contains(searchValue, StringComparison.CurrentCultureIgnoreCase))
            .Select(e => e.Value)
            .ToDictionary(e => e.Id);

        listView2.CustomersListViewRefresh(searchedCustomers);
    }
}

public enum BooksColumns
{
    Id = 1,
    Title,
    Author,
    Genre,
    Year,
    Publisher,
    Price,
    Count,
}