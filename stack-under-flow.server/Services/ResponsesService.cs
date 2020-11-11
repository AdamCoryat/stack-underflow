using Stack.Repositories;

namespace Stack.Services
{
    public class ResponsesService
    {
      private readonly ResponsesRepository _repo;

    public ResponsesService(ResponsesRepository repo)
    {
      _repo = repo;
    }
  }
}