using Jul.Entities;

namespace Jul.Extensions;

public static class ListViewExtensions
{
    public static void BooksListViewRefresh(this ListView listView, Dictionary<int, Books> booksMap)
    {
        listView.Items.Clear();

        var rows = booksMap
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

        listView.Items.AddRange(rows);
    }
    
    public static void CustomersListViewRefresh(this ListView listView, Dictionary<int, Customers> customersMap)
    {
        listView.Items.Clear();

        var rows = customersMap.Select(entry =>
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

        listView.Items.AddRange(rows);
    }
}