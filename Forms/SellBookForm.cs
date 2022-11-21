using Jul.Entities;
using Jul.Extensions;
using Jul.Services;
using static Jul.Form1;

namespace Jul.Forms;

public partial class SellBookForm : Form
{
    private readonly ListView _listView;
    private readonly Dictionary<int, Customers> _customersMap;
    private readonly Dictionary<int, Books> _booksMap;
    private readonly UnitOfWork _uow;
    private readonly List<Books> _books;
    private readonly List<Books> _selectedBooks;
    private readonly Customers _selectedCustomer;

    public SellBookForm(ListView listView, Dictionary<int, Customers> customersMap, Dictionary<int, Books> booksMap, UnitOfWork uow)
    {
        _listView = listView;
        _customersMap = customersMap;
        _booksMap = booksMap;
        _uow = uow;
        InitializeComponent();
        _selectedBooks = new();
    }

    private async void SellBookForm_Load(object sender, EventArgs e)
    {
        var booksColumns = new[]
        {
            "Id",
            "Title",
            "Author",
            "Genre",
            "year",
            "Publisher",
            "Price",
        };

        ListViewConfigure(booksListView, booksColumns);

        var customersName = _customersMap
            .Select(e => e.Value.Name)
            .ToArray();
        SetupComboBox(customerComboBox, customersName);
    }

    private void SetupComboBox(ComboBox comboBox, string[] collection)
    {
        comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;

        comboBox.AutoCompleteCustomSource.AddRange(collection);
        comboBox.Items.AddRange(collection);
    }
    
    private async Task ListViewConfigure(ListView listView, string[] listViewColumns)
    {
        listView.FullRowSelect = true;
        listView.GridLines = true;
        listView.View = View.Details;
        listView.FullRowSelect = true;

        RenderListViewColumns(listView, listViewColumns);
        FillListView();
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

    private void FillListView()
    {
        if (_listView.SelectedItems is null)
        {
            return;
        }

        var selectedItemsId = new List<string>();
        foreach (ListViewItem listViewSelectedItem in _listView.SelectedItems)
        {
            selectedItemsId.Add(listViewSelectedItem.SubItems[0].Text);
        }

        var totalPrice = 0d;
        var rows = selectedItemsId.Select(e =>
            {
                var book = _booksMap[int.Parse(e)];
                _selectedBooks.Add(book);
                totalPrice += book.Price;
                return new ListViewItem(new[]
                {
                    book.Id.ToString(),
                    book.BookTitle,
                    book.Author.AuthorName,
                    book.Genres.GenreName,
                    book.Year.ToString(),
                    book.Publisher.PublisherName,
                    book.Price.ToString(),
                });
            })
            .ToArray();
        

        booksListView.Items.AddRange(rows);
        totalPriceLabel.Text += Math.Round(totalPrice, 2).ToString();
    }

    private async void sellButton_Click(object sender, EventArgs e)
    {
        var selectedCustomerName = customerComboBox.SelectedItem;

        if (selectedCustomerName is null)
        {
            MessageBox.Show("You should select an existing customer!", "Warning", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (booksListView.Items.Count == 0)
        {
            MessageBox.Show("There are no books in the list!", "Warning", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var customer = _uow.DbContext.Customers.SingleOrDefault(e => e.Name == selectedCustomerName);
        var date = DateTime.Now;

        var receipts = _selectedBooks
            .Where(e => e.Count > 0)
            .Select(book =>
            {
                book.Count--;
                return new Receipts
                {
                    Book = book,
                    Customer = customer,
                    DateSold = date,
                };
            })
            .ToList();

        _uow.DbContext.Receipts.AddRange(receipts);

        try
        {
            await _uow.SaveChangesAsync();
            MessageBox.Show("Success!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _listView.BooksListViewRefresh(_booksMap);
        }
        catch (Exception exception)
        {
            MessageBox.Show("Error while selling!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        finally
        {
            Close();
        }
    }
}