using System.Data;

namespace Stack.Repositories
{
    public class ResponsesRepository
    {
      private readonly IDbConnection _db;

    public ResponsesRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}