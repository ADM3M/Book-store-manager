using Jul.Entities;
using Jul.Services;

namespace Jul.Forms;

public partial class CreateBookForm : Form
{
    private readonly ListView _listView;
    private readonly Dictionary<int, Books> _booksMap;
    private readonly UnitOfWork _uow;

    public CreateBookForm(ListView listView, Dictionary<int, Books> booksMap, UnitOfWork uow)
    {
        InitializeComponent();
        _listView = listView;
        _booksMap = booksMap;
        _uow = uow;
    }

    private void CreateBookForm_Load(object sender, EventArgs e)
    {
        var authorsName = _booksMap
            .Select(e => e.Value.Author.AuthorName)
            .ToArray();

        var genresName = _booksMap
            .Select(e => e.Value.Genres.GenreName)
            .ToArray();
        
        var publishersName = _booksMap
            .Select(e => e.Value.Publisher.PublisherName)
            .ToArray();
        
        SetupComboBox(authorCombobox, authorsName);
        SetupComboBox(genreCombobox, genresName);
        SetupComboBox(publisherCombobox, publishersName);
    }

    private void SetupComboBox(ComboBox comboBox, string[] collection)
    {
        comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;

        comboBox.AutoCompleteCustomSource.AddRange(collection);
        comboBox.Items.AddRange(collection);
    }

    private async void addButton_Click(object sender, EventArgs e)
    {
        var authorName = authorCombobox.SelectedItem as string;
        authorName ??= authorCombobox.Text;
        var genreName = genreCombobox.SelectedItem as string;
        var publisherName = publisherCombobox.SelectedItem as string;
        publisherName ??= publisherCombobox.Text;
        var title = titleTextbox.Text;
        var isYearCorrect = int.TryParse(yearTextbox.Text, out int year);
        var isPriceCorrect = double.TryParse(yearTextbox.Text, out double price);
        var isCountCorrect = int.TryParse(countTextBox.Text, out int count);

        var allFieldsCorrect = authorName != null
                               && genreName != null
                               && publisherName != null
                               && title != null
                               && isYearCorrect
                               && isPriceCorrect
                               && isCountCorrect;

        if (!allFieldsCorrect)
        {
            MessageBox.Show("Fill all field correct!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        var author = await _uow.AuthorsRepository.GetOrAddAuthor(authorName!);
        var publisher = await _uow.PublishersRepository.GetOrAddAuthor(publisherName);
        var genre = _uow.DbContext.Genres.SingleOrDefault(e => e.GenreName == genreName);

        if (genre is null)
        {
            MessageBox.Show("Choose ganre from existing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
        
        var book = new Books
        {
            BookTitle = title,
            Author = author,
            Genres = genre,
            Publisher = publisher,
            Count = count,
            Year = new DateTime(year)
        };

        try
        {
            _uow.DbContext.Books.Add(book);
            await _uow.DbContext.SaveChangesAsync();

            _booksMap.Add(book.Id, book);
            _listView.Items.Add(
                new ListViewItem(
                    new[]
                    {
                        book.Id.ToString(),
                        title,
                        authorName,
                        genreName,
                        year.ToString(),
                        publisherName,
                        price.ToString()
                    }
                ));

        }
        catch (Exception exception)
        {
            MessageBox.Show("Error while adding a book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        finally
        {
            Close();
        }
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}