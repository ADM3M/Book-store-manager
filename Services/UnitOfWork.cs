using Jul.Data;

namespace Jul.Services;

public class UnitOfWork
{
    private static UnitOfWork? _instance = null;

    public readonly DataContext DbContext;
    public readonly ControlsService ControlsService;
    
    private UnitOfWork()
    {
        DbContext = new DataContext();
        ControlsService = new ControlsService();
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