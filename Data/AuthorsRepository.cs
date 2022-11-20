using Jul.Entities;
using Jul.Services;

namespace Jul.Data;

public class AuthorsRepository
{
    private readonly UnitOfWork _uow;

    public AuthorsRepository(UnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<Authors> GetOrAddAuthor(string authorName)
    {
        var author = _uow.DbContext.Authors.SingleOrDefault(e => e.AuthorName == authorName);

        if (author is null)
        {
            author = new Authors
            {
                AuthorName = authorName
            };

            _uow.DbContext.Authors.Add(author);
            await _uow.SaveChangesAsync();
        }

        return author;
    }
}