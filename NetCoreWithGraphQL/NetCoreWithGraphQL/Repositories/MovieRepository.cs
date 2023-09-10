using NetCoreWithGraphQL.Data;
using NetCoreWithGraphQL.Interfaces;

namespace NetCoreWithGraphQL.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly ApplicationDbContext _appDbContext;

    public MovieRepository(ApplicationDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
}