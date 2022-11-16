using Humanizer;
using Jul.Data;
using Jul.Entities;
using Jul.Forms;
using Jul.Services;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;

namespace Jul;

public partial class Form1 : Form
{
    private readonly UnitOfWork _uow;
    private Dictionary<int, Books> booksMap;

    public Form1()
    {
        InitializeComponent();
        _uow = UnitOfWork.Create();
        appTabs.DrawItem += new DrawItemEventHandler(CustomTabRender.tabControl1_DrawItem);
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        await Seed.SeedDataBase(_uow);
        await InitializeBdData();

        var booksColumns = new[]
        {
            "Id",
            "Title",
            "Author",
            "Genre",
            "Year",
            "Publisher",
            "Price",
        };
        await ListViewConfigure(listView1, booksColumns);

        var customersColumns = new[]
        {
            "Id",
            "Name",
            "Adress"
        };
        await ListViewConfigure(listView2, customersColumns);

        listView1.ColumnClick += ColumnSortEventHandler;
    }

    private void ColumnSortEventHandler(object sender, ColumnClickEventArgs e)
    {
        //var listView = sender as ListView;

        //foreach (var item in listView.Items)
        //{

        //}
    }

    private async Task InitializeBdData()
    {
        var books = await _uow.DbContext.Books
            .Include(e => e.Author)
            .Include(e => e.Publisher)
            .Include(e => e.Genre)
            .ToListAsync();

        booksMap = books?.ToDictionary(e => e.Id);
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

        if (listViewColumns.Any(e => e.Contains("Author")))
        {
            MockBooksListView(listView1);
        }
        else
        {
            MockCustomersListView(listView2);
        }
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

    private void MockBooksListView(ListView listView)
    {
        listView.Items.Clear();
        Random random = new Random();
        
        var rows = ListMock.BooksName.Select(name =>
        {
            return new ListViewItem(
                    new[]
                    {
                        random.Next(0, 20).ToString(),
                        name,
                        ListMock.GetRandomData(ListMock.AuthorsName),
                        ListMock.GetRandomData(ListMock.Genres),
                        random.Next(1980, 2022).ToString(),
                        ListMock.GetRandomData(ListMock.PublishersName),
                        random.Next(5, 26).ToString(),
                    }
                );
        }).ToArray();

        listView.Items.AddRange(rows);
    }

    private void MockCustomersListView(ListView listView)
    {
        listView.Items.Clear();
        Random random = new Random();

        var rows = ListMock.CustomerNames.Select(name =>
        {
            var customerAdress = ListMock.GetRandomData(ListMock.Adresses);
            var country = ListMock.GetRandomData(ListMock.Countries);
            var city = ListMock.GetRandomData(ListMock.Cities);

            var adress = $"{customerAdress}, {city}, {country}";
            
            return new ListViewItem(
                    new[]
                    {
                        random.Next(0, 20).ToString(),
                        name,
                        adress,
                    }
                );
        }).ToArray();

        listView.Items.AddRange(rows);
    }

    private void FillListView(ListView listView)
    {
        listView.Items.Clear();

        var rows = booksMap.Select(entry =>
            {
                var book = entry.Value;
                return new ListViewItem(new[]
                {
                    book.Id.ToString(),
                    book.BookTitle,
                    book.Author.AuthorName,
                    book.Genre.GenreName,
                    book.Year.ToString(),
                    book.Publisher.PublisherName,
                    book.Price.ToString(),
                });
            })
            .ToArray();

        listView.Items.AddRange(rows);
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        var createBookForm = new CreateBookForm(listView1);
        createBookForm.Show();
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        var selectedBooksId = ((IEnumerable<ListViewItem>) listView1.SelectedItems).Select(c => c.SubItems[0].Text);
        var sellBooksForm = new SellBookForm(selectedBooksId, booksMap);
    }

    public static class ListMock
    {
        public static string[] AuthorsName = new[]
        {
            "William Shakespeare",
            "J.R.R. Tolkien",
            "George Orwell",
            "Charles Dickens",
            "Leo Tolstoy",
            "Jane Austen",
            "Ernest Hemingway",
            "Homer",
        };

        public static string[] PublishersName = new[]
        {
            "Pearson",
            "RELX Group",
            "Thomson Reuters",
            "Bertelsmann",
            "Wolters Kluwer",
            "Hachette Livre",
            "Grupo Planeta",
            "Springer Nature",
            "Scholastic",
        };

        public static string[] BooksName = new[]
        {
            "ULYSSES",
            "THE GREAT GATSBY",
            "A PORTRAIT OF THE ARTIST AS A YOUNG MAN",
            "LOLITA",
            "BRAVE NEW WORLD",
            "THE SOUND AND THE FURY",
            "CATCH-22",
            "DARKNESS AT NOON",
        };

        public static string[] Genres = new[]
        {
            "Fantasy",
            "Science Fiction",
            "Dystopian",
            "Adventure",
            "Romance",
            "Detective & Mystery",
            "Horror",
            "Thriller",
        };

        public static string[] CustomerNames = new[]
        {
            "Liam",
            "Noah",
            "Oliver",
            "Elijah",
            "James",
            "William",
            "Benjamin",
            "Lucas",
            "Henry",
            "Theodore",
            "Olivia",
            "Emma",
            "Charlotte",
            "Amelia",
            "Ava",
            "Sophia",
            "Isabella",
            "Mia",
            "Evelyn",
            "Harper",
        };

        public static string[] Adresses = new[]
        {
            "1510 Raver Croft Drive",
            "3913 Thrash Trai",
            "4852 Charack Road Jeffersonville",
            "1661 Fannie Street Houston",
            "2608 Atha Drive Bakersfield",
            "4732 Mulberry Avenue",
        };

        public static string[] Cities = new[]
        {
            "Greeneville",
            "Corsicana",
            "Heber",
        };

        public static string[] Countries = new[]
        {
            "Tennessee(TE)",
            "Texas(TX)",
            "Indiana(IN)",
            "California(CA)",
            "Arkansas(AR)",
        };

        public static string GetRandomData(string[] source)
        {
            var random = new Random();
            var index = random.Next(0, source.Length);
            return source[index];
        }
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
        var addCustomerForm = new AddCustomerForm();
        addCustomerForm.Show();
    }
}