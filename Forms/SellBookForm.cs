using System.Windows.Forms;
using Jul.Entities;

namespace Jul.Forms;

public partial class SellBookForm : Form
{
    private readonly List<Books> _books;

    public SellBookForm(IEnumerable<string> selectedBooksId, Dictionary<int, Books> booksMap)
    {
        InitializeComponent();
        _books = selectedBooksId.Select(i => booksMap[int.Parse(i)]).ToList();
    }

    private async void SellBookForm_Load(object sender, EventArgs e)
    {

    }

    private async Task ConfigureBooksView(ListView listView)
    {
        listView.Columns.Clear();

        var columns = new List<ColumnHeader>
        {
            new ColumnHeader
            {
                Text = "Title",
                Width = 90,
            },
            new ColumnHeader
            {
                Text = "Author",
                Width = 90,
            },
            new ColumnHeader
            {
                Text = "Genre",
                Width = 90,
            },
            new ColumnHeader
            {
                Text = "Year",
                Width = 90,
            },
            new ColumnHeader
            {
                Text = "Publisher",
                Width = 90,
            },
            new ColumnHeader
            {
                Text = "Price",
                Width = 90,
            },

        };

        columns.ForEach(c => c.TextAlign = HorizontalAlignment.Center);

        listView.Columns.AddRange(columns.ToArray());
    }
}