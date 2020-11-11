using Microsoft.AspNetCore.Mvc;
using Stack.Services;

namespace Stack.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ResponsesController
    {
      private readonly ResponsesService _rs;

    public ResponsesController(ResponsesService rs)
    {
      _rs = rs;
    }
  }
}