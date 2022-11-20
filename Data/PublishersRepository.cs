using Jul.Entities;
using Jul.Services;

namespace Jul.Data;

public class PublishersRepository
{
    private readonly UnitOfWork _uow;

    public PublishersRepository(UnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<Publishers> GetOrAddAuthor(string publisherName)
    {
        var publisher = _uow.DbContext.Publishers.SingleOrDefault(e => e.PublisherName == publisherName);

        if (publisher is null)
        {
            publisher = new Publishers()
            {
                PublisherName = publisherName
            };

            _uow.DbContext.Publishers.Add(publisher);
            await _uow.SaveChangesAsync();
        }

        return publisher;
    }
}