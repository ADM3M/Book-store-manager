using Jul.Data;
using Jul.Services;
using Microsoft.EntityFrameworkCore;

namespace Jul.Entities;

public static class DbInitializer
{
    private static readonly UnitOfWork _uow;
    private static readonly DataContext _dbContext;
    private static readonly string[] _booksName = {
        "ULYSSES",
        "THE GREAT GATSBY",
        "A PORTRAIT OF THE ARTIST AS A YOUNG MAN",
        "LOLITA",
        "BRAVE NEW WORLD",
        "THE SOUND AND THE FURY",
        "CATCH-22",
        "DARKNESS AT NOON",
    };

    private static readonly string[] _customersName =
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

    static DbInitializer()
    {
        _uow = UnitOfWork.Create();
        _dbContext = _uow.DbContext;
    }

    public static async Task SeedDbAsync()
    {
        await _dbContext.Database.MigrateAsync();
        
        var check = !_dbContext.Authors.Any()
                    && !_dbContext.Books.Any()
                    && !_dbContext.Genres.Any()
                    && !_dbContext.Publishers.Any()
                    && !_dbContext.Cities.Any()
                    && !_dbContext.Countries.Any()
                    && !_dbContext.Customers.Any();

        if (!check)
            return;
        
        InitializeBooksWithData();
        InitializeCustomersWithData();
        await _uow.SaveChangesAsync();
    }

    private static void InitializeCustomersWithData()
    {
        var cities = InitializeCities();
        var countries = InitializeCountries();
        InitializeCustomers(cities, countries);
    }

    private static void InitializeBooksWithData()
    {
        var publishers = InitializePublishers();
        var authors = InitializeAuthors();
        var genres = InitializeGenres();
        InitializeBooks(publishers, authors, genres);
    }

    private static List<Genres> InitializeGenres()
    {
        var genres = new List<Genres>
        {
            new Genres { GenreName = "Romance"},
            new Genres { GenreName = "Fiction"},
            new Genres { GenreName = "Fantasy"},
            new Genres { GenreName = "Science Fiction"},
            new Genres { GenreName = "Action & Adventure"},
            new Genres { GenreName = "Historical Fiction"},
            new Genres { GenreName = "Short Story"},
            new Genres { GenreName = "Fairy Tale"},
            new Genres { GenreName = "Dystopian"},
            new Genres { GenreName = "Horror"},
        };

        _dbContext.Genres.AddRange(genres);
        return genres;
    }

    private static List<Authors> InitializeAuthors()
    {
        var authors = new List<Authors>
        {
            new Authors { AuthorName = "William Shakespeare"},
            new Authors { AuthorName = "J.R.R. Tolkien"},
            new Authors { AuthorName = "George Orwell"},
            new Authors { AuthorName = "Victor Hugo"},
            new Authors { AuthorName = "Charles Dickens"},
            new Authors { AuthorName = "Lev Tolstoy"},
            new Authors { AuthorName = "Jane Austen"},
            new Authors { AuthorName = "Ernest Hemingway"},
            new Authors { AuthorName = "Homer"},
            new Authors { AuthorName = "Mark Twen"},
        };

        _dbContext.Authors.AddRange(authors);
        return authors;
    }

    private static List<Publishers> InitializePublishers()
    {
        var publishers = new List<Publishers>
        {
            new Publishers { PublisherName = "Alpina"},
            new Publishers { PublisherName = "Hacaton"},
            new Publishers { PublisherName = "Odri"},
            new Publishers { PublisherName = "Alpina. Kids"},
            new Publishers { PublisherName = "Ecsmo"},
            new Publishers { PublisherName = "Popurry"},
            new Publishers { PublisherName = "Corpus"},
            new Publishers { PublisherName = "Fargus"},
            new Publishers { PublisherName = "Willmos"},
            new Publishers { PublisherName = "Reepo"},
        };

        _dbContext.Publishers.AddRange(publishers);
        return publishers;
    }

    private static Books CreateBook(List<Publishers> publishers, List<Authors> authors, List<Genres> genres)
    {
        var random = new Random();
        var publisherId = random.Next(1, 10);
        var authorId = random.Next(1, 10);
        var genreId = random.Next(1, 10);
        var booksCount = random.Next(1, 30);

        var book = new Books
        {
            Genres = genres[genreId],
            Author = authors[authorId],
            Publisher = publishers[publisherId],
            Count = random.Next(1, 30),
            Price = random.Next(1, 20) + Math.Round(random.NextDouble(), 2)
        };

        return book;
    }

    private static List<Books> InitializeBooks(List<Publishers> publishers, List<Authors> authors, List<Genres> genres)
    {
        var books = new List<Books>();
        
        for (int i = 0; i < _booksName.Length; i++)
        {
            var book = CreateBook(publishers, authors, genres);
            book.BookTitle = _booksName[i];
            
            books.Add(book);
        }

        _dbContext.Books.AddRange(books);
        return books;
    }

    private static List<Cities> InitializeCities()
    {
        var cities = new List<Cities>
        {
            new Cities { CityName = "Minsk" },
            new Cities { CityName = "Gomel" },
            new Cities { CityName = "Brest" },
            new Cities { CityName = "Zhlobin" },
            new Cities { CityName = "Mogilev" },
            new Cities { CityName = "Pinsk" },
            new Cities { CityName = "Hoiniki" },
            new Cities { CityName = "Skidri" },
            new Cities { CityName = "Vitebsk" },
            new Cities { CityName = "Polotsk" },
            new Cities { CityName = "Moskva" },
            new Cities { CityName = "Serpuhov" },
            new Cities { CityName = "St-Peterburg" },
            new Cities { CityName = "Omsk" },
            new Cities { CityName = "Bryansk" },
            new Cities { CityName = "Verhoyansk" },
        };
        
        _dbContext.Cities.AddRange(cities);
        return cities;
    }

    private static List<Countries> InitializeCountries()
    {
        var countries = new List<Countries>
        {
            new Countries { CountryName = "Belarus"},
            new Countries { CountryName = "Russia"}
        };
        
        _dbContext.Countries.AddRange(countries);
        return countries;
    }

    private static List<Customers> InitializeCustomers(List<Cities> cities, List<Countries> countries)
    {
        var customers = new List<Customers>();
        
        for (int i = 0; i < _customersName.Length; i++)
        {
            var customer = CreateCustomer(cities, countries);
            customer.Name = _customersName[i];
            customers.Add(customer);
        }

        _dbContext.Customers.AddRange(customers);
        return customers;
    }

    private static Customers CreateCustomer(List<Cities> cities, List<Countries> countries)
    {
        var random = new Random();
        var cityId = random.Next(1, 10);
        var countryId = cityId < 11 ? 0 : 1;

        return new Customers
        {
            City = cities[cityId],
            Country = countries[countryId],
            Adress = string.Empty
        };
    }
}