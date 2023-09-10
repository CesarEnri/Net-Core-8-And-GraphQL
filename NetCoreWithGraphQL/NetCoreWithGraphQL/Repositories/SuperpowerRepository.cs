using NetCoreWithGraphQL.Data;
using NetCoreWithGraphQL.Interfaces;

namespace NetCoreWithGraphQL.Repositories;

public class SuperpowerRepository : ISuperpowerRepository
{
    private readonly ApplicationDbContext _appDbContext;

    public SuperpowerRepository(ApplicationDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
}