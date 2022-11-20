using Jul.Entities;
using Jul.Services;
using Microsoft.EntityFrameworkCore;

namespace Jul.Data
{
    public static class Seed
    {
        public static async Task SeedDataBase(UnitOfWork uow)
        {
            var dataContext = uow.DbContext;
            await dataContext.Database.MigrateAsync();

            if (!await dataContext.Genres.AnyAsync())
            {
                var genres = new List<Genres>
                {
                    new Genres { GenreName = "Comedy" },
                    new Genres { GenreName = "Horror" },
                    new Genres { GenreName = "Dramma" },
                    new Genres { GenreName = "Triller" },
                    new Genres { GenreName = "Survival" },
                };

                await dataContext.Genres.AddRangeAsync(genres);
            }

            if (!await dataContext.Authors.AnyAsync())
            {
                var authors = new List<Authors>
                {
                    new Authors { AuthorName = "some_name1" },
                    new Authors { AuthorName = "some_name2" },
                    new Authors { AuthorName = "some_name3" },
                    new Authors { AuthorName = "some_name4" },
                    new Authors { AuthorName = "some_name5" },
                };

                await dataContext.Authors.AddRangeAsync(authors);
            }

            if (!await dataContext.Publishers.AnyAsync())
            {
                var publishers = new List<Publishers>
                {
                    new Publishers { PublisherName = "some_publisher1" },
                    new Publishers { PublisherName = "some_publisher2" },
                    new Publishers { PublisherName = "some_publisher3" },
                    new Publishers { PublisherName = "some_publisher4" },
                    new Publishers { PublisherName = "some_publisher5" },
                };

                await dataContext.Publishers.AddRangeAsync(publishers);
            }

            //if (!await dataContext.Books.AnyAsync())
            //{
            //    var books = new List<Books>
            //    {
            //        new Books
            //        {
            //            BookTitle = "book_title1",
            //            PublisherId = 1,
            //            AuthorId = 1,
            //            GenreId = 1,
            //            Price = 1,
            //            Year = new DateTime(DateTime.Now.Year),
            //        },
            //        new Books
            //        {
            //            BookTitle = "book_title2",
            //            PublisherId = 2,
            //            AuthorId = 2,
            //            GenreId = 2,
            //            Price = 2,
            //            Year = new DateTime(DateTime.Now.Year),
            //        },
            //        new Books
            //        {
            //            BookTitle = "book_title3",
            //            PublisherId = 3,
            //            AuthorId = 3,
            //            GenreId = 3,
            //            Price = 3,
            //            Year = new DateTime(DateTime.Now.Year),
            //        },
            //    };

            //    await dataContext.Books.AddRangeAsync(books);
            //}

            await dataContext.SaveChangesAsync();
        }
    }
}
