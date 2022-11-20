using Jul.Entities;
using static Jul.Form1;

namespace Jul.Forms;

public partial class CustomerReceiptsForm : Form
{
    private readonly string userName;

    public CustomerReceiptsForm(Dictionary<int, Books> booksMap, string userName)
    {
        InitializeComponent();
        _booksMap = booksMap;
        this.userName = userName;
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
        };

        await ListViewConfigure(listView1, columns);
        label1.Text = userName;
    }

    private async Task ListViewConfigure(ListView listView, string[] listViewColumns)
    {
        listView.FullRowSelect = true;
        listView.GridLines = true;
        listView.View = View.Details;

        RenderListViewColumns(listView, listViewColumns);

        //if (booksMap is not null && booksMap.Count > 0)
        //{
        //    FillListView(listView);
        //}
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
}