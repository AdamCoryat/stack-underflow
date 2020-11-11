using System.Data;

namespace Stack.Repositories
{
    public class QuestionsRepository
    {
      private readonly IDbConnection _db;

    public QuestionsRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}