using Microsoft.AspNetCore.Mvc;
using Stack.Services;

namespace Stack.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class QuestionsController : ControllerBase
    {
      private readonly QuestionsService _qs;

    public QuestionsController(QuestionsService qs)
    {
      _qs = qs;
    }
  }
}