using System.Data;

namespace Stack.Repositories
{
    public class CatagoriesRepository
    {
      private readonly IDbConnection _db;

    public CatagoriesRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}