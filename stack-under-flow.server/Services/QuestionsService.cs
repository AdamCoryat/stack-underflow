using Stack.Repositories;

namespace Stack.Services
{
    public class QuestionsService
    {
      private readonly QuestionsRepository _repo;

    public QuestionsService(QuestionsRepository repo)
    {
      _repo = repo;
    }
  }
}