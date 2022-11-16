using Jul.Data;

namespace Jul.Services;

public class UnitOfWork
{
    private static UnitOfWork? _instance = null;

    public DataContext DbContext { get; set; }
    
    private UnitOfWork()
    {
        DbContext = new DataContext();
    }
    
    public static UnitOfWork Create()
    {
        return _instance ??= new UnitOfWork();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await DbContext.SaveChangesAsync();
    }
}