using NetCoreWithGraphQL.Models;

namespace NetCoreWithGraphQL.Data
{
    public class Query
    {
        public IQueryable<Superhero> GetSuperheroes =>
            new List<Superhero>().AsQueryable();
    }
}
